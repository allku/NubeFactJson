USE [BDQualityv]
GO

/****** Object:  View [dbo].[fe_facturadetalle]    Script Date: 06/01/2018 22:32:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






/*and d.Folio = '23374'
and d.Folio = '143330'
order by d.Folio desc*/
ALTER VIEW [dbo].[fe_facturadetalle]
AS
SELECT     d.TipoDocumento, d.Folio numero, t.Item AS codigo_principal, i.Descripcion, 
                      t.Cantidad, t.Precio AS Precio_Uni, '0' AS cod_porc, '0' AS porc_iva, d.Impuesto, t.Precio * t.PorcentajeDR / 100 * - 1 AS Descuento, 
                      t.Precio - t.Precio * t.PorcentajeDR / 100 * - 1 AS Precio_total_sin_imp
FROM         dbo.Documento AS d INNER JOIN
                      dbo.DocumentoDet AS t ON d.Empresa = t.Empresa AND d.TipoDocumento = t.TipoDocumento AND d.Correlativo = t.Correlativo INNER JOIN
                      dbo.Item AS i ON t.Empresa = i.Empresa AND t.Item = i.Item AND t.TipoItem = i.TipoItem
WHERE     (d.Empresa = 'Activefun') 
AND (d.TipoDocumento IN (
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
)) AND (d.Estado = 'S')







GO


