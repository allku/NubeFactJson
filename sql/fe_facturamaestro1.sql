USE [BDQualityv]
GO

/****** Object:  View [dbo].[fe_facturamaestro1]    Script Date: 07/01/2018 21:48:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER view [dbo].[fe_facturamaestro1]
as
select numero,
max(tipo_documento) AS tipo_documento,max(Nosecuencial) AS Nosecuencial,
max(Fecha) as fecha,MAX(Total_sin_iva) as Total_sin_Iva,max(Total_con_iva) as Total_con_Iva,
max(Iva) as Iva,SUM(Descuento) as Descuento,MAX(Total)as Total,max(Estado) as Estado, 
MAX(Codigo_cli) as Codigo_Cli,Documento_cli as Documento_cli,razonsocial as razonSocial,
max(Direccion) as Direccion,max(Fono) as Fono,max(eMail) as eMail,max(Guia_remision) as Guia_Remision
FROM fe_facturamaestro
--where numero = '23375'
group by numero,Documento_cli,razonSocial




GO

