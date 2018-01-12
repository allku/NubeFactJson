USE [BDQualityv]
GO

/****** Object:  View [dbo].[v_peru_facturas]    Script Date: 07/01/2018 21:49:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



alter VIEW [dbo].[v_peru_facturas]
AS
SELECT   '1' as tipo_comprobante,
		   f.tipo_documento as tipo,
		   dbo.FUN_PUNTO(f.tipo_documento) as serie,
           f.numero as numero,
           f.DOCUMENTO_CLI AS numero_documento,       
           ltrim(f.razonSocial) AS denominacion,
           f.Direccion AS direccion,
		   /*f.email*/ '' as email,
           CAST(ROUND(f.Total_con_Iva, 2) AS decimal(18, 2)) AS total_gravada,
           CAST(ROUND(((f.Total_con_Iva*18)/100), 2) AS decimal(18, 2)) AS total_igv,
           CAST(ROUND(f.Total_con_Iva+((f.Total_con_Iva*18)/100), 2) AS decimal(18, 2)) AS total,
           CONVERT(VARCHAR(10), f.fecha, 105) AS fecha

  FROM         dbo.fe_facturamaestro1 f
  where f.numero > 0
  and f.DOCUMENTO_CLI <> ''
--  and  dbo.FUN_PUNTO(f.tipo_documento)  = 'F001'
--  and numero = 6

GO


