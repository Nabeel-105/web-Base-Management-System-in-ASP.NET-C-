USE [master]
GO
/****** Object:  Database [db_ofc]    Script Date: 6/8/2020 11:04:15 PM ******/
CREATE DATABASE [db_ofc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_ofc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_ofc.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_ofc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\db_ofc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_ofc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_ofc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_ofc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_ofc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_ofc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_ofc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_ofc] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_ofc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_ofc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_ofc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_ofc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_ofc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_ofc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_ofc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_ofc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_ofc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_ofc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_ofc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_ofc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_ofc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_ofc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_ofc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_ofc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_ofc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_ofc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_ofc] SET  MULTI_USER 
GO
ALTER DATABASE [db_ofc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_ofc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_ofc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_ofc] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_ofc] SET DELAYED_DURABILITY = DISABLED 
GO
USE [db_ofc]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[c_id] [varchar](50) NOT NULL,
	[c_name] [varchar](50) NOT NULL,
	[cell] [varchar](50) NOT NULL,
	[no_item] [varchar](50) NOT NULL,
	[t_bill] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[empid] [varchar](12) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[cell] [varchar](11) NOT NULL,
	[address] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[pid] [varchar](10) NOT NULL,
	[title] [varchar](20) NOT NULL,
	[price] [varchar](50) NOT NULL,
	[stock] [varchar](50) NOT NULL,
	[Expiry] [varchar](50) NOT NULL,
	[Manuf] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Registeration]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registeration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[cpassword] [varchar](50) NOT NULL,
	[acesslevel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Registeration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[recipt_no] [nchar](10) NULL,
	[p_name] [nchar](10) NULL,
	[price] [nchar](10) NULL,
	[quantity] [nchar](10) NULL,
	[date] [nchar](10) NULL,
	[sold_by] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[s_id] [varchar](50) NOT NULL,
	[s_name] [varchar](50) NOT NULL,
	[cell] [varchar](50) NOT NULL,
	[item_supply] [varchar](50) NOT NULL,
	[name_reciver] [varchar](50) NOT NULL,
	[t_amount] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[SP_empDelete]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_empDelete]

@empid VARCHAR(12)
AS
Delete from Employee  where empid=@empid
return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_empInsert]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[SP_empInsert]

@empid VARCHAR(12),
@name VARCHAR(50),
@cell VARCHAR(11),
@address VARCHAR(50)
AS
INSERT INTO Employee values (@empid,@name,@cell,@address)
return 0
GO
/****** Object:  StoredProcedure [dbo].[SP_empUpdate]    Script Date: 6/8/2020 11:04:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_empUpdate]

@empid VARCHAR(12),
@name VARCHAR(50),
@cell VARCHAR(11),
@address VARCHAR(50)
AS
Update Employee set name=(@name),cell=(@cell),address=(@address) where empid=(@empid)
return 0
GO
USE [master]
GO
ALTER DATABASE [db_ofc] SET  READ_WRITE 
GO
