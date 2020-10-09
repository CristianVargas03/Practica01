create database Practica1
use Practica1

CREATE TABLE Productos
(
ID_Prod int PRIMARY KEY not null IDENTITY (1,1),
Nombre_Prod VARCHAR (50),
Codigo INT,
Stock INT,
Fecha_Vencimiento DATE,
Descripcion VARCHAR (50),
Categoria varchar (50),
Estado_Prod VARCHAR (50)
)

insert into Productos (Nombre_Prod, Codigo, Stock, Fecha_Vencimiento, Descripcion, Categoria, Estado_Prod)
values ('Manzanas', 001, 10, '10/08/2020', 'Rojas', 'Fruta', 'Activo')

insert into Productos (Nombre_Prod, Codigo, Stock, Fecha_Vencimiento, Descripcion, Categoria, Estado_Prod)
values ('Peras', 002, 25, '10/08/2020', 'Verdes', 'Fruta', 'Inactivo')

select * from Productos

CREATE TABLE Categoria
(
ID_Catg int PRIMARY KEY not null IDENTITY (1,1),
Nombre_Catg VARCHAR (50),
Estado_Catg VARCHAR (50)
)

insert into Categoria (Nombre_Catg, Estado_Catg)
values ('Frutas', 'Activo')

select * from Categoria


