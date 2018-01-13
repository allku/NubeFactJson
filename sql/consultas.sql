select * from v_peru_facturas
where fecha = '05-01-2018';

select * from v_peru_facturas_detalle
where concat(serie,numero) in (select concat(serie,numero) from v_peru_facturas
where fecha = '05-01-2018');