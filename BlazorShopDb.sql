USE [master]
GO
/****** Object:  Database [BlazorShopDb]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE DATABASE [BlazorShopDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BlazorShopDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BlazorShopDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BlazorShopDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BlazorShopDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BlazorShopDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlazorShopDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlazorShopDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BlazorShopDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BlazorShopDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BlazorShopDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BlazorShopDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BlazorShopDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BlazorShopDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BlazorShopDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BlazorShopDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BlazorShopDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BlazorShopDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BlazorShopDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BlazorShopDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BlazorShopDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BlazorShopDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BlazorShopDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BlazorShopDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BlazorShopDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BlazorShopDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BlazorShopDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BlazorShopDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BlazorShopDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BlazorShopDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BlazorShopDb] SET  MULTI_USER 
GO
ALTER DATABASE [BlazorShopDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BlazorShopDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BlazorShopDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BlazorShopDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BlazorShopDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BlazorShopDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BlazorShopDb] SET QUERY_STORE = OFF
GO
USE [BlazorShopDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/25/2022 2:56:53 AM ******/
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
/****** Object:  Table [dbo].[Addresses]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
	[Country] [nvarchar](255) NOT NULL,
	[State] [nvarchar](255) NOT NULL,
	[City] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](1000) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 5/25/2022 2:56:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 5/25/2022 2:56:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 5/25/2022 2:56:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 5/25/2022 2:56:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 5/25/2022 2:56:53 AM ******/
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
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 5/25/2022 2:56:53 AM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [nvarchar](450) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[DeliveryAddressId] [int] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersProducts]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersProducts](
	[OrderId] [nvarchar](450) NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrdersProducts] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[ImageSource] [nvarchar](2048) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCarts]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCarts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_ShoppingCarts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCartsProducts]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCartsProducts](
	[ShoppingCartId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_ShoppingCartsProducts] PRIMARY KEY CLUSTERED 
(
	[ShoppingCartId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wishlists]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wishlists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_Wishlists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WishlistsProducts]    Script Date: 5/25/2022 2:56:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WishlistsProducts](
	[WishlistId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[ModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_WishlistsProducts] PRIMARY KEY CLUSTERED 
(
	[WishlistId] ASC,
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Addresses_IsDeleted]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_IsDeleted] ON [dbo].[Addresses]
(
	[IsDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Addresses_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Addresses_UserId] ON [dbo].[Addresses]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUsers_IsDeleted]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUsers_IsDeleted] ON [dbo].[AspNetUsers]
(
	[IsDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categories_IsDeleted]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Categories_IsDeleted] ON [dbo].[Categories]
(
	[IsDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_DeliveryAddressId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_DeliveryAddressId] ON [dbo].[Orders]
(
	[DeliveryAddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_UserId] ON [dbo].[Orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrdersProducts_ProductId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrdersProducts_ProductId] ON [dbo].[OrdersProducts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_IsDeleted]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_IsDeleted] ON [dbo].[Products]
(
	[IsDeleted] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_ShoppingCarts_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_ShoppingCarts_UserId] ON [dbo].[ShoppingCarts]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ShoppingCartsProducts_ProductId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_ShoppingCartsProducts_ProductId] ON [dbo].[ShoppingCartsProducts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Wishlists_UserId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_Wishlists_UserId] ON [dbo].[Wishlists]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_WishlistsProducts_ProductId]    Script Date: 5/25/2022 2:56:53 AM ******/
