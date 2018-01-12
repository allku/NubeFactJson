USE [BDQualityv]
GO

/****** Object:  View [dbo].[fe_facturamaestro]    Script Date: 07/01/2018 21:48:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER view [dbo].[fe_facturamaestro]
as
select d.Folio as numero,
d.TipoDocumento AS tipo_documento,d.folio AS Nosecuencial,d.Fecha,0.00 as Total_sin_Iva,
d.Afecto as Total_con_Iva,d.Impuesto as Iva,ROUND((t.Cantidad * t.Precio)-(t.Cantidad * (t.Precio-(((t.Precio * PorcentajeDR )/100)*-1))), 2) as Descuento,
d.Total,d.Estado, 
CASE WHEN len(e.CodLegal) = 13 THEN '04' 
     WHEN (len(e.CodLegal) = 10 and ISNUMERIC(e.CodLegal) = 1) THEN '05' 
     WHEN (e.CodLegal) = '9999999999999' THEN '07' ELSE '06' END as Codigo_Cli,
e.CodLegal as Documento_cli,REPLACE(e.RazonSocial,',',' ') as razonSocial,e.Direccion,e.Fono,e.eMail,
'' as Guia_Remision
FROM Documento d inner join DocumentoDet t on d.Empresa = t.Empresa and d.TipoDocumento = t.TipoDocumento 
and d.Correlativo = t.Correlativo inner join Entidad e on d.Empresa = e.Empresa and d.TipoEntidad = e.TipoEntidad 
and d.Entidad = e.Entidad 
where d.empresa = 'Activefun' 
and e.TipoEntidad='CLIENTE'
and d.TipoDocumento in (
'FACTURA PTO VENTA 1',
'FACTURA PTO VENTA 2',
'FACTURA PTO VENTA 3',
'FACTURA PTO VENTA 4',
'FACTURA PTO VENTA 5',
'FACTURA PTO VENTA 6',
'FACTURA PTO VENTA 7',
'FACTURA CUMPLEANOS',
'FACTURA PTO CAFET',
'FACTURA PTO SHOP',

'BOLETA PTO VENTA 1',
'BOLETA PTO VENTA 2',
'BOLETA PTO VENTA 3',
'BOLETA PTO VENTA 4',
'BOLETA PTO VENTA 5',
'BOLETA PTO VENTA 6',
'BOLETA PTO VENTA 7',
'BOLETA CUMPLEAÑOS',
'BOLETA PTO CAFET',
'BOLETA PTO SHOP'
) 
and d.Estado = 'S'



GO

