USE [CountryCityDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Country]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Country](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[About] [text] NULL,
 CONSTRAINT [PK_tbl_Country_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_City]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_City](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nchar](10) NULL,
	[CityAbout] [nchar](10) NULL,
	[DwellerNumber] [int] NULL,
	[Location] [varchar](50) NULL,
	[Weather] [varchar](50) NULL,
	[CountryID] [int] NULL,
 CONSTRAINT [PK_tbl_City] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
