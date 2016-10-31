{ DATABASE suru  delimiter | }

grant dba to "informix";
grant connect to "suru_general";
grant connect to "suru_individual";
grant connect to "suru_auxiliar";











{ TABLE "informix".conforma row size = 8 number of columns = 2 index size = 18 }
{ unload file name = confo00100.unl number of rows = 0 }

create table "informix".conforma 
  (
    id_coop integer not null ,
    id_tambo integer not null ,
    primary key (id_tambo)  constraint "informix".pkconforma
  );

revoke all on "informix".conforma from "public" as "informix";

{ TABLE "informix".pertenece row size = 8 number of columns = 2 index size = 18 }
{ unload file name = perte00101.unl number of rows = 0 }

create table "informix".pertenece 
  (
    id_usuario integer not null ,
    id_tambo integer not null ,
    primary key (id_usuario)  constraint "informix".pkpertenece
  );

revoke all on "informix".pertenece from "public" as "informix";

{ TABLE "informix".posee row size = 8 number of columns = 2 index size = 18 }
{ unload file name = posee00102.unl number of rows = 0 }

create table "informix".posee 
  (
    id_animal integer not null ,
    id_tambo integer not null ,
    primary key (id_animal)  constraint "informix".pkposee
  );

revoke all on "informix".posee from "public" as "informix";

{ TABLE "informix".campo_recria row size = 86 number of columns = 3 index size = 
              9 }
{ unload file name = campo00104.unl number of rows = 2 }

create table "informix".campo_recria 
  (
    id_camporec serial not null ,
    nombre varchar(40) not null ,
    ubicacion varchar(40) not null 
  );

revoke all on "informix".campo_recria from "public" as "informix";

{ TABLE "informix".van row size = 12 number of columns = 3 index size = 18 }
{ unload file name = van__00105.unl number of rows = 0 }

create table "informix".van 
  (
    id_cria integer not null ,
    id_camporec integer not null ,
    fecha date not null ,
    primary key (id_cria)  constraint "informix".pkvan
  );

revoke all on "informix".van from "public" as "informix";

{ TABLE "informix".lote row size = 45 number of columns = 2 index size = 9 }
{ unload file name = lote_00106.unl number of rows = 1 }

create table "informix".lote 
  (
    id_lote serial not null ,
    nombre varchar(40) not null 
  );

revoke all on "informix".lote from "public" as "informix";

{ TABLE "informix".asigna row size = 8 number of columns = 2 index size = 31 }
{ unload file name = asign00107.unl number of rows = 0 }

create table "informix".asigna 
  (
    id_vaca integer not null ,
    id_lote integer not null ,
    primary key (id_vaca,id_lote)  constraint "informix".pkasigna
  );

revoke all on "informix".asigna from "public" as "informix";

{ TABLE "informix".tiene row size = 16 number of columns = 4 index size = 18 }
{ unload file name = tiene00108.unl number of rows = 1 }

create table "informix".tiene 
  (
    id_vaca integer not null ,
    id_estado integer not null ,
    fecha_i date not null ,
    fecha_f date,
    primary key (id_vaca)  constraint "informix".fktiene
  );

revoke all on "informix".tiene from "public" as "informix";

{ TABLE "informix".contrae row size = 18 number of columns = 5 index size = 31 }
{ unload file name = contr00109.unl number of rows = 0 }

create table "informix".contrae 
  (
    id_animal integer not null ,
    id_enf integer not null ,
    cont smallint not null ,
    fecha_i date not null ,
    fecha_f date,
    primary key (id_animal,id_enf)  constraint "informix".pkcontrae
  );

revoke all on "informix".contrae from "public" as "informix";

{ TABLE "informix".animal row size = 137 number of columns = 7 index size = 9 }
{ unload file name = anima00110.unl number of rows = 13 }

create table "informix".animal 
  (
    id_animal serial not null ,
    nom_animal varchar(40) not null ,
    sexo varchar(40) not null ,
    raza varchar(40) not null ,
    fecha_nac date not null ,
    x smallint not null ,
    fecha_muerte date
  );

revoke all on "informix".animal from "public" as "informix";

{ TABLE "informix".cooperativa row size = 131 number of columns = 5 index size = 
              9 }
{ unload file name = coope00111.unl number of rows = 0 }

create table "informix".cooperativa 
  (
    id_coop serial not null ,
    nom_coop varchar(40) not null ,
    depart varchar(40) not null ,
    calle_coop varchar(40) not null ,
    num_coop integer not null 
  );

revoke all on "informix".cooperativa from "public" as "informix";

{ TABLE "informix".cria row size = 12 number of columns = 3 index size = 27 }
{ unload file name = cria_00112.unl number of rows = 2 }

create table "informix".cria 
  (
    id_cria integer not null ,
    id_vaca integer not null ,
    id_toro integer not null ,
    primary key (id_cria)  constraint "informix".pkcria
  );

revoke all on "informix".cria from "public" as "informix";

{ TABLE "informix".entora row size = 96 number of columns = 6 index size = 31 }
{ unload file name = entor00114.unl number of rows = 0 }

