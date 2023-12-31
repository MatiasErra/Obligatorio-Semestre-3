USE [master]
GO
/****** Object:  Database [obligatorioProg]    Script Date: 08/07/2022 22:06:54 ******/
CREATE DATABASE [obligatorioProg]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'obligatorioProg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\obligatorioProg.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'obligatorioProg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\obligatorioProg_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [obligatorioProg] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [obligatorioProg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [obligatorioProg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [obligatorioProg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [obligatorioProg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [obligatorioProg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [obligatorioProg] SET ARITHABORT OFF 
GO
ALTER DATABASE [obligatorioProg] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [obligatorioProg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [obligatorioProg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [obligatorioProg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [obligatorioProg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [obligatorioProg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [obligatorioProg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [obligatorioProg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [obligatorioProg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [obligatorioProg] SET  ENABLE_BROKER 
GO
ALTER DATABASE [obligatorioProg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [obligatorioProg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [obligatorioProg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [obligatorioProg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [obligatorioProg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [obligatorioProg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [obligatorioProg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [obligatorioProg] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [obligatorioProg] SET  MULTI_USER 
GO
ALTER DATABASE [obligatorioProg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [obligatorioProg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [obligatorioProg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [obligatorioProg] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [obligatorioProg] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [obligatorioProg] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [obligatorioProg] SET QUERY_STORE = OFF
GO
USE [obligatorioProg]
GO
/****** Object:  User [sa]    Script Date: 08/07/2022 22:06:54 ******/
CREATE USER [sa] FOR LOGIN [sa] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](40) NULL,
	[users] [varchar](40) NULL,
	[pass] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](40) NULL,
	[pass] [varchar](20) NULL,
	[users] [varchar](20) NULL,
	[ci] [varchar](20) NULL,
	[tel] [varchar](20) NULL,
	[dir] [varchar](40) NULL,
	[mail] [varchar](30) NULL,
	[fchregistro] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mecanico]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mecanico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NULL,
	[apellido] [varchar](40) NULL,
	[ci] [varchar](20) NULL,
	[tel] [varchar](20) NULL,
	[fchingreso] [varchar](11) NULL,
	[valorHora] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reparacion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reparacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fchaEntrada] [varchar](30) NULL,
	[fchaSalida] [varchar](40) NULL,
	[horas] [int] NULL,
	[fchaReservada] [varchar](30) NULL,
	[fchaAgendada] [varchar](20) NULL,
	[descripcion] [varchar](50) NULL,
	[idVehiculo] [int] NOT NULL,
	[idMecanico] [int] NULL,
	[Tipo] [varchar](20) NULL,
	[Costo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reparacion_Repuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reparacion_Repuesto](
	[idRepar] [int] NOT NULL,
	[idRepuesto] [int] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idRepuesto] ASC,
	[idRepar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuesto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
	[descripcion] [varchar](45) NULL,
	[tipo] [varchar](45) NULL,
	[costo] [int] NULL,
	[stock] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuperAdmins]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuperAdmins](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[users] [varchar](40) NULL,
	[pass] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [varchar](20) NULL,
	[Marca] [varchar](40) NULL,
	[Modelo] [varchar](20) NULL,
	[Anio] [varchar](20) NULL,
	[Color] [varchar](20) NULL,
	[idCli] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([id], [nombre], [apellido], [users], [pass]) VALUES (1, N'juan', N'jose', N'Admin', N'Admin')
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [pass], [users], [ci], [tel], [dir], [mail], [fchregistro]) VALUES (4, N'Matias', N'Erramoupse', N'1234', N'Blue', N'121', N'11', N'11', N'3', N'Jul  6 2022')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [pass], [users], [ci], [tel], [dir], [mail], [fchregistro]) VALUES (5, N'jose', N'luis', N'1234', N'Joseluis', N'4311', N'1321', N'Artigas', N'2@gmail', N'Jul  8 2022')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Mecanico] ON 

INSERT [dbo].[Mecanico] ([id], [nombre], [apellido], [ci], [tel], [fchingreso], [valorHora]) VALUES (3, N'Joaquin', N'lorenzo', N'32321', N'1', N'09 05 2021', N'20')
INSERT [dbo].[Mecanico] ([id], [nombre], [apellido], [ci], [tel], [fchingreso], [valorHora]) VALUES (4, N'Pan', N'Chon', N'232541', N'2321312', N'05 03 2019', N'40')
SET IDENTITY_INSERT [dbo].[Mecanico] OFF
GO
SET IDENTITY_INSERT [dbo].[Reparacion] ON 

INSERT [dbo].[Reparacion] ([id], [fchaEntrada], [fchaSalida], [horas], [fchaReservada], [fchaAgendada], [descripcion], [idVehiculo], [idMecanico], [Tipo], [Costo]) VALUES (28, NULL, NULL, NULL, N'20 07 2022', N'Jul  8 2022', NULL, 3, NULL, N'Agendado', 0)
INSERT [dbo].[Reparacion] ([id], [fchaEntrada], [fchaSalida], [horas], [fchaReservada], [fchaAgendada], [descripcion], [idVehiculo], [idMecanico], [Tipo], [Costo]) VALUES (30, N'09 07 2022', N'11 07 2022', 50, N'09 07 2022', N'Jul  8 2022', N'Coso', 2, 3, N'Reparado', 2900)
INSERT [dbo].[Reparacion] ([id], [fchaEntrada], [fchaSalida], [horas], [fchaReservada], [fchaAgendada], [descripcion], [idVehiculo], [idMecanico], [Tipo], [Costo]) VALUES (31, N'08 07 2022', N'15 07 2022', 20, N'08 07 2022', N'Jul  8 2022', N'si', 4, 4, N'Reparado', 9800)
SET IDENTITY_INSERT [dbo].[Reparacion] OFF
GO
INSERT [dbo].[Reparacion_Repuesto] ([idRepar], [idRepuesto], [cantidad]) VALUES (30, 4, 1)
INSERT [dbo].[Reparacion_Repuesto] ([idRepar], [idRepuesto], [cantidad]) VALUES (31, 4, 5)
INSERT [dbo].[Reparacion_Repuesto] ([idRepar], [idRepuesto], [cantidad]) VALUES (30, 5, 2)
INSERT [dbo].[Reparacion_Repuesto] ([idRepar], [idRepuesto], [cantidad]) VALUES (31, 5, 10)
INSERT [dbo].[Reparacion_Repuesto] ([idRepar], [idRepuesto], [cantidad]) VALUES (30, 6, 1)
GO
SET IDENTITY_INSERT [dbo].[Repuesto] ON 

INSERT [dbo].[Repuesto] ([id], [nombre], [descripcion], [tipo], [costo], [stock]) VALUES (4, N'Bujia', N'Para el motor', N'Motor', 1000, N'300')
INSERT [dbo].[Repuesto] ([id], [nombre], [descripcion], [tipo], [costo], [stock]) VALUES (5, N'Ruedas', N'Para las ruedas ', N'Neumatico', 400, N'200')
INSERT [dbo].[Repuesto] ([id], [nombre], [descripcion], [tipo], [costo], [stock]) VALUES (6, N'Aceite', N'Para cambiar', N'Insumo', 100, N'300')
SET IDENTITY_INSERT [dbo].[Repuesto] OFF
GO
SET IDENTITY_INSERT [dbo].[SuperAdmins] ON 

INSERT [dbo].[SuperAdmins] ([id], [users], [pass]) VALUES (1, N'SuperAdmin', N'12345')
SET IDENTITY_INSERT [dbo].[SuperAdmins] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculo] ON 

INSERT [dbo].[Vehiculo] ([id], [Matricula], [Marca], [Modelo], [Anio], [Color], [idCli]) VALUES (2, N'Za-11', N'm', N'H', N'2021', N'Verde', 4)
INSERT [dbo].[Vehiculo] ([id], [Matricula], [Marca], [Modelo], [Anio], [Color], [idCli]) VALUES (3, N'AZ131', N'zZA', N'13', N'2020', N'Negro', 4)
INSERT [dbo].[Vehiculo] ([id], [Matricula], [Marca], [Modelo], [Anio], [Color], [idCli]) VALUES (4, N'Zal', N'LJ', N'Z13', N'2020', N'Rojo', 5)
SET IDENTITY_INSERT [dbo].[Vehiculo] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Admins__2B8C777D92A4B25D]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Admins] ADD UNIQUE NONCLUSTERED 
(
	[users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Admins__2B8C777DBE06A3D0]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Admins] ADD UNIQUE NONCLUSTERED 
(
	[users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cliente__2B8C777D218E6F21]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Cliente] ADD UNIQUE NONCLUSTERED 
(
	[users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cliente__32136662E8E4A806]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Cliente] ADD UNIQUE NONCLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Mecanico__32136662FB86E14A]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Mecanico] ADD UNIQUE NONCLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Reparaci__981347072FB33979]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Reparacion] ADD UNIQUE NONCLUSTERED 
(
	[fchaReservada] ASC,
	[idVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Repuesto__72AFBCC60F117964]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Repuesto] ADD UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SuperAdm__2B8C777D8BA4B6D0]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[SuperAdmins] ADD UNIQUE NONCLUSTERED 
(
	[users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__SuperAdm__2B8C777DE8113503]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[SuperAdmins] ADD UNIQUE NONCLUSTERED 
(
	[users] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Vehiculo__0FB9FB4F765447BD]    Script Date: 08/07/2022 22:06:54 ******/
ALTER TABLE [dbo].[Vehiculo] ADD UNIQUE NONCLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cliente] ADD  DEFAULT (CONVERT([varchar](11),getdate())) FOR [fchregistro]
GO
ALTER TABLE [dbo].[Reparacion] ADD  DEFAULT (CONVERT([varchar](11),getdate())) FOR [fchaAgendada]
GO
ALTER TABLE [dbo].[Reparacion]  WITH CHECK ADD FOREIGN KEY([idMecanico])
REFERENCES [dbo].[Mecanico] ([id])
GO
ALTER TABLE [dbo].[Reparacion]  WITH CHECK ADD FOREIGN KEY([idVehiculo])
REFERENCES [dbo].[Vehiculo] ([id])
GO
ALTER TABLE [dbo].[Reparacion_Repuesto]  WITH CHECK ADD FOREIGN KEY([idRepar])
REFERENCES [dbo].[Reparacion] ([id])
GO
ALTER TABLE [dbo].[Reparacion_Repuesto]  WITH CHECK ADD FOREIGN KEY([idRepuesto])
REFERENCES [dbo].[Repuesto] ([id])
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD FOREIGN KEY([idCli])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Reparacion]  WITH CHECK ADD CHECK  (([Tipo]='Reparado' OR [Tipo]='En Reparacion' OR [Tipo]='Agendado'))
GO
/****** Object:  StoredProcedure [dbo].[AgregarCant]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AgregarCant]
	-- Add the parameters for the stored procedure here
@idRepar int,
@idRepuesto int,
@cant varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   Update Reparacion_Repuesto set cantidad = @cant
   where  idRepar = @idRepar and idRepuesto = @idRepuesto
	

END
GO
/****** Object:  StoredProcedure [dbo].[AltaAdmin]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaAdmin] 
	-- Add the parameters for the stored procedure here
	@nombre varchar(20),
	@apellido varchar(40),
	@password varchar(20),
	@user varchar(20)
	
AS
BEGIN
	

    -- Insert statements for procedure here
	insert into Admins
	(nombre, apellido, pass, users)

	values (@nombre, @apellido, @password, @user)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaCliente]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaCliente] 
	-- Add the parameters for the stored procedure here
	@nombre varchar(20),
	@apellido varchar(40),
	@password varchar(20),
	@user varchar(20),
	@ci   varchar(20),
	@tel varchar(20),
	@dir varchar(40),
	@mail varchar(30)
AS
BEGIN
	

    -- Insert statements for procedure here
	insert into Cliente
	(nombre, apellido, pass, users, ci , tel, dir, mail)

	values (@nombre, @apellido, @password, @user, @ci, @tel, @dir, @mail)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaEnReparacion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaEnReparacion]
	-- Add the parameters for the stored procedure here
	@fchaEntrada varchar(20),
	@fchaReservada varchar(20),
	@descripcion varchar(20),
	@idVehiculo int,
	@idMecanico int
AS
BEGIN
	insert into Reparacion(fchaEntrada,
	fchaReservada,
	descripcion,
	idVehiculo,
	idMecanico)
	values(@fchaEntrada, @fchaReservada, @descripcion, @idVehiculo, @idMecanico)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaMecanico]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaMecanico] 
	-- Add the parameters for the stored procedure here
	@Nombre varchar(20),
	@Apellido varchar(40),
	@Ci   varchar(20),
	@Tel varchar(40),
	@FchaIngreso varchar(30),
	@ValorHora varchar(10)

AS
BEGIN
	

    -- Insert statements for procedure here
	insert into Mecanico values (@nombre, @apellido,@ci, @tel, @FchaIngreso,  @ValorHora)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaRepar_Repuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaRepar_Repuesto]
	-- Add the parameters for the stored procedure here
	@idRepar integer,
	@idRepuesto integer,
	@cantidad integer

AS

BEGIN
Declare @Total numeric (10,2)
Declare @a int 
Declare @b int


insert into  Reparacion_Repuesto (idRepar, idRepuesto, cantidad) 
values(
@idRepar,
@idRepuesto,
@cantidad
)

set @a = (select sum(RR.cantidad * R.costo) from Reparacion_Repuesto RR inner join Repuesto R on R.id= RR.idRepuesto
	where  RR.idRepar = @idRepar)
	
	set @b =(select sum(R.horas * M.valorHora) from Reparacion R inner join Mecanico M on R.idMecanico = M.id
	where R.id = @idRepar)

	set @Total = @a + @b



	update Reparacion set Costo = @Total
	where id = @idRepar


END
GO
/****** Object:  StoredProcedure [dbo].[AltaReparacion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaReparacion]
	-- Add the parameters for the stored procedure here

	
	@fchaEntrada varchar(20),
	@fchaSalida varchar(20),
	@horas integer,
	@fchaReservada varchar(20),
	@descripcion varchar(20),
	@idVehiculo int,
	@idMecanico int




AS
BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.

	
	insert into Reparacion(
		[fchaEntrada]
           ,[fchaSalida]
           ,[horas]
           ,[fchaReservada]
           ,[descripcion]
           ,[idVehiculo]
           ,[idMecanico])
	values(@fchaEntrada, @fchaSalida, @horas, @fchaReservada, @descripcion, @idVehiculo, @idMecanico)

END

GO
/****** Object:  StoredProcedure [dbo].[AltaReparacionCli]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaReparacionCli] 
	-- Add the parameters for the stored procedure here
		@fchaReservada varchar(20),
	@idVehiculo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   insert into Reparacion(
	fchaReservada,
	idVehiculo)
	values(@fchaReservada, @idVehiculo )
END
GO
/****** Object:  StoredProcedure [dbo].[AltaRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaRepuesto]
	-- Add the parameters for the stored procedure here

	@descripcion varchar(45),
	@tipo varchar(45),
	@costo int,
	@nombre varchar(45),
	 @stock varchar(45)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Repuesto values(@nombre, @descripcion, @tipo, @costo, @stock)
END

GO
/****** Object:  StoredProcedure [dbo].[AltaVehiculo]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AltaVehiculo] 
	-- Add the parameters for the stored procedure here
	@matricula varchar(20),
	@marca varchar(40),
	@modelo varchar(20),
	@anio varchar(20),
	@color   varchar(20),
	@idCli integer
AS
BEGIN
	

    -- Insert statements for procedure here
	insert into Vehiculo values (@matricula, @marca, @modelo, @anio, @color, @idCli)
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarAdmin]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarAdmin]
	-- Add the parameters for the stored procedure here
	@id integer 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[pass]
      ,[users]
     
	from Admins
	where Admins.id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarCli]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarCli]
	-- Add the parameters for the stored procedure here
	@id integer 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[pass]
      ,[users]
      ,[ci]
      ,[tel]
      ,[dir]
      ,[mail]
      ,[fchregistro]
	from Cliente 
	where Cliente.id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarlstVeh]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarlstVeh]
	-- Add the parameters for the stored procedure here
	 @idCli integer
AS
BEGIN
	select 
	id,
	matricula,
	marca,
	modelo,
	anio,
	color,
	IdCli
	from  Vehiculo
	where idCli = @idCli


  
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarMec]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarMec]
	-- Add the parameters for the stored procedure here
	@id integer 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[ci]
      ,[tel]
      
      
      ,[fchingreso]
	  ,valorHora
	from Mecanico 
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarReparacion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarReparacion]
	-- Add the parameters for the stored procedure here
@id integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select[id],
	fchaEntrada,
	fchaSalida,
	horas,
	fchaReservada,
	descripcion,
	idVehiculo,
	idMecanico,
	Tipo,
	costo
	
	
	
	from Reparacion
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarRepuesto]
	-- Add the parameters for the stored procedure here
@id integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select[id], nombre ,[descripcion],[tipo],[costo], stock from Repuesto
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarVehi]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[BuscarVehi]
	-- Add the parameters for the stored procedure here
	 @id integer
AS
BEGIN
	select 
	id,
	matricula,
	marca,
	modelo,
	anio,
	color,
	IdCli
	from  Vehiculo
	where id = @id  


  
END
GO
/****** Object:  StoredProcedure [dbo].[CambiarPass]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CambiarPass]
	-- Add the parameters for the stored procedure here
	@Id integer,
  	@pass varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Cliente set pass = @pass
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[CantRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[CantRepuesto]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  Select sum(cantidad) as Cant from Reparacion_Repuesto RR inner join Repuesto R on  R.id = RR.idRepuesto
	Group by RR.idRepuesto
	order by sum(cantidad) Desc


END
GO
/****** Object:  StoredProcedure [dbo].[CostoDeRepar]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Procedure [dbo].[CostoDeRepar] (@Total numeric (10,2) out ,@idRepar int)

as 
 declare @a int 
 declare @b int 
begin

	set @a = (select sum(RR.cantidad * R.costo) from Reparacion_Repuesto RR inner join Repuesto R on R.id= RR.idRepuesto
	where  RR.idRepar = @idRepar)
	
	set @b =(select sum(R.horas * M.valorHora) from Reparacion R inner join Mecanico M on R.idMecanico = M.id
	where R.id = @idRepar)

	set @Total = @a + @b
end;
GO
/****** Object:  StoredProcedure [dbo].[EliminarAdmin]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarAdmin]
	-- Add the parameters for the stored procedure here
	@id integer	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Admins
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarCli]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarCli]
	-- Add the parameters for the stored procedure here
	@id integer	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Cliente
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMecanico]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarMecanico]
	-- Add the parameters for the stored procedure here
	@id integer	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Mecanico
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarRepar]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarRepar]
	-- Add the parameters for the stored procedure here
	@id integer	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Reparacion_Repuesto
	where idRepar = @id

	delete from Reparacion
	where id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarReparacion_Repuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarReparacion_Repuesto]
	-- Add the parameters for the stored procedure here
		@idRepar integer,
	@id integer	
AS
BEGIN
Declare @Total numeric (10,2)
Declare @a int 
Declare @b int
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here	
	delete from Reparacion_Repuesto
	where idRepuesto = @id
	if exists (select * from Reparacion_Repuesto 
	where  idRepar = @idRepar)
	begin

	set @a = (select sum(RR.cantidad * R.costo) from Reparacion_Repuesto RR inner join Repuesto R on R.id= RR.idRepuesto
	where  RR.idRepar = @idRepar)
	end

	else
	begin
		set @a = 0
	end

	set @b =(select sum(R.horas * M.valorHora) from Reparacion R inner join Mecanico M on R.idMecanico = M.id
	where R.id = @idRepar)

	set @Total = @a + @b

		update Reparacion set Costo = @Total
	where id = @idRepar
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[EliminarRepuesto]
	-- Add the parameters for the stored procedure here

	@id integer
AS
BEGIN

delete from Repuesto
where id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[EliminarVehi]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EliminarVehi]
	-- Add the parameters for the stored procedure here
	@id integer	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Vehiculo
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[IniciarSesion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[IniciarSesion] 
	-- Add the parameters for the stored procedure here
	@user varchar(30),
	@pass varchar(30)
AS
BEGIN
if exists(select id from Cliente where users =  @user and pass = @pass)
begin
	select id from Cliente
	where users = @user and pass = @pass
end
	end


GO
/****** Object:  StoredProcedure [dbo].[IniciarSesionA]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[IniciarSesionA] 
	-- Add the parameters for the stored procedure here
	@user varchar(30),
	@pass varchar(30)
AS
BEGIN
if exists(select id from Admins where users =  @user and pass = @pass)
begin
	select id from Admins
	where users = @user and pass = @pass
end
	end


GO
/****** Object:  StoredProcedure [dbo].[IniciarSesionSA]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[IniciarSesionSA] 
	-- Add the parameters for the stored procedure here
	@user varchar(30),
	@pass varchar(30)
AS
BEGIN
if exists(select id from SuperAdmins where users =  @user and pass = @pass)
begin
	select id from SuperAdmins
	where users = @user and pass = @pass
end
	end


GO
/****** Object:  StoredProcedure [dbo].[ModAdmin]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModAdmin] 
	-- Add the parameters for the stored procedure here
	@Id integer,
	@Nombre varchar(20),
	@Apellido varchar(40),
	
	@user varchar(20)




AS
BEGIN
update Admins
set 
nombre =  @Nombre,
apellido = @Apellido,
users = @user

	where id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[ModCli]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModCli]
	-- Add the parameters for the stored procedure here
	@Id integer,
	@Nombre varchar(20),
	@Apellido varchar(40),
	@pass varchar(20),
	@user varchar(20),
	@Ci   varchar(20),
	@dir  varchar(20),
	@Tel varchar(40),
	@Mail varchar(30),
	@fchaRegistro varchar(20)



AS
BEGIN
update Cliente
set 
nombre =  @Nombre,
apellido = @Apellido,
pass = @pass,
users = @user,
ci = @Ci,
dir = @dir,
tel = @Tel,
mail = @Mail,
fchregistro = @fchaRegistro
	where id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[ModRep]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModRep]
	-- Add the parameters for the stored procedure here
	@Id integer,
	@Nombre varchar(20),
	@Apellido varchar(40),
	@Ci   varchar(20),
	@Tel varchar(40),
	@FchaIngreso varchar(30),
	@ValorHora varchar(10)


AS
BEGIN
update Mecanico
set 
nombre =  @Nombre,
apellido = @Apellido,
ci = @Ci,
tel = @Tel,
fchingreso = @FchaIngreso,
valorHora = @ValorHora
	where id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[ModRepar]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModRepar]
	-- Add the parameters for the stored procedure here
	@id integer, 
	@FechaEntrada varchar(20),
	@FechaSalida varchar(40),
	@Horas int,
	@fchaReservada varchar(20),
	@descripcion varchar(40),
	@IdVehiculo integer,
	@IdMecanico integer


AS
BEGIN
update Reparacion set 
fchaEntrada = @FechaEntrada,
	fchaSalida = @FechaSalida, 
	horas = @Horas,
	fchaReservada = @fchaReservada, 
	descripcion = @descripcion,
	idVehiculo = @IdVehiculo,
	idMecanico = @IdMecanico
	where id = @id

	Declare @Total numeric (10,2)
Declare @a int 
Declare @b int

set @a = (select sum(RR.cantidad * R.costo) from Reparacion_Repuesto RR inner join Repuesto R on R.id= RR.idRepuesto
	where  RR.idRepar = @id)
	
	set @b =(select sum(R.horas * M.valorHora) from Reparacion R inner join Mecanico M on R.idMecanico = M.id
	where R.id = @id)

	set @Total = @a + @b



	update Reparacion set Costo = @Total
	where id = @id


END
GO
/****** Object:  StoredProcedure [dbo].[ModRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModRepuesto]
	-- Add the parameters for the stored procedure here
	@id integer,
	@descripcion varchar(45),
	@tipo varchar(45),
	@costo integer,
	@nombre varchar(45),
	@stock varchar(45)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	update Repuesto set
	nombre = @nombre,
	descripcion = @descripcion,
	tipo = @tipo,
	costo = @costo,
	stock = @stock
	where id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ModVehi]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ModVehi]
	-- Add the parameters for the stored procedure here
	@id integer, 
	@mat varchar(20),
	@mar varchar(40),
	@modelo varchar(20),
	@anio varchar(20),
	@color varchar(20),
	@idCli integer


AS
BEGIN
update Vehiculo set 
Matricula = @mat,
	Marca = @mar, 
	Modelo = @modelo, 
	Anio = @anio,
	Color = @color,
	idCli = @idCli
	where id = @id

END
GO
/****** Object:  StoredProcedure [dbo].[ObtAdmin]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtAdmin]

AS
BEGIN
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[pass]
      ,[users]
     
  FROM [obligatorioProg].[dbo].Admins

END
GO
/****** Object:  StoredProcedure [dbo].[ObtCliente]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtCliente]

AS
BEGIN
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[pass]
      ,[users]
      ,[ci]
      ,[tel]
      ,[dir]
      ,[mail]
      ,[fchregistro]
  FROM [obligatorioProg].[dbo].[Cliente]

END
GO
/****** Object:  StoredProcedure [dbo].[ObtMecanico]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtMecanico]

AS
BEGIN
	 SELECT  [id]
      ,[nombre]
      ,[apellido]
      ,[ci]
      ,[tel]
      
      
      ,[fchingreso]
	  ,valorHora
  FROM [obligatorioProg].[dbo].Mecanico

END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacion]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ObtReparacion]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select[id],fchaEntrada,fchaSalida, horas,fchaReservada, fchaAgendada, descripcion, idVehiculo, idMecanico, Costo, Tipo from Reparacion



END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacion_Rep]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtReparacion_Rep]
	-- Add the parameters for the stored procedure here
	@id integer
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select idRepar, idRepuesto,cantidad from Reparacion_Repuesto
where idRepar = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacionAgend]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



Create PROCEDURE [dbo].[ObtReparacionAgend]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select[id], fchaReservada, fchaAgendada,  idVehiculo, Tipo from Reparacion
where Tipo ='Agendado'


END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacionRepar]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ObtReparacionRepar]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select[id],fchaEntrada,fchaSalida, horas,fchaReservada, fchaAgendada, descripcion, idVehiculo, idMecanico, Costo, Tipo from Reparacion
where Tipo ='Reparado'


END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacionReparEnRep]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtReparacionReparEnRep]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select[id],fchaEntrada, fchaReservada, fchaAgendada, descripcion, idVehiculo, idMecanico, Tipo from Reparacion
where Tipo ='En Reparacion'


END
GO
/****** Object:  StoredProcedure [dbo].[ObtReparacionReparFch]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[ObtReparacionReparFch]
	-- Add the parameters for the stored procedure here
	@fchaI varchar(20),
	@fchaF varchar(20)

AS
BEGIN

select[id],fchaEntrada,fchaSalida, horas,fchaReservada, fchaAgendada, descripcion, idVehiculo, idMecanico, Costo, Tipo from Reparacion
where Tipo ='Reparado' and fchaSalida between @fchaI and @fchaF


END
GO
/****** Object:  StoredProcedure [dbo].[ObtRepuesto]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[ObtRepuesto]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select[id],nombre ,[descripcion],[tipo],[costo], stock from Repuesto


END
GO
/****** Object:  StoredProcedure [dbo].[ObtRepuestoORD]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[ObtRepuestoORD]
	-- Add the parameters for the stored procedure here


AS
BEGIN

select R.id, R.Nombre, R.descripcion, R.tipo, R.costo, R.stock from Repuesto R inner join Reparacion_Repuesto RR on  R.id = RR.idRepuesto
	Group by R.id, R.Nombre, R.descripcion, R.tipo, R.costo, R.stock
	order by sum(RR.cantidad) desc

END
GO
/****** Object:  StoredProcedure [dbo].[ObtVehiculo]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ObtVehiculo]

AS
BEGIN
	 SELECT  [id]
      ,[Matricula]
      ,[Marca]
      ,[Modelo]
      ,[Anio]
      ,[Color]
	  ,[idCli]
  
  FROM [obligatorioProg].[dbo].[Vehiculo]

END
GO
/****** Object:  StoredProcedure [dbo].[VehRepDeUnCli]    Script Date: 08/07/2022 22:06:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[VehRepDeUnCli]
	-- Add the parameters for the stored procedure here
	 @idCli int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT R.fchaSalida ,V.Matricula, V.Modelo,  R.Costo  from Vehiculo V inner join Reparacion R on 
	R.idVehiculo = V.id 
	Where V.idCli = @idCli and R.Tipo = 'Reparado'
	Order by R.fchaSalida 
END
GO
USE [master]
GO
ALTER DATABASE [obligatorioProg] SET  READ_WRITE 
GO
