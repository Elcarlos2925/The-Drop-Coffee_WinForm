Create database THE_DROP_COFFEE;
USE THE_DROP_COFFEE;

#drop database THE_DROP_COFFEE;
CREATE TABLE PRODUCTOS(
Id_Producto int not null,
NOMBRE varchar (20) NOT NULL,
PRECIO DOUBLE NOT NULL,
INFORMACIÓN longtext not null,
PRIMARY KEY (Id_Producto)
);

create table INGREDIENTES_PRODUCTOS(
ID_INGREDIENTE INT NOT NULL,
ID_PRODUCTO INT NOT NULL
);

create TABLE VENTAS_PRODUCTOS(
ID_VENTA INT NOT NULL,
ID_PRODUCTO INT NOT NULL
);

create table INGREDIENTES(
ID_INGREDIENTE INT NOT NULL AUTO_INCREMENT,
NOMBRE VARCHAR(70) NOT NULL,
DISPONIBILIDAD bool NOT NULL,
id_Productos int not null,
PRIMARY KEY (ID_INGREDIENTE));

create table EMPLEADOS(
id_Empleados int not null auto_increment ,
Nombres varchar (50) not null,
Apellido_Materno varchar (30) not null,
Apellido_Paterno varchar (30) not null,
Telefono varchar (10) not null,
RFC varchar(13)not null,
UserPassword int not null ,
primary key (id_Empleados)
);

create table Ventas(
Num_Venta int not null auto_increment,
Fecha_Hora date not null,
Productos longText not null,
SubTotal double not null,
IVA double not null,
EFECTIVO double not null,
Total double not null,
Cambio Double not null,
primary key (Num_Venta)
);

create table Administradores(
Usuario varchar (10) not null,
Nombres varchar (50) not null,
Apellido_Materno varchar (30) not null,
Apellido_Paterno varchar (30) not null,
CorreoElectronico varchar (99) not null,
Telefono varchar (10) not null,
Admin_Password varchar (20) not null,
Primary key (Usuario)
);

alter table INGREDIENTES_PRODUCTOS add constraint INGREDIENTES_PRODUCTOS_ID_PRODUCTOS_FK foreign key (Id_Producto)references PRODUCTOS(ID_PRODUCTO);
alter table INGREDIENTES_PRODUCTOS add constraint INGREDIENTES_PRODUCTOS_ID_INGREDIENTES_FK foreign key (ID_INGREDIENTE)references INGREDIENTES(ID_INGREDIENTE);

alter table VENTAS_PRODUCTOS add constraint VENTAS_PRODUCTOS_ID_Ventas_FK foreign key (ID_VENTA)references Ventas(Num_Venta);
alter table VENTAS_PRODUCTOS add constraint VENTAS_PRODUCTOS_ID_PRODUCTOS_FK foreign key (ID_PRODUCTO)references PRODUCTOS(Id_Producto);

insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(1,"Americano",70.00,"Bebida caliente de 8 oz, Es un café que consiste en partes exactamente iguales de espresso y agua.");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(2,"Brownie",35.00,"Porción individual de 105 gr, Clásico brownie sabor chocolate");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(3,"Cappuccino",85.00,"Bebida caliente de 16 oz, Contiene un shot de expresso con leche y mucha espuma");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(4,"Chocolate",60.00,"Bebida caliente de 16 oz, Contiene leche vaporizada combinada con salsa de chocolate y vainilla, cubierto con crema batida y espiral de salsa de chocolate");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(5,"Frappuccino",85.00,"Bebida fría de 16 oz, Contiene café con leche y hielo");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(6,"Galleta",20.00,"Porción individual de 45gr, Clásica galleta con chispas de chocolate");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(7,"Latte",80.00,"Bebida caliente de 16 oz, Contiene un shot de expresso con mucha leche y espuma ");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(8,"Mocha",65.00,"Bebida caliente de 16 oz, Contiene un espresso con leche y salsa de chocolate");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(9,"Pastel",50.00,"Porción individual de 105 gr, Clásico brownie sabor chocolate");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(10,"Sandwich",55.00,"Sandwich de pierna, Contiene pan de 12 granos con queso crema, jamón de pierna, queso manchego, lechuga, tomate y alfalfa" );
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(11,"TeaMatcha",80.00,"Bebida fría de 16 oz, Contiene crema batida a base de leche entera");
insert into productos(Id_Producto,NOMBRE,PRECIO,INFORMACIÓN)values(12,"White_Mocha",65.00,"Bebida caliente de 16 oz, Café Espresso con capas de mocha y mocha blanco combinadas en leche vaporizada y chispas sabor chocolate. No lleva crema batida. Sin endulzantes.");

insert into Administradores(Usuario,Nombres,Apellido_Materno,Apellido_Paterno,CorreoElectronico,Telefono,Admin_Password)values("Carlos2925","Carlos Abraham","Avalos","Lozoya","l21211548@tectijuana.edu.mx","6640847382","1122334455");
insert into Administradores(Usuario,Nombres,Apellido_Materno,Apellido_Paterno,CorreoElectronico,Telefono,Admin_Password)values("Omar","Omar Alexander","Neri","Mendez","l21211554@tectijuana.edu.mx","6639569841","12345");
select * from Administradores;

select * from Administradores where  Usuario = "Carlos2925" and Admin_Password = "1122334455" ;