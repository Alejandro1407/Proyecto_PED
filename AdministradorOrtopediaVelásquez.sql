create database OrtopediaVelásquez
GO

use OrtopediaVelásquez
GO

create table horarios(
	id int identity primary key,
	horai time,
	horaf time
);
GO

alter table horarios
add constraint ck_horas check (horaf > horai);
GO

create table tipoOrtesis(
	id int primary key identity,
	nombre varchar(35),
	descripcion varchar(75)
);
GO

create table ortesis(
	id int primary key identity,
	codigo as 'ORT' + upper(substring(nombre,1,2)) + cast(id as varchar(5)),
	nombre varchar(50),
	tipo int foreign key references tipoOrtesis(id),
	descripcion varchar(75),
	foto image,
	precio money
);
GO

create table tipoProtesis(
	id int primary key identity,
	nombre varchar(35),
	descripcion varchar(75)
);
GO

create table protesis(
	id int primary key identity,
	codigo as 'PRO' + upper(substring(nombre,1,2)) + cast(id as varchar(5)),
	nombre varchar(50),
	tipo int foreign key references tipoProtesis(id),
	descripcion varchar(75),
	foto image,
	precio money
);
GO
create table medico(
	id int primary key identity,
	nombres varchar(50),
	apellidos varchar(50),
	experiencia varchar(75),
	especialidad varchar(50),
	userName as 'MED' + substring(nombres,1,1) + substring(apellidos,1,1) + cast(id as varchar(5))
);
GO

create table rol(
	id INT PRIMARY KEY IDENTITY,
	Nombre VARCHAR(50)
);
GO

INSERT INTO rol VALUES ('Administrador'),
					   ('Paciente'),
					   ('Doctor')
GO

create table usuario (
	id int primary key identity,
	email varchar(50) not null unique,
	contrasenya varchar(25) check (LEN(contrasenya) >= 8),
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	sexo CHAR(1),
	edad int not null CHECK(edad > 0 AND edad <= 100),
	idRol INT FOREIGN KEY REFERENCES rol(id)
);
GO

INSERT INTO usuario  VALUES ('alejandroalejo714@gmail.com','password','Alejandro','Alejo','M',18,1)

create table consulta(
	id int primary key identity,
	codigo as 'CON' + cast(id as varchar(5)),
	fecha date,
	idHorario int not null foreign key references horarios(id),
	idUsuario int not null foreign key references usuario(id),
	idProtesis int foreign key references protesis (id),
	idOrtesis int foreign key references ortesis (id),
	idMedico int foreign key references medico (id),
);
GO


