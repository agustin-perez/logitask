/* Fertspa studios - 3°BD - 2019
Vistas sobre la BD
Dabase version 3.8 FINAL */

/* Inicio de vistas */
    /* Inicio loginView */
    create view loginview (usuario, pass) as select username, pass from usuario;
    /* Fin de vista */

    /* Inicio listadovehiculos */
    create view listadovehiculos(vin, marca, modelo, release, color, tipo) as select vin, marca, modelo, release, color, tipo from vehiculo where bajalogica = 'F';
    /* Fin de vista */

    /* Inicio listadolugares */
    create view listadolugares(idlugar, nombre, descripcion, capacidad) as select idlugar, nombre, descripcion, capacidad from lugar where bajalogica = 'F';
    /* Fin de vista */

    /* Inicio listadolugaresprincipales */
    create view listadolugaresprincipales(idlugar, nombre, descripcion, capacidad) as select idlugar, nombre, descripcion, capacidad from lugar where bajalogica = 'F' and idlugar not in (select idsub from sublugar);
    /* Fin de vista */
/* Fin de vistas */