CREATE NONCLUSTERED INDEX [IX_WishlistsProducts_ProductId] ON [dbo].[WishlistsProducts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD  CONSTRAINT [FK_Addresses_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Addresses] CHECK CONSTRAINT [FK_Addresses_AspNetUsers_UserId]
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
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Addresses_DeliveryAddressId] FOREIGN KEY([DeliveryAddressId])
REFERENCES [dbo].[Addresses] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Addresses_DeliveryAddressId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[OrdersProducts]  WITH CHECK ADD  CONSTRAINT [FK_OrdersProducts_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[OrdersProducts] CHECK CONSTRAINT [FK_OrdersProducts_Orders_OrderId]
GO
ALTER TABLE [dbo].[OrdersProducts]  WITH CHECK ADD  CONSTRAINT [FK_OrdersProducts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrdersProducts] CHECK CONSTRAINT [FK_OrdersProducts_Products_ProductId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryId]
GO
ALTER TABLE [dbo].[ShoppingCarts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarts_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[ShoppingCarts] CHECK CONSTRAINT [FK_ShoppingCarts_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ShoppingCartsProducts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCartsProducts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShoppingCartsProducts] CHECK CONSTRAINT [FK_ShoppingCartsProducts_Products_ProductId]
GO
ALTER TABLE [dbo].[ShoppingCartsProducts]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCartsProducts_ShoppingCarts_ShoppingCartId] FOREIGN KEY([ShoppingCartId])
REFERENCES [dbo].[ShoppingCarts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShoppingCartsProducts] CHECK CONSTRAINT [FK_ShoppingCartsProducts_ShoppingCarts_ShoppingCartId]
GO
ALTER TABLE [dbo].[Wishlists]  WITH CHECK ADD  CONSTRAINT [FK_Wishlists_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Wishlists] CHECK CONSTRAINT [FK_Wishlists_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[WishlistsProducts]  WITH CHECK ADD  CONSTRAINT [FK_WishlistsProducts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WishlistsProducts] CHECK CONSTRAINT [FK_WishlistsProducts_Products_ProductId]
GO
ALTER TABLE [dbo].[WishlistsProducts]  WITH CHECK ADD  CONSTRAINT [FK_WishlistsProducts_Wishlists_WishlistId] FOREIGN KEY([WishlistId])
REFERENCES [dbo].[Wishlists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WishlistsProducts] CHECK CONSTRAINT [FK_WishlistsProducts_Wishlists_WishlistId]
GO
USE [master]
GO
ALTER DATABASE [BlazorShopDb] SET  READ_WRITE 
GO

USE [BlazorShopDb]
GO

INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Fruit')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Roots')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Seeds')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Flower')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Fungi')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Tuber')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Bulbs')
GO
INSERT INTO [dbo].[Categories]([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name]) VALUES (GETDATE(),GETDATE(),0,NULL,'Leaves')
GO

INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Okra','Okra is a good source of dietary fibre, vitamin C and folate, a source of niacin, magnesium and manganese, and and contains a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/okra.png',100,12,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Cucumber','Lebanese cucumbers provide almost twice the amount of vitamin C and vitamin A compared to other varieties. Peeling cucumbers reduces the dietary fibre content slightly. Cucumbers have a high water content.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/cucumber.png',100,9,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Artichokes','Globe artichokes are a good source of dietary fibre and folate; a source of biotin, niacin, vitamin C and magnesium and contain a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/artichokes-globe.png',100,14,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Chokos','Chokos are a good source of vitamin C, and a source of folate, pantothenic acid and vitamin E.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/chokos.png',100,11,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Tomato','Tomatoes are a good source of vitamin C and a source of vitamin A (from beta-carotene) and contain a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/tomatoes.png',100,7,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Chilli peppers','Hot','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/chili.png',100,7,1)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Carrot','Carrots are a good source of vitamin A, from carotenoids, in particular beta-carotene, which is converted to vitamin A by the body.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/carrots.png',100,10,2)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Ginger','For most people ginger is eaten only in small quantities so may be considered more important for its flavour than nutritional value.' ,'https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/ginger.png',100,8,2)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Beetroot','Beetroot is a good source of vitamin B6, a source of dietary fibre, folate, niacin, thiamin and vitamin C and contains a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/beetroot.png',100,16,2)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Sweet corn','Sweet corn is a good source of carbohydrate and contains a range of nutrients, especially B group vitamins. It is a good source of dietary fibre, folate and niacin; a source of riboflavin, thiamin, vitamin B6, vitamin C, magnesium, phosphorus and zinc, and contains a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/sweet-corn.png',100,11,3)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Broccoli','Broccoli is a good source of vitamin C, and one serving [1 cup] easily provides an adult`s vitamin C requirements for a day.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/broccoli.png',100,15,4)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Cauliflower','Cauliflower is a good source of vitamin C, a source of dietary fibre, folate and vitamin B6, and contains a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/cauliflower.png',100,21,4)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Mushrooms','Mushrooms are a good source of biotin and pantothenic acid, a source of dietary fibre, niacin, riboflavin, vitamin B6, copper, phosphorus and selenium, and contain a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/mushrooms.png',100,23,5)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Potato','As potatoes are eaten so frequently in meals of New Zealanders they are an important source of nutrients in the diet.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/potatoes.png',100,12,6)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Taro','Taro is high in carbohydrate, greater than potato, and consequently one of the highest vegetable sources of energy.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/taro.png',100,16,6)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Garlic','For most people garlic is eaten only in small quantities. Garlic contributes to the flavour of many dishes rather than making a nutritional contribution.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/garlic.png',100,4,7)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Leeks','Leeks are a good source of folate, a source of dietary fibre, thiamin, vitamin B6, vitamin C, and contain a dietary significant amount of potassium. They contain phytonutrients, including carotenoids and phenolic compounds.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/leeks.png',100,5,7)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Onion','New Zealanders are frequent consumers of onions. Onions are not rich in the common nutrients but are low in energy. However, onions are rich in phytonutrients – flavonoids, fructans, saponins and sulphur containing compounds. The red varieties are a source of the flavonoids, anthocyanins.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/onions.png',100,6,7)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Spring onion','Spring onions are a source of folate. Flavonoids, carotenoids and some sulphur compounds are the phytonutrients found in spring onions.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/spring-onions.png',100,4,7)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Shallot','Shallots have a more delicate, sweeter taste and finer texture than onions.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/shallots2.png',100,2,7)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Silverbeet','Silverbeet is a source of vitamin A (from beta-carotene), folate and vitamin K, and contains a dietary significant amount of potassium. Phytonutrients abound in silverbeet including carotenoids (lutein and zeaxanthin) and some flavonoids.','https://www.vegetables.co.nz/assets/_resampled/FillWyI0MDAiLCIzMDAiXQ/453~Silver-Beet-57691.jpg',100,7,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Cabbage','Cabbages (white/green) are a good source of vitamin C, a source of vitamin K, and contain a dietary significant amount of potassium.','https://www.vegetables.co.nz/assets/_resampled/FillWyI0MDAiLCIzMDAiXQ/100~Cabbage-Savoy-Head-57593.jpg',100,7,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Spinach','Spinach deserves its reputation as a health enhancing vegetable, being a good source of both nutrients and phytonutrients.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/spinach2.png',100,5,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Salad green','Salad greens have a similar nutritional content to lettuce, however, varieties such as rocket are richer in vitamin A (from beta-carotene).','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/salad-greens.png',100,3,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Witloof','Witloof is a source of folate, dietary fibre and vitamin C.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/witloof.png',100,2,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Lettuce','While lettuce contains mainly water (95%) this is an advantage in that it provides hydration and is a low energy food.','https://www.vegetables.co.nz/assets/_resampled/FillWyI0MDAiLCIzMDAiXQ/598~Lettuce-Butterhead-Buttercrunch-57826.jpg',100,1,8)
GO
INSERT INTO [dbo].[Products] ([CreatedOn],[ModifiedOn],[IsDeleted],[DeletedOn],[Name],[Description],[ImageSource],[Quantity],[Price],[CategoryId])
 VALUES (GETDATE(),GETDATE(),0,NULL,'Watercress','Watercress is a good source of folate, vitamin C and vitamin A (from beta-carotene). Glucosinolates are the phytonutrients plentiful in watercress.','https://www.vegetables.co.nz/assets/vegetables/_resampled/FillWyI0MDAiLCIzMDAiXQ/watercress.png',100,10,8)
GO

