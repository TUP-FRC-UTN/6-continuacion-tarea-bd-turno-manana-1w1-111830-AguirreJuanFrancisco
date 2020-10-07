USE [master]
GO
/****** Object:  Database [TUP_PII_2020]    Script Date: 9/26/2020 9:54:56 AM ******/
CREATE DATABASE [TUP_PII_2020]
 CONTAINMENT = NONE

GO
ALTER DATABASE [TUP_PII_2020] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TUP_PII_2020].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TUP_PII_2020] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET ARITHABORT OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TUP_PII_2020] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TUP_PII_2020] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TUP_PII_2020] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TUP_PII_2020] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TUP_PII_2020] SET  MULTI_USER 
GO
ALTER DATABASE [TUP_PII_2020] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TUP_PII_2020] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TUP_PII_2020] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TUP_PII_2020] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TUP_PII_2020] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TUP_PII_2020] SET QUERY_STORE = OFF
GO
USE [TUP_PII_2020]
GO
/****** Object:  User [tup_2020]    Script Date: 9/26/2020 9:54:56 AM ******/
CREATE USER [tup_2020] FOR LOGIN [tup_2020] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [tup_2020]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 9/26/2020 9:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[apellido] [varchar](50) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[tipo_documento] [int] NOT NULL,
	[documento] [int] NOT NULL,
	[tipo_estado_civil] [int] NOT NULL,
 CONSTRAINT [PK_personas] PRIMARY KEY CLUSTERED 
(
	[documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_documento]    Script Date: 9/26/2020 9:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_documento](
	[id_tipo_documento] [int] IDENTITY(1,1) NOT NULL,
	[n_tipo_documento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_documento] PRIMARY KEY CLUSTERED 
(
	[id_tipo_documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_estado_civil]    Script Date: 9/26/2020 9:54:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_estado_civil](
	[id_estado_civil] [int] IDENTITY(1,1) NOT NULL,
	[n_estado_civil] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_estado_civil] PRIMARY KEY CLUSTERED 
(
	[id_estado_civil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [tipo_estado_civil]) VALUES (N'GIGENA', N'VALERIA', 1, 13, 1)
INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [tipo_estado_civil]) VALUES (N'DAMIANO', N'LUIS', 1, 14, 2)
INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [tipo_estado_civil]) VALUES (N'PEREZ', N'ANA', 4, 123, 5)
INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [tipo_estado_civil]) VALUES (N'LOPEZ', N'JUAN', 5, 987, 3)
INSERT [dbo].[personas] ([apellido], [nombres], [tipo_documento], [documento], [tipo_estado_civil]) VALUES (N'COSME', N'FULANITO', 2, 12345, 4)
SET IDENTITY_INSERT [dbo].[tipo_documento] ON 

INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (1, N'DNI')
INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (2, N'LE')
INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (3, N'LC')
INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (4, N'CEDULA')
INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (5, N'PASAPORTE')
INSERT [dbo].[tipo_documento] ([id_tipo_documento], [n_tipo_documento]) VALUES (6, N'S/D')
SET IDENTITY_INSERT [dbo].[tipo_documento] OFF
SET IDENTITY_INSERT [dbo].[tipo_estado_civil] ON 

INSERT [dbo].[tipo_estado_civil] ([id_estado_civil], [n_estado_civil]) VALUES (1, N'SOLTERO')
INSERT [dbo].[tipo_estado_civil] ([id_estado_civil], [n_estado_civil]) VALUES (2, N'CASADO')
INSERT [dbo].[tipo_estado_civil] ([id_estado_civil], [n_estado_civil]) VALUES (3, N'DIVORCIADO')
INSERT [dbo].[tipo_estado_civil] ([id_estado_civil], [n_estado_civil]) VALUES (4, N'VIUDO')
INSERT [dbo].[tipo_estado_civil] ([id_estado_civil], [n_estado_civil]) VALUES (5, N'SEPARADO')
SET IDENTITY_INSERT [dbo].[tipo_estado_civil] OFF
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_tipo_documento] FOREIGN KEY([tipo_documento])
REFERENCES [dbo].[tipo_documento] ([id_tipo_documento])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_tipo_documento]
GO
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_personas_tipo_estado_civil] FOREIGN KEY([tipo_estado_civil])
REFERENCES [dbo].[tipo_estado_civil] ([id_estado_civil])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_personas_tipo_estado_civil]
GO
USE [master]
GO
ALTER DATABASE [TUP_PII_2020] SET  READ_WRITE 
GO