create table "informix".entora 
  (
    id_vaca integer not null ,
    id_toro integer not null ,
    tipo varchar(40) not null ,
    proceso varchar(40) not null ,
    fecha date not null ,
    servicio_activo smallint,
    primary key (id_vaca,id_toro)  constraint "informix".pkentora
  );

revoke all on "informix".entora from "public" as "informix";

{ TABLE "informix".estado row size = 45 number of columns = 2 index size = 9 }
{ unload file name = estad00115.unl number of rows = 6 }

create table "informix".estado 
  (
    id_estado serial not null ,
    nombre varchar(40) not null 
  );

revoke all on "informix".estado from "public" as "informix";

{ TABLE "informix".leche row size = 45 number of columns = 2 index size = 9 }
{ unload file name = leche00116.unl number of rows = 3 }

create table "informix".leche 
  (
    id_leche serial not null ,
    tipo varchar(40) not null 
  );

revoke all on "informix".leche from "public" as "informix";

{ TABLE "informix".requiere row size = 49 number of columns = 3 index size = 31 }
{ unload file name = requi00117.unl number of rows = 3 }

create table "informix".requiere 
  (
    id_animal integer not null ,
    id_tratam integer not null ,
    medicacion varchar(40) not null ,
    primary key (id_animal,id_tratam)  constraint "informix".pkrequiere
  );

revoke all on "informix".requiere from "public" as "informix";

{ TABLE "informix".rol row size = 43 number of columns = 2 index size = 7 }
{ unload file name = rol__00119.unl number of rows = 4 }

create table "informix".rol 
  (
    id_rol smallint not null ,
    nombre varchar(40) not null ,
    primary key (id_rol)  constraint "informix".pkrol
  );

revoke all on "informix".rol from "public" as "informix";

{ TABLE "informix".tambo row size = 92 number of columns = 5 index size = 9 }
{ unload file name = tambo00120.unl number of rows = 5 }

create table "informix".tambo 
  (
    id_tambo serial not null ,
    nom_tambo varchar(40) not null ,
    calle_tambo varchar(40) not null ,
    num_tambo integer not null ,
    sector varchar(1) not null 
  );

revoke all on "informix".tambo from "public" as "informix";

{ TABLE "informix".tel_coop row size = 20 number of columns = 2 index size = 34 }
{ unload file name = tel_c00121.unl number of rows = 0 }

create table "informix".tel_coop 
  (
    id_coop integer not null ,
    tel_coop varchar(15) not null ,
    primary key (id_coop,tel_coop)  constraint "informix".pktel_coop
  );

revoke all on "informix".tel_coop from "public" as "informix";

{ TABLE "informix".tel_tambo row size = 20 number of columns = 2 index size = 34 
              }
{ unload file name = tel_t00122.unl number of rows = 6 }

create table "informix".tel_tambo 
  (
    id_tambo integer not null ,
    tel_tambo varchar(15) not null ,
    primary key (id_tambo,tel_tambo)  constraint "informix".pktel_tambo
  );

revoke all on "informix".tel_tambo from "public" as "informix";

{ TABLE "informix".toro row size = 45 number of columns = 2 index size = 9 }
{ unload file name = toro_00123.unl number of rows = 4 }

create table "informix".toro 
  (
    id_toro integer not null ,
    tipo varchar(40) not null ,
    primary key (id_toro)  constraint "informix".pktoro
  );

revoke all on "informix".toro from "public" as "informix";

{ TABLE "informix".tratamiento row size = 45 number of columns = 2 index size = 9 
              }
{ unload file name = trata00124.unl number of rows = 4 }

create table "informix".tratamiento 
  (
    id_tratam serial not null ,
    nombre varchar(40) not null 
  );

revoke all on "informix".tratamiento from "public" as "informix";

{ TABLE "informix".usu_rol row size = 6 number of columns = 2 index size = 16 }
{ unload file name = usu_r00125.unl number of rows = 4 }

create table "informix".usu_rol 
  (
    id_usuario integer not null ,
    id_rol smallint not null ,
    primary key (id_usuario)  constraint "informix".pkusu_rol
  );

revoke all on "informix".usu_rol from "public" as "informix";

{ TABLE "informix".vaca row size = 45 number of columns = 2 index size = 9 }
{ unload file name = vaca_00126.unl number of rows = 7 }

create table "informix".vaca 
  (
    id_vaca integer not null ,
    tipo varchar(40) not null ,
    primary key (id_vaca)  constraint "informix".pkvaca
  );

revoke all on "informix".vaca from "public" as "informix";

{ TABLE "informix".usuario row size = 131 number of columns = 5 index size = 55 }
{ unload file name = usuar00127.unl number of rows = 4 }

create table "informix".usuario 
  (
    id_usuario serial not null ,
    cedula integer not null ,
    login varchar(40) not null ,
    nombre varchar(40) not null ,
    apellido varchar(40) not null 
  );

revoke all on "informix".usuario from "public" as "informix";

{ TABLE "informix".enfermedad row size = 207 number of columns = 4 index size = 55 
              }
{ unload file name = enfer00129.unl number of rows = 7 }

