Create Database EstudiantesDb
Go
Use EstudiantesDb
Go
Create Table Estudiantes(
	EstudianteId int primary key identity(1,1),
	Matricula varchar(9),
	Nombres varchar(30),
	Apellidos varchar(30),
	Cedula varchar(13),
	Telefono varchar(12),
	Celular varchar(12),
	Email varchar(30),
	FechaNacimiento date,
	Sexo int,
	Balance float(13)
);