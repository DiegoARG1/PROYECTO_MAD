using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROYECTO_MAD.Entidad;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PROYECTO_MAD
{
    public class FacturaPDFDocument : IDocument
    {
        private Factura factura;
        private Reservacion reservacion;
        private string numeroFactura;

        public DocumentSettings GetSettings()
        {
            return DocumentSettings.Default;
        }

        public FacturaPDFDocument(Factura factura, Reservacion reservacion, string numeroFactura)
        {
            this.factura = factura;
            this.reservacion = reservacion;
            this.numeroFactura = numeroFactura;
            // ¡Importante! QuestPDF necesita esta licencia para producción gratuita
            QuestPDF.Settings.License = LicenseType.Community;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        // Define la estructura del documento
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50); // Márgenes
                    page.DefaultTextStyle(style => style.FontSize(12).FontFamily(Fonts.Arial));

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
        }

        // --- Encabezado ---
        void ComposeHeader(IContainer container)
        {
            container.Column(col => 
            {
                col.Item().Row(row =>
                {
                    row.RelativeItem().Column(colFactura =>
                    {
                        colFactura.Item().Text($"Factura Nro: {numeroFactura}").Bold().FontSize(14);
                        colFactura.Item().Text($"Fecha Emisión: {factura.FechaEmision:dd/MM/yyyy HH:mm}");
                        colFactura.Item().Text($"Código Reserva: {factura.IdReservacion.ToString()}");
                    });
                    row.RelativeItem().Column(colHotel =>
                    {
                        colHotel.Item().Text(reservacion.NombreHotel).Bold().FontSize(12).AlignRight();
                        colHotel.Item().Text($"{reservacion.HotelCalle} #{reservacion.HotelNumero}").AlignRight();
                        colHotel.Item().Text($"{reservacion.HotelCiudad}, {reservacion.HotelCodigoPostal}").AlignRight();
                    });
                });

                col.Item().PaddingTop(10).LineHorizontal(1).LineColor(Colors.Grey.Medium);

            });
        }

        // --- Contenido Principal ---
        void ComposeContent(IContainer container)
        {
            container.Column(col =>
            {
                // Datos del Cliente y Estancia
                col.Item().PaddingTop(15).Row(row =>
                {
                    row.RelativeItem().Column(colCliente =>
                    {
                        colCliente.Item().Text("Facturado a:").SemiBold().FontSize(12);
                        colCliente.Item().Text(reservacion.NombreCliente);
                        // colCliente.Item().Text($"RFC: {reservacion.RFCCliente}"); // Si lo cargaste
                    });
                    row.RelativeItem().Column(colEstancia =>
                    {
                        colEstancia.Item().Text("Detalles de Estancia:").SemiBold().FontSize(12);
                        colEstancia.Item().Text($"Entrada: {reservacion.FechaEntrada:dd/MM/yyyy}");
                        colEstancia.Item().Text($"Salida: {DateTime.Today:dd/MM/yyyy}");
                        int noches = Math.Max(1, (int)(DateTime.Today - reservacion.FechaEntrada.Date).TotalDays);
                        colEstancia.Item().Text($"Noches: {noches}");
                    });
                });

                // Tabla de Cargos
                col.Item().PaddingTop(20).Element(ComposeTable);

                // Resumen Financiero
                col.Item().PaddingTop(10).AlignRight().Column(colResumen =>
                {
                    colResumen.Item().Row(row =>
                    {
                        row.RelativeItem().Text("Total Hospedaje:").SemiBold();
                        row.ConstantItem(100).Text($"{factura.TotalHospedaje:C2}").AlignRight();
                    });
                    colResumen.Item().Row(row =>
                    {
                        row.RelativeItem().Text("Anticipo Pagado:").SemiBold();
                        row.ConstantItem(100).Text($"{factura.MontoAnticipo:C2}").AlignRight();
                    });
                    colResumen.Item().LineHorizontal(0.5f).LineColor(Colors.Grey.Medium);
                    colResumen.Item().Row(row =>
                    {
                        row.RelativeItem().Text("MONTO PAGADO HOY:").Bold().FontSize(12);
                        row.ConstantItem(100).Text($"{factura.MontoPendientePagado:C2}").Bold().FontSize(12).AlignRight();
                    });
                    colResumen.Item().Text($"Forma de Pago: {factura.FormaPago}").AlignRight();
                });

                col.Item().PaddingTop(50).Text("¡Gracias por su preferencia!").AlignCenter();
            });
        }

        // --- Tabla Detallada ---
        void ComposeTable(IContainer container)
        {
            int noches = Math.Max(1, (int)(DateTime.Today - reservacion.FechaEntrada.Date).TotalDays);
            var detallesAgrupados = reservacion.Detalles
                .GroupBy(d => new { d.NivelTipoHabitacion, d.PrecioNoche })
                .Select(g => new {
                    Tipo = g.Key.NivelTipoHabitacion,
                    PrecioUnit = g.Key.PrecioNoche,
                    CantidadHab = g.Count(),
                    TotalPersonas = g.Sum(d => d.NroPersonas)
                });

            container.Table(table =>
            {
                // Define Columnas
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(3); // Concepto
                    columns.RelativeColumn(1); // Noches
                    columns.RelativeColumn(1); // Cant.
                    columns.RelativeColumn(1); // Pers.
                    columns.RelativeColumn(2); // P. Unit (corregido)
                    columns.RelativeColumn(2); // Total
                });

                // Encabezado
                table.Header(header =>
                {
                    header.Cell().Background(Colors.Grey.Lighten3).Text("Concepto").SemiBold();
                    header.Cell().Background(Colors.Grey.Lighten3).Text("Noches").SemiBold();
                    header.Cell().Background(Colors.Grey.Lighten3).Text("Cant.").SemiBold();
                    header.Cell().Background(Colors.Grey.Lighten3).Text("Pers.").SemiBold();
                    header.Cell().Background(Colors.Grey.Lighten3).Text("P. Unit/Noche").SemiBold().AlignRight();
                    header.Cell().Background(Colors.Grey.Lighten3).Text("Monto").SemiBold().AlignRight();
                });

                // Filas de datos
                foreach (var grupo in detallesAgrupados)
                {
                    // Lógica de precio por Noche * Cantidad Hab
                    decimal monto = noches * grupo.CantidadHab * grupo.PrecioUnit;
                    table.Cell().Text(grupo.Tipo);
                    table.Cell().Text(noches.ToString());
                    table.Cell().Text(grupo.CantidadHab.ToString());
                    table.Cell().Text(grupo.TotalPersonas.ToString());
                    table.Cell().Text($"{grupo.PrecioUnit:C2}").AlignRight();
                    table.Cell().Text($"{monto:C2}").AlignRight();
                }
            });
        }
    }
}
