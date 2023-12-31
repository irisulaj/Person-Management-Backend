USE [master]
GO
/****** Object:  Database [PersonManagement]    Script Date: 9/27/2023 9:07:27 PM ******/
CREATE DATABASE [PersonManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PersonManagement', FILENAME = N'/var/opt/mssql/data/PersonManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PersonManagement_log', FILENAME = N'/var/opt/mssql/data/PersonManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PersonManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PersonManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PersonManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PersonManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PersonManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PersonManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PersonManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [PersonManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PersonManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PersonManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PersonManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PersonManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PersonManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PersonManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PersonManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PersonManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PersonManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PersonManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PersonManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PersonManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PersonManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PersonManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PersonManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PersonManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PersonManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [PersonManagement] SET  MULTI_USER 
GO
ALTER DATABASE [PersonManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PersonManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PersonManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PersonManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PersonManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PersonManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PersonManagement', N'ON'
GO
ALTER DATABASE [PersonManagement] SET QUERY_STORE = OFF
GO
USE [PersonManagement]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/27/2023 9:07:27 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM01_Person]    Script Date: 9/27/2023 9:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM01_Person](
	[Id_person] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[DateofBirth] [datetime] NULL,
	[Phone] [int] NULL,
	[Gender] [char](1) NULL,
	[IsEmployed] [bit] NULL,
	[Id_maritalstatus] [int] NULL,
	[PlaceofBirth] [varchar](50) NULL,
 CONSTRAINT [PK_PM01_Person] PRIMARY KEY CLUSTERED 
(
	[Id_person] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM02_MaritalStatus]    Script Date: 9/27/2023 9:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM02_MaritalStatus](
	[Id_MaritalStatus] [int] IDENTITY(1,1) NOT NULL,
	[MaritalStatus] [varchar](15) NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_PM02_MaritalStatus] PRIMARY KEY CLUSTERED 
(
	[Id_MaritalStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PM03_User]    Script Date: 9/27/2023 9:07:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PM03_User](
	[Id_user] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Surname] [varchar](50) NULL,
	[Username] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Role] [varchar](50) NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PM03_User] PRIMARY KEY CLUSTERED 
(
	[Id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PM03_User] ADD  DEFAULT ('') FOR [Password]
GO
USE [master]
GO
ALTER DATABASE [PersonManagement] SET  READ_WRITE 
GO
