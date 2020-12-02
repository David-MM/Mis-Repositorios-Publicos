CREATE TABLE [Cliente] (
  [idCliente] int PRIMARY KEY IDENTITY(1, 1),
  [RTN] nvarchar(255) not null,
  [R_Social] nvarchar(255) not null,
  [Descuento_Sugerido] float not null,
  [L_Credito] float not null,
  [Telefono] nvarchar(255),
  [E_Mail] nvarchar(255),
  [Direccion] nvarchar(255)
)
GO

CREATE TABLE [Produto] (
  [idProducto] int PRIMARY KEY IDENTITY(1, 1),
  [Codigo] nvarchar(255) not null,
  [Nombre] nvarchar(255) not null,
  [P_Sugerido] float not null,
  [Isv_Sugerido] float not null,
  [Descripcion] nvarchar(255)
)
GO

CREATE TABLE [Inventario] (
  [idInventario] int PRIMARY KEY IDENTITY(1, 1),
  [idProducto] int not null,
  [Cantidad] float not null
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

CREATE TABLE [User] (
  [idUser] int PRIMARY KEY IDENTITY(1, 1),
  [NickName] nvarchar(255),
  [Password] nvarchar(255),
  [Roll] char
)
GO

CREATE TABLE [Pago] (
  [idPago] int PRIMARY KEY IDENTITY(1, 1),
  [FacturaID] int,
  [Fecha] datetime
)
GO

ALTER TABLE [Inventario] ADD FOREIGN KEY ([idProducto]) REFERENCES [Produto] ([idProducto])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([User]) REFERENCES [User] ([idUser])
GO

ALTER TABLE [Factura] ADD FOREIGN KEY ([ClientesID]) REFERENCES [Cliente] ([idCliente])
GO

ALTER TABLE [FacturaDetalle] ADD FOREIGN KEY ([FacturaID]) REFERENCES [Factura] ([idFactura])
GO

ALTER TABLE [FacturaDetalle] ADD FOREIGN KEY ([ProductoID]) REFERENCES [Produto] ([idProducto])
GO

ALTER TABLE [Pago] ADD FOREIGN KEY ([FacturaID]) REFERENCES [Factura] ([idFactura])
GO