create table "informix".enfermedad 
  (
    id_enf serial not null ,
    nombre varchar(40) not null ,
    tipo varchar(40) not null ,
    descrip varchar(120) not null 
  );

revoke all on "informix".enfermedad from "public" as "informix";

{ TABLE "informix".producen row size = 20 number of columns = 5 index size = 35 }
{ unload file name = produ00131.unl number of rows = 0 }

create table "informix".producen 
  (
    id_lote integer not null ,
    id_leche integer not null ,
    cantidad integer not null ,
    calcio integer not null ,
    fecha date not null ,
    primary key (id_lote,id_leche,fecha)  constraint "informix".pkproducen
  );

revoke all on "informix".producen from "public" as "informix";




grant select on "informix".conforma to "public" as "informix";
grant update on "informix".conforma to "public" as "informix";
grant insert on "informix".conforma to "public" as "informix";
grant delete on "informix".conforma to "public" as "informix";
grant index on "informix".conforma to "public" as "informix";
grant select on "informix".conforma to "suru_general" as "informix";
grant update on "informix".conforma to "suru_general" as "informix";
grant insert on "informix".conforma to "suru_general" as "informix";
grant delete on "informix".conforma to "suru_general" as "informix";
grant select on "informix".conforma to "suru_programador" as "informix";
grant alter on "informix".conforma to "suru_programador" as "informix";
grant select on "informix".conforma to "suru_individual" as "informix";
grant select on "informix".pertenece to "suru_general" as "informix";
grant update on "informix".pertenece to "suru_general" as "informix";
grant insert on "informix".pertenece to "suru_general" as "informix";
grant delete on "informix".pertenece to "suru_general" as "informix";
grant select on "informix".pertenece to "public" as "informix";
grant update on "informix".pertenece to "public" as "informix";
grant insert on "informix".pertenece to "public" as "informix";
grant delete on "informix".pertenece to "public" as "informix";
grant index on "informix".pertenece to "public" as "informix";
grant select on "informix".pertenece to "suru_individual" as "informix";
grant select on "informix".pertenece to "suru_programador" as "informix";
grant alter on "informix".pertenece to "suru_programador" as "informix";
grant select on "informix".posee to "suru_auxiliar" as "informix";
grant update on "informix".posee to "suru_auxiliar" as "informix";
grant insert on "informix".posee to "suru_auxiliar" as "informix";
grant select on "informix".posee to "public" as "informix";
grant update on "informix".posee to "public" as "informix";
grant insert on "informix".posee to "public" as "informix";
grant delete on "informix".posee to "public" as "informix";
grant index on "informix".posee to "public" as "informix";
grant select on "informix".posee to "suru_general" as "informix";
grant select on "informix".posee to "suru_programador" as "informix";
grant alter on "informix".posee to "suru_programador" as "informix";
grant select on "informix".posee to "suru_individual" as "informix";
grant update on "informix".posee to "suru_individual" as "informix";
grant insert on "informix".posee to "suru_individual" as "informix";
grant delete on "informix".posee to "suru_individual" as "informix";
grant select on "informix".campo_recria to "public" as "informix";
grant update on "informix".campo_recria to "public" as "informix";
grant insert on "informix".campo_recria to "public" as "informix";
grant delete on "informix".campo_recria to "public" as "informix";
grant index on "informix".campo_recria to "public" as "informix";
grant select on "informix".campo_recria to "suru_programador" as "informix";
grant alter on "informix".campo_recria to "suru_programador" as "informix";
grant select on "informix".campo_recria to "suru_auxiliar" as "informix";
grant update on "informix".campo_recria to "suru_auxiliar" as "informix";
grant insert on "informix".campo_recria to "suru_auxiliar" as "informix";
grant select on "informix".campo_recria to "suru_general" as "informix";
grant select on "informix".campo_recria to "suru_individual" as "informix";
grant update on "informix".campo_recria to "suru_individual" as "informix";
grant insert on "informix".campo_recria to "suru_individual" as "informix";
grant delete on "informix".campo_recria to "suru_individual" as "informix";
grant select on "informix".van to "suru_individual" as "informix";
grant update on "informix".van to "suru_individual" as "informix";
grant insert on "informix".van to "suru_individual" as "informix";
grant delete on "informix".van to "suru_individual" as "informix";
grant select on "informix".van to "suru_programador" as "informix";
grant alter on "informix".van to "suru_programador" as "informix";
grant select on "informix".van to "suru_general" as "informix";
grant select on "informix".van to "public" as "informix";
grant update on "informix".van to "public" as "informix";
grant insert on "informix".van to "public" as "informix";
grant delete on "informix".van to "public" as "informix";
grant index on "informix".van to "public" as "informix";
grant select on "informix".van to "suru_auxiliar" as "informix";
grant update on "informix".van to "suru_auxiliar" as "informix";
grant insert on "informix".van to "suru_auxiliar" as "informix";
grant select on "informix".lote to "suru_programador" as "informix";
grant alter on "informix".lote to "suru_programador" as "informix";
grant select on "informix".lote to "public" as "informix";
grant update on "informix".lote to "public" as "informix";
grant insert on "informix".lote to "public" as "informix";
grant delete on "informix".lote to "public" as "informix";
grant index on "informix".lote to "public" as "informix";
grant select on "informix".lote to "suru_auxiliar" as "informix";
grant update on "informix".lote to "suru_auxiliar" as "informix";
grant insert on "informix".lote to "suru_auxiliar" as "informix";
grant select on "informix".lote to "suru_individual" as "informix";
grant update on "informix".lote to "suru_individual" as "informix";
grant insert on "informix".lote to "suru_individual" as "informix";
grant delete on "informix".lote to "suru_individual" as "informix";
grant select on "informix".lote to "suru_general" as "informix";
grant select on "informix".asigna to "suru_auxiliar" as "informix";
grant update on "informix".asigna to "suru_auxiliar" as "informix";
grant insert on "informix".asigna to "suru_auxiliar" as "informix";
grant select on "informix".asigna to "public" as "informix";
grant update on "informix".asigna to "public" as "informix";
grant insert on "informix".asigna to "public" as "informix";
grant delete on "informix".asigna to "public" as "informix";
grant index on "informix".asigna to "public" as "informix";
grant select on "informix".asigna to "suru_programador" as "informix";
grant alter on "informix".asigna to "suru_programador" as "informix";
grant select on "informix".asigna to "suru_individual" as "informix";
grant update on "informix".asigna to "suru_individual" as "informix";
grant insert on "informix".asigna to "suru_individual" as "informix";
grant delete on "informix".asigna to "suru_individual" as "informix";
grant select on "informix".asigna to "suru_general" as "informix";
grant select on "informix".tiene to "public" as "informix";
grant update on "informix".tiene to "public" as "informix";
grant insert on "informix".tiene to "public" as "informix";
grant delete on "informix".tiene to "public" as "informix";
grant index on "informix".tiene to "public" as "informix";
grant select on "informix".tiene to "suru_auxiliar" as "informix";
grant update on "informix".tiene to "suru_auxiliar" as "informix";
grant insert on "informix".tiene to "suru_auxiliar" as "informix";
grant select on "informix".tiene to "suru_programador" as "informix";
grant alter on "informix".tiene to "suru_programador" as "informix";
grant select on "informix".tiene to "suru_individual" as "informix";
grant update on "informix".tiene to "suru_individual" as "informix";
grant insert on "informix".tiene to "suru_individual" as "informix";
grant delete on "informix".tiene to "suru_individual" as "informix";
grant select on "informix".tiene to "suru_general" as "informix";
grant select on "informix".contrae to "suru_auxiliar" as "informix";
grant update on "informix".contrae to "suru_auxiliar" as "informix";
grant insert on "informix".contrae to "suru_auxiliar" as "informix";
grant select on "informix".contrae to "public" as "informix";
grant update on "informix".contrae to "public" as "informix";
grant insert on "informix".contrae to "public" as "informix";
grant delete on "informix".contrae to "public" as "informix";
grant index on "informix".contrae to "public" as "informix";
grant select on "informix".contrae to "suru_individual" as "informix";
grant update on "informix".contrae to "suru_individual" as "informix";
grant insert on "informix".contrae to "suru_individual" as "informix";
grant delete on "informix".contrae to "suru_individual" as "informix";
grant select on "informix".contrae to "suru_programador" as "informix";
grant alter on "informix".contrae to "suru_programador" as "informix";
grant select on "informix".contrae to "suru_general" as "informix";
grant select on "informix".animal to "suru_individual" as "informix";
grant update on "informix".animal to "suru_individual" as "informix";
grant insert on "informix".animal to "suru_individual" as "informix";
grant delete on "informix".animal to "suru_individual" as "informix";
grant select on "informix".animal to "suru_auxiliar" as "informix";
grant update on "informix".animal to "suru_auxiliar" as "informix";
grant insert on "informix".animal to "suru_auxiliar" as "informix";
grant select on "informix".animal to "suru_programador" as "informix";
grant alter on "informix".animal to "suru_programador" as "informix";
grant select on "informix".animal to "suru_general" as "informix";
grant select on "informix".animal to "public" as "informix";
grant update on "informix".animal to "public" as "informix";
grant insert on "informix".animal to "public" as "informix";
grant delete on "informix".animal to "public" as "informix";
grant index on "informix".animal to "public" as "informix";
grant select on "informix".cooperativa to "suru_programador" as "informix";
grant alter on "informix".cooperativa to "suru_programador" as "informix";
grant select on "informix".cooperativa to "public" as "informix";
grant update on "informix".cooperativa to "public" as "informix";
grant insert on "informix".cooperativa to "public" as "informix";
grant delete on "informix".cooperativa to "public" as "informix";
grant index on "informix".cooperativa to "public" as "informix";
grant select on "informix".cooperativa to "suru_general" as "informix";
grant update on "informix".cooperativa to "suru_general" as "informix";
grant insert on "informix".cooperativa to "suru_general" as "informix";
grant delete on "informix".cooperativa to "suru_general" as "informix";
grant select on "informix".cria to "public" as "informix";
grant update on "informix".cria to "public" as "informix";
grant insert on "informix".cria to "public" as "informix";
grant delete on "informix".cria to "public" as "informix";
grant index on "informix".cria to "public" as "informix";
grant select on "informix".cria to "suru_general" as "informix";
grant select on "informix".cria to "suru_programador" as "informix";
grant alter on "informix".cria to "suru_programador" as "informix";
grant select on "informix".cria to "suru_auxiliar" as "informix";
grant update on "informix".cria to "suru_auxiliar" as "informix";
grant insert on "informix".cria to "suru_auxiliar" as "informix";
grant select on "informix".cria to "suru_individual" as "informix";
grant update on "informix".cria to "suru_individual" as "informix";
grant insert on "informix".cria to "suru_individual" as "informix";
grant delete on "informix".cria to "suru_individual" as "informix";
grant select on "informix".entora to "public" as "informix";
grant update on "informix".entora to "public" as "informix";
grant insert on "informix".entora to "public" as "informix";
grant delete on "informix".entora to "public" as "informix";
grant index on "informix".entora to "public" as "informix";
grant select on "informix".entora to "suru_programador" as "informix";
grant alter on "informix".entora to "suru_programador" as "informix";
grant select on "informix".entora to "suru_auxiliar" as "informix";
grant update on "informix".entora to "suru_auxiliar" as "informix";
grant insert on "informix".entora to "suru_auxiliar" as "informix";
grant select on "informix".entora to "suru_general" as "informix";
grant select on "informix".entora to "suru_individual" as "informix";
grant update on "informix".entora to "suru_individual" as "informix";
grant insert on "informix".entora to "suru_individual" as "informix";
grant delete on "informix".entora to "suru_individual" as "informix";
grant select on "informix".estado to "suru_programador" as "informix";
grant alter on "informix".estado to "suru_programador" as "informix";
grant select on "informix".estado to "suru_individual" as "informix";
grant update on "informix".estado to "suru_individual" as "informix";
grant insert on "informix".estado to "suru_individual" as "informix";
grant delete on "informix".estado to "suru_individual" as "informix";
grant select on "informix".estado to "public" as "informix";
grant update on "informix".estado to "public" as "informix";
grant insert on "informix".estado to "public" as "informix";
grant delete on "informix".estado to "public" as "informix";
grant index on "informix".estado to "public" as "informix";
grant select on "informix".estado to "suru_general" as "informix";
grant select on "informix".estado to "suru_auxiliar" as "informix";
grant update on "informix".estado to "suru_auxiliar" as "informix";
grant insert on "informix".estado to "suru_auxiliar" as "informix";
grant select on "informix".leche to "suru_individual" as "informix";
grant update on "informix".leche to "suru_individual" as "informix";
grant insert on "informix".leche to "suru_individual" as "informix";
grant delete on "informix".leche to "suru_individual" as "informix";
grant select on "informix".leche to "suru_general" as "informix";
grant select on "informix".leche to "suru_auxiliar" as "informix";
grant update on "informix".leche to "suru_auxiliar" as "informix";
grant insert on "informix".leche to "suru_auxiliar" as "informix";
grant select on "informix".leche to "suru_programador" as "informix";
grant alter on "informix".leche to "suru_programador" as "informix";
grant select on "informix".leche to "public" as "informix";
grant update on "informix".leche to "public" as "informix";
grant insert on "informix".leche to "public" as "informix";
grant delete on "informix".leche to "public" as "informix";
grant index on "informix".leche to "public" as "informix";
grant select on "informix".requiere to "suru_auxiliar" as "informix";
grant update on "informix".requiere to "suru_auxiliar" as "informix";
grant insert on "informix".requiere to "suru_auxiliar" as "informix";
grant select on "informix".requiere to "public" as "informix";
grant update on "informix".requiere to "public" as "informix";
grant insert on "informix".requiere to "public" as "informix";
grant delete on "informix".requiere to "public" as "informix";
grant index on "informix".requiere to "public" as "informix";
grant select on "informix".requiere to "suru_individual" as "informix";
grant update on "informix".requiere to "suru_individual" as "informix";
grant insert on "informix".requiere to "suru_individual" as "informix";
grant delete on "informix".requiere to "suru_individual" as "informix";
grant select on "informix".requiere to "suru_programador" as "informix";
grant alter on "informix".requiere to "suru_programador" as "informix";
grant select on "informix".requiere to "suru_general" as "informix";
grant select on "informix".rol to "suru_auxiliar" as "informix";
grant select on "informix".rol to "public" as "informix";
grant update on "informix".rol to "public" as "informix";
grant insert on "informix".rol to "public" as "informix";
grant delete on "informix".rol to "public" as "informix";
grant index on "informix".rol to "public" as "informix";
grant select on "informix".rol to "suru_general" as "informix";
grant select on "informix".rol to "suru_programador" as "informix";
grant alter on "informix".rol to "suru_programador" as "informix";
grant select on "informix".rol to "suru_individual" as "informix";
grant update on "informix".rol to "suru_individual" as "informix";
grant insert on "informix".rol to "suru_individual" as "informix";
grant delete on "informix".rol to "suru_individual" as "informix";
grant select on "informix".tambo to "suru_individual" as "informix";
grant select on "informix".tambo to "suru_general" as "informix";
grant update on "informix".tambo to "suru_general" as "informix";
grant insert on "informix".tambo to "suru_general" as "informix";
grant delete on "informix".tambo to "suru_general" as "informix";
grant select on "informix".tambo to "suru_programador" as "informix";
grant alter on "informix".tambo to "suru_programador" as "informix";
grant select on "informix".tambo to "public" as "informix";
grant update on "informix".tambo to "public" as "informix";
grant insert on "informix".tambo to "public" as "informix";
grant delete on "informix".tambo to "public" as "informix";
grant index on "informix".tambo to "public" as "informix";
grant select on "informix".tel_coop to "public" as "informix";
grant update on "informix".tel_coop to "public" as "informix";
grant insert on "informix".tel_coop to "public" as "informix";
grant delete on "informix".tel_coop to "public" as "informix";
grant index on "informix".tel_coop to "public" as "informix";
grant select on "informix".tel_coop to "suru_programador" as "informix";
grant alter on "informix".tel_coop to "suru_programador" as "informix";
grant select on "informix".tel_coop to "suru_general" as "informix";
grant update on "informix".tel_coop to "suru_general" as "informix";
grant insert on "informix".tel_coop to "suru_general" as "informix";
grant delete on "informix".tel_coop to "suru_general" as "informix";
grant select on "informix".tel_tambo to "suru_general" as "informix";
grant select on "informix".tel_tambo to "suru_individual" as "informix";
grant update on "informix".tel_tambo to "suru_individual" as "informix";
grant insert on "informix".tel_tambo to "suru_individual" as "informix";
grant delete on "informix".tel_tambo to "suru_individual" as "informix";
grant select on "informix".tel_tambo to "suru_programador" as "informix";
grant alter on "informix".tel_tambo to "suru_programador" as "informix";
grant select on "informix".tel_tambo to "public" as "informix";
grant update on "informix".tel_tambo to "public" as "informix";
grant insert on "informix".tel_tambo to "public" as "informix";
grant delete on "informix".tel_tambo to "public" as "informix";
grant index on "informix".tel_tambo to "public" as "informix";
grant select on "informix".toro to "suru_programador" as "informix";
grant alter on "informix".toro to "suru_programador" as "informix";
grant select on "informix".toro to "suru_individual" as "informix";
grant update on "informix".toro to "suru_individual" as "informix";
grant insert on "informix".toro to "suru_individual" as "informix";
grant delete on "informix".toro to "suru_individual" as "informix";
grant select on "informix".toro to "suru_auxiliar" as "informix";
grant update on "informix".toro to "suru_auxiliar" as "informix";
grant insert on "informix".toro to "suru_auxiliar" as "informix";
grant select on "informix".toro to "public" as "informix";
grant update on "informix".toro to "public" as "informix";
grant insert on "informix".toro to "public" as "informix";
grant delete on "informix".toro to "public" as "informix";
grant index on "informix".toro to "public" as "informix";
grant select on "informix".toro to "suru_general" as "informix";
grant select on "informix".tratamiento to "public" as "informix";
grant update on "informix".tratamiento to "public" as "informix";
grant insert on "informix".tratamiento to "public" as "informix";
grant delete on "informix".tratamiento to "public" as "informix";
grant index on "informix".tratamiento to "public" as "informix";
grant select on "informix".tratamiento to "suru_auxiliar" as "informix";
grant update on "informix".tratamiento to "suru_auxiliar" as "informix";
grant insert on "informix".tratamiento to "suru_auxiliar" as "informix";
grant select on "informix".tratamiento to "suru_programador" as "informix";
grant alter on "informix".tratamiento to "suru_programador" as "informix";
grant select on "informix".tratamiento to "suru_individual" as "informix";
grant update on "informix".tratamiento to "suru_individual" as "informix";
grant insert on "informix".tratamiento to "suru_individual" as "informix";
grant delete on "informix".tratamiento to "suru_individual" as "informix";
grant select on "informix".tratamiento to "suru_general" as "informix";
grant select on "informix".usu_rol to "suru_individual" as "informix";
grant update on "informix".usu_rol to "suru_individual" as "informix";
grant insert on "informix".usu_rol to "suru_individual" as "informix";
grant delete on "informix".usu_rol to "suru_individual" as "informix";
grant select on "informix".usu_rol to "public" as "informix";
grant update on "informix".usu_rol to "public" as "informix";
grant insert on "informix".usu_rol to "public" as "informix";
grant delete on "informix".usu_rol to "public" as "informix";
grant index on "informix".usu_rol to "public" as "informix";
grant select on "informix".usu_rol to "suru_auxiliar" as "informix";
grant select on "informix".usu_rol to "suru_general" as "informix";
grant select on "informix".usu_rol to "suru_programador" as "informix";
grant alter on "informix".usu_rol to "suru_programador" as "informix";
grant select on "informix".vaca to "suru_general" as "informix";
grant select on "informix".vaca to "public" as "informix";
grant update on "informix".vaca to "public" as "informix";
grant insert on "informix".vaca to "public" as "informix";
grant delete on "informix".vaca to "public" as "informix";
grant index on "informix".vaca to "public" as "informix";
grant select on "informix".vaca to "suru_auxiliar" as "informix";
grant update on "informix".vaca to "suru_auxiliar" as "informix";
grant insert on "informix".vaca to "suru_auxiliar" as "informix";
grant select on "informix".vaca to "suru_individual" as "informix";
grant update on "informix".vaca to "suru_individual" as "informix";
grant insert on "informix".vaca to "suru_individual" as "informix";
grant delete on "informix".vaca to "suru_individual" as "informix";
grant select on "informix".vaca to "suru_programador" as "informix";
grant alter on "informix".vaca to "suru_programador" as "informix";
grant select on "informix".usuario to "suru_programador" as "informix";
grant alter on "informix".usuario to "suru_programador" as "informix";
grant select on "informix".usuario to "suru_individual" as "informix";
grant update on "informix".usuario to "suru_individual" as "informix";
grant insert on "informix".usuario to "suru_individual" as "informix";
grant delete on "informix".usuario to "suru_individual" as "informix";
grant select on "informix".usuario to "public" as "informix";
grant update on "informix".usuario to "public" as "informix";
grant insert on "informix".usuario to "public" as "informix";
grant delete on "informix".usuario to "public" as "informix";
grant index on "informix".usuario to "public" as "informix";
grant select on "informix".usuario to "suru_general" as "informix";
grant select on "informix".usuario to "suru_auxiliar" as "informix";
grant select on "informix".enfermedad to "suru_general" as "informix";
grant select on "informix".enfermedad to "suru_individual" as "informix";
grant update on "informix".enfermedad to "suru_individual" as "informix";
grant insert on "informix".enfermedad to "suru_individual" as "informix";
grant delete on "informix".enfermedad to "suru_individual" as "informix";
grant select on "informix".enfermedad to "suru_programador" as "informix";
grant alter on "informix".enfermedad to "suru_programador" as "informix";
grant select on "informix".enfermedad to "suru_auxiliar" as "informix";
grant update on "informix".enfermedad to "suru_auxiliar" as "informix";
grant insert on "informix".enfermedad to "suru_auxiliar" as "informix";
grant select on "informix".enfermedad to "public" as "informix";
grant update on "informix".enfermedad to "public" as "informix";
grant insert on "informix".enfermedad to "public" as "informix";
grant delete on "informix".enfermedad to "public" as "informix";
grant index on "informix".enfermedad to "public" as "informix";
grant select on "informix".producen to "suru_programador" as "informix";
grant alter on "informix".producen to "suru_programador" as "informix";
grant select on "informix".producen to "public" as "informix";
grant update on "informix".producen to "public" as "informix";
grant insert on "informix".producen to "public" as "informix";
grant delete on "informix".producen to "public" as "informix";
grant index on "informix".producen to "public" as "informix";
grant select on "informix".producen to "suru_general" as "informix";
grant select on "informix".producen to "suru_auxiliar" as "informix";
grant update on "informix".producen to "suru_auxiliar" as "informix";
grant insert on "informix".producen to "suru_auxiliar" as "informix";
grant select on "informix".producen to "suru_individual" as "informix";
grant update on "informix".producen to "suru_individual" as "informix";
grant insert on "informix".producen to "suru_individual" as "informix";
grant delete on "informix".producen to "suru_individual" as "informix";















