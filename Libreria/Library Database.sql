CREATE DATABASE LibraryProyect
ON
( NAME = LibraryProyect_dat,
	FILENAME = 'D:\PROYECTOS\LibraryProyect.mdf',
	SIZE = 5,
	MAXSIZE = 20,
	FILEGROWTH = 5	
)
LOG ON
( NAME = LibraryProyect_LOG,
	FILENAME = 'D:\PROYECTOS\LibraryProyect.Ldf',
	SIZE = 2,
	MAXSIZE = 10,
	FILEGROWTH = 2	
)
GO

USE LibraryProyect
GO

CREATE TABLE [Cliente] (
  [cliente_id] int PRIMARY KEY,
  [nombre] nvarchar(255),
  [telefono] nvarchar(255),
  [correo] nvarchar(255),
  [password] nvarchar(255),
  [fecha_nacimiento] date
)
GO

CREATE TABLE [Escritores] (
  [escritor_id] int PRIMARY KEY,
  [nombre_escritor] nvarchar(255),
  [pais] nvarchar(255),
  [fecha_nacimiento] date
)
GO

CREATE TABLE [Libros] (
  [libro_id] int PRIMARY KEY,
  [precio_venta] money,
  [precio_renta] money,
  [nombre_libro] nvarchar(255),
  [genero] nvarchar(255),
  [year] date,
  [disponible] nvarchar(10),
  [escritor_id] int
)
GO

CREATE TABLE [Usuarios] (
  [usuario_id] nvarchar(6) PRIMARY KEY,
  [nombre_usuario] nvarchar(255),
  [contraseña] nvarchar(255),
  [correo] nvarchar(255),
  [telefono] nvarchar(9),
  [DUI] nvarchar(10),
  [posicion] nvarchar(255)  
)
GO

CREATE TABLE [Prestamos] (
  [prestamos_id] int PRIMARY KEY,
  [libro_id] int,
  [cliente] int,
  [fecha_de_prestamo] date,
  [fecha_entrega] date,
  [demora] money,
  [empleado_atendiende] nvarchar(6)
)
GO

CREATE TABLE [Reserva] (
  [reserva_id] int PRIMARY KEY,
  [fecha_reserva] date,
  [libro_id] int,
  [cliente] int,
  [precio] money
)
GO

CREATE TABLE [Ganancias] (
  [id_] int PRIMARY KEY,
  [fecha] date,
  [ganancia_rentas] money,
  [ganancia_demoras] money,
  [ganancia_reserva] money,
  [ganancia_venta] money,
  [ganancia_total] money,
  [perdida_iva] money
)
GO

CREATE TABLE [ventas] (
  [venta_id] int PRIMARY KEY,
  [libro_id] int,
  [cliente_id] int,
  [usuario_id] nvarchar(6)
)
GO

ALTER TABLE [Libros] ADD FOREIGN KEY ([escritor_id]) REFERENCES [Escritores] ([escritor_id])
GO

ALTER TABLE [Prestamos] ADD FOREIGN KEY ([libro_id]) REFERENCES [Libros] ([libro_id])
GO

ALTER TABLE [Prestamos] ADD FOREIGN KEY ([cliente]) REFERENCES [Cliente] ([cliente_id])
GO

ALTER TABLE [Prestamos] ADD FOREIGN KEY ([empleado_atendiende]) REFERENCES [Usuarios] ([usuario_id])
GO

ALTER TABLE [Reserva] ADD FOREIGN KEY ([libro_id]) REFERENCES [Libros] ([libro_id])
GO

ALTER TABLE [Reserva] ADD FOREIGN KEY ([cliente]) REFERENCES [Cliente] ([cliente_id])
GO

ALTER TABLE [ventas] ADD FOREIGN KEY ([libro_id]) REFERENCES [Libros] ([libro_id])
GO

ALTER TABLE [ventas] ADD FOREIGN KEY ([cliente_id]) REFERENCES [Cliente] ([cliente_id])
GO

ALTER TABLE [ventas] ADD FOREIGN KEY ([usuario_id]) REFERENCES [Usuarios] ([usuario_id])
GO




