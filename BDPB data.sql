/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 16/1/2022 0:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 16/1/2022 0:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteId] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
	[Telefono] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ClienteId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 16/1/2022 0:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[CuentaId] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nvarchar](max) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[CuentaId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 16/1/2022 0:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[MovimientoId] [int] IDENTITY(1,1) NOT NULL,
	[CuentaId] [int] NOT NULL,
	[Tipo] [nvarchar](max) NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Valor] [decimal](18, 2) NOT NULL,
	[Saldo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED 
(
	[MovimientoId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 16/1/2022 0:51:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[PasswordHash] [varbinary](max) NULL,
	[PasswordSalt] [varbinary](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220114162323_AgregarClienteDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220114202834_AgregarTablasDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220115152434_AgregarUserDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220115153651_AgregarUsersDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220115153935_AgregarTalbsDecimalDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220115155116_AgregarTDecimalDb', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220115163005_cambioTablasDb', N'5.0.7')
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (1, N'Christian Yepez C', N'La Pampa', N'0982101189')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (2, N'Alexa', N'Pomasqui', N'9888552')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (3, N'Paolo', N'Mitad', N'98881111')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (5, N'Yelaida', N'Quito', N'05785456')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (6, N'Renato', N'casa', N'NA')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (7, N'Gabriel', N'Sur de Quito', N'1546456')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (8, N'pepito', N'en la loma', N'3333')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (14, N'Christian1', N'Pampa', N'0982101189')
INSERT [dbo].[Clientes] ([ClienteId], [Nombres], [Direccion], [Telefono]) VALUES (15, N'pepito334', N'dadasd', N'1231312')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Cuentas] ON 

INSERT [dbo].[Cuentas] ([CuentaId], [Numero], [Saldo], [ClienteId]) VALUES (2, N'Pic456', CAST(11000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Cuentas] ([CuentaId], [Numero], [Saldo], [ClienteId]) VALUES (3, N'Pic564', CAST(226000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Cuentas] ([CuentaId], [Numero], [Saldo], [ClienteId]) VALUES (4, N'Pich4-345', CAST(12000.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Cuentas] ([CuentaId], [Numero], [Saldo], [ClienteId]) VALUES (5, N'BP333', CAST(25000.00 AS Decimal(18, 2)), 4)
SET IDENTITY_INSERT [dbo].[Cuentas] OFF
GO
SET IDENTITY_INSERT [dbo].[Movimientos] ON 

INSERT [dbo].[Movimientos] ([MovimientoId], [CuentaId], [Tipo], [Fecha], [Valor], [Saldo]) VALUES (2, 2, N'D', CAST(N'2021-01-12T00:00:00.0000000' AS DateTime2), CAST(-1000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[Movimientos] ([MovimientoId], [CuentaId], [Tipo], [Fecha], [Valor], [Saldo]) VALUES (3, 3, N'D', CAST(N'2022-01-13T20:55:06.2130000' AS DateTime2), CAST(-1000.00 AS Decimal(18, 2)), CAST(9000.00 AS Decimal(18, 2)))
INSERT [dbo].[Movimientos] ([MovimientoId], [CuentaId], [Tipo], [Fecha], [Valor], [Saldo]) VALUES (4, 2, N'C', CAST(N'2022-01-13T20:55:06.2130000' AS DateTime2), CAST(10000.00 AS Decimal(18, 2)), CAST(19000.00 AS Decimal(18, 2)))
INSERT [dbo].[Movimientos] ([MovimientoId], [CuentaId], [Tipo], [Fecha], [Valor], [Saldo]) VALUES (5, 4, N'C', CAST(N'2022-01-14T22:11:15.4080000' AS DateTime2), CAST(100.00 AS Decimal(18, 2)), CAST(12100.00 AS Decimal(18, 2)))
INSERT [dbo].[Movimientos] ([MovimientoId], [CuentaId], [Tipo], [Fecha], [Valor], [Saldo]) VALUES (6, 2, N'C', CAST(N'2021-01-15T00:00:00.0000000' AS DateTime2), CAST(200.00 AS Decimal(18, 2)), CAST(333.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Movimientos] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [PasswordHash], [PasswordSalt]) VALUES (4, N'christian', 0x8BE1CB30A128D87E8B8510D9B934B4F7C9D094CE84D1DC5239BAAE086E65C077D5E6D1F486DC268315495E657D80A302588996281893AEC35FD9A9B81BBCB4AA, 0x320404671D4217BFEBFE35AAAEAE26F49DD33D4A1AE04FA2348364658881A9845147DE563BF39CECE88EDEF9259DC66DB1D47AF0D8F5FFC7E24E71372435113B067A23B706330FE1408B055788823D807CE2BB7776CAA5E04E6B3FB8F69645A9D66DD1A94DA7E323EA7B60C5D2A4B84BE79718C2DEC2787E921AEED7A6D1F1EE)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordHash], [PasswordSalt]) VALUES (5, N'cyepez', 0xEF666842EF95C704CF3CC4CEF362C53788003C15C29F961274D2DF5D41EB41EF845E882AFDC2FA4D178014D52D73CD9ADB4F5AF309C1F928700363C01CE0A14C, 0xCE94980A96AA01CAB9D5281740ACAAADD871347750F748734405AEF7048FEB24DE05F9003822F44069EE79A6409D9349394CD41768B54EA1A8F9E6E397F66C9D7987B4781DB459399D91049A8753572265C0FBB8ADD33D39CAC71F4C851DA6AB42BC1EBF18E40A9AC2450C56B407A28B4A048F930BBADF9BDE2384FF33DDB505)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordHash], [PasswordSalt]) VALUES (6, N'juanita', 0xD27FE154EF36C85DD866DCF8988B1F7A5001D99351D831F925762FEB42FFDBEC220062FFC5634B9A4BFD9C8342D32CD19B29F065824EA1AA35AB64D2D1BBA069, 0x2A7AD8FCD089325DEF72F54C0AD7153DE285CC9189069911BA99145C8CC2CC4A5C602460A1D9C5D70E56BECA2243837E535375986FF01D1E80195099C34ABA49748D44E3186AC535B7490C4FC2BB4DACEAB19A969D26DCF8594164617D15BB9AAFA1F4133EF4039EE6742F1E637A334227C79BA48F4D97DC7829C0CA8B44D422)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordHash], [PasswordSalt]) VALUES (7, N'juantia', 0x1ADDFDD2298564BACC5D44D76AD03D66BE91E5AE9FE1F511691B872425EF17EA02854216D48F4E0E733BE3AE62BB8AA842A6A9F4F062A14F3CC8E019DC3CF982, 0xE58759E492F4101EE924FE6D3829CEE323EBF36F03E2FA13694022C2067BFB80892229A067F80D25A621F7EF3F74D50CFEB0A6CF730ADE3E15EB716470D1F2C3A233B9DBA567E4C555A2EEBCA4A988625AE2DC8367FD5EA7B9CB5AB96BE99C300D342297E067482D9937CF4D281C1C216C6838F2DB8C1044174D714383CC88D9)
INSERT [dbo].[Users] ([Id], [UserName], [PasswordHash], [PasswordSalt]) VALUES (9, N'cyepez1', 0xC2416B633A0440692D22072D8E7E557E8E07B45C351CD0F08D085FF2CA54E7891DA8122BB9A1CAA0980CD3A863ABCA2CCC31EC521DD7E1DF2C8C1193573C6865, 0x0C7D50179EE1D811D19C0B3EEEDF0FA826A838A1DBA4F692B292764514CEF617F2630A345D0D782ECF372C59D48EAED1A059332034D39D86745A1E1B6A179F974970821B669E9522A3A55EEAD634EF5706AE80A75EF2310918D0566B3474E3762858207044C5AA1C957DBED3248235D815A5DF4EE353F8871FEF5794F085EE49)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Cuentas] ADD  DEFAULT ((0)) FOR [ClienteId]
GO
