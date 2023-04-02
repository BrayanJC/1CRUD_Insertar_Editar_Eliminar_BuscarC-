Create database CRUD_Example
use CRUD_Example
go
Create table DBPacientes(
Id int identity(1,1) primary key,
Nombres varchar(100) not null,
Apellidos varchar(100) not null,
Tipo varchar(100) not null,
Tratamiento varchar(100) not null,
Imagen varbinary(max)
)
go

