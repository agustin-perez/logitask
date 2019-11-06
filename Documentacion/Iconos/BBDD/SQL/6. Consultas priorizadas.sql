/* Fertspa studios - 3°BD - 2019
Consultas priorizadas por el docente
Dabase version 3.8 FINAL */

/* Inicio DML */

1.select fechallegada, lugar.descripcion, sublugarvehiculo.vin, marca,modelo,color from(select max(fechaMovimiento) as fechallegada, sublugarvehiculo.vin, vehiculo.marca,modelo,color from vehiculo inner join sublugarvehiculo on sublugarvehiculo.vin=vehiculo.vin
inner join sublugar on sublugar.idsub=sublugarvehiculo.idsub group by sublugarvehiculo.vin, vehiculo.marca,modelo,color) as sub inner join sublugarvehiculo on sub.vin=sublugarvehiculo.vin and sublugarvehiculo.fechaMovimiento = sub.fechallegada
inner join sublugar on sublugar.idsub=sublugarvehiculo.idsub inner join lugar on lugar.idlugar=sublugar.idlugar order by current, lugar.nombre;
2. select vehiculo.marca , count(vehiculo.vin) from sublugarvehiculo inner join sublugar on sublugarvehiculo.idsub=sublugar.idsub inner join vehiculo on vehiculo.vin=sublugarvehiculo.vin where idlugar=1 group by vehiculo.marca;
3. select sublugarvehiculo.vin, sublugar.idlugar,lugar.descripcion , (current - fechaMovimiento) from sublugarvehiculo inner join sublugar on sublugar.idsub=sublugarvehiculo.idsub inner join lugar on sublugar.idlugar = lugar.idlugar where sublugarvehiculo.bajalogica='f' and vin="WBAAM3333XFP59732";
4. select embarque.username, embarque.idembarque, llegadaestimada from embarque inner join lote on lote.idlote = embarque.idlote left join lugardestinoembarque on embarque.idembarque = lugardestinoembarque.idembarque where lugardestinoembarque.llegada is null;
6. select lugar.descripcion, count(numeroinspec) as numero_de_danios from inspeccion inner join lugar on idlugar=lugar where YEAR(fecha)=YEAR(current) group by lugar.descripcion
7. select vin, numeroinspec, fecha, lugar, username from inspeccion where vin = "JH4DA175XGS009825" order by vin, numeroinspec;
8. select damage.vin, numeroinspec, marca, modelo, color, descripcion, imagen from damage, vehiculo where vehiculo.vin = damage.vin;
10. select count(vin) from vehiculo, inspeccion where vin not in inspeccion.vin;
13. select count(vin) from vehiculo where vin not in (select vin from inspeccion); 
14. select first 10 vehiculo.vin, marca, modelo, count(numeroinspec) as numeroDanios from vehiculo left join inspeccion on vehiculo.vin=inspeccion.vin group by vehiculo.vin, marca, modelo order by count(numeroinspec) desc
  
/* Fin del DML */