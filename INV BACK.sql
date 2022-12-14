USE [master]
GO
/****** Object:  Database [INVOICE]    Script Date: 18/09/2021 22:37:39 ******/
CREATE DATABASE [INVOICE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'INVOICE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\INVOICE.mdf' , SIZE = 51200KB , MAXSIZE = 102400KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'INVOICE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\INVOICE_log.ldf' , SIZE = 15360KB , MAXSIZE = 102400KB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [INVOICE] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [INVOICE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [INVOICE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [INVOICE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [INVOICE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [INVOICE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [INVOICE] SET ARITHABORT OFF 
GO
ALTER DATABASE [INVOICE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [INVOICE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [INVOICE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [INVOICE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [INVOICE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [INVOICE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [INVOICE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [INVOICE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [INVOICE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [INVOICE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [INVOICE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [INVOICE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [INVOICE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [INVOICE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [INVOICE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [INVOICE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [INVOICE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [INVOICE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [INVOICE] SET  MULTI_USER 
GO
ALTER DATABASE [INVOICE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [INVOICE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [INVOICE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [INVOICE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [INVOICE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [INVOICE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [INVOICE] SET QUERY_STORE = OFF
GO
USE [INVOICE]
GO
/****** Object:  Table [dbo].[creditnote]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[creditnote](
	[creditnoteno] [numeric](9, 0) IDENTITY(11100000,1) NOT NULL,
	[invoiceno] [varchar](50) NULL,
	[dateissued] [date] NULL,
	[amount] [money] NULL,
 CONSTRAINT [PK_creditnote] PRIMARY KEY CLUSTERED 
(
	[creditnoteno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoice_record]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoice_record](
	[invoice_no] [numeric](8, 0) IDENTITY(10000100,1) NOT NULL,
	[date] [date] NULL,
	[company_name1] [varchar](50) NULL,
	[net_amount] [money] NULL,
	[Tax] [money] NULL,
	[balance_remaining] [money] NULL,
	[duedate] [date] NULL,
 CONSTRAINT [PK_invoice_record] PRIMARY KEY CLUSTERED 
(
	[invoice_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[sku] [nvarchar](25) NOT NULL,
	[product_name] [nvarchar](75) NOT NULL,
	[brand] [varchar](30) NULL,
	[costprice] [money] NULL,
	[tax] [money] NULL,
	[sellingprice] [money] NULL,
	[stock] [numeric](3, 0) NULL,
 CONSTRAINT [PK_product_1] PRIMARY KEY CLUSTERED 
(
	[sku] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[productsale]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[productsale](
	[date] [date] NOT NULL,
	[sku] [nvarchar](25) NOT NULL,
	[product_name] [nvarchar](75) NULL,
	[quantity] [int] NULL,
	[salesid] [numeric](5, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchase]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchase](
	[deliveryid] [numeric](6, 0) IDENTITY(1,1) NOT NULL,
	[date] [varchar](10) NULL,
	[productreceived] [varchar](75) NULL,
	[quantityreceived] [numeric](3, 0) NULL,
	[supplier] [varchar](20) NULL,
	[cost_taxincluded] [money] NULL,
	[tax] [money] NULL,
 CONSTRAINT [PK_purchase] PRIMARY KEY CLUSTERED 
(
	[deliveryid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receipt]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receipt](
	[receipt_no] [int] IDENTITY(1100000000,1) NOT NULL,
	[invoice_no1] [varchar](15) NOT NULL,
	[date_paid] [date] NOT NULL,
	[amt_paid] [money] NOT NULL,
	[means] [varchar](50) NULL,
	[depoDate] [date] NULL,
	[chequeNo] [varchar](50) NULL,
 CONSTRAINT [PK_receipt] PRIMARY KEY CLUSTERED 
(
	[receipt_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reserve]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reserve](
	[reservationID] [numeric](3, 0) IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[deposit] [money] NULL,
	[remainingbal] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[saleID] [numeric](5, 0) IDENTITY(10000,1) NOT NULL,
	[date] [date] NOT NULL,
	[customer] [varchar](75) NULL,
	[products_sold] [varchar](750) NULL,
	[netamount] [money] NULL,
	[taxamount] [nchar](10) NULL,
	[discount] [nchar](10) NULL,
	[margin] [money] NULL,
	[salesperson] [nchar](20) NULL,
	[paymentmethod] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[SupplierName] [varchar](50) NOT NULL,
	[Contact] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[total]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[total](
	[total] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[name] [varchar](25) NOT NULL,
	[password] [varchar](15) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[product] ([sku], [product_name], [brand], [costprice], [tax], [sellingprice], [stock]) VALUES (N'asd', N's', N'ed', 1.0000, 1.0000, 1.0000, CAST(1 AS Numeric(3, 0)))
GO
INSERT [dbo].[productsale] ([date], [sku], [product_name], [quantity], [salesid]) VALUES (CAST(N'2021-08-09' AS Date), N'-', N'-', 1, CAST(10000 AS Numeric(5, 0)))
INSERT [dbo].[productsale] ([date], [sku], [product_name], [quantity], [salesid]) VALUES (CAST(N'2021-08-09' AS Date), N'300016', N'pgc', 1, CAST(20012 AS Numeric(5, 0)))
GO
SET IDENTITY_INSERT [dbo].[sales] ON 

INSERT [dbo].[sales] ([saleID], [date], [customer], [products_sold], [netamount], [taxamount], [discount], [margin], [salesperson], [paymentmethod]) VALUES (CAST(10000 AS Numeric(5, 0)), CAST(N'2021-08-09' AS Date), N'- vat:- brn:-', N'-(-)X1,-(-)X1,-(-)X1,-(-)X1,-(-)X1,', 6875.0000, N'896.74    ', N'0.00      ', 6875.0000, N'Benazir             ', N'CASH')
SET IDENTITY_INSERT [dbo].[sales] OFF
GO
INSERT [dbo].[supplier] ([SupplierName], [Contact]) VALUES (N'GM PUNJABI', N'-         ')
INSERT [dbo].[supplier] ([SupplierName], [Contact]) VALUES (N'BRIGHT STAR INDUSTRIAL COMPANY LTD', N'-         ')
INSERT [dbo].[supplier] ([SupplierName], [Contact]) VALUES (N'AYOOB CASSIM', N'-         ')
INSERT [dbo].[supplier] ([SupplierName], [Contact]) VALUES (N'QIP', N'-         ')
GO
INSERT [dbo].[total] ([total]) VALUES (958202.0200)
GO
INSERT [dbo].[Users] ([name], [password]) VALUES (N'Benazir', N'benazir9436')
INSERT [dbo].[Users] ([name], [password]) VALUES (N'Mohammad', N'mo4567')
INSERT [dbo].[Users] ([name], [password]) VALUES (N'Yousuf', N'whay6932')
INSERT [dbo].[Users] ([name], [password]) VALUES (N'Nizam', N'niz6051')
GO
/****** Object:  StoredProcedure [dbo].[total_sales]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[total_sales]
AS

DECLARE @price money
DECLARE @sum money
set @sum = 0

DECLARE sumsale CURSOR
FOR SELECT net_amount
FROM invoice_record

OPEN sumsale

FETCH NEXT FROM sumsale
INTO @price

WHILE @@FETCH_STATUS=0
BEGIN	
	
	set @sum = @sum + @price

	FETCH NEXT FROM sumsale
	INTO @price
END

UPDATE total
SET total = @sum
WHERE total != @sum

CLOSE sumsale
DEALLOCATE sumsale;

GO
/****** Object:  StoredProcedure [dbo].[total_sales_byclient]    Script Date: 18/09/2021 22:37:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[total_sales_byclient] @companyname varchar(50)
AS

DECLARE @price money
DECLARE @sum money
set @sum = 0

DECLARE sumsale CURSOR
FOR SELECT net_amount
FROM invoice_record
WHERE company_name1 = @companyname

OPEN sumsale

FETCH NEXT FROM sumsale
INTO @price

WHILE @@FETCH_STATUS=0
BEGIN	
	
	set @sum = @sum + @price

	FETCH NEXT FROM sumsale
	INTO @price
END

UPDATE total
SET total = @sum
WHERE total != @sum

CLOSE sumsale
DEALLOCATE sumsale;

GO
USE [master]
GO
ALTER DATABASE [INVOICE] SET  READ_WRITE 
GO
