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


INSERT INTO usuario (nombres,apellidos,email,tipoUsuario,contrasenya,sexo,fechaNacimiento)  VALUES ('Alejandro','Alejo','alejandroalejo714@gmail.com',1,'password','M','14-jul-2000')
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

create table consulta(
	id int primary key identity,
	codigo as 'CON' + cast(id as varchar(5)),
	fecha date default getdate(),
	idCliente int not null foreign key references usuario(id),
	descripcion varchar(500)
);
GO

create table detalle_consulta(
	idProtesis int foreign key references protesis (id),
	idOrtesis int foreign key references ortesis (id),
	idMedico int foreign key references usuario(id) not null,
);
GO

alter table detalle_consulta
add idConsulta int foreign key references consulta(id);
GO

use OrtopediaVelásquez

select * from usuario;
GO

/*create trigger AsignarCodigo on usuario INSTEAD OF INSERT
as
begin
	declare @tipo int,
	@tipoS varchar(20),
	@id int,
	@nombres varchar(50),
	@apellidos varchar(50),
	@email varchar(50),
	@codigoUsuario varchar(20),
	@contrasenya varchar(30),
	@sexo char(1),
	@fechaNacimiento date,
	@alergias varchar(500),
	@especialidad varchar(500),
	@experiencia varchar(500);

	set @id = (select id from inserted);
	select @tipo = tipoUsuario from inserted;
	select @tipoS = tipoUsuario from TipoUsuario where id = @tipo;
	select @nombres = nombres from inserted;
	select @apellidos = apellidos from inserted;
	select @email = email from inserted;
	select @codigoUsuario = codigoUsuario from inserted;
	select @contrasenya = contrasenya from inserted;
	select @sexo = sexo from inserted;
	select @fechaNacimiento = fechaNacimiento from inserted;
	select @alergias = alergias from inserted;
	select @especialidad =  especialidad from inserted;
	select @experiencia = experiencia from inserted;

	INSERT into usuario VALUES (@nombres,@apellidos,@email,CONCAT(UPPER(SUBSTRING(@tipoS,1,3)),FORMAT(@id,'####')),@tipo,@contrasenya,@sexo,@fechaNacimiento,@alergias,@especialidad,@experiencia);
	
end;
GO*/

--drop trigger AsignarCodigo