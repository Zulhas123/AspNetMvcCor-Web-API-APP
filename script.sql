USE [master]
GO
/****** Object:  Database [CarShopDb]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE DATABASE [CarShopDb];
GO
ALTER DATABASE [CarShopDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarShopDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarShopDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarShopDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarShopDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarShopDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarShopDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarShopDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CarShopDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarShopDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarShopDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarShopDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarShopDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarShopDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarShopDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarShopDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarShopDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CarShopDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarShopDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarShopDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarShopDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarShopDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarShopDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarShopDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarShopDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarShopDb] SET  MULTI_USER 
GO
ALTER DATABASE [CarShopDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarShopDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarShopDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarShopDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarShopDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarShopDb] SET QUERY_STORE = OFF
GO
USE [CarShopDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04 03 2020 2:22:13 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[price] [decimal](18, 2) NULL,
	[IsAvailable] [bit] NULL,
	[ImageUrl] [nvarchar](max) NULL,
	[CarTypeId] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarOrder]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderNo] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[OrderDate] [datetime2](7) NULL,
 CONSTRAINT [PK_CarOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarType]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cartype1] [nvarchar](max) NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuHelperModel]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuHelperModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ControllerName] [nvarchar](max) NULL,
	[ActionName] [nvarchar](max) NULL,
	[MenuModelId] [int] NULL,
 CONSTRAINT [PK_MenuHelperModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuModel]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuHelperModelId] [int] NOT NULL,
	[RollId] [nvarchar](max) NULL,
	[RollIdText] [nvarchar](max) NULL,
 CONSTRAINT [PK_MenuModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MenuModelManage]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MenuModelManage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MenuModelId] [int] NOT NULL,
	[Retrive] [bit] NOT NULL,
	[Insert] [bit] NOT NULL,
	[Update] [bit] NOT NULL,
	[Delete] [bit] NOT NULL,
 CONSTRAINT [PK_MenuModelManage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 04 03 2020 2:22:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[QTY] [int] NULL,
	[CarId] [int] NULL,
	[CarOrderId] [int] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200301045135_Asdd', N'2.1.11-servicing-32099')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200304025737_Avc', N'2.1.11-servicing-32099')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e7c3d9b1-6660-4897-bf99-b973bbf2246d', N'Admin2', N'ADMIN2', N'0d5e723f-9741-4883-a43a-eceaa7e7be50')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e90d5cf9-26c7-453f-87b3-2cdcf76d8c0f', N'Staff', N'STAFF', N'c027c199-f16f-418d-9edd-28d5a9b3c2df')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f77ee869-7915-437f-b23c-7ab9babe7fbc', N'officer', N'OFFICER', N'a48f91aa-4af8-4d53-8b61-a1b6902d4770')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b6e82c0d-4094-4ca5-a2d8-aab7e99694da', N'e7c3d9b1-6660-4897-bf99-b973bbf2246d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e1617003-6ae9-497f-b38e-7e1c28635c5b', N'e7c3d9b1-6660-4897-bf99-b973bbf2246d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b6e82c0d-4094-4ca5-a2d8-aab7e99694da', N'e90d5cf9-26c7-453f-87b3-2cdcf76d8c0f')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'b6e82c0d-4094-4ca5-a2d8-aab7e99694da', N'b@gmail.com', N'B@GMAIL.COM', N'b@gmail.com', N'B@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELIjBL3ySJCpfpa90X/XaSyYTWL2mufdCYCp2zwcNpwkYl8XrLsmN9AxQ/MbMM3sKg==', N'ZDGRABZM5WVFDLWU3QJSGDL4UBEFIYYS', N'156fc0a7-2604-44ca-be53-ad2cf6d113cd', NULL, 0, 0, NULL, 1, 0, N'b', N'b')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'bed31e78-18cb-41dd-a2c3-e5fa095251a7', N'Robiul@gmail.com', N'ROBIUL@GMAIL.COM', N'Robiul@gmail.com', N'ROBIUL@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJkIBVtKtV3U6wAm/fRI+RYVEYwJjcbxhqB89dgtGQRQY5WwF6QTGG/4GgVbkQQ/LA==', N'NEVTE7L64F2GLC2SXIXVVG6V4U4D7WZ6', N'873bc3f5-ca4a-443a-83ec-98486baccc8b', NULL, 0, 0, NULL, 1, 0, N'Robiul', N'Hassan')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'cb64bba7-353a-48c7-8615-47c8f22e1a26', N'Zulhas@gmail.com', N'ZULHAS@GMAIL.COM', N'Zulhas@gmail.com', N'ZULHAS@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEMvaKWVoFvFIf4nYpSf9WDuhHiUVZOLAb6cyLdan2tkG6t9WJx0mJHCB1UIdcblHpg==', N'K3NKV4LLYEXISAEHMM6NGPRVO7ONXLVG', N'118af506-452b-4de4-8e81-93a4afa986de', NULL, 0, 0, NULL, 1, 0, N'Zulhas', N'z')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'e1617003-6ae9-497f-b38e-7e1c28635c5b', N'a@gmail.com', N'A@GMAIL.COM', N'a@gmail.com', N'A@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFyn0uiaUDdx9tV3eSdy5e/n96CQCdh6s57uFeduD/eCSAUkacAD8+mCMQ/Ehmxb6Q==', N'XRTRMOXTIWIWJPXK3747VU2ZJLWYE2VL', N'522df8d5-9fbe-4837-8d97-d11cb41999cf', NULL, 0, 0, NULL, 1, 0, N'a', N'a')
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (1, N'Bus', N'WD_uum', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car2.jpg', 1)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (2, N'Truck', N'WDm', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car1.jpg', 2)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (3, N'Bus', N'WDm', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car3.jpg', 3)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (4, N'PickUp', N'WD_88m', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car6.jpg', 1)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (5, N'Bus', N'WDm', CAST(258887.00 AS Decimal(18, 2)), 1, N'/Image/pic8.jpg', 3)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (6, N'Micro', N'WDm', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car7.jpg', 2)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (7, N'Bus', N'WD__22m', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car8.jpg', 2)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (8, N'Truck', N'WDm', CAST(258887.00 AS Decimal(18, 2)), 1, N'~/Image/Car6.jpg', 1)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (1002, N'Flower444', N'dddd', CAST(2000000.00 AS Decimal(18, 2)), 0, N'/Image/download.jpg', 3)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (1003, N'Bus', N'WW_555', CAST(45876.00 AS Decimal(18, 2)), 0, N'/Image/pic.jpg', 1)
INSERT [dbo].[Car] ([Id], [Name], [Model], [price], [IsAvailable], [ImageUrl], [CarTypeId]) VALUES (1004, N'Flower', N'wwww', CAST(2000000.00 AS Decimal(18, 2)), 1, N'/Image/Car5.jpg', 1)
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[CarOrder] ON 

INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (1, N'101', N'Abir', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (2, N'102', N'Zulhas', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (3, N'103', N'Robiul', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (4, N'103', N'AKram', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (5, N'104', N'Imran', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (6, N'105', N'Monir', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[CarOrder] ([Id], [OrderNo], [Name], [Email], [Address], [OrderDate]) VALUES (7, N'106', N'Joy', N'abir@gmail.com', N'Dahaka', CAST(N'2010-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[CarOrder] OFF
SET IDENTITY_INSERT [dbo].[CarType] ON 

INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1, N'Bus')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (2, N'Truck')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (3, N'pickUp')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (4, N'Micro')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1002, N'asdsdaf')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1003, N'asdsdafsas')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1004, N'Bus1')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1005, N'Bus1')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1006, N'Bus1')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1007, N'Bus1')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1008, N'Truck')
INSERT [dbo].[CarType] ([Id], [Cartype1]) VALUES (1009, N'pickUp')
SET IDENTITY_INSERT [dbo].[CarType] OFF
SET IDENTITY_INSERT [dbo].[MenuHelperModel] ON 

INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (1, N'Cars', N'Index', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (2, N'Cars', N'Index', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (3, N'CarTypes', N'Index', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (4, N'CarOrders', N'Index', NULL)
INSERT [dbo].[MenuHelperModel] ([Id], [ControllerName], [ActionName], [MenuModelId]) VALUES (5, N'OrderDetails', N'Index', NULL)
SET IDENTITY_INSERT [dbo].[MenuHelperModel] OFF
SET IDENTITY_INSERT [dbo].[MenuModel] ON 

INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (1, 0, N'e7c3d9b1-6660-4897-bf99-b973bbf2246d', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (2, 0, N'e7c3d9b1-6660-4897-bf99-b973bbf2246d', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (3, 1, N'e7c3d9b1-6660-4897-bf99-b973bbf2246d', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (4, 1, N'e7c3d9b1-6660-4897-bf99-b973bbf2246d', NULL)
INSERT [dbo].[MenuModel] ([Id], [MenuHelperModelId], [RollId], [RollIdText]) VALUES (1002, 4, N'e90d5cf9-26c7-453f-87b3-2cdcf76d8c0f', NULL)
SET IDENTITY_INSERT [dbo].[MenuModel] OFF
SET IDENTITY_INSERT [dbo].[MenuModelManage] ON 

INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (1006, 3, 0, 1, 0, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (1007, 4, 0, 0, 1, 0)
INSERT [dbo].[MenuModelManage] ([Id], [MenuModelId], [Retrive], [Insert], [Update], [Delete]) VALUES (1008, 1002, 1, 0, 1, 0)
SET IDENTITY_INSERT [dbo].[MenuModelManage] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (4, 4, 1, 1)
INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (5, 7, 2, 6)
INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (6, 3, 1, 1)
INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (7, 9, 5, 7)
INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (8, 5, 3, 1)
INSERT [dbo].[OrderDetail] ([Id], [QTY], [CarId], [CarOrderId]) VALUES (9, 4, 1, 5)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Car_CarTypeId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_Car_CarTypeId] ON [dbo].[Car]
(
	[CarTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MenuHelperModel_MenuModelId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_MenuHelperModel_MenuModelId] ON [dbo].[MenuHelperModel]
(
	[MenuModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MenuModelManage_MenuModelId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_MenuModelManage_MenuModelId] ON [dbo].[MenuModelManage]
(
	[MenuModelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_CarId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_CarId] ON [dbo].[OrderDetail]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetail_CarOrderId]    Script Date: 04 03 2020 2:22:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetail_CarOrderId] ON [dbo].[OrderDetail]
(
	[CarOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarType_CarTypeId] FOREIGN KEY([CarTypeId])
REFERENCES [dbo].[CarType] ([Id])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarType_CarTypeId]
GO
ALTER TABLE [dbo].[MenuHelperModel]  WITH CHECK ADD  CONSTRAINT [FK_MenuHelperModel_MenuModel_MenuModelId] FOREIGN KEY([MenuModelId])
REFERENCES [dbo].[MenuModel] ([Id])
GO
ALTER TABLE [dbo].[MenuHelperModel] CHECK CONSTRAINT [FK_MenuHelperModel_MenuModel_MenuModelId]
GO
ALTER TABLE [dbo].[MenuModelManage]  WITH CHECK ADD  CONSTRAINT [FK_MenuModelManage_MenuModel_MenuModelId] FOREIGN KEY([MenuModelId])
REFERENCES [dbo].[MenuModel] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MenuModelManage] CHECK CONSTRAINT [FK_MenuModelManage_MenuModel_MenuModelId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Car_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Car_CarId]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_CarOrder_CarOrderId] FOREIGN KEY([CarOrderId])
REFERENCES [dbo].[CarOrder] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_CarOrder_CarOrderId]
GO
USE [master]
GO
ALTER DATABASE [CarShopDb] SET  READ_WRITE 
GO
