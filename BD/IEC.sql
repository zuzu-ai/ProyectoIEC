-- drop database IEC;
-- CREACIÓN DE BD
create database IEC;
use IEC;
-- TABLA PUESTO
create table puesto(
pkid varchar(4) primary key,
nombre varchar(30),
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into puesto values ("1","Supervisor","1");
insert into puesto values ("2","Técnico","1");
insert into puesto values ("3","Secretaria","1");
-- TABLA JORNADA
create table jornada(
pkid varchar(4) primary key,
nombre varchar(30) null,
horainicio time not null,
horafin time not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
insert into jornada values ("1","Área Técnica", "07:00:00","17:00:00","1");
insert into jornada values ("2","Área Administrativa", "08:00:00","16:30:00","1");
-- TABLA FOTO
create table foto (
pkId varchar(15) primary key,
fotografia LONGBLOB
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- TABLA EMPLEADO
create table empleado(
pkid varchar(4) primary key,
fkpuesto varchar(4) not null,
nombre varchar(60) not null,
DPI varchar(13) not null,
fkjornada varchar(4) not null,
contratacion date,
despido date,
foto varchar(15)null,
estado varchar(1),
foreign key (fkpuesto) references puesto(pkid),
foreign key (fkjornada) references jornada(pkid),
foreign key (foto) references foto(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into empleado values ("1","1", "José René Quemé Hervías","2145896250101","1",null,null,null,"1");
insert into empleado values ("2","1", "Jorge Mario Ruiz Gonzales","5647821450101","1",null,null,null,"1");
insert into empleado values ("3","2", "Pedro David Hernandez Turcos","6632147850101","1",null,null,null,"1");
insert into empleado values ("4","2", "Andrea Sofía Galindo Zacs","6632014570101","1",null,null,null,"1");

-- TABLA PREGUNTA
create table pregunta(
pkid varchar(4) primary key,
pregunta varchar(75) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into pregunta values ("1", "¿Año de nacimiento?", "1");

-- TABLA TIPO USUARIO
create table tipousuario(
pkid varchar(4) primary key,
nombre varchar(15) not null,
estado varchar(1)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into tipousuario values ("1", "Administrador", "1");
insert into tipousuario values ("2", "Supervisor", "1");
insert into tipousuario values ("3", "Visitante", "1");
-- TABLA USUARIO
create table usuario(
pkid varchar(4) primary key,
fktipousuario varchar(4) not null,
fkempleado varchar(4) not null,
usuario varchar(15) not null,
contrasena varchar(100) not null,
fkpregunta varchar(4) not null,
repuesta varchar(100) not null,
estado varchar(1),
foreign key (fktipousuario) references tipousuario(pkid),
foreign key (fkpregunta) references pregunta(pkid),
foreign key (fkempleado) references empleado(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into usuario values ("1", "1", "1", "admin","LKAekHU9EtweB49HAaTRfg==","1","1","1");
-- TABLA DISPOSITIVO
create table dispositivo(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into dispositivo values ("1","Instelecom","1");
-- TABLA GESTION
create table gestion(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into gestion values ("1","Entrada","1");
insert into gestion values ("2","Salida","1");
-- TABLA TIPO AUSENCIA
create table tipoAusencia(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into tipoausencia values ("1","Falta Injustificada","1");
insert into tipoausencia values ("2","Falta con Permiso","1");
-- TABLA AUSENCIA
create table ausencia(
pkid varchar(4) primary key,
fkempleado varchar(4) not null,
tipoausencia varchar(4) not null,
fecha date not null,
detalles varchar(400) null,
estado varchar(1) not null,

foreign key (fkempleado) references empleado(pkid),
foreign key (tipoausencia) references tipoausencia(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into ausencia values ("1","3","1", "2022-07-15","el empleado faltó injustificadamente","1");
insert into ausencia values ("2","4","2", "2022-07-15","el empleado pidió permiso para faltar por asuntos familiares","1");
-- TABLA TIPO PAGO
create table tipoPago(
pkid varchar(4) primary key,
nombre varchar(30) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into tipopago values ("1","Comida","1");
insert into tipopago values ("2","Combustible","1");
insert into tipopago values ("3","Viáticos","1");
insert into tipopago values ("4","Otros","1");
-- TABLA PAGOEMPLEADO
create table pagoEmpleado(
pkid varchar(4) primary key,
fkempleado varchar(4) not null,
tipopago varchar(4) not null,
fecha date not null,
monto double not null,
detalles varchar(400) null,
estado varchar(1) not null,

foreign key (fkempleado) references empleado(pkid),
foreign key (tipopago) references tipopago(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into pagoempleado values ("1","1","1","2022-07-15","50","Se le pagó al empleado un almuerzo","1");
insert into pagoempleado values ("2","1","2","2022-07-15","100","Se le pagó al empleado la gasolina del carro","1");
insert into pagoempleado values ("3","1","3","2022-07-15","260","Se le pagó al empleado los viaticos","1");
insert into pagoempleado values ("4","1","1","2022-07-15","15","Se le pagó al empleado un desayuno","1");
insert into pagoempleado values ("5","1","1","2022-07-15","300","Se le pagó al empleado la compra de un barreno","1");
-- TABLA DATOSE
create table datosE(
pkid varchar(4) primary key,
fkempleado varchar(4) not null,
fkdispositivo varchar(1) not null,
estado varchar(1) not null,
foreign key (fkempleado) references empleado(pkid),
foreign key (fkdispositivo) references dispositivo(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;

insert into datosE values ("1","1","1","1");
insert into datosE values ("2","2","1","1");
insert into datosE values ("3","3","1","1");
insert into datosE values ("4","4","1","1");
-- TABLA DATOSD
create table datosD(
pkid varchar(4) primary key,
fkdatosE varchar(4) not null,
tiempo datetime not null,
fkgestion varchar(1) not null,
tiporeg varchar(1) not null,
estado varchar(1) not null,
foreign key (fkdatosE) references datosE(pkid),
foreign key (fkgestion) references gestion(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DIARIOSE
create table diariosE(
pkid varchar(4) primary key,
fechatrabajada date not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA DIARIOSD
create table diariosD(
pkid varchar(4) primary key,
fkdiariosE varchar(4) not null,
fkempleado varchar(4) not null,
entrada time null,
salida time null,
htrabajadas time null,
hdescontadas time null,
ausencias int null,
hextras time null,
pcomidas double null,
pcombustible double null,
pviaticos double null,
potros double null,
observaciones varchar(800) null,
estado varchar(1) not null,

foreign key (fkdiariosE) references diariosE(pkid),
foreign key (fkempleado) references empleado(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MENSUALESE
create table mensualesE(
pkid varchar(4) primary key,
fechainicio date not null,
fechafin date not null,
mes varchar(2) not null,
estado varchar(1) not null
)engine=InnoDB DEFAULT CHARSET=latin1;
-- TABLA MENSUALESD
create table mensualesD(
pkid varchar(4) primary key,
fkmensualesE varchar(4) not null,
fkempleado varchar(4) not null,
htrabajadas time null,
hdescontadas time null,
ausencias int null,
hextras time null,
pcomidas double null,
pcombustible double null,
pviaticos double null,
potros double null,
observaciones varchar(800) null,
estado varchar(1) not null,

foreign key (fkmensualesE) references mensualesE(pkid),
foreign key (fkempleado) references empleado(pkid)
)engine=InnoDB DEFAULT CHARSET=latin1;