revoke usage on language SPL from public ;

grant usage on language SPL to public ;





create unique index "informix".ix114_1 on "informix".campo_recria 
    (id_camporec) using btree ;
alter table "informix".campo_recria add constraint primary key 
    (id_camporec) constraint "informix".pkcampo_recria  ;
create unique index "informix".ix116_1 on "informix".lote (id_lote) 
    using btree ;
alter table "informix".lote add constraint primary key (id_lote) 
    constraint "informix".pklote  ;
create unique index "informix".ix107_1 on "informix".animal (id_animal) 
    using btree ;
alter table "informix".animal add constraint primary key (id_animal) 
    constraint "informix".pkanimal  ;
create unique index "informix".ix100_1 on "informix".cooperativa 
    (id_coop) using btree ;
alter table "informix".cooperativa add constraint primary key 
    (id_coop) constraint "informix".pkcooperativa  ;
create unique index "informix".ix124_1 on "informix".tratamiento 
    (id_tratam) using btree ;
alter table "informix".tratamiento add constraint primary key 
    (id_tratam) constraint "informix".pktratamiento  ;
create unique index "informix".ix120_1 on "informix".estado (id_estado) 
    using btree ;
alter table "informix".estado add constraint primary key (id_estado) 
    constraint "informix".pkestado  ;
