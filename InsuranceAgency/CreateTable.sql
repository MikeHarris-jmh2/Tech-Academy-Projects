CREATE TABLE[dbo].[InsuranceInformation]
(

   [Id][int] NOT NULL IDENTITY PRIMARY KEY,

   [FirstName] [nchar] (50) NULL,
	[LastName] [nchar] (50) NULL,
	[EmailAddress] [nchar] (100) NULL,
	[DateofBirth] [date] NULL,
	[CarYear] [int] NULL,
	[CarMake] [nchar] (50) NULL,
	[CarModel] [nchar] (50) NULL,
	[hasDUI] [bit] NULL,
	[SpeedingTickets] [int] NULL,
	[FullCoverageorLiability] [bit] NULL,
)
GO
