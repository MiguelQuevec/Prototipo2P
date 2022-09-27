create database Parte2Analisis;
use Parte2Analisis;

create table tbl_empleados(
pk_IDempleado int not null primary key auto_increment,
nombreEmpleado varchar(50),
puesto varchar(50),
fk_IDtipoContrato int not null
);

create table tbl_contrato(
pk_IDcontrato int not null primary key auto_increment,
tipoContrato varchar(50)
);

create table tbl_producto(
pk_IDproducto int not null primary key auto_increment,
descripcion varchar(50),
nombre varchar(50)
);

create table tbl_ventas(
pk_IDventa int not null primary key auto_increment,
fk_IDproducto int not null,
cantidadVenta int not null,
calculoComision int not null,
foreign key (fk_IDproducto) references tbl_producto (pk_IDproducto)
);

create table tbl_percepciones(
pk_IDpercepcion int not null primary key auto_increment,
fk_IDcontrato int not null,
descripcion varchar(50),
cantidad int not null,
foreign key (fk_IDcontrato) references tbl_contrato (pk_IDcontrato)
);

create table tbl_planilla(
pk_IDplanilla int not null primary key auto_increment,
fk_IDpercepcion int not null,
foreign key (fk_IDpercepcion) references tbl_percepciones (pk_IDpercepcion)
);

