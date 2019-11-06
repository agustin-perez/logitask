/* Fertspa studios - 3°BD - 2019
Stored Procedure Language
Dabase version 3.8 FINAL */

/* Inicio procedimientos almacenados */
	/* Procedimiento login */
	CREATE PROCEDURE consultalogin(user varchar(16), passwd varchar(45))
		RETURNING boolean AS resultado
		DEFINE queryuser varchar(16);
		select usuario into queryuser from loginview where usuario = user AND pass = passwd;
		IF (queryuser = user) THEN
			RETURN 'T';
		ELSE
			RETURN 'F';
		END IF
	END PROCEDURE;
	/* Fin de procedimiento */
	
	/* Procedimiento consultaoperariotipo */
	CREATE PROCEDURE consultaoperariotipo(operario varchar(16)) 
		RETURNING boolean AS resultado
		DEFINE resultado boolean;
		select tipo into resultado from operarios where username = operario;
		RETURN resultado;
	END PROCEDURE;
	/* Fin de procedimiento */
	
	/* Procedimiento cambiarpass */
	CREATE PROCEDURE cambiarpass(userpass varchar(16), oldpass varchar(45), newpass varchar(45))
		RETURNING boolean AS resultado
		DEFINE userstored varchar(16);
		DEFINE passcheck varchar(45);
		DEFINE newpasscheck varchar(45);
		select username into userstored from usuario where username = userpass;
		select pass into passcheck from usuario where username = userstored; 
		IF (passcheck = oldpass) THEN
			update usuario set pass = newpass where username = userstored;
			select pass into newpasscheck from usuario where username = userstored; 
			IF (newpasscheck = newpass) THEN
				RETURN 'T';
			END IF
		END IF 
		RETURN 'F';
	END PROCEDURE; 
	/* Fin de procedimiento */

	CREATE PROCEDURE lugarporid(id integer)
		RETURNING varchar(64) AS resultado
		DEFINE resultado varchar(64);
		select nombre into resultado from lugar where idlugar = id and bajalogica = 'F';
		RETURN resultado;
    END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE verificarvehiculo(vinAConsultar varchar(17))
		RETURNING boolean as resultado
		DEFINE vinConsultado varchar(17);
		select vin into vinConsultado from vehiculo where vin = vinAConsultar;
		IF (vinConsultado = vinAConsultar) THEN
				RETURN 'T';
		END IF
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE obtenerultimainspeccion()
		RETURNING integer AS resultado
		DEFINE resultado integer;
		select max(numeroInspec) into resultado from inspeccion;
		RETURN resultado;
    END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE obtenerultimolote() 
		RETURNING integer AS resultado
		DEFINE resultado integer;
		select max(idlote) into resultado from lote;
		RETURN resultado;
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE checkvehiculolote(vininput varchar(17))
		RETURNING boolean AS resultado
		DEFINE resultado boolean;
		DEFINE vininspec integer;
		DEFINE vinlote integer;
		select count(*) into vininspec from inspeccion where vin = vininput;
		select count(*) into vinlote from vehiculosenlote where vin = vininput;
		IF vininspec > 0 AND vinlote = 0 THEN
			RETURN 'T';
		END IF
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE cantidadvehiculosmaxlote()
		RETURNING integer AS resultado
		DEFINE resultado integer;
		select max(capacidad) into resultado from mediostransporte where bajalogica = 'F';
		RETURN resultado;
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE cantidadvehiculosporlote(id integer)
		RETURNING integer AS resultado
		DEFINE resultado integer;
		select count(*) into resultado from vehiculosenlote where idlote = id;
		RETURN resultado;
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE verificarrol(user varchar(16))
		RETURNING smallint AS resultado
		DEFINE userverificado varchar(16);
		DEFINE puerto varchar(16);
		DEFINE patio varchar(16);
		DEFINE transportista varchar(16);
		DEFINE admins varchar(16);
		select username into userverificado from usuario where username = user;
		IF userverificado = user THEN
			select username into admins from administrativos where username = user;
			select username into puerto from operarios where username = user and tipo = 'F';
			select username into patio from operarios where username = user and tipo = 'T';
			select username into transportista from transportistas where username = user;
			IF user = admins THEN 
				RETURN 0; 
			END IF 
			IF user = puerto THEN 
				RETURN 1;
			END IF 
			IF user = patio THEN 
				RETURN 2;
			END IF 
			IF user = transportista THEN 
				RETURN 3; 
			END IF 
			RETURN -1;
		END IF
		RETURN -1;
	END PROCEDURE;
	/* Fin de procedimiento */
			
	CREATE PROCEDURE eliminarvehiculo(vehiculo varchar(17))
		RETURNING boolean as resultado
		DEFINE consultavin varchar(17);
		update vehiculo set bajalogica = 'T' where vin = vehiculo;
		select vin into consultavin from vehiculo where vin = vehiculo and bajalogica = 'T';
		IF consultavin = vehiculo THEN
			RETURN 'T';
		END IF 
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE actualizarcoordenadas(coord varchar(64), embarque integer)
		update embarque set ubicacion = coord where idembarque = embarque;
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE updatevehiculo(vehiculo varchar(17), marcaedit varchar(64), modeloedit varchar(64), releaseedit datetime year to year, coloredit varchar (32), tipoedit char)
		RETURNING boolean AS resultado
		DEFINE newmarca varchar(64);
		DEFINE newmodelo varchar(64);
		DEFINE newrelease datetime year to year;
		DEFINE newcolor varchar(32);
		DEFINE newtipo char;
		update vehiculo set marca = marcaedit, modelo = modeloedit, release = releaseedit, color = coloredit, tipo = tipoedit where vin = vehiculo;
		select marca into newmarca from vehiculo where vin = vehiculo;
		select modelo into newmodelo from vehiculo where vin = vehiculo;
		select release into newrelease from vehiculo where vin = vehiculo;
		select color into newcolor from vehiculo where vin = vehiculo;
		select tipo into newtipo from vehiculo where vin = vehiculo;
		IF marcaedit = newmarca AND modeloedit = newmodelo AND releaseedit = newrelease AND coloredit = newcolor AND tipoedit = newtipo THEN
			RETURN 'T';
		END IF 
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE obtenerultimoembarque()
		RETURNING integer AS resultado
		DEFINE resultado integer;
		select max(idembarque) into resultado from embarque;
		RETURN resultado;
    END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE flujoesperapuerto(vinbuscado varchar(17))
		RETURNING boolean AS resultado
		DEFINE resultado boolean;
		DEFINE vinresultado integer;
		select count(vin) into vinresultado from inspeccion where vin = vinbuscado; 
		IF vinresultado > 0 THEN
			RETURN 'T';
		END IF
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE flujopartir(vin varchar(17))
		RETURNING boolean AS resultado
		DEFINE resultado smallint;
		select count(idembarque) into resultado from embarque where idlote in (select idlote from vehiculosenlote where vin = "1FMZK04185GA30815");
		IF resultado > 0 THEN
			RETURN 'T';
		END IF 
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE flujoesperapatio(vin varchar(17))
		RETURNING boolean AS resultado
		DEFINE resultadomax smallint;
		DEFINE conteoresultado smallint;
		select max(idembarque) into resultadomax from embarque where idlote in (select idlote from vehiculosenlote where vin = "1FMZK04185GA30815");
		select count(idlugar) into conteoresultado from lugardestinoembarque where idembarque = resultadomax;
		IF conteoresultado > 0 THEN
			RETURN 'T';
		END IF 
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */

	CREATE PROCEDURE flujosubzona(vinbusqueda varchar(17))
		RETURNING boolean AS resultado
		DEFINE resultadocount smallint;
		select count(*) into resultadocount from sublugarvehiculo where vin = vinbusqueda;
		IF resultadocount > 0 THEN
			RETURN 'T';
		END IF
		RETURN 'F';
	END PROCEDURE;
	/* Fin de procedimiento */






	/* Procedimiento obtenerinspeccion


	
	/* Procedimiento restorepass */
	/*CREATE PROCEDURE restorepass(username varchar(16), newpass varchar(45))
		RETURNING boolean as resultado

	END PROCEDURE; TERMINARRRRRRRRRRR*/
	/* Fin procedimiento restorepass */
	
/* Fin procedimientos almacenados */