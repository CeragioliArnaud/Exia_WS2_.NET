USE [CESI_3eAnnee]
GO

/****** Object:  Table [dbo].[Persons]    Script Date: 29/11/2018 09:28:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Persons](
	[PersonID] [int] NULL,
	[LastName] [varchar](255) NULL,
	[FirstName] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL
) ON [PRIMARY]

GO

