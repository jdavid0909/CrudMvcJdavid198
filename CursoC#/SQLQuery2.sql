

create Database DBCARRITO


GO

USE DBCARRITO 

GO


create table CATEGORIA(
IdCategoria int primary Key identity,
Description varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)


go 


create Table Marca(
IdMarca int primary key identity,
Description varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()

)

go

create table PRODUCTO(

IdProdcto int primary key identity,
Nombre varchar(100),
Descripcion varchar(500),
IdMarca int references Marca(IdMarca),
IdCategoria int references Categoria(IdCategoria),
Precio decimal(10,2) default 0,
Stock int,
RutaImage varchar(100),
NombreImagen varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()

)


GO

create table CLIENTE(
IdCliente int primary key identity,
Nombres varchar(100),
Apellidos varchar(100),
Correo varchar(100),
Clave varchar(100),
Restablecer bit default 0,
FechaRegistro datetime default getdate()
)
go

create table CARRITO(
IdCarrito int primary key identity,
IdCliente int references CLIENTE(IdCliente),
IdProducto int references Producto(IdProdcto),
Cantidad int 
)

GO

create table VENTA (
IdVenta int primary key identity,
IdCliente int references Cliente(IdCliente),
TotalProducto int,
MontoTotal decimal(10,2),
Contacto varchar(50),
IdDistritro varchar(50),
Telefono varchar(50),
Direccion varchar(500),
IdTransaccion varchar(50),
FechaRegistro datetime default getdate()
)
go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references Venta(IdVenta),
IdProducto int references PRODUCTO(IdProdcto),
Cantidad int, 
Total decimal(10,2)
)

GO

create table USUARIO(
IdUsuario int primary key identity, 
Nombres varchar(100),
Apellidos varchar(100),
Correo varchar(100),
Clave varchar(150),
Restablecer bit default 1,
Activo bit default 1,
FechaRegistro datetime default getdate()
)

GO

create table DEPARTAMENTO(
	IdDepartamento varchar(2) not null,
	Descripcion varchar(45) not null
)

GO 

create table PROVINCIA(
	IdProvincia varchar(4) not null,
	Descripcion varchar(45) not null,
	IdDepartamento varchar(2) not null
)

GO 

create table Distrito(
	IdDistrito varchar(4) not null,
	Descripcion varchar(45) not null,
	IdProvincia varchar(4) not null,
	IdDepartamento varchar(2) not null
)

GO 


