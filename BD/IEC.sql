-- CREACIÓN DE BD
create database IEC;
use IEC;
-- TABLA PUESTO
create table puesto(
pkid varchar(4) primary key,
nombre varchar(30),
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA EMPLEADO
create table empleado(
pkid varchar(4) primary key,
fkpuesto varchar(4) not null,
nombre varchar(50) not null,
apellido varchar(50) not null,
DPI varchar(13) not null,
contratacion date,
despido date,
foto blob,
estado varchar(1),

foreign key (fkpuesto) references puesto(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA USUARIO
create table usuario(
pkid varchar(4) primary key,
fkempleado varchar(4) not null,
usuario varchar(15) not null,
contrasena varchar(100) not null,
estado varchar(1),

foreign key (fkempleado) references empleado(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DISPOSITIVO
create table dispositivo(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA GESTION
create table gestion(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DATOSE
create table datosE(
pkid varchar(4) primary key,
fkempleado varchar(4) not null,
fkdispositivo varchar(1) not null,
estado varchar(1) not null,
foreign key (fkempleado) references empleado(pkid),
foreign key (fkdispositivo) references dispositivo(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DATOSD
create table datosD(
pkid varchar(4) primary key,
fkdatosE varchar(4) not null,
fecha date not null,
hora time not null,
fkgestion varchar(1) not null,
tiporeg varchar(1) not null,
estado varchar(1) not null,
foreign key (fkdatosE) references datosE(pkid),
foreign key (fkgestion) references gestion(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;