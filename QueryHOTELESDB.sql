CREATE DATABASE HOTELESDB
GO
USE HOTELESDB
GO

CREATE TABLE ROL (
IdRol int identity primary key,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
);
go

CREATE TABLE PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate()
);
go

CREATE TABLE DOMICILIO(
IdDomicilio int primary key identity,
Pais varchar(50),
Estado varchar(60),
Ciudad varchar(80),
Calle varchar(100),
Numero varchar(10),
CodigoPostal varchar(10),
FechaRegistro datetime default getdate()
);
go

CREATE TABLE USUARIO(
IdUsuario int primary key identity,
Nombre varchar(50),
Apellidos varchar(80),
Correo varchar(100),
Contrasenia varchar(255),
NumeroNomina varchar(50),
FechaNacimiento date,
IdDomicilio int references DOMICILIO(IdDomicilio),
Telefono varchar(20),
IdRol int references ROL(IdRol),
Estado bit DEFAULT 1,
FechaRegistro datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
);
go

CREATE TABLE HOTEL(
IdHotel int identity primary key,
Nombre varchar(50),
IdDomicilio int references DOMICILIO(IdDomicilio),
NroHabitaciones int,
NroPisos int,
FechaInicioOperaciones date,
FechaRegistro datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
)
go

CREATE TABLE TIPO_HABITACION(
IdTipoHabitacion int identity primary key,
IdHotel int references HOTEL(IdHotel),
Nivel varchar(100),
NroCamas int,
TipoCamas varchar(50),
Capacidad int,
PrecioNoche decimal(12,2),
FechaRegistro datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
)
go

CREATE TABLE AMENIDAD(
IdAmenidad int identity primary key,
Nombre varchar (100)
)
go

CREATE TABLE TIPO_HABITACION_AMENIDAD(
IdTipoHabitacionAmenidad int identity primary key,
IdTipoHabitacion int references TIPO_HABITACION(IdTipoHabitacion),
IdAmenidad int references AMENIDAD(IdAmenidad)
)
go

CREATE TABLE HABITACION(
IdHabitacion int identity primary key,
IdTipoHabitacion int references TIPO_HABITACION(IdTipoHabitacion),
NroHabitacion varchar(20),
NroPiso int,
Estado varchar(30),
FechaRegistro datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
)
go

CREATE TABLE CLIENTE(
IdCliente int identity primary key,
Nombre varchar(50),
Apellidos varchar(100),
Correo varchar(100),
Rfc varchar(20),
EstadoCivil varchar(30),
FechaNacimiento date,
IdDomicilio int references DOMICILIO(IdDomicilio),
Telefono varchar(20),
FechaRegistro datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
)
go

CREATE TABLE RESERVACION(
IdReservacion uniqueidentifier primary key default newid(),
IdCliente int references CLIENTE(IdCliente),
IdHotel int references HOTEL(IdHotel),
FechaEntrada date,
FechaSalida date,
Anticipo decimal(10,2),
MetodoPago varchar(50),
Estado varchar(20) default 'Activa',
FechaReservacion datetime default getdate(),
UsuarioCreador int references USUARIO(IdUsuario)
)
go

CREATE TABLE DETALLE_RESERVACION(
IdDetalleReservacion int identity primary key,
IdReservacion uniqueidentifier references RESERVACION(IdReservacion),
IdTipoHabitacion int references TIPO_HABITACION(IdTipoHabitacion),
IdHabitacion int references HABITACION(IdHabitacion) null,
NroPersonas int,
PrecioNoche decimal(12,2),
)
go

CREATE TABLE FACTURAS (
    FacturaID int identity primary key,
    IdReservacion UNIQUEIDENTIFIER references RESERVACION(IdReservacion),
    IdHotel int references HOTEL(IdHotel),
    IdCliente int references CLIENTE(IdCliente),
    IdUsuario int references USUARIO(IdUsuario),
    FechaEmision datetime default getdate(),
    TotalHospedaje decimal(12,2),
    MontoAnticipo decimal(12,2),
    MontoPendientePagado decimal(12,2),
    FormaPago varchar(50),
    Estatus varchar(20) default 'Pagada'
)
go

CREATE TABLE CANCELACIONES (
    CancelacionID int identity primary key,
    IdReservacion UNIQUEIDENTIFIER references RESERVACION(IdReservacion) UNIQUE,
    UsuarioCancelacionID int references USUARIO(IdUsuario),
    FechaCancelacion datetime default getdate(),
    MontoReembolsado decimal(10,2)
)
go

INSERT INTO ROL (Descripcion)
VALUES('ADMINISTRADOR')
go

INSERT INTO ROL (Descripcion)
VALUES('OPERADOR')
go

-- PERMISOS PARA USUARIO OPERATIVO
INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(2,'menuclientes')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(2,'menureservaciones')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(2,'menucheckin')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(2,'menucheckout')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(2,'menuacercade')
go

-- PERMISOS PARA USUARIO ADMINISTRATIVO
INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuempleados')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuhoteles')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuhabitaciones')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuclientes')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuhistorial')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menureservaciones')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menucancelaciones')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menucheckin')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menucheckout')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menureporteocupacion')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menureporteventas')
go

INSERT INTO PERMISO (IdRol,NombreMenu)
VALUES(1,'menuacercade')
go

INSERT INTO DOMICILIO (Pais,Estado,Ciudad,Calle,Numero,CodigoPostal)
VALUES('Mexico','Nuevo Leon','San Nicolas','Zamora','1403','96400')
go

INSERT INTO USUARIO (Nombre,Apellidos,Correo,Contrasenia,NumeroNomina,FechaNacimiento,IdDomicilio,Telefono,IdRol,UsuarioCreador)
VALUES('Diego','RomanGonzalez','Tupu@gmail.com','#9mW2Thmb','123456','2004-12-09',3,'9211310469',1,null)
go

INSERT INTO AMENIDAD (Nombre) VALUES ('Aire acondicionado');
INSERT INTO AMENIDAD (Nombre) VALUES ('TV');
INSERT INTO AMENIDAD (Nombre) VALUES ('WiFi');
INSERT INTO AMENIDAD (Nombre) VALUES ('Toallas');
INSERT INTO AMENIDAD (Nombre) VALUES ('Articulos de aseo personal');
INSERT INTO AMENIDAD (Nombre) VALUES ('MiniBar');
INSERT INTO AMENIDAD (Nombre) VALUES ('Terraza');
go

SELECT * FROM CLIENTE