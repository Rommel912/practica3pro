Use master
Go
Drop database if exists Alumnos
Go
Create database Alumnos

Go
Use Alumnos
Go

Create Table Alumnos(
	Carrera int primary key identity not null,
	CarreraID int,
	Nombres varchar(100),
	Apellidos varchar(50),
	Carnet varchar (50),
	Edad varchar(50),
	)