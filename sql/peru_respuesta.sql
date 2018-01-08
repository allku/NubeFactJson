USE [BDQualityv]
GO

/****** Object:  Table [dbo].[peru_respuesta]    Script Date: 06/01/2018 22:33:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[peru_respuestas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](100) NULL,
	[serie] [varchar](100) NULL,
	[numero] [varchar](100) NULL,
	[enlace] [varchar](1000) NULL,
	[aceptada_por_sunat] [varchar](100) NULL,
	[sunat_description] [varchar](100) NULL,
	[sunat_note] [varchar](100) NULL,
	[sunat_responsecode] [varchar](100) NULL,
	[sunat_soap_error] [varchar](100) NULL,
	[pdf_zip_base64] [text] NULL,
	[xml_zip_base64] [text] NULL,
	[cdr_zip_base64] [text] NULL,
	[cadena_para_codigo_qr] [varchar](1000) NULL,
	[codigo_hash] [varchar](100) NULL,
	[enlace_del_pdf] [varchar](1000) NULL,
	[enlace_del_xml] [varchar](1000) NULL,
	[enlace_del_cdr] [varchar](1000) NULL,
	[observacion] [varchar](1000) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


