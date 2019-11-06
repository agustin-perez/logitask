/* Fertspa studios - 3°BD - 2019
Data Control Language
Dabase version 3.8 FINAL */

/* Inicio de DCL */
	/* Database Administrators */
	grant dba to aperez, gacquistapace;
	/* Fin Database Administrators */

	/* Inicio roles */
	create role administrativo;
	create role operario;
	create role transportista;

	grant connect to fdalmaso;
	grant connect to imendez;
	grant connect to aperez;
	grant default role administrativo to fdalmaso;
	grant default role operario to imendez;
	grant default role transportista to jsullcaray;
	/* Fin de roles */

	/* Inicio de permisos por rol */
		/* Permisos especiales: bajalogica y pass*/
		grant update (bajalogica) on usuario to administrativo; 
		grant update (bajalogica) on teluser to administrativo;
		grant update (bajalogica) on inspeccion to operario; /* Considerar que en el programa se va a resolver el rol, dicho permiso es solo para patio */
		grant update (bajalogica) on inspeccion to administrativo, operario; 
		grant update (bajalogica) on lote to operario; 
		grant update (bajalogica) on vehiculosenlote to operario; 
		grant update (bajalogica) on mediostransporte to administrativo; 
		grant update (pass) on usuario to administrativo, operario, transportista; 
		/* Fin de permisos especiales */

		/* Inicio de selects */
		grant select on usuario to administrativo, operario, transportista;
		grant select on teluser to administrativo, operario, transportista; 
		grant select on operarios to administrativo, operario; 
		grant select on transportistas to administrativo, transportista; 
		grant select on administrativos to administrativo; 
		grant select on vehiculo to administrativo, operario, transportista; 
		grant select on lugar to administrativo, operario, transportista;
		grant select on sublugar to administrativo, operario, transportista;
		grant select on sublugarvehiculo to administrativo, operario, transportista; 
		grant select on inspeccion to administrativo, operario, transportista;
		grant select on damage to administrativo, operario, transportista; 
		grant select on lote to administrativo, operario, transportista; 
		grant select on vehiculosenlote to administrativo, operario, transportista; 
		grant select on mediostransporte to administrativo, operario, transportista;
		grant select on embarque to administrativo, operario, transportista; 
		grant select on lugarpartidaembarque to administrativo, operario, transportista; 
		grant select on lugardestinoembarque to administrativo, operario, transportista;
		grant select on loginview to administrativo, operario, transportista;
		/* Fin de selects */
	
		/* Inicio de inserts */
		grant insert on teluser to administrativo, operario, transportista;
		grant insert on operarios to administrativo; 
		grant insert on transportistas to administrativo;
		grant insert on vehiculo to administrativo, operario;
		grant insert on lugar to administrativo; 
		grant insert on sublugar to administrativo; 
		grant insert on sublugarvehiculo to administrativo, operario;
		grant insert on inspeccion to administrativo, operario; 
		grant insert on damage to administrativo, operario; 
		grant insert on lote to administrativo, operario; 
		grant insert on vehiculosenlote to administrativo, operario; 
		grant insert on mediostransporte to administrativo;
		grant insert on embarque to administrativo, transportista; 
		grant insert on lugarpartidaembarque to administrativo, transportista; 
		grant insert on lugardestinoembarque to administrativo, transportista; 
		/* Fin de inserts */
		
		/* Inicio de updates */
		grant update (tel) on teluser to administrativo;
		grant update on operarios to administrativo; 
		grant update on transportistas to administrativo;
		grant update on vehiculo to administrativo;
		grant update on lugar to administrativo; 
		grant update on sublugar to administrativo; 
		grant update on sublugarvehiculo to administrativo; 
		grant update on inspeccion to administrativo; 
		grant update on damage to administrativo; 
		grant update on lote to administrativo; 
		grant update on vehiculosenlote to administrativo; 
		grant update on mediostransporte to administrativo; 
		grant update on embarque to administrativo; 
		/* Fin de updates */
	/* Fin de permisos por rol */
/* Fin de DCL */