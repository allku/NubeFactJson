USE [BDQualityV]
GO

/****** Object:  View [dbo].[v_peru_facturas_reporte]    Script Date: 13/5/2018 23:10:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





/****** Script for SelectTopNRows command from SSMS  ******/
CREATE VIEW [dbo].[v_peru_facturas_reporte]
AS
SELECT f.tipo_comprobante
      ,f.tipo
      ,f.serie
      ,f.numero
      ,f.numero_documento
      ,f.denominacion
      ,f.total_gravada
      ,f.total_igv
      ,f.total
      ,f.fecha
	  ,isnull((select case r.observacion when 'Este documento ya existe en NubeFacT' then 'True' else r.aceptada_por_sunat end
	  from peru_respuestas r
	  where r.serie = f.serie
	  and r.numero = f.numero 
	  and r.tipo = f.tipo_comprobante),'False') as estado
	  ,isnull((select r.observacion from peru_respuestas r
	  where r.serie = f.serie
	  and r.numero = f.numero 
	  and r.tipo = f.tipo_comprobante),'') as observacion
  FROM v_peru_facturas f

GO


