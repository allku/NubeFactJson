USE [BDQualityV]
GO

/****** Object:  View [dbo].[v_peru_facturas]    Script Date: 13/5/2018 23:10:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO














CREATE VIEW [dbo].[v_peru_facturas]
AS
SELECT   case when SUBSTRING(dbo.FUN_PUNTO(f.tipo_documento), 1, 1) = 'F' then '1' else '2' end as tipo_comprobante,
		   f.tipo_documento as tipo,
		   dbo.FUN_PUNTO(f.tipo_documento) as serie,
           f.numero as numero,
		   case when rtrim(ltrim(f.razonSocial)) = 'CONSUMIDOR FINAL' then
			'7'
		   else 
		   '1' end
		   as tipo_documento_cliente,
           f.DOCUMENTO_CLI AS numero_documento,       
           ltrim(f.razonSocial) AS denominacion,
           f.Direccion AS direccion,
		   replace(lower(CASE WHEN f.email LIKE '[a-z,0-9,_,-]%@[a-z,0-9,_,-]%.[a-z][a-z]%'
  THEN f.email
  ELSE null 
  END),' ','')  as email,
           CAST(ROUND(f.Total_con_Iva, 2) AS decimal(18, 2)) AS total_gravada,
		   CAST(ROUND(f.descuento, 2) AS decimal(18, 2)) as descuento,
           CAST(ROUND(((f.Total_con_Iva*18)/100), 2) AS decimal(18, 2)) AS total_igv,
           CAST(ROUND(f.Total_con_Iva+((f.Total_con_Iva*18)/100), 2) AS decimal(18, 2)) AS total,
           f.fecha

  FROM         dbo.fe_facturamaestro1 f
  where f.numero > 0
  and f.DOCUMENTO_CLI <> ''
  --and SUBSTRING(dbo.FUN_PUNTO(f.tipo_documento), 1, 1) <> 'F'
--  and  dbo.FUN_PUNTO(f.tipo_documento)  = 'F001'
--  and numero = 6




GO