create unique index "informix".ix118_1 on "informix".leche (id_leche) 
    using btree ;
alter table "informix".leche add constraint primary key (id_leche) 
    constraint "informix".pkleche  ;
create unique index "informix".ix115_2 on "informix".enfermedad 
    (nombre) using btree ;
create unique index "informix".ix122_1 on "informix".enfermedad 
    (id_enf) using btree ;
alter table "informix".enfermedad add constraint primary key 
    (id_enf) constraint "informix".pkenfermedad  ;
create unique index "informix".ix101_1 on "informix".tambo (id_tambo) 
    using btree ;
alter table "informix".tambo add constraint primary key (id_tambo) 
    constraint "informix".pktambo  ;
create unique index "informix".ix131_3 on "informix".usuario (login) 
    using btree ;
create unique index "informix".ix134_1 on "informix".usuario (id_usuario) 
    using btree ;
alter table "informix".usuario add constraint primary key (id_usuario) 
    constraint "informix".pkusuario  ;



alter table "informix".cria add constraint (foreign key (id_vaca) 
    references "informix".vaca  on delete cascade constraint "informix"
    .fkcria2);
alter table "informix".cria add constraint (foreign key (id_toro) 
    references "informix".toro  on delete cascade constraint "informix"
    .fkcria3);
