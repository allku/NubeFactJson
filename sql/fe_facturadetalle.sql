USE [BDQualityv]
GO

/****** Object:  View [dbo].[fe_facturadetalle]    Script Date: 07/01/2018 21:48:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


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
)) AND (d.Estado = 'S')
GO





