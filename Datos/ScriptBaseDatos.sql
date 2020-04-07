CREATE DATABASE [Webips];
USE  [Webips]

CREATE TABLE [dbo].[Persona](
	[Identificacion] [nvarchar](10) NOT NULL PRIMARY KEY,
	[Nombre] [nvarchar](50) NOT NULL,
	[ValorServicio] [int] NOT NULL,
	[Salario] [int]  NOT NULL,
	[Copago] [int] NOT NULL,
) 
GO

COMMIT