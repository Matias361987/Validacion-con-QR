create database Validacion
use Validacion;

Create table  Usuarios (
Username varchar (20),
Password nvarchar (30) ,
SecretKey int);

INSERT INTO Usuarios(Username, Password, SecretKey)
VALUES ('pedro','','');

select * from Usuarios

delete  from Usuarios where Username = 'Carlos'