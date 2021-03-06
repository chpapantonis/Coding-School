USE [master]
GO
/****** Object:  Database [CrowdFunding]    Script Date: 5/11/2016 11:10:22 μμ ******/
CREATE DATABASE [CrowdFunding]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CrowdFunding', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS03\MSSQL\DATA\CrowdFunding.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CrowdFunding_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS03\MSSQL\DATA\CrowdFunding_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CrowdFunding] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CrowdFunding].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CrowdFunding] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CrowdFunding] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CrowdFunding] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CrowdFunding] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CrowdFunding] SET ARITHABORT OFF 
GO
ALTER DATABASE [CrowdFunding] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CrowdFunding] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CrowdFunding] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CrowdFunding] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CrowdFunding] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CrowdFunding] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CrowdFunding] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CrowdFunding] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CrowdFunding] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CrowdFunding] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CrowdFunding] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CrowdFunding] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CrowdFunding] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CrowdFunding] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CrowdFunding] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CrowdFunding] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CrowdFunding] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CrowdFunding] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CrowdFunding] SET  MULTI_USER 
GO
ALTER DATABASE [CrowdFunding] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CrowdFunding] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CrowdFunding] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CrowdFunding] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CrowdFunding] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CrowdFunding] SET QUERY_STORE = OFF
GO
USE [CrowdFunding]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CrowdFunding]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Project]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatorId] [int] NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Description] [text] NOT NULL,
	[StatusId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[TargetAmount] [decimal](18, 2) NOT NULL,
	[CurrentFundAmount] [decimal](18, 2) NOT NULL,
	[Ratio] [decimal](7, 2) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectStatus]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectStatus](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProjectStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectUpdate]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectUpdate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Text] [nvarchar](500) NOT NULL,
	[DateInserted] [datetime] NOT NULL,
 CONSTRAINT [PK_ProjectUpdate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reward]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reward](
	[Id] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateInserted] [datetime] NOT NULL,
	[Description] [nvarchar](50) NOT NULL,
	[RequiredAmount] [decimal](18, 2) NOT NULL,
	[MaxAvailable] [int] NOT NULL,
	[CurrentAvailable] [int] NOT NULL,
	[IsAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_Reward] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](200) NOT NULL,
	[LastName] [nvarchar](200) NOT NULL,
	[PhotoUrl] [nvarchar](200) NOT NULL,
	[CardNumber] [nvarchar](50) NOT NULL,
	[ExpirationDate] [datetime] NOT NULL,
	[SecurityCode] [smallint] NOT NULL,
	[VerificationGuid] [uniqueidentifier] NULL,
	[IsVerified] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserProjectComment]    Script Date: 5/11/2016 11:10:23 μμ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProjectComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BackerId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Text] [nvarchar](500) NOT NULL,
	[DateInserted] [datetime] NOT NULL,
 CONSTRAINT [PK_UserProjectComment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'Art')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (5, N'Culture')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (4, N'Games')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'History')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Science')
INSERT [dbo].[ProjectStatus] ([Id], [Name]) VALUES (1, N'Created')
INSERT [dbo].[ProjectStatus] ([Id], [Name]) VALUES (5, N'Finished')
INSERT [dbo].[ProjectStatus] ([Id], [Name]) VALUES (3, N'Successful')
INSERT [dbo].[ProjectStatus] ([Id], [Name]) VALUES (4, N'Unsuccessful')
INSERT [dbo].[ProjectStatus] ([Id], [Name]) VALUES (2, N'Verified')
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_Category_Name]    Script Date: 5/11/2016 11:10:23 μμ ******/
ALTER TABLE [dbo].[Category] ADD  CONSTRAINT [UQ_Category_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_ProjectStatus_Name]    Script Date: 5/11/2016 11:10:23 μμ ******/
ALTER TABLE [dbo].[ProjectStatus] ADD  CONSTRAINT [UQ_ProjectStatus_Name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_Reward_ProjectId_Name]    Script Date: 5/11/2016 11:10:23 μμ ******/
ALTER TABLE [dbo].[Reward] ADD  CONSTRAINT [UQ_Reward_ProjectId_Name] UNIQUE NONCLUSTERED 
(
	[ProjectId] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Category]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_ProjectStatus] FOREIGN KEY([StatusId])
REFERENCES [dbo].[ProjectStatus] ([Id])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_ProjectStatus]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_User] FOREIGN KEY([CreatorId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_User]
GO
ALTER TABLE [dbo].[ProjectUpdate]  WITH CHECK ADD  CONSTRAINT [FK_ProjectUpdate_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[ProjectUpdate] CHECK CONSTRAINT [FK_ProjectUpdate_Project]
GO
ALTER TABLE [dbo].[Reward]  WITH CHECK ADD  CONSTRAINT [FK_Reward_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[Reward] CHECK CONSTRAINT [FK_Reward_Project]
GO
ALTER TABLE [dbo].[UserProjectComment]  WITH CHECK ADD  CONSTRAINT [FK_UserProjectComment_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[UserProjectComment] CHECK CONSTRAINT [FK_UserProjectComment_Project]
GO
ALTER TABLE [dbo].[UserProjectComment]  WITH CHECK ADD  CONSTRAINT [FK_UserProjectComment_User] FOREIGN KEY([BackerId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[UserProjectComment] CHECK CONSTRAINT [FK_UserProjectComment_User]
GO
USE [master]
GO
ALTER DATABASE [CrowdFunding] SET  READ_WRITE 
GO
