/* Fertspa studios - 3°BD - 2019
Modelo físico
Dabase version 3.8 FINAL */

/* Inicio de DDL */
    /* Inicio tabla "usuario" */
    create table usuario(
    username varchar (16),
    pass varchar (45),
    nombre varchar (64),
    apellido varchar (64),
    bajalogica boolean default 'F' not null,
    primary key (username) constraint cp_usuario
    );
    /* Fin tabla "usuario" */   

    /* Inicio tabla "telUser" */  
    create table teluser(
    username varchar (16),
    tel varchar (11),
    bajalogica boolean default 'F' not null, 
    primary key (username, tel) constraint cp_telUser
    );
    /* Fin tabla "telUser" */

    /* Inicio tabla "operarios" */
    create table operarios(
    username varchar (16),
    tipo boolean,
    bajalogica boolean default 'F' not null, 
    primary key (username) constraint cp_operario,
    foreign key (username) references usuario constraint ce_operario
    );
    /* Fin tabla "operario" */

    /* Inicio tabla "transportistas" */
    create table transportistas(
    username varchar (16),
    bajalogica boolean default 'F' not null,
    primary key (username) constraint cp_transportista,
    foreign key (username)  references usuario constraint ce_transportista
    );
    /* Fin tabla "transportista" */

    /* Inicio tabla "administrativos" */
    create table administrativos(
    username varchar (16),
    bajalogica boolean default 'F' not null,
    primary key (username) constraint cp_administrativo,
    foreign key (username) references usuario constraint ce_administrativo
    );
    /* Fin tabla "administrativo" */

    /* Inicio tabla "vehiculo" */
    create table vehiculo(
    vin varchar (17),
    marca varchar (64), 
    modelo varchar (64),
    release datetime year to year,
    color varchar (32),
    tipo char,
    bajalogica boolean default 'F' not null,
    check (tipo in ("A", "C", "S", "V", "M")),
    primary key (vin) constraint cp_vehiculo
    );
    /* Fin tabla "vehiculo" */

    /* Inicio tabla "lugar" */
    create table lugar(
    idlugar serial,
    nombre varchar (64),
    descripcion lvarchar(30000),
    capacidad smallint,
    bajalogica boolean default 'F' not null,
    primary key (idlugar) constraint cp_lugar
    );
    /* Fin tabla "lugar" */

    /* Inicio tabla "subLugar" */
    create table sublugar(
    idsub integer,
    idlugar integer not null,
    bajalogica boolean default 'F' not null,
    primary key (idsub) constraint cp_sublugar,
    foreign key (idsub) references lugar (idlugar) constraint ce_lugarPadre,
    foreign key (idlugar) references lugar constraint ce_lugarHijo
    );
    /* Fin tabla "subLugar" */

    /* Inicio tabla "subLugarVehiculo" */
    create table sublugarvehiculo(
    vin varchar (17), 
    idsub integer,
    username varchar (16),
    fechaMovimiento datetime year to fraction,
    bajalogica boolean default 'F' not null,
    primary key (vin, idsub) constraint cp_subLugarVehiculo,
    foreign key (vin) references vehiculo constraint ce_vehiculoSub,
    foreign key (idsub) references subLugar constraint ce_subLugarVehiculo,
    foreign key (username) references operarios constraint ce_responsableSLV
    );
    /* Fin tabla "subLugarVehiculo" */

    /* Inicio tabla "inspeccion" */
    create table inspeccion(
    numeroinspec serial,
    vin varchar (17),
    username varchar (16),
    lugar integer,
    fecha datetime year to fraction,
    bajalogica boolean default 'F' not null,
    primary key (numeroinspec, vin) constraint cp_inspeccion,
    foreign key (vin) references vehiculo constraint ce_vinInspec,
    foreign key (username) references operarios constraint ce_userInspec,
    foreign key (lugar) references lugar (idlugar) constraint ce_lugarInspec
    );
    /* Fin tabla "inspeccion" */

    /* Inicio tabla "damage" */
    create table damage(
    numerodamage serial,
    numeroinspec integer,
    vin varchar (17),
    imagen byte,
    descripcion lvarchar (30000),
    bajalogica boolean default 'F' not null,
    primary key (numerodamage, numeroinspec, vin) constraint cp_damage,
    foreign key (numeroinspec, vin) references inspeccion constraint ce_inspecDamage,
    foreign key (vin) references vehiculo constraint ce_vinDamage
    );
    /* Fin tabla "damage" */

    /* Inicio tabla "lote" */
    create table lote(
    idlote serial,
    username varchar (16),
    nombre varchar (64),
    descripcion lvarchar (30000),
    llegadaestimada datetime year to minute,
    bajalogica boolean default 'F' not null,
    primary key (idlote) constraint cp_lote,
    foreign key (username) references operarios constraint ce_userLote
    );
    /* Fin tabla "lote" */

    /* Inicio tabla "vehiculosEnLote" */
    create table vehiculosenlote(
    vin varchar (17),
    idlote integer,
    bajalogica boolean default 'F' not null,
    primary key (vin) constraint cp_vEnLote,
    foreign key (vin) references vehiculo constraint ce_vEnLote,
    foreign key (idlote) references lote constraint ce_loteVehicEnLote
    );
    /* Fin tabla "vehiculosEnLote" */

    /* Inicio tabla "mediosTransporte" */
    create table mediostransporte(
    numerocoche smallint,
    matricula varchar (8),
    capacidad smallint not null, 
    bajalogica boolean default 'F' not null,
    Primary key (numerocoche) constraint cp_cocheTransporte
    );
    /* Fin tabla "mediosTransporte" */

    /* Inicio tabla "embarque" */
    create table embarque(
    idembarque serial,
    idlote integer,
    numerocoche smallint,
    username varchar (16),
    ubicacion varchar (64),
    bajalogica boolean default 'F' not null,
    primary key (idembarque) constraint cp_embarque,
    foreign key (idlote) references lote constraint ce_loteEmbarque,
    foreign key (numerocoche) references mediosTransporte constraint ce_cocheEmbarque,
    foreign key (username) references transportistas constraint ce_userEmbarque
    );
    /* Fin tabla "embarque" */

    /* Inicio tabla "lugarPartidaEmbarque */
    create table lugarpartidaembarque(
    idlugar integer,
    idembarque integer,
    partida datetime year to fraction,
    bajalogica boolean default 'F' not null,
    primary key (idlugar, idembarque) constraint cp_lugarPartida,
    foreign key (idlugar) references lugar constraint ce_lugarLugarPartida,
    foreign key (idembarque) references embarque constraint ce_embarqueLugarPartida
    );
    /* Fin tabla "lugarPartidaEmbarque" */

    /* Inicio tabla "lugarDestinoEmbarque" */
    create table lugardestinoembarque(
    idlugar integer,
    idembarque integer,
    llegada datetime year to fraction,
    bajalogica boolean default 'F' not null,
    primary key (idlugar, idembarque) constraint cp_destinoEmbarque,
    foreign key (idlugar) references lugar constraint ce_lugarDestinoEmbarque,
    foreign key (idembarque) references embarque constraint ce_embarqueDestinoEmbarques
    );
    /* Fin tabla "lugarDestinoEmbarque" */
/* Fin del DDL */





