create database Practica1
use Practica1

CREATE TABLE Productos
(
ID_Prod int PRIMARY KEY not null IDENTITY (1,1),
Nombre_Prod VARCHAR (50),
Codigo INT,
Stock INT,
Fecha_Vencimiento DateTime,
Descripcion VARCHAR (50),
Categoria varchar (50),
Estado_Prod VARCHAR (50)
)

insert into Productos (Nombre_Prod, Codigo, Stock, Fecha_Vencimiento, Descripcion, Categoria, Estado_Prod)
values 

('Salchichas', 003, 60, '10/08/2020', 'Chorizo', 'Enlatados', 'Activo'),
('Papas', 004, 80, '10/08/2020', 'Amarilla', 'Viveres', 'Inactivo'),
('Apio', 005, 40, '10/08/2020', 'Verde', 'Verduras', 'Activo'),
('Cerdo', 006, 25, '10/08/2020', 'Verdes', 'Carnes', 'Acivo'),
('Coca Cola', 100, 10, '10/08/2020', 'Zero', 'Bebidas', 'Activo'),
('Maiz', 008, 150, '10/08/2020', 'Dulce', 'Enlatados', 'Inactivo'),
('Canela', 009, 70, '10/08/2020', 'Polvo', 'Especias', 'Activo'),
('Yogurt', 0010, 45, '10/08/2020', 'Fresa', 'Lacteos', 'Activo')



CREATE TABLE Categoria
(
ID_Catg int PRIMARY KEY not null IDENTITY (1,1),
Nombre_Catg VARCHAR (50),
Estado_Catg VARCHAR (50)
)

insert into Categoria (Nombre_Catg, Estado_Catg)
values 
('Frutas', 'Activo'),
('Viveres', 'Activo'),
('Vegetales', 'Activo'),
('Legumbres', 'Activo'),
('Carnes', 'Activo'),
('Lacteos', 'Activo'),
('Bebidas', 'Activo'),
('Frutos Secos', 'Activo'),
('Cereales', 'Activo'),
('Enlatados', 'Activo'),
('Especias', 'Activo')

select * from Categoria
select * from Productos

CREATE PROC Editar_Productos
@nombre varchar(50),
@codigo int,
@stock int,
@fecha_vencimiento datetime,
@descripcion varchar(50),
@categoria varchar(50),
@estado varchar(50),
@id int
as
Update Productos Set Nombre_Prod=@nombre, Codigo=@codigo, Stock=@stock, Fecha_Vencimiento=@fecha_vencimiento, Descripcion=@descripcion, Categoria=@categoria, Estado_Prod=@estado where ID_Prod=@id
go

exec Editar_Productos 'Platano',1,1,'10/05/2020','Maduro','Vivere','Activo', 1

create proc Eliminar_Productos
@idproducto int
as
delete from Productos where ID_Prod=@idproducto
go

exec Eliminar_Producto 1001

--------------------------------------------------------------------------------------------

CREATE PROC Editar_Categoria
@nombre varchar(50),
@estado varchar(50),
@id int
as
Update Categoria Set Nombre_Catg=@nombre, Estado_Catg=@estado where ID_Catg=@id
go

exec Editar_Categoria 'Viveres', 'Activo',1

create proc Eliminar_Categoria
@idcatg int
as
delete from Categoria where ID_Catg=@idcatg
go

exec Eliminar_Categoria 1

