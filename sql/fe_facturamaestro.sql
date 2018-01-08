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
'FAC PTO VTA 1',
'FAC PTO VTA 2',
'FAC PTO VTA 3',
'FAC PTO VTA 4',
'FAC PTO VTA 5',
'FAC PTO CAFET',
'FAC PTO CAFET 2',
'FAC PTO SHOP',
'FAC CUMPLEAÑOS',
'FAC VTA SALIDA',
'FACTURA EXPORTACION'
) 
and d.Estado = 'S'



GO

