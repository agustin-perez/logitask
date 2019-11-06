/* Fertspa studios - 3°BD - 2019
Data manipulation language
LAS SENTENCIAS SQL MOSTRADAS A CONTINUACION DEBEN SER EJECUTADAS POR EL DBA (DATABASE ADMINISTRATOR).
Dabase version 3.8 FINAL */

/* Inicio DML - Inserts */
    /* Nota: donde hay inserts personalizados, la clave primaria o parte de ella es SERIAL */

    /* Inserts especiales de DBA */
    /* Fin inserts especiales de DBA */

    /* usuario - 12 inserts */
    INSERT INTO usuario VALUES ("sysadmin","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Franco","Dalmaso","F");
    INSERT INTO usuario VALUES ("agusasdfk","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Agustín","Perez","F");
    INSERT INTO usuario VALUES ("fiz1995","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Fernando","Ramirez","F");
    INSERT INTO usuario VALUES ("kim12kim","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Samantha","Vegas","F");
    INSERT INTO usuario VALUES ("polezter","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Julio","Mendez","F");
    INSERT INTO usuario VALUES ("demver33","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Jennifer","Figueroa","F");
    INSERT INTO usuario VALUES ("makdub2000","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Jorge","Serrato","F");    
    INSERT INTO usuario VALUES ("blaspol77","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Hugo","Quimes","F");    
    INSERT INTO usuario VALUES ("charmi1990","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Pedro","Rodriguez","F");    
    INSERT INTO usuario VALUES ("snake97","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Ismael","Dales","F");    
    INSERT INTO usuario VALUES ("victor250801","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Victor","Sosa","F");    
    INSERT INTO usuario VALUES ("futurpepe","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Jose","Mendez","F");    
    INSERT INTO usuario VALUES ("kira1990","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Valentina","Galvan","F");
    INSERT INTO usuario VALUES ("frutito2007","7OYSgGD82gr8Q8LVkQnEEOid4r72AtcO1iwGQP15WXA=","Desmond","Miles","F");

    /* telUser - 12 inserts */
    INSERT INTO telUser VALUES ("fiz1995","098-548-473","F");
    INSERT INTO telUser VALUES ("kim12kim","098-696-247","F");
    INSERT INTO telUser VALUES ("polezter","2-826-9866","F");
    INSERT INTO telUser VALUES ("demver33","098-789-698","F");
    INSERT INTO telUser VALUES ("makdub2000","2-398-8809","F");
    INSERT INTO telUser VALUES ("blaspol77","098-888-598","F");
    INSERT INTO telUser VALUES ("charmi1990","098-777-369","F");
    INSERT INTO telUser VALUES ("snake97","098-253-123","F");
    INSERT INTO telUser VALUES ("victor250801","2-179-8780","F");
    INSERT INTO telUser VALUES ("futurpepe","098-653-187","F");
    INSERT INTO telUser VALUES ("frutito2007","098-777-477","F");
    INSERT INTO telUser VALUES ("kira1990","2-268-2196","F");
    INSERT INTO telUser VALUES ("frutito2007","098-221-824","F");

    /* operario - 6 inserts: 3 puerto - 3 patio */
    INSERT INTO operarios VALUES ("snake97","F", "F");
    INSERT INTO operarios VALUES ("makdub2000","F", "F");
    INSERT INTO operarios VALUES ("demver33","F", "F");
    INSERT INTO operarios VALUES ("polezter","T", "F");
    INSERT INTO operarios VALUES ("kira1990","T", "F");
    INSERT INTO operarios VALUES ("victor250801","T", "F");
    INSERT INTO operarios (username, bajaLogica) VALUES ("sysadmin", "F");
    INSERT INTO operarios (username, bajaLogica) VALUES ("agusasdfk", "F");

    /* transportista - 5 inserts */
    INSERT INTO transportistas VALUES ("fiz1995", "F");
    INSERT INTO transportistas VALUES ("kim12kim", "F");
    INSERT INTO transportistas VALUES ("blaspol77", "F");
    INSERT INTO transportistas VALUES ("charmi1990", "F");
    INSERT INTO transportistas VALUES ("futurpepe", "F");
    INSERT INTO transportistas VALUES ("sysadmin", "F");
    INSERT INTO transportistas VALUES ("agusasdfk", "F");

    /* administrativo - 2 inserts - NOTA PARA FERTSPA: LOS INSERTS DE ESTA TABLA DEBEN ESTAR EN LOS OTROS TIPOS DE USUARIO, DE LO CONTRARIO, 
    SE GENERARA UNA EXCEPCION SYSTEM.DATA.ODBC.ODBCEXCEPTION EN TIEMPO DE EJECUCION, EN EL PROGRAMA. */
    INSERT INTO administrativos VALUES ("sysadmin", "F");
    INSERT INTO administrativos VALUES ("agusasdfk", "F");

    /* vehiculo - 19 inserts */
    INSERT INTO vehiculo VALUES ("JH4DA175XGS009825","Acura","Integra","1986","rojo","A","F");
    INSERT INTO vehiculo VALUES ("WP0CD2A91BS773285","Porsche","911","2011","gris","A","F");
    INSERT INTO vehiculo VALUES ("JH4KA2650HC000268","Acura","Legend","1987","negro","A","F");
    INSERT INTO vehiculo VALUES ("SCFAB22311K301756","Aston Martin","DB7","2001","negro","A","F");
    INSERT INTO vehiculo VALUES ("JT2BG22K3Y0485107","Toyota","Camry","2000","blanco","A","F");
    INSERT INTO vehiculo VALUES ("WBAAM3333XFP59732","BMW","3 Series","1999","violet","A","F");
    INSERT INTO vehiculo VALUES ("1FTRW14W84KC76110","Ford","F 150","2004","pink","A","F");
    INSERT INTO vehiculo VALUES ("1FUPFSEB3YLF03840","Freightliner","Conventional","2000","blanco","C","F");
    INSERT INTO vehiculo VALUES ("JNKCV61E49M014581","Infiniti","G37 Sedan","2009","gris","A","F");
    INSERT INTO vehiculo VALUES ("3VWSE29M82M028637","Volkswagen","Jetta","2002","purple","A","F");
    INSERT INTO vehiculo VALUES ("JH4CC2560RC008414","Acura","Vigor","1994","verde","A","F");
    INSERT INTO vehiculo VALUES ("JF1GH6B60BG810286","Subaru","Impreza","2011","azul","A","F");
    INSERT INTO vehiculo VALUES ("JH4KA4530LC018693","Acura","Legend","1990","gold","A","F");
    INSERT INTO vehiculo VALUES ("1GBJ7D1B4BV132373","Chevrolet","C6500","1981","blanco","C","F");
    INSERT INTO vehiculo VALUES ("JH4DA3440KS029436","Acura","Integra","1989","rojo","A","F");
    INSERT INTO vehiculo VALUES ("1FMZK04185GA30815","Ford","Freestyle","2005","blanco","V","F");
    INSERT INTO vehiculo VALUES ("4S3BK4355T6319316","Subaru","Legacy","1996","silver","A","F");
    INSERT INTO vehiculo VALUES ("WDDHF8JB4DA682581","Mercedes Benz","E","2013","brown","A","F");
    INSERT INTO vehiculo VALUES ("2G1WH55K5Y9322458","Chevrolet","Impala","2000","azul","A","F");

    /* lugar - 2 inserts */
    INSERT INTO lugar (nombre,descripcion,capacidad,bajaLogica) VALUES ("Puerto","Puerto de montevideo",1500,"F");
    INSERT INTO lugar (nombre,descripcion,capacidad,bajaLogica) VALUES ("Patio","Patio zona franca libertad",5000,"F");
    INSERT INTO lugar (nombre,descripcion,capacidad,bajaLogica) VALUES ("P1","Plaza del puerto",200,"F");
    INSERT INTO lugar (nombre,descripcion,capacidad,bajaLogica) VALUES ("A1","Zona de vehículos chinos",200,"F");
    INSERT INTO lugar (nombre,descripcion,capacidad,bajaLogica) VALUES ("B2","Zona de vehículos deportivos",10,"F");


    /* inspeccion - 5 inserts */
    INSERT INTO inspeccion (VIN,username,lugar,fecha,bajaLogica) VALUES ("JH4DA175XGS009825","snake97",1,"2019-10-01 15:34:56.088","F");
    INSERT INTO inspeccion (VIN,username,lugar,fecha,bajaLogica) VALUES ("WP0CD2A91BS773285","snake97",1,"2019-10-02 18:02:19.099","F");
    INSERT INTO inspeccion (VIN,username,lugar,fecha,bajaLogica) VALUES ("JH4KA2650HC000268","victor250801",2,"2019-10-02 10:20:40.068","F");
    INSERT INTO inspeccion (VIN,username,lugar,fecha,bajaLogica) VALUES ("1FMZK04185GA30815","kira1990",2,"2019-10-02 16:20:56.071","F");
    INSERT INTO inspeccion (VIN,username,lugar,fecha,bajaLogica) VALUES ("JT2BG22K3Y0485107","polezter",2,"2019-10-03 14:53:00.098","F");

    /* damage - 5 inserts */
    INSERT INTO damage (numeroInspec,VIN,imagen,descripcion, bajaLogica) VALUES (1,"JH4DA175XGS009825",null,"Parachoques traseros destrozados","F");
    INSERT INTO damage (numeroInspec,VIN,imagen,descripcion, bajaLogica) VALUES (2,"WP0CD2A91BS773285",null,"Abolladura ligera en el capó","F");
    INSERT INTO damage (numeroInspec,VIN,imagen,descripcion, bajaLogica) VALUES (3,"JH4KA2650HC000268",null,"Abolladura profunda en la puerta derecha delantera","F");
    INSERT INTO damage (numeroInspec,VIN,imagen,descripcion, bajaLogica) VALUES (4,"1FMZK04185GA30815",null,"Vidrio de la puerta derecha delantera rota","F");
    INSERT INTO damage (numeroInspec,VIN,imagen,descripcion, bajaLogica) VALUES (5,"JT2BG22K3Y0485107",null,"Retrovisor derecho destruido completamente","F");

    /* subLugar - 8 inserts */
    INSERT INTO subLugar VALUES (4, 2, 'F');
    INSERT INTO subLugar VALUES (5, 2, 'F');
    INSERT INTO subLugar VALUES (3, 1, 'F');

    /* lote - 5 inserts */
    INSERT INTO lote (username,nombre,descripcion,llegadaestimada,bajaLogica) VALUES ("snake97","Des","Lote creado...",current,"F");
    INSERT INTO lote (username,nombre,descripcion,llegadaestimada,bajaLogica) VALUES ("makdub2000","Vil","Lote creado...",current,"F");
    INSERT INTO lote (username,nombre,descripcion,llegadaestimada,bajaLogica) VALUES ("demver33","Mes","Lote creado...",current,"F");
    INSERT INTO lote (username,nombre,descripcion,llegadaestimada,bajaLogica) VALUES ("makdub2000","Pez","Lote creado...",current,"F");
    INSERT INTO lote (username,nombre,descripcion,llegadaestimada,bajaLogica) VALUES ("demver33","Xep","Lote creado...",current,"F");

    /* mediosTransporte - 5 inserts */
    INSERT INTO mediosTransporte VALUES (1550,"SHI-0065",20,"F");
    INSERT INTO mediosTransporte VALUES (1687,"ASA-4671",20,"F");
    INSERT INTO mediosTransporte VALUES (1777,"MSA-7788",20,"F");
    INSERT INTO mediosTransporte VALUES (2085,"SOA-9810",20,"F");
    INSERT INTO mediosTransporte VALUES (1193,"SHI-6719",20,"F");

    /* embarque - 5 inserts */
    INSERT INTO embarque (IDLote,numeroCoche,username,ubicacion,bajaLogica) VALUES (1,1550,"fiz1995","-34,912559: -56,190106","F");
    INSERT INTO embarque (IDLote,numeroCoche,username,ubicacion,bajaLogica) VALUES (2,1550,"kim12kim","-34,912709: -56,190321","F");
    INSERT INTO embarque (IDLote,numeroCoche,username,ubicacion,bajaLogica) VALUES (3,1687,"blaspol77","-34,912727: -56,190686","F");
    INSERT INTO embarque (IDLote,numeroCoche,username,ubicacion,bajaLogica) VALUES (4,1687,"charmi1990","-34,912745: -56,191319","F");
    INSERT INTO embarque (IDLote,numeroCoche,username,ubicacion,bajaLogica) VALUES (5,1550,"futurpepe","-34,913167: -56,191115","F");

    /* subLugarVehiculo - 5 inserts */
    INSERT INTO subLugarVehiculo VALUES ("WBAAM3333XFP59732",4, "polezter", current, 'F');
    INSERT INTO subLugarVehiculo VALUES ("1FUPFSEB3YLF03840",5, "sysadmin", current, 'F');
    INSERT INTO subLugarVehiculo VALUES ("WDDHF8JB4DA682581",4, "polezter", current, 'F');
    INSERT INTO subLugarVehiculo VALUES ("SCFAB22311K301756",3, "kira1990", current, 'F');
    INSERT INTO subLugarVehiculo VALUES ("2G1WH55K5Y9322458",5, "victor250801", current, 'F');

    /* vehiculosEnLote - 5 inserts */
    INSERT INTO vehiculosEnLote VALUES ("JH4DA175XGS009825",1,"F");
    INSERT INTO vehiculosEnLote VALUES ("WP0CD2A91BS773285",4,"F");
    INSERT INTO vehiculosEnLote VALUES ("JH4KA2650HC000268",4,"F");
    INSERT INTO vehiculosEnLote VALUES ("SCFAB22311K301756",4,"F");
    INSERT INTO vehiculosEnLote VALUES ("JT2BG22K3Y0485107",5,"F");

    /* lugarPartidaEmbarque - 5 inserts */
    INSERT INTO lugarPartidaEmbarque VALUES (1,1,"2019-10-01 15:58:12.089", 'F');
    INSERT INTO lugarPartidaEmbarque VALUES (1,2,"2019-10-01 14:24:01.067", 'F');
    INSERT INTO lugarPartidaEmbarque VALUES (1,3,"2019-10-01 14:58:30.031", 'F');
    INSERT INTO lugarPartidaEmbarque VALUES (1,4,"2019-10-02 15:44:31.087", 'F');
    INSERT INTO lugarPartidaEmbarque VALUES (1,5,"2019-10-03 16:36:45.000", 'F');

    /* lugarDestinoEmbarque -5 inserts */
    INSERT INTO lugarDestinoEmbarque VALUES (2,1,"2019-10-01 16:31:34.007", 'F');
    INSERT INTO lugarDestinoEmbarque VALUES (2,2,"2019-10-01 14:48:12.098", 'F');
    INSERT INTO lugarDestinoEmbarque VALUES (2,3,"2019-10-01 15:30:34.067", 'F');
    INSERT INTO lugarDestinoEmbarque VALUES (2,4,"2019-10-02 16:02:21.009", 'F');
    INSERT INTO lugarDestinoEmbarque VALUES (2,5,"2019-10-03 16:58:02.045", 'F');
/* Fin del DML */