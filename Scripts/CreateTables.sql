use master
go
CREATE DATABASE [VuelosDb]
go
use VuelosDb
go
GO
IF OBJECT_ID('dbo.Vuelo', 'U') IS NOT NULL drop table Vuelo       ;
GO
IF OBJECT_ID('dbo.Itinerario', 'U') IS NOT NULL drop table Itinerario  ;
GO
IF OBJECT_ID('dbo.Pista', 'U') IS NOT NULL drop table Pista		  ;
GO
IF OBJECT_ID('dbo.Aeronave', 'U') IS NOT NULL drop table Aeronave	  ;
GO
IF OBJECT_ID('dbo.Lugar', 'U') IS NOT NULL drop table Lugar		  ;
GO
IF OBJECT_ID('dbo.Tripulacion', 'U') IS NOT NULL drop table Tripulacion ;
GO
IF OBJECT_ID('dbo.Tripulante', 'U') IS NOT NULL drop table Tripulante  ;
GO
IF OBJECT_ID('dbo.Cargo', 'U') IS NOT NULL drop table Cargo		  ;
GO
IF OBJECT_ID('dbo.Aeropuerto', 'U') IS NOT NULL drop table Aeropuerto  ;
GO
IF OBJECT_ID('dbo.Localidad', 'U') IS NOT NULL drop table Localidad	  ;
GO


/****** Object:  Table [dbo].[Aeronave]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeronave](
	[IdAeronave] [uniqueidentifier] NOT NULL,
	[Estado] [varchar](50) NULL,
	[NroAsientos] [int] NULL,
	[Marca] [varchar](50) NULL,
	[Modelo] [varchar](50) NULL,
	[CapacidadCarga] [decimal](18, 2) NULL,
	[CapacidadTanque] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Aeronave] PRIMARY KEY CLUSTERED 
(
	[IdAeronave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Aeropuerto]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aeropuerto](
	[IdAeropuerto] [uniqueidentifier] NOT NULL,
	[IdLugar] [uniqueidentifier] NULL,
	[SecuenciaVuelo] [int] NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Aeropuerto] PRIMARY KEY CLUSTERED 
(
	[IdAeropuerto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[IdCargo] [uniqueidentifier] NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[IdCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Itinerario]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Itinerario](
	[IdItinerario] [uniqueidentifier] NOT NULL,
	[IdPista] [uniqueidentifier] NULL,
	[IdAeronave] [uniqueidentifier] NULL,
	[NroVuelo] int NULL,
	[FechaHoraDesde] [datetime] NULL,
	[FechaHoraHasta] [datetime] NULL,
 CONSTRAINT [PK_Itinerario] PRIMARY KEY CLUSTERED 
(
	[IdItinerario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[IdLocalidad] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[IdLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[IdLugar] [uniqueidentifier] NOT NULL,
	[IdLocalidad] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Lugar] PRIMARY KEY CLUSTERED 
(
	[IdLugar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pista]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pista](
	[IdPista] [uniqueidentifier] NOT NULL,
	[IdAeropuerto] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Pista] PRIMARY KEY CLUSTERED 
(
	[IdPista] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tripulacion]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tripulacion](
	[IdTripulacion] [uniqueidentifier] NOT NULL,
	[IdVuelo] [uniqueidentifier] NOT NULL,
	[IdCargo] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Tripulacion] PRIMARY KEY CLUSTERED 
(
	[IdTripulacion] ASC,
	[IdVuelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tripulante]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tripulante](
	[IdTripulante] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[MillasVuelo] [decimal](18, 2) NULL,
	[HorasVuelo] [int] NULL,
 CONSTRAINT [PK_Tripulante] PRIMARY KEY CLUSTERED 
(
	[IdTripulante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vuelo]    Script Date: 1/7/2022 22:34:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vuelo](
	[IdVuelo] [uniqueidentifier] NULL,
	[IdLugarOrigen] [uniqueidentifier] NULL,
	[IdLugarDestino] [uniqueidentifier] NULL,
	[IdItinerario] [uniqueidentifier] NULL,
	[FechaHoraPartida] [datetime] NULL,
	[FechaHoraLlegada] [datetime] NULL,
	[TipoVuelo] [varchar](10) NULL,
	[MilasVuelo] [decimal](18, 2) NULL,
	[TiempoVuelo] [int] NULL
) ON [PRIMARY]
GO
