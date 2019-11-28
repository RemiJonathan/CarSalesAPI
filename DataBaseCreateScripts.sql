USE [CarSalesDB]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2019-11-28 3:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerFname] [varchar](10) NULL,
	[CustomerLname] [varchar](20) NULL,
	[CustomerEmail] [varchar](75) NULL,
	[CustomerPhone] [varchar](30) NULL,
	[CustomerCivicNo] [varchar](10) NULL,
	[CustomerStreetName] [varchar](20) NULL,
	[CustomerAppartment] [varchar](5) NULL,
	[CustomerCity] [varchar](30) NULL,
	[CustomerProvince] [varchar](2) NULL,
	[CustomerPostalCode] [varchar](6) NULL,
	[CustomerIsActive] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2019-11-28 3:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [int] IDENTITY(1,1) NOT NULL,
	[LocationAddressCivicNo] [varchar](10) NULL,
	[LocationAddressStreetName] [varchar](20) NULL,
	[LocationAddressAppartment] [varchar](5) NULL,
	[LocationAddressCity] [varchar](30) NULL,
	[LocationAddressProvince] [varchar](2) NULL,
	[LocationAddressPostalCode] [varchar](6) NULL,
	[LocationIsActive] [bit] NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 2019-11-28 3:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[SaleId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[SalespersonId] [int] NOT NULL,
	[VehicleId] [int] NOT NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[SaleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salesperson]    Script Date: 2019-11-28 3:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salesperson](
	[SalespersonId] [int] IDENTITY(1,1) NOT NULL,
	[SalespersonFname] [varchar](10) NULL,
	[SalespersonLname] [varchar](20) NULL,
	[SalespersonEmail] [varchar](75) NULL,
	[SalespersonPhone] [varchar](30) NULL,
	[SalespersonCivicNo] [varchar](10) NULL,
	[SalespersonStreetName] [varchar](20) NULL,
	[SalespersonAppartment] [varchar](5) NULL,
	[SalespersonCity] [varchar](30) NULL,
	[SalespersonProvince] [varchar](2) NULL,
	[SalespersonPostalCode] [varchar](6) NULL,
	[LocationId] [int] NOT NULL,
	[SalespersonIsActive] [bit] NULL,
 CONSTRAINT [PK_Salesperson] PRIMARY KEY CLUSTERED 
(
	[SalespersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 2019-11-28 3:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[VehicleId] [int] IDENTITY(1,1) NOT NULL,
	[VehicleModel] [varchar](10) NULL,
	[VehicleYear] [varchar](4) NULL,
	[VehicleManufacturer] [varchar](20) NULL,
	[VehicleDescription] [varchar](100) NULL,
	[VehiclePrice] [numeric](10, 2) NULL,
	[Commission] [numeric](4, 2) NULL,
	[Stock] [int] NULL,
	[VehicleIsActive] [bit] NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (1, N'Remi', N'Choquette', N'contact@remijonathan.com', N'5146646663', N'4100', N'RJ', N'11', N'Montreal', N'QC', N'H3T1E3', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (2, N'Amin', N'Meslioui', N'contact@aminmeslioui.com', N'5141231234', N'5140', N'Westmount Square', NULL, N'Montreal', N'QC', N'P3T1ET', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (3, N'Fred', N'Desautels', N'contact@minomes.com', N'5145423434', N'789', N'Westmount Circle', NULL, N'Montreal', N'QC', N'W3T5ET', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (4, N'Peter', N'Haladay', N'contact@petmes.com', N'5145423434', N'789', N'Westmount Circle', NULL, N'Montreal', N'QC', N'W3T5ET', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (5, N'Peter', N'Haladay', N'contact@petmes.com', N'5145423434', N'789', N'Westmount Circle', NULL, N'Montreal', N'QC', N'W3T5ET', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (6, N'Dylan', N'Pita', N'contact@petmes.com', N'5145423434', N'789', N'Westmount Circle', NULL, N'Montreal', N'QC', N'W3T5ET', 1)
GO
INSERT [dbo].[Customer] ([CustomerId], [CustomerFname], [CustomerLname], [CustomerEmail], [CustomerPhone], [CustomerCivicNo], [CustomerStreetName], [CustomerAppartment], [CustomerCity], [CustomerProvince], [CustomerPostalCode], [CustomerIsActive]) VALUES (7, N'Remi', N'Jonathan', N'contact@remijonathan.com', N'5148862243', N'1450', N'Bissonet', NULL, N'Montreal', N'QC', N'J4M2L2', 1)
GO
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
ALTER TABLE [dbo].[Customer] ADD  CONSTRAINT [DF_Customer_CustomerIsActive]  DEFAULT ((1)) FOR [CustomerIsActive]
GO
ALTER TABLE [dbo].[Location] ADD  CONSTRAINT [DF_Location_LocationIsActive]  DEFAULT ((1)) FOR [LocationIsActive]
GO
ALTER TABLE [dbo].[Salesperson] ADD  CONSTRAINT [DF_Salesperson_SalespersonIsActive]  DEFAULT ((1)) FOR [SalespersonIsActive]
GO
ALTER TABLE [dbo].[Vehicle] ADD  CONSTRAINT [DF_Vehicle_VehicleIsActive]  DEFAULT ((1)) FOR [VehicleIsActive]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Customer]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Salesperson] FOREIGN KEY([SalespersonId])
REFERENCES [dbo].[Salesperson] ([SalespersonId])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Salesperson]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK_Sale_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicle] ([VehicleId])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK_Sale_Vehicle]
GO
ALTER TABLE [dbo].[Salesperson]  WITH CHECK ADD  CONSTRAINT [FK_Salesperson_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Salesperson] CHECK CONSTRAINT [FK_Salesperson_Location]
GO