alter table "informix".usu_rol add constraint (foreign key (id_rol) 
    references "informix".rol  on delete cascade constraint "informix"
    .fkusu_rol2);
alter table "informix".pertenece add constraint (foreign key 
    (id_usuario) references "informix".usuario  on delete cascade 
    constraint "informix".fkpertenece1);
alter table "informix".tel_coop add constraint (foreign key (id_coop) 
    references "informix".cooperativa  on delete cascade constraint 
    "informix".fktel_coop);
alter table "informix".tel_tambo add constraint (foreign key 
    (id_tambo) references "informix".tambo  on delete cascade 
    constraint "informix".fltel_tambo);
alter table "informix".conforma add constraint (foreign key (id_coop) 
    references "informix".cooperativa  on delete cascade constraint 
    "informix".fkconforma1);
alter table "informix".conforma add constraint (foreign key (id_tambo) 
    references "informix".tambo  on delete cascade constraint 
    "informix".fkconforma2);
alter table "informix".pertenece add constraint (foreign key 
    (id_tambo) references "informix".tambo  on delete cascade 
    constraint "informix".fkpertenece2);
alter table "informix".posee add constraint (foreign key (id_animal) 
    references "informix".animal  on delete cascade constraint 
    "informix".fkposee1);
alter table "informix".posee add constraint (foreign key (id_tambo) 
    references "informix".tambo  on delete cascade constraint 
    "informix".fkposee2);
