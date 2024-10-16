

use DBCARRITO



select * from Usuario;


insert into Usuario(nombres, Apellidos,correo, clave) 
values ('test2 nombre','test apellido','test@example.com','9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08');


select * from categoria;

insert into Categoria(Description) 
values ('Tecnologia'),('Muebles'),('Dormitorio'),('Deportes');


select * from marca

insert into marca(Description) 
values ('SONYTE'),('HPTE'),('LGTE'),('HYUNDAITE'),('CANONTE'),('ROBERTO ALENTE')



Select * from Departamento


insert into Departamento(IdDepartamento,Descripcion) 
values ('01','Francisco Morazan'),('02','Comayagua'),('03','Cortez')


select * from provincia 

insert into provincia(IdProvincia,Descripcion,IdDepartamento) 
values ('0101','Francisco Morazan','01'),('0202','Comayagua','02'),('0303','Cortez','03')


select * from distrito

insert into distrito(IdDistrito,IdProvincia,Descripcion,IdDepartamento) 
values ('0101','0101','Distritro Central','01'),('0101','0202','Comayagua','02'),('0101','0303','Sanpedro Sula','03')
