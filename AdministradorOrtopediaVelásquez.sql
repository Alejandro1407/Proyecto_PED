USE master
GO
-- Create the new database if it does not exist already
IF NOT EXISTS (
    SELECT name
        FROM sys.databases
        WHERE name = N'ProyectoADS'
)
CREATE DATABASE OrtopediaVelásquez
GO

USE OrtopediaVelásquez;

CREATE TABLE TipoUsuario
(
    id INT NOT NULL PRIMARY KEY IDENTITY,
    tipoUsuario varchar(20),
);
GO

insert into TipoUsuario 
values	
(
	'Administrador'
),
(	
	'Ortopedista'
),
(
	'Secretaria'
),
(
	'Paciente'
);


CREATE TABLE usuario
(
    id int primary key identity,
	nombres varchar(50) not null,
	apellidos varchar(50) not null,
	email varchar(50) unique not null,
	tipoUsuario int foreign key references TipoUsuario(id),
	contrasenya varchar(30) not null,
	sexo char(1) check (sexo = 'M' OR sexo = 'F'),
	fechaNacimiento date check (fechaNacimiento < getdate()),
	alergias varchar(500) null,
	especialidad varchar(500) null,
	experiencia varchar(500) null
);
GO

INSERT INTO usuario (nombres,apellidos,email,tipoUsuario,contrasenya,sexo,fechaNacimiento)  VALUES ('Administrador','01','administrador_1@gmail.com',1,'password','M','10-jul-2000')
GO

INSERT INTO usuario (nombres,apellidos,email,tipoUsuario,contrasenya,sexo,fechaNacimiento, especialidad, experiencia)  VALUES ('Medico','01','medico_1@gmail.com',2,'password','M','12-jul-2000','Jefe','Jefe de Invalidos')
GO

INSERT INTO usuario (nombres,apellidos,email,tipoUsuario,contrasenya,sexo,fechaNacimiento)  VALUES ('Secretaria','01','secretaria_1@gmail.com',3,'Password01','M','13-jul-2000')
GO

INSERT INTO usuario (nombres,apellidos,email,tipoUsuario,contrasenya,sexo,fechaNacimiento)  VALUES ('Paciente','01','paciente_1@gmail.com',3,'Password01','M','14-jul-2000')
GO

--Horarios

CREATE TABLE Dias(
	Id INT PRIMARY KEY IDENTITY,
	Dia VARCHAR(35)
);
GO

INSERT INTO Dias VALUES ('Lunes'),
						('Martes'),
						('Miercoles'),
						('Jueves'),
						('Viernes');
GO
CREATE TABLE Horarios(
	Id INT PRIMARY KEY IDENTITY,
	Dia INT,
	Ortopeda INT,
	Hora VARCHAR(4),
	FOREIGN KEY (Dia) REFERENCES Dias(Id),
	FOREIGN KEY (Ortopeda) REFERENCES usuario(id)
);
GO

--INSERT INTO Horarios VALUES (1,4,'7:00');
--GO

--SELECT d.Dia, u.nombres, h.Hora FROM Horarios h INNER JOIN usuario u ON h.Ortopeda = u.id INNER JOIN Dias d ON h.Dia = d.Id

create table tipoOrtesis(
	id int primary key identity,
	nombre varchar(35),
	foto image,
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
	foto image,
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

create table cita(
	id int primary key identity,
	codigo as 'CITA' + cast(id as varchar(5)),
	fecha date,
	idPaciente int not null foreign key references usuario(id),
	idMedico int foreign key references usuario(id),
    idHorario INT FOREIGN KEY REFERENCES Horarios(id),
	observaciones varchar(500) null
);
GO