alter table "informix".toro add constraint (foreign key (id_toro) 
    references "informix".animal  on delete cascade constraint 
    "informix".fktoro);
alter table "informix".vaca add constraint (foreign key (id_vaca) 
    references "informix".animal  on delete cascade constraint 
    "informix".fkvaca);
alter table "informix".cria add constraint (foreign key (id_cria) 
    references "informix".animal  on delete cascade constraint 
    "informix".fkcria);
alter table "informix".entora add constraint (foreign key (id_vaca) 
    references "informix".vaca  on delete cascade constraint "informix"
    .fkentora1);
alter table "informix".entora add constraint (foreign key (id_toro) 
    references "informix".toro  on delete cascade constraint "informix"
    .fkentora2);
alter table "informix".van add constraint (foreign key (id_cria) 
    references "informix".cria  on delete cascade constraint "informix"
    .fkvan1);
alter table "informix".van add constraint (foreign key (id_camporec) 
    references "informix".campo_recria  on delete cascade constraint 
    "informix".fkvan2);
alter table "informix".asigna add constraint (foreign key (id_vaca) 
    references "informix".vaca  on delete cascade constraint "informix"
    .fkasigna1);
alter table "informix".asigna add constraint (foreign key (id_lote) 
    references "informix".lote  on delete cascade constraint "informix"
    .fkasigna2);
