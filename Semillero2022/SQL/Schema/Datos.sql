USE ProyectoNeoris;
GO 

/****** Object:  Table [dbo].[Catalogo_Distrito]    Script Date: 2/28/2022 11:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_Distrito](
	[IDREGION] [int] NULL,
	[IDDISTRICT] [int] NULL,
	[DISTRICTNAME] [nvarchar](100) NOT NULL,
	[CODESTATUS] [nvarchar](2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Catalogo_Estados]    Script Date: 2/28/2022 11:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_Estados](
	[ID_ESTADO] [int] NOT NULL,
	[NOMBRE] [nvarchar](255) NOT NULL,
	[ESTATUS] [nvarchar](255) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Catalogo_Municipios]    Script Date: 2/28/2022 11:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_Municipios](
	[ID_MUNICIPIO] [int] NOT NULL,
	[ID_ESTADO] [int] NOT NULL,
	[NOMBRE] [nvarchar](255) NOT NULL,
	[ESTATUS] [nvarchar](255) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Catalogo_Region]    Script Date: 2/28/2022 11:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catalogo_Region](
	[IDREGION] [int] NOT NULL,
	[REGIONNAME] [nvarchar](15) NOT NULL,
	[CODESTATUS] [nvarchar](1) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Catalogo_Tienda]    Script Date: 2/28/2022 11:22:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Catalogo_Tienda](
	[IDSTORE] [int] NOT NULL,
	[STORENAME] [nvarchar](50) NOT NULL,
	[CODESTATUS] [nvarchar](1) NOT NULL,
	[TAXRATE] [decimal](5, 2) NOT NULL,
	[IDMARKET] [int] NOT NULL,
	[IDDISTRICT] [int] NOT NULL,
	[ZoneCode] [varchar](20) NOT NULL,
	[DIRECCION] [nvarchar](70) NULL,
	[LOCALIDAD] [nvarchar](70) NULL,
	[MUNICIPIO] [nvarchar](50) NULL,
	[ESTADO] [nvarchar](6) NULL,
	[CODIGOPOSTAL] [nvarchar](18) NULL,
	[TELEFONO] [nvarchar](20) NULL
) ON [PRIMARY]

