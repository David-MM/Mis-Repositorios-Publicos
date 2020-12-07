CREATE DATABASE CPM
GO
USE CPM
GO
CREATE TABLE [Cliente] (
  [idCliente] int PRIMARY KEY IDENTITY(1, 1),
  [RTN] nvarchar(255) not null,
  [R_Social] nvarchar(255) not null,
  [Descuento_Sugerido] float not null,
  [L_Credito] float not null,
  [Telefono] nvarchar(255),
  [E_Mail] nvarchar(255),
  [Direccion] nvarchar(255),
  [Estado_Delete] int not null
)
GO

CREATE TABLE [Producto] (
  [idProducto] int PRIMARY KEY IDENTITY(1, 1),
  [Codigo] nvarchar(255) not null,
  [Nombre] nvarchar(255) not null,
  [P_Sugerido] float not null,
  [Isv_Sugerido] float not null,
  [Descripcion] nvarchar(255),
  [Estado_Delete] int not null
)
GO

CREATE TABLE [Inventario] (
  [idInventario] int PRIMARY KEY IDENTITY(1, 1),
  [idProducto] int not null,
  [Cantidad] float not null,
  [Estado_Delete] int not null
)
GO

CREATE TABLE [Factura] (
  [idFactura] int PRIMARY KEY IDENTITY(1, 1),
  [User] int not null,
  [Fecha] datetime not null,
  [ClientesID] int,
  [Descuento] float,
  [Tipo] char not null,
  [Estado] char not null
)
GO

CREATE TABLE [FacturaDetalle] (
  [FacturaID] int,
  [ProductoID] int,
  [Cantidad] float not null,
  [Precio] float not null,
  [Isv] float not null
  PRIMARY KEY (FacturaID, ProductoID)
)
GO

CREATE TABLE [Usuario] (
  [idUser] int PRIMARY KEY IDENTITY(1, 1),
  [NickName] nvarchar(255) not null,
  [Password] nvarchar(255) not null,
  [Roll] char not null,
  [Estado_Delete] int not null
)
GO

CREATE TABLE [Pago] (
  [idPago] int PRIMARY KEY IDENTITY(1, 1),
  [FacturaID] int not null,
  [Fecha] datetime not null,
  [Estado_Delete] int not null
)
GO

ALTER TABLE [Inventario] ADD FOREIGN KEY ([idProducto]) REFERENCES [Producto] ([idProducto])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([User]) REFERENCES [Usuario] ([idUser])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([ClientesID]) REFERENCES [Cliente] ([idCliente])
GO

ALTER TABLE [FacturaDetalle] ADD FOREIGN KEY ([FacturaID]) REFERENCES [Factura] ([idFactura])
GO

ALTER TABLE [FacturaDetalle] ADD FOREIGN KEY ([ProductoID]) REFERENCES [Producto] ([idProducto])
GO

ALTER TABLE [Pago] ADD FOREIGN KEY ([FacturaID]) REFERENCES [Factura] ([idFactura])
GO

Select * From Cliente
insert into Cliente
values 
('05011992136761','SOSA',.20,5000,'95828792','Arnol.Sosa@Hotmail.com','Col. Lopez Arellano, Choloma',1),
('1111111111111','SIMAN',.05,20000,'25541275','Siman@Siman.com','Varias',1),
('2222222222222','Kielsa',.02,50000,'25541001','Kielsa@Kielsa.com','Bo. El centro, SPS',1),
('3333333333333','FarmaCity',.03,15000,'25501211','FarmaCity@FarmaCity.com','Bo. Las Acacias, SPS',1),
('4444444444444','Drogueria Nacional',.25,100000,'25540444','Drogeria@DNacional.com','3ra Ave. Bo. El Centro, SPS',1)

insert into Producto 
values 
('1111111111111','Panadol',4.20,0.15,'Para el dolor de cabeza',1),
('1111111111112','CereNervon',85.24,0.15,'Multivitaminas',1),
('1111111111113','Tapon',8.40,0.15,'A la diarrea le pone fin',1),
('1111111111114','Tapcin',3.00,0.15,'Para el dolor de estomago',1),
('1111111111115','Cura del Covid',1,0,'No vender hasta 2021',1)

insert into Inventario 
values 
(1,150,1),(2,80,1),(3,15,1),(4,2500,1),(5,1,1)

--Valores de Rol
--A admin de sistema
--V Ventas
--I Inventario
--P Pagos
insert into Usuario 
values
('Admin','1234','A',1),
('Ventas','1234','V',1),
('Inventario','1234','I',1),
('Pagos','1234','P',1)

--Tipo Factura
	--R Credito
	--C Contado
--Estado Factura
	--G Gravada
	--F Facturada
	--A Anulada
	--P Pagada
insert into Factura 
values
(1,'3/12/2020',1,0.2,'C','P'),
(1,'4/12/2020',1,0.2,'R','A'),
(1,'5/12/2020',1,0.2,'R','G'),
(1,'5/12/2020',1,0.2,'R','F')

Insert into FacturaDetalle
values
(1,1,1,5,.15),(1,4,1,3,.15),
(2,1,1,5,.15),
(3,2,1,95,.15),
(4,2,5,87,.15),(4,1,25,4.50,.15),(4,3,15,8.50,.15)

Insert into Pago
values 
(1,'03/12/2020',1)