alter table "informix".producen add constraint (foreign key (id_lote) 
    references "informix".lote  on delete cascade constraint "informix"
    .fkproducen1);
alter table "informix".producen add constraint (foreign key (id_leche) 
    references "informix".leche  on delete cascade constraint 
    "informix".fkproducen2);
alter table "informix".tiene add constraint (foreign key (id_vaca) 
    references "informix".vaca  on delete cascade constraint "informix"
    .fktiene1);
alter table "informix".tiene add constraint (foreign key (id_estado) 
    references "informix".estado  on delete cascade constraint 
    "informix".fktiene2);
alter table "informix".contrae add constraint (foreign key (id_animal) 
    references "informix".animal  on delete cascade constraint 
    "informix".fkcontrae1);
alter table "informix".contrae add constraint (foreign key (id_enf) 
    references "informix".enfermedad  on delete cascade constraint 
    "informix".fkcontrae2);
alter table "informix".requiere add constraint (foreign key (id_animal) 
    references "informix".animal  on delete cascade constraint 
    "informix".fkrequiere1);
alter table "informix".requiere add constraint (foreign key (id_tratam) 
    references "informix".tratamiento  on delete cascade constraint 
    "informix".fkrequiere2);
alter table "informix".usu_rol add constraint (foreign key (id_usuario) 
    references "informix".usuario  on delete cascade constraint 
    "informix".fkusu_rol1);






update statistics high for table animal (
     id_animal) 
     resolution   1.00000 ;
update statistics high for table estado (
     id_estado) 
     resolution   1.00000 ;
update statistics high for table rol (
     id_rol) 
     resolution   1.00000 ;
update statistics high for table usu_rol (
     id_rol) 
     resolution   1.00000 ;

 


