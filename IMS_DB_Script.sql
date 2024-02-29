USE [master]
GO
/****** Object:  Database [IMS_DB]    Script Date: 2/29/2024 10:58:59 PM ******/
CREATE DATABASE [IMS_DB] ON  PRIMARY 
( NAME = N'IMS_DB', FILENAME = N'E:\Databases\IMS_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IMS_DB_log', FILENAME = N'E:\Databases\IMS_DB_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMS_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMS_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IMS_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IMS_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IMS_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IMS_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [IMS_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IMS_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IMS_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IMS_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IMS_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IMS_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IMS_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IMS_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IMS_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IMS_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IMS_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IMS_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IMS_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IMS_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IMS_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IMS_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IMS_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IMS_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [IMS_DB] SET  MULTI_USER 
GO
ALTER DATABASE [IMS_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IMS_DB] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'IMS_DB', N'ON'
GO
USE [IMS_DB]
GO
/****** Object:  Table [dbo].[CATEGORY]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](50) NULL,
	[cat_IsActive] [tinyint] NULL,
 CONSTRAINT [PK_CATEGORY] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTORY_JOURNAL]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTORY_JOURNAL](
	[Inv_Tr_Id] [decimal](10, 0) IDENTITY(1,1) NOT NULL,
	[Inv_Tr_Dt] [date] NULL,
	[Inv_Indent_No] [bigint] NULL,
	[Inv_Code] [varchar](50) NULL,
	[Inv_Name] [varchar](155) NULL,
	[Inv_Desc] [varchar](255) NULL,
	[Inv_Opn_Bal] [decimal](15, 0) NULL,
	[Inv_Receive] [decimal](15, 0) NULL,
	[Inv_Issued] [decimal](15, 0) NULL,
	[Inv_Balance] [decimal](15, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVOICE_ROLES]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVOICE_ROLES](
	[allowId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NULL,
	[suplName] [varchar](50) NULL,
	[suplLocId] [int] NULL,
	[suplnmCd] [varchar](10) NULL,
 CONSTRAINT [PK_INDENT_ROLES] PRIMARY KEY CLUSTERED 
(
	[allowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCATIONS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCATIONS](
	[loc_id] [int] IDENTITY(1,1) NOT NULL,
	[loc_city] [varchar](20) NULL,
	[loc_province] [varchar](20) NULL,
	[loc_Street] [varchar](50) NULL,
 CONSTRAINT [PK_LOCATIONS] PRIMARY KEY CLUSTERED 
(
	[loc_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MANAGERS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MANAGERS](
	[man_id] [int] IDENTITY(1,1) NOT NULL,
	[man_name] [varchar](150) NULL,
	[man_desig] [varchar](50) NULL,
	[man_locId] [int] NULL,
	[man_email] [varchar](50) NULL,
	[man_contact] [varchar](20) NULL,
 CONSTRAINT [PK_MANAGERS] PRIMARY KEY CLUSTERED 
(
	[man_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTS](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_code] [varchar](50) NULL,
	[product_barcode] [varchar](100) NULL,
	[product_name] [varchar](100) NULL,
	[product_unit] [varchar](50) NULL,
	[product_price] [float] NULL,
	[product_qty_unit] [int] NULL,
	[product_quantity] [decimal](18, 0) NULL,
	[product_status] [tinyint] NULL,
	[product_category] [int] NULL,
	[product_min_level] [int] NULL,
 CONSTRAINT [PK_PRODUCTS] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASEINVOICE]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASEINVOICE](
	[PI_AUTO_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PI_ID] [bigint] NOT NULL,
	[PI_SUPL] [varchar](50) NULL,
	[PI_DATE] [date] NULL,
	[PI_USER] [varchar](20) NULL,
 CONSTRAINT [PK_PURCHASEINVOICE] PRIMARY KEY CLUSTERED 
(
	[PI_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASEINVOICEDETAILS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASEINVOICEDETAILS](
	[PID_ID] [bigint] IDENTITY(1,1) NOT NULL,
	[PID_PI] [bigint] NULL,
	[PID_CODE] [varchar](20) NULL,
	[PID_NAME] [varchar](50) NULL,
	[PID_PACKING] [varchar](10) NULL,
	[PID_Q_UNIT] [int] NULL,
	[PID_QUANTITY] [decimal](18, 0) NULL,
	[PID_CATEGORY] [varchar](20) NULL,
	[PID_STATUS] [varchar](10) NULL,
	[PID_DATE] [date] NULL,
 CONSTRAINT [PK_PURCHASEINVOICEDETAILS] PRIMARY KEY CLUSTERED 
(
	[PID_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [varchar](50) NULL,
	[role_description] [varchar](50) NULL,
 CONSTRAINT [PK_ROLES] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_DETAILS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_DETAILS](
	[sale_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[sale_id] [bigint] NULL,
	[sale_item_cd] [varchar](10) NULL,
	[sale_desc] [varchar](100) NULL,
	[sale_packing] [varchar](10) NULL,
	[sale_pack_unit] [int] NULL,
	[sale_qty] [int] NULL,
	[sale_category] [varchar](50) NULL,
	[sale_detail_date] [date] NULL,
	[sale_detail_status] [varchar](10) NULL,
 CONSTRAINT [PK_SALE_DETAILS] PRIMARY KEY CLUSTERED 
(
	[sale_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SALE_MASTER]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SALE_MASTER](
	[sale_id] [bigint] NOT NULL,
	[sale_date] [date] NULL,
	[sale_req_from] [varchar](50) NULL,
	[sale_req_to] [varchar](50) NULL,
	[sale_done_by] [varchar](20) NULL,
	[sale_status] [varchar](10) NULL,
	[sale_final_by] [varchar](50) NULL,
 CONSTRAINT [PK_SALE_MASTER] PRIMARY KEY CLUSTERED 
(
	[sale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECTION_CONSUMPTION]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECTION_CONSUMPTION](
	[Item_Code] [varchar](20) NULL,
	[Item_Desc] [varchar](200) NULL,
	[Item_Pckg] [varchar](10) NULL,
	[Item_Opn_Bal] [decimal](18, 0) NULL,
	[Item_Consumption] [decimal](18, 0) NULL,
	[Item_Balance] [decimal](18, 0) NULL,
	[Item_Upd_dt] [date] NULL,
	[Item_Section] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECTION_STOCK]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECTION_STOCK](
	[Item_Code] [varchar](50) NULL,
	[Item_Desc] [varchar](200) NULL,
	[Item_Pckg] [varchar](50) NULL,
	[Item_Section] [int] NULL,
	[Item_Balance] [decimal](18, 0) NULL,
	[Item_Upd_dt] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECTIONS]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECTIONS](
	[Sec_ID] [int] IDENTITY(1,1) NOT NULL,
	[Sec_Desc] [varchar](100) NULL,
 CONSTRAINT [PK_SECTIONS] PRIMARY KEY CLUSTERED 
(
	[Sec_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STAFF]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STAFF](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](50) NULL,
	[last_name] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[contact] [varchar](50) NULL,
	[address] [varchar](200) NULL,
	[type_id] [int] NULL,
	[role_id] [int] NULL,
	[location_id] [int] NULL,
	[sec_id] [int] NULL,
	[manager_id] [int] NULL,
	[status] [tinyint] NULL,
 CONSTRAINT [PK_STAFF] PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uniqueUser] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK](
	[st_prodId] [varchar](10) NOT NULL,
	[st_quantity] [int] NOT NULL,
 CONSTRAINT [UQ__STOCK__CCE4B7E02AE9D7F7] UNIQUE NONCLUSTERED 
(
	[st_prodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[STOCK_DETAIL_REPORT]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STOCK_DETAIL_REPORT](
	[item_desc] [varchar](255) NULL,
	[item_pack] [varchar](20) NULL,
	[item_category] [int] NULL,
	[unit] [varchar](20) NULL,
	[opening_stock] [decimal](18, 0) NULL,
	[received] [decimal](18, 0) NULL,
	[issued] [decimal](18, 0) NULL,
	[closing_stock] [decimal](18, 0) NULL,
	[current_stock] [decimal](18, 0) NULL,
	[start_date] [date] NULL,
	[end_date] [date] NULL,
	[d1] [int] NULL,
	[d2] [int] NULL,
	[d3] [int] NULL,
	[d4] [int] NULL,
	[d5] [int] NULL,
	[d6] [int] NULL,
	[d7] [int] NULL,
	[d8] [int] NULL,
	[d9] [int] NULL,
	[d10] [int] NULL,
	[d11] [int] NULL,
	[d12] [int] NULL,
	[d13] [int] NULL,
	[d14] [int] NULL,
	[d15] [int] NULL,
	[d16] [int] NULL,
	[d17] [int] NULL,
	[d18] [int] NULL,
	[d19] [int] NULL,
	[d20] [int] NULL,
	[d21] [int] NULL,
	[d22] [int] NULL,
	[d23] [int] NULL,
	[d24] [int] NULL,
	[d25] [int] NULL,
	[d26] [int] NULL,
	[d27] [int] NULL,
	[d28] [int] NULL,
	[d29] [int] NULL,
	[d30] [int] NULL,
	[d31] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUPPLIER]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUPPLIER](
	[supl_id] [int] IDENTITY(1,1) NOT NULL,
	[supl_name] [varchar](50) NULL,
	[supl_company] [varchar](50) NULL,
	[supl_locId] [int] NULL,
	[supl_contact] [varchar](50) NULL,
	[supl_ntn] [varchar](20) NULL,
	[supl_nm_code] [varchar](5) NULL,
	[supl_status] [tinyint] NULL,
 CONSTRAINT [PK_SUPPLIER] PRIMARY KEY CLUSTERED 
(
	[supl_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRACKDELETEITEMSPI]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRACKDELETEITEMSPI](
	[pi_id] [bigint] NOT NULL,
	[usr_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[pro_qty] [int] NOT NULL,
	[del_date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TYPE]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TYPE](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TYPE_DESC] [varchar](50) NULL,
 CONSTRAINT [PK_TYPE] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[STAFF] ADD  CONSTRAINT [DF_STAFF_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[MANAGERS]  WITH CHECK ADD  CONSTRAINT [FK_MANAGERS_LOCATIONS] FOREIGN KEY([man_locId])
REFERENCES [dbo].[LOCATIONS] ([loc_id])
GO
ALTER TABLE [dbo].[MANAGERS] CHECK CONSTRAINT [FK_MANAGERS_LOCATIONS]
GO
ALTER TABLE [dbo].[SALE_MASTER]  WITH CHECK ADD  CONSTRAINT [FK_SALE_MASTER_SALE_MASTER] FOREIGN KEY([sale_id])
REFERENCES [dbo].[SALE_MASTER] ([sale_id])
GO
ALTER TABLE [dbo].[SALE_MASTER] CHECK CONSTRAINT [FK_SALE_MASTER_SALE_MASTER]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_LOCATIONS] FOREIGN KEY([location_id])
REFERENCES [dbo].[LOCATIONS] ([loc_id])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_LOCATIONS]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_MANAGERS] FOREIGN KEY([manager_id])
REFERENCES [dbo].[MANAGERS] ([man_id])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_MANAGERS]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_ROLES] FOREIGN KEY([role_id])
REFERENCES [dbo].[ROLES] ([role_id])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_ROLES]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_SECTIONS] FOREIGN KEY([sec_id])
REFERENCES [dbo].[SECTIONS] ([Sec_ID])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_SECTIONS]
GO
ALTER TABLE [dbo].[STAFF]  WITH CHECK ADD  CONSTRAINT [FK_STAFF_TYPE] FOREIGN KEY([type_id])
REFERENCES [dbo].[TYPE] ([ID])
GO
ALTER TABLE [dbo].[STAFF] CHECK CONSTRAINT [FK_STAFF_TYPE]
GO
ALTER TABLE [dbo].[SUPPLIER]  WITH CHECK ADD  CONSTRAINT [FK_SUPPLIER_LOCATIONS] FOREIGN KEY([supl_locId])
REFERENCES [dbo].[LOCATIONS] ([loc_id])
GO
ALTER TABLE [dbo].[SUPPLIER] CHECK CONSTRAINT [FK_SUPPLIER_LOCATIONS]
GO
ALTER TABLE [dbo].[TRACKDELETEITEMSPI]  WITH CHECK ADD  CONSTRAINT [FK__TRACKDELE__pro_i__77FFC2B3] FOREIGN KEY([pro_id])
REFERENCES [dbo].[PRODUCTS] ([product_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TRACKDELETEITEMSPI] CHECK CONSTRAINT [FK__TRACKDELE__pro_i__77FFC2B3]
GO
/****** Object:  StoredProcedure [dbo].[st_deleteCategory]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
create procedure [dbo].[st_deleteCategory]
@id int
as
delete from category where cat_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteConsumption]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_deleteConsumption]
@deldate date
as
delete from SECTION_CONSUMPTION where Item_Upd_dt = @deldate
GO
/****** Object:  StoredProcedure [dbo].[st_deleteInvRole]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_deleteInvRole]
@id int
as
delete from INVOICE_ROLES where allowId = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteItemFromConsumptionList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteItemFromConsumptionList]
@deldate date,
@item varchar(10)
as
delete from SECTION_CONSUMPTION 
where Item_Upd_dt = @deldate and Item_Code = @item
GO
/****** Object:  StoredProcedure [dbo].[st_deleteItemFromPurchase]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteItemFromPurchase]
@pid as bigint
as
delete from PURCHASEINVOICEDETAILS
where PURCHASEINVOICEDETAILS.PID_ID = @pid
GO
/****** Object:  StoredProcedure [dbo].[st_deleteItemFromPurchaseInvDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteItemFromPurchaseInvDetails]
@itemcd varchar(10),
@piid bigint
as
BEGIN
delete from PURCHASEINVOICEDETAILS where PID_PI = @piid and PID_CODE = @itemcd
END
GO
/****** Object:  StoredProcedure [dbo].[st_deleteItemFromSaleDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[st_deleteItemFromSaleDetails]
@ID BIGINT,
@DESC VARCHAR(100),
@DATE DATE
AS
BEGIN
	delete from SALE_DETAILS where sale_id = @ID and sale_desc = @DESC and sale_detail_date = @DATE 
END
GO
/****** Object:  StoredProcedure [dbo].[st_deleteLocation]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
CREATE procedure [dbo].[st_deleteLocation]
@id int
as
delete from WAREHOUSE where loc_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteManager]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
create procedure [dbo].[st_deleteManager]
@id int
as
delete from managers where man_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteProduct]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Delete Record Procedure */
create procedure [dbo].[st_deleteProduct]
@pid int
as
delete from products where product_id = @pid
GO
/****** Object:  StoredProcedure [dbo].[st_deletePurchaseInvoiceWithDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deletePurchaseInvoiceWithDetails]
@id bigint
as
delete from PURCHASEINVOICE where PI_ID = @id
delete from PURCHASEINVOICEDETAILS where PID_PI = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
create procedure [dbo].[st_deleteRoles]
@id int
as
delete from roles where role_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSaleInvoiceWithDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteSaleInvoiceWithDetails]
@id bigint
as
delete from SALE_MASTER where sale_id = @id
delete from SALE_DETAILS where sale_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSection]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_deleteSection]
@id int
as
delete from SECTIONS where sec_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deletestaff]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deletestaff]
@sid int
as
delete from staff where staff_id = @sid
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSupplier]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
create procedure [dbo].[st_deleteSupplier]
@id int
as
delete from supplier where supl_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteType]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For delete record */
create procedure [dbo].[st_deleteType]
@id int
as
delete from type where id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_getCashSheetDates]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[st_getCashSheetDates]
@var_date as date
as
Declare @year int = year(@var_date), @month int = month(@var_date);
WITH numbers
as
(
    Select 1 as value
    UNion ALL
    Select value + 1 from numbers
    where value + 1 <= Day(EOMONTH(datefromparts(@year,@month,1)))
)
SELECT datefromparts(@year,@month,numbers.value) Datum FROM numbers
GO
/****** Object:  StoredProcedure [dbo].[st_getcatgData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getcatgData]
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (cat_IsActive = 1) then 'Yes' else 'No' end as 'Status'
from category c 
order by cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getcatgList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
create procedure [dbo].[st_getcatgList]
as
select
c.cat_id as 'ID',
c.cat_name as 'Category'
from category c 
order by cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getConsumptionData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getConsumptionData]
@cddate as date
as
select
sc.Item_Code as 'code',
sc.Item_Desc as 'name',
sc.Item_Pckg as 'pack',
sc.Item_Opn_Bal as 'opnbalance',
sc.Item_Consumption as 'consumption',
sc.Item_Balance as 'clobalance',
sc.Item_Upd_dt as 'upddate',
sc.Item_Section as 'usrsection'
from SECTION_CONSUMPTION sc
where sc.Item_Upd_dt = @cddate
order by sc.Item_Upd_dt desc
GO
/****** Object:  StoredProcedure [dbo].[st_getConsumptionDates]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getConsumptionDates]
as
select 
sc.Item_Upd_dt as 'scdate'
from SECTION_CONSUMPTION sc 
group by sc.Item_Upd_dt
order by sc.Item_Upd_dt desc
GO
/****** Object:  StoredProcedure [dbo].[st_getConsumptionStock]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getConsumptionStock]
@icode varchar(10),
@sumdate date
as
select
ss.sale_desc as 'desc',
ss.sale_packing as 'pckg',
ss.sale_pack_unit as 'qunit',
case when (lastconsumption.clobal is null) then sum(ss.sale_qty) else CAST(lastconsumption.clobal / ss.sale_pack_unit as int) end as 'totalbal',
lastconsumption.clobal
from 
		(
			SALE_DETAILS ss left join
			(
				select top 1
					ssc.Item_Code, ssc.Item_Balance as clobal
				from 
					SECTION_CONSUMPTION ssc
				where 
					ssc.Item_Upd_dt <  @sumdate	
				group by 
					ssc.Item_Code,ssc.Item_Balance,ssc.Item_Upd_dt
				order by ssc.Item_Upd_dt desc
			) 
			lastconsumption on ss.sale_item_cd = lastconsumption.Item_Code
		)
where ss.sale_item_cd = @icode
and ss.sale_detail_status = 'ISSUED'
and ss.sale_detail_date <= @sumdate
group by ss.sale_desc,ss.sale_packing,ss.sale_pack_unit,lastconsumption.clobal
GO
/****** Object:  StoredProcedure [dbo].[st_getInvRoleData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getInvRoleData]
as
select
i.allowId as 'ID',
i.userId as 'usrid',
i.suplName as 'name',
i.suplLocId as 'locid',
i.suplnmCd as 'nmcode'
from INVOICE_ROLES i
order by i.allowId asc
GO
/****** Object:  StoredProcedure [dbo].[st_getInvRoleList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getInvRoleList]
as
select
i.allowId as 'ID',
i.suplName as 'Name',
i.suplnmCd as 'prefix'
from INVOICE_ROLES i
order by i.allowId asc
GO
/****** Object:  StoredProcedure [dbo].[st_getLastPurchaseID]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getLastPurchaseID]
as
select top 1 pii.PI_ID from purchaseinvoice pii ORDER BY pii.PI_ID desc
GO
/****** Object:  StoredProcedure [dbo].[st_getLastSaleID]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getLastSaleID]
as
select top 1 si.sale_id from SALE_MASTER si ORDER BY si.sale_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getLocationData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getLocationData]
as
select
l.loc_id as 'ID',
l.loc_city as 'City',
l.loc_province as 'Province',
l.loc_Street as 'Street'
from LOCATIONS l
order by l.loc_city asc
GO
/****** Object:  StoredProcedure [dbo].[st_getLocationList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getLocationList]
as
select
l.loc_id as 'ID',
l.loc_city as 'City'
from LOCATIONS l 
order by l.loc_city asc
GO
/****** Object:  StoredProcedure [dbo].[st_getManagerData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getManagerData]
as
select
m.man_id as 'ID',
m.man_name as 'Name',
m.man_desig as 'Desig',
m.man_locId as 'Location',
m.man_email as 'Email',
m.man_contact as 'Contact'
from managers m
order by m.man_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getManagerList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getManagerList]
as
select
m.man_id as 'ID',
m.man_name as 'Name'
from managers m
order by m.man_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductByCode]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getProductByCode]
@prod_code varchar(50)
as
select
p.product_id as 'pid',
p.product_code as 'code',
p.product_barcode as 'barcode',
p.product_name as 'pname',
p.product_unit as 'punit',
p.product_price as 'pprice',
p.product_qty_unit as 'p_q_unt',
p.product_quantity as 'p_qty',
case when (product_status = 1) then 'Active' else 'In-Active' end as 'Status',
p.product_category as 'pcatg',
p.product_min_level as 'pminlvl'
from products p
where p.product_code = @prod_code or p.product_barcode = @prod_code
order by product_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getProductData]
as
select
p.product_id as 'pid',
p.product_code as 'code',
p.product_barcode as 'barcode',
p.product_name as 'pname',
p.product_unit as 'punit',
p.product_price as 'pprice',
p.product_qty_unit as 'p_q_unt',
p.product_quantity as 'p_qty',
p.product_category as 'pcatg',
p.product_min_level as 'pminlvl',
case when (product_status = 1) then 'Active' else 'In-Active' end as 'Status'
from products p 
order by p.product_code asc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
create procedure [dbo].[st_getProductList]
as
select
p.product_id as 'ID',
p.product_name as 'ProdName'
from products p 
order by p.product_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductQtyByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductQtyByParam]
@prod_code as nvarchar(20)
as
begin
declare @qty int
set @qty = (select product_quantity from PRODUCTS where product_code = @prod_code)
print @qty
end

GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseInvoiceDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseInvoiceDetails]
@pid bigint
as
select
pii.PID_PI as 'pid',
pii.PID_CODE as 'picode',
pii.PID_NAME as 'name',
pii.PID_PACKING as 'packing',
pii.PID_Q_UNIT as 'perpack',
pii.PID_QUANTITY as 'qty',
pii.PID_CATEGORY as 'catg',
pii.PID_STATUS as 'status'
from PURCHASEINVOICEDETAILS pii
where pii.PID_PI = @pid 
order by pii.PID_CODE 
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseInvoiceList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseInvoiceList]
@month int,
@year int
as
select
pii.PI_AUTO_ID 'ID',
pii.PI_ID as 'PID' 
from PURCHASEINVOICE pii where month(pii.PI_DATE) = @month and year(pii.PI_DATE) = @year
order by pii.PI_AUTO_ID
GO
/****** Object:  StoredProcedure [dbo].[st_getRequiredCategoryByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getRequiredCategoryByParam]
@a as int,
@b as varchar(20) out
as
begin
set @b = convert(varchar(250),(select cat_name from CATEGORY where cat_id = @a))
end
GO
/****** Object:  StoredProcedure [dbo].[st_getRequiredInvRoleByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getRequiredInvRoleByParam]
@a as int,
@b as varchar(50) out
as
begin
set @b = convert(varchar(250),(select suplName from INVOICE_ROLES where userId = @a))
end
GO
/****** Object:  StoredProcedure [dbo].[st_getRequiredRoleByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getRequiredRoleByParam]
@a as int,
@b as varchar(20) out
as
begin
set @b = convert(varchar(250),(select role_name from ROLES where role_id = @a))
end
GO
/****** Object:  StoredProcedure [dbo].[st_getRequiredSectionByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getRequiredSectionByParam]
@a as int,
@b as varchar(20) out
as
begin
set @b = convert(varchar(250),(select Sec_Desc from SECTIONS where Sec_ID = @a))
end
GO
/****** Object:  StoredProcedure [dbo].[st_getRequiredTypeByParam]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getRequiredTypeByParam]
@a as int,
@b as varchar(20) out
as
begin
set @b = convert(varchar(250),(select TYPE_DESC from TYPE where ID = @a))
end
GO
/****** Object:  StoredProcedure [dbo].[st_getRoleList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getRoleList]
as
select
r.role_id as 'ID',
r.role_name as 'RoleName'
from roles r 
order by role_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getRolesData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
create procedure [dbo].[st_getRolesData]
as
select
r.role_id as 'ID',
r.role_description as 'RoleDesc',
r.role_name as 'RoleName'
from roles r
order by role_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSaleInvoiceBySearch]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getSaleInvoiceBySearch]
@data as varchar(20)
as
select 
sm.sale_id as 'saleid',
sm.sale_date as 'date',
sm.sale_req_from as 'reqfrm',
sm.sale_req_to as 'reqto',
sm.sale_done_by as 'usr',
sm.sale_status as 'status',
sd.sale_item_cd as 'sdcode',
sd.sale_desc as 'name',
sd.sale_packing as 'pcking',
sd.sale_pack_unit as 'punit',
sd.sale_qty as 'qty',
sd.sale_category as 'catg'
from SALE_MASTER sm
inner join SALE_DETAILS sd on sd.sale_id = sm.sale_id
where 
sm.sale_id like '%' + @data + '%'
or
sm.sale_done_by like '%' + @data + '%'
or
sm.sale_date like '%' + @data + '%'
or
sd.sale_item_cd like '%' + @data + '%'
or
sd.sale_desc like '%' + @data + '%'
order by sd.sale_item_cd
GO
/****** Object:  StoredProcedure [dbo].[st_getSaleInvoices]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getSaleInvoices]
as
select 
sm.sale_id as 'saleid',
sm.sale_date as 'date',
sm.sale_req_from as 'reqfrm',
sm.sale_req_to as 'reqto',
sm.sale_done_by as 'usr',
sm.sale_status as 'status',
sm.sale_final_by as 'finalby'
from SALE_MASTER sm order by sm.sale_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSaleInvoiceWithDetail]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getSaleInvoiceWithDetail]
@saleid as bigint
as
select 
sm.sale_id as 'saleid',
sm.sale_date as 'date',
sm.sale_req_from as 'reqfrm',
sm.sale_req_to as 'reqto',
sm.sale_done_by as 'usr',
sm.sale_status as 'status',
sm.sale_final_by as 'final',
sd.sale_item_cd as 'sdcode',
sd.sale_desc as 'name',
sd.sale_packing as 'packing',
sd.sale_pack_unit as 'punit',
sd.sale_qty as 'qty',
sd.sale_category as 'catg'
from SALE_MASTER sm
inner join SALE_DETAILS sd on sd.sale_id = sm.sale_id
where sm.sale_id = @saleid
order by sm.sale_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getSectionData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getSectionData]
as
select
s.sec_id as 'ID',
s.sec_DESC as 'SecDesc'
from SECTIONS s 
order by SEC_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSectionList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getSectionList]
as
select
s.sec_id as 'ID',
s.sec_DESC as 'SecDesc'
from SECTIONS s 
order by SEC_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_getstaffdata]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getstaffdata]
as
select
s.staff_id as 'sid',
s.first_name as 'fname',
s.last_name as 'lname',
s.username as 'uname',
s.password as 'pwd',
s.contact as 'contact',
s.address as 'addrs',
s.role_id as 'roleid',
s.type_id as 'typeid',
s.location_id as 'locid',
s.sec_id as 'secid',
s.manager_id as 'manId',
case when (status = 1) then 'Active' else 'In-Active' end as 'Status'
from staff s 
order by first_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getStaffList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getStaffList]
as
select
s.staff_id as 'ID',
s.first_name as 'Name'
from STAFF s 
order by first_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getStockBySearch]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_getStockBySearch]
@data varchar(50)
as
select
p.product_id as 'pid',
p.product_code as 'code',
p.product_barcode as 'barcode',
p.product_name as 'pname',
p.product_unit as 'punit',
p.product_price as 'pprice',
p.product_qty_unit as 'p_q_unt',
p.product_quantity as 'p_qty',
case when (p.product_quantity < p.product_min_level) then 'Low Balance' else 'Average' end as 'Status',
p.product_category as 'pcatg',
p.product_min_level as 'pminlvl'
from products p
where 
p.product_code like '%' + @data + '%'
or
p.product_category like '%' + @data + '%'
or
p.product_name like '%' + @data + '%'
or
p.product_unit like '%' + @data + '%'
order by p.product_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getStockData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getStockData]
as
select
p.product_id as 'pid',
p.product_code as 'code',
p.product_barcode as 'barcode',
p.product_name as 'pname',
p.product_unit as 'punit',
p.product_price as 'pprice',
p.product_qty_unit as 'p_q_unt',
p.product_quantity as 'p_qty',
case when (p.product_quantity < p.product_min_level) then 'Low Balance' else 'Average' end as 'Status',
p.product_category as 'pcatg',
p.product_min_level as 'pminlvl'
from products p 
order by product_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getStockQuantity]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getStockQuantity]
@prodId varchar(10)
as
select s.st_quantity as 'quantity' from STOCK s where s.st_prodId = @prodId
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getSupplierData]
as
select
s.supl_id as 'ID',
s.supl_name as 'Name',
s.supl_company as 'Company',
s.supl_locId as 'Location',
s.supl_contact as 'Contact',
s.supl_ntn as 'NTN',
s.supl_nm_code as 'ShCode',
case when (s.supl_status = 1) then 'Active' else 'In-Active' end as 'Status'
from supplier s
order by s.supl_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
CREATE procedure [dbo].[st_getSupplierList]
as
select
s.supl_id as 'ID',
s.supl_name as 'Name',
s.supl_nm_code as 'prefix'
from supplier s
order by s.supl_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getTypeData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
create procedure [dbo].[st_getTypeData]
as
select
t.id as 'ID',
t.TYPE_DESC as 'TypeDesc'
from type t 
order by TYPE_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_getTypeList]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Show Record Procedure */
create procedure [dbo].[st_getTypeList]
as
select
t.id as 'ID',
t.TYPE_DESC as 'TypeDesc'
from type t 
order by TYPE_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_getUserDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_getUserDetails]
@user varchar(50),
@pass varchar(50)
as
select
u.staff_id as 'ID',
u.first_name as 'Name',
u.last_name as 'LName',
u.username as 'username',
u.password as 'password',
u.location_id as 'locid',
u.manager_id as 'mangid',
u.role_id as 'rolid',
u.sec_id as 'secid',
u.type_id as 'typid'
from staff u
where u.username = @user 
AND
u.password = @pass
GO
/****** Object:  StoredProcedure [dbo].[st_insertCategory]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertCategory]
@name varchar(50),
@IsActive tinyint
as
insert into category values(@name,@IsActive)
GO
/****** Object:  StoredProcedure [dbo].[st_insertConsumption]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Consumption Table Procedures */
create procedure [dbo].[st_insertConsumption]
@item_code varchar(20),
@item_desc varchar(200),
@item_pckg varchar(10),
@item_opn_bal decimal(18,0),
@item_consumption decimal(18,0),
@item_balance decimal(18,0),
@item_upd_date date,
@item_section varchar(50)
as
insert into SECTION_CONSUMPTION values(@item_code,@item_desc,@item_pckg,@item_opn_bal,@item_consumption,@item_balance,@item_upd_date,@item_section)
GO
/****** Object:  StoredProcedure [dbo].[st_insertdeletedItemPI]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertdeletedItemPI]
@pi bigint,
@usrid int,
@proid int,
@quant int,
@deldt date
as
insert into TRACKDELETEITEMSPI values(@pi,@usrid,@proid,@quant,@deldt)
GO
/****** Object:  StoredProcedure [dbo].[st_insertInventoryJournal]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertInventoryJournal]
@ij_date date,
@ij_indentno bigint,
@ij_code varchar(50),
@ij_name varchar(150),
@ij_desc varchar(250),
@ij_opnbal decimal(15,0),
@ij_recieve decimal(15,0),
@ij_issued decimal(15,0),
@ij_clobal decimal (15,0)
as
insert into INVENTORY_JOURNAL ([Inv_Tr_Dt], [Inv_Indent_No], [Inv_Code], [Inv_Name], [Inv_Desc], [Inv_Opn_Bal], [Inv_Receive], [Inv_Issued], [Inv_Balance])
values (@ij_date,@ij_indentno,@ij_code,@ij_name,@ij_desc,@ij_opnbal,@ij_recieve,@ij_issued,@ij_clobal)
GO
/****** Object:  StoredProcedure [dbo].[st_insertInvRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Invoice Roles Procedures */

create procedure [dbo].[st_insertInvRoles]
@usrid int,
@suplname varchar(50),
@locid int,
@prefix varchar(5)
as
insert into INVOICE_ROLES values(@usrid,@suplname,@locid,@prefix)
GO
/****** Object:  StoredProcedure [dbo].[st_insertLocation]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Locations Procedures 
   For insert record */

CREATE procedure [dbo].[st_insertLocation]
@loc_city varchar(50),
@loc_province varchar(50),
@loc_street varchar(50)
as
insert into LOCATIONS values(@loc_city,@loc_province,@loc_street)
GO
/****** Object:  StoredProcedure [dbo].[st_insertManager]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Locations Procedures 
   For insert record */

CREATE procedure [dbo].[st_insertManager]
@man_name varchar(50),
@man_desig varchar(50),
@man_email varchar(50),
@man_contact varchar(50),
@man_locId int
as
insert into MANAGERS values(@man_name,@man_desig,@man_locId,@man_email,@man_contact)
GO
/****** Object:  StoredProcedure [dbo].[st_insertProduct]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Insert Record Procedure */
create procedure [dbo].[st_insertProduct]
@pid int,
@pro_code varchar(50),
@pro_bcode varchar(100),
@pro_name varchar(100),
@pro_unit varchar(50),
@pro_price float,
@pro_q_unt int,
@pro_qty decimal(18,0),
@pro_status tinyint,
@pro_catg int,
@pro_min_lvl int
as
insert into products ([product_code], [product_barcode], [product_name], [product_unit], [product_price], [product_qty_unit], [product_quantity], [product_status], [product_category], [product_min_level])
values (@pro_code,@pro_bcode,@pro_name,@pro_unit,@pro_price,@pro_q_unt,@pro_qty,@pro_status,@pro_catg,@pro_min_lvl)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseInvoice]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





/* For Purchase Procedures */

CREATE procedure [dbo].[st_insertPurchaseInvoice]
@pi_id as bigint,
@pi_supl as varchar(50),
@pi_date as date,
@pi_user as varchar(20)
as
BEGIN
insert into purchaseinvoice values(@pi_id,@pi_supl,@pi_date,@pi_user)
END
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseInvoiceDetail]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertPurchaseInvoiceDetail]
@pid_pi as bigint,
@pid_code as varchar(10),
@pid_name as varchar(20),
@pid_packing as varchar(10),
@pid_qunit as int,
@pid_qty as decimal(18,0),
@pid_catg as varchar(20),
@pid_status as varchar(10),
@pid_date as date
as
insert into PURCHASEINVOICEDETAILS values(@pid_pi,@pid_code,@pid_name,@pid_packing,@pid_qunit,@pid_qty,@pid_catg,@pid_status,@pid_date)
GO
/****** Object:  StoredProcedure [dbo].[st_insertRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Type Procedures 
   For insert record */

create procedure [dbo].[st_insertRoles]
@rolename varchar(50),
@roledesc varchar(50)
as
insert into roles values(@rolename,@roledesc)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSaleDetail]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertSaleDetail]
@sd_id as bigint,
@sd_code as varchar(10),
@sd_name as varchar(20),
@sd_packing as varchar(10),
@sd_qunit as int,
@sd_qty as decimal(18,0),
@sd_catg as varchar(20),
@sd_date as date,
@sd_status as varchar(20)
as
insert into SALE_DETAILS values(@sd_id,@sd_code,@sd_name,@sd_packing,@sd_qunit,@sd_qty,@sd_catg,@sd_date,@sd_status)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSaleMaster]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertSaleMaster]
@id as bigint,
@sdate as date,
@reqfrom as varchar(50),
@reqto as varchar(50),
@user as varchar(20),
@status as varchar(10),
@issueperson as varchar(50)
as
insert into SALE_MASTER values(@id, @sdate, @reqfrom, @reqto,@user, @status,@issueperson)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSection]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSection]
@section varchar(100)
as
insert into SECTIONS values(@section)
GO
/****** Object:  StoredProcedure [dbo].[st_insertstaff]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_insertstaff]
@fname varchar(50),
@lname varchar(50),
@uname varchar(50),
@pwd varchar(50),
@contact varchar(50),
@address varchar(200),
@roleid int,
@typeid int,
@locid int,
@secid int,
@manager_id int,
@status tinyint

as

insert into staff ([first_name], [last_name], [username], [password], [contact], [address], [role_id], [type_id], [location_id],[sec_id],[manager_id],[status])
values(@fname, @lname, @uname, @pwd, @contact, @address, @roleid, @typeid, @locid,@secid,@manager_id,@status)
GO
/****** Object:  StoredProcedure [dbo].[st_insertStock]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Purchase Procedures */

CREATE procedure [dbo].[st_insertStock]
@proId varchar(10),
@quant int
as
insert into STOCK values(@proId,@quant)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSupplier]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Suppliers Procedures 
   For insert record */

create procedure [dbo].[st_insertSupplier]
@supl_name varchar(50),
@supl_company varchar(50),
@supl_contact varchar(50),
@supl_locId int,
@supl_ntn varchar(20),
@supl_nm_code varchar(5),
@supl_status tinyint
as
insert into SUPPLIER values(@supl_name,@supl_company,@supl_locId,@supl_contact,@supl_ntn,@supl_nm_code,@supl_status)
GO
/****** Object:  StoredProcedure [dbo].[st_insertType]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Type Procedures 
   For insert record */

create procedure [dbo].[st_insertType]
@type varchar(50)
as
insert into type values(@type)
GO
/****** Object:  StoredProcedure [dbo].[st_issueIndentOrder]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_issueIndentOrder]
@invoice_id bigint,
@issue_by varchar(20)
AS
BEGIN
SET NOCOUNT ON
DECLARE
@upd_qty decimal(18,0),
@opn_bal bigint,
@sd_id bigint,
@sm_id bigint,
@sd_code varchar(20),
@sd_name varchar(50),
@sd_pack varchar(10),
@sd_qunit int,
@sd_qty decimal(18,0),
@sd_catg varchar(20),
@sd_date date,
@invoice bigint,
@issueby varchar(20),
@chk_qty int,
@bal_qty decimal(18,0)

SET @opn_bal = 0
SET @upd_qty = 0
SET @invoice = @invoice_id
SET @issueby = @issue_by

DECLARE cursor_indentdetails CURSOR FOR
SELECT [sale_detail_id], [sale_id], [sale_item_cd], [sale_desc], [sale_packing], [sale_pack_unit], [sale_qty], [sale_category], [sale_detail_date] FROM SALE_DETAILS WHERE sale_id = @invoice

OPEN cursor_indentdetails
FETCH NEXT FROM cursor_indentdetails INTO @sd_id,@sm_id,@sd_code,@sd_name,@sd_pack,@sd_qunit,@sd_qty,@sd_catg,@sd_date
WHILE @@FETCH_STATUS=0
BEGIN
	set @bal_qty = (SELECT product_quantity from products where product_code = @sd_code)
	IF @bal_qty > @sd_qty
	BEGIN
		set @upd_qty = (SELECT sale_qty FROM SALE_DETAILS where sale_id = @sm_id and sale_item_cd = @sd_code)
		--set @opn_bal = (SELECT product_quantity from PRODUCTS where product_code = @sd_code)
		UPDATE PRODUCTS SET product_quantity = product_quantity - @upd_qty WHERE product_code = @sd_code
		UPDATE SALE_MASTER SET sale_status = 'ISSUED', sale_final_by = @issueby WHERE sale_id = @sm_id
		UPDATE SALE_DETAILS SET sale_detail_status = 'ISSUED' WHERE sale_id = @sm_id
		UPDATE SECTION_STOCK SET Item_Balance = Item_Balance + (@sd_qty * @sd_qunit), Item_Upd_dt = @sd_date WHERE Item_Code = @sd_code
		INSERT INTO INVENTORY_JOURNAL values(@sd_date,@sm_id,@sd_code,@sd_name,'Indent Issued',@opn_bal,0,@sd_qty,@opn_bal)
	END
	FETCH NEXT FROM cursor_indentdetails INTO @sd_id,@sm_id,@sd_code,@sd_name,@sd_pack,@sd_qunit,@sd_qty,@sd_catg,@sd_date
END
CLOSE cursor_indentdetails
DEALLOCATE cursor_indentdetails
END
GO
/****** Object:  StoredProcedure [dbo].[st_PurchaseInvoiceReceipt]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_PurchaseInvoiceReceipt]
@prchinvoice bigint
as
BEGIN
select
pim.PI_ID as 'prchid',
pim.PI_DATE as 'date',
pim.PI_SUPL as 'suplier',
pim.PI_USER as 'user',
pid.PID_CODE as 'sdcode',
pid.PID_NAME as 'name',
pid.PID_PACKING as 'packing',
pid.PID_Q_UNIT as 'punit',
pid.PID_QUANTITY 'qty',
pid.PID_CATEGORY as 'catg',
pid.PID_STATUS as 'status',
c.cat_name as 'catgname',
usr.first_name as 'usrname',
t.TYPE_DESC as 'sdesign',
m.man_name as 'manager',
m.man_desig as 'design',
sp.supl_nm_code as 'prefix',
l.loc_city as 'loc'
from [dbo].[PURCHASEINVOICE] pim 
inner join [dbo].[PURCHASEINVOICEDETAILS] pid on pim.PI_ID = pid.PID_PI
inner join STAFF usr on pim.PI_USER = usr.first_name
inner join MANAGERS m on usr.manager_id = m.man_id
inner join TYPE t on usr.type_id = t.ID
inner join ROLES r on usr.role_id = r.role_id
inner join LOCATIONS l on usr.location_id = l.loc_id
inner join CATEGORY c on pid.PID_CATEGORY = c.cat_id
inner join SUPPLIER sp on pim.PI_SUPL = sp.supl_name
where pim.PI_ID = @prchinvoice
order by sdcode
END
GO
/****** Object:  StoredProcedure [dbo].[st_receivePurchaseOrder]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_receivePurchaseOrder]
@purch_id bigint
AS
BEGIN
SET NOCOUNT ON
DECLARE
@upd_qty decimal(18,0),
@opn_bal bigint,
@pid bigint,
@pid_invoice bigint,
@pid_code varchar(20),
@pid_name varchar(50),
@pid_pack varchar(10),
@pid_qunit int,
@pid_qty decimal(18,2),
@pid_catg decimal(18,2),
@pid_stat varchar(10),
@pid_date date,
@invoice bigint

SET @opn_bal = 0
SET @upd_qty = 0
SET @invoice = @purch_id
DECLARE cursor_prchdetails CURSOR FOR
SELECT [PID_ID], [PID_PI], [PID_CODE], [PID_NAME], [PID_PACKING], [PID_Q_UNIT], [PID_QUANTITY], [PID_CATEGORY], [PID_STATUS], [PID_DATE] FROM PURCHASEINVOICEDETAILS WHERE PID_PI = @invoice AND PID_STATUS = 'INVOICE' ORDER BY PID_ID

OPEN cursor_prchdetails
FETCH NEXT FROM cursor_prchdetails INTO @pid,@pid_invoice,@pid_code,@pid_name,@pid_pack,@pid_qunit,@pid_qty,@pid_catg,@pid_stat,@pid_date
WHILE @@FETCH_STATUS=0
BEGIN
	set @upd_qty = (SELECT PID_QUANTITY FROM PURCHASEINVOICEDETAILS where PID_PI = @pid_invoice and PID_CODE = @pid_code)
	--set @opn_bal = (SELECT product_quantity from PRODUCTS where product_code = @pid_code)
	UPDATE PRODUCTS SET product_quantity = product_quantity + @upd_qty WHERE product_code = @pid_code
	UPDATE PURCHASEINVOICEDETAILS SET PID_STATUS = 'RECIEVED' WHERE PID_PI = @pid_invoice and PID_CODE = @pid_code
	INSERT INTO INVENTORY_JOURNAL values(@pid_date,@pid_invoice,@pid_code,@pid_name,'Item Received',@opn_bal,@pid_qty,0,@opn_bal)
	FETCH NEXT FROM cursor_prchdetails INTO @pid,@pid_invoice,@pid_code,@pid_name,@pid_pack,@pid_qunit,@pid_qty,@pid_catg,@pid_stat,@pid_date
END
CLOSE cursor_prchdetails
DEALLOCATE cursor_prchdetails
END
GO
/****** Object:  StoredProcedure [dbo].[st_SaleInvoiceReceipt]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_SaleInvoiceReceipt]
@saleinvoice bigint
as
BEGIN
select
sm.sale_id as 'saleid',
sm.sale_date as 'date',
sm.sale_req_from as 'reqfrm',
sm.sale_req_to as 'reqto',
sm.sale_done_by as 'usr',
sm.sale_status as 'status',
sm.sale_final_by as 'final',
sd.sale_item_cd as 'sdcode',
sd.sale_desc as 'name',
sd.sale_packing as 'packing',
sd.sale_pack_unit as 'punit',
sd.sale_qty as 'qty',
sd.sale_category as 'catg',
c.cat_name as 'catgname',
usr.first_name as 'usrname',
t.TYPE_DESC as 'sdesign',
m.man_name as 'manager',
m.man_desig as 'design',
sp.supl_nm_code as 'prefix',
l.loc_city as 'loc'
from SALE_MASTER sm 
inner join SALE_DETAILS sd on sm.sale_id = sd.sale_id
inner join STAFF usr on sm.sale_done_by = usr.first_name
inner join MANAGERS m on usr.manager_id = m.man_id
inner join TYPE t on usr.type_id = t.ID
inner join ROLES r on usr.role_id = r.role_id
inner join LOCATIONS l on usr.location_id = l.loc_id
inner join CATEGORY c on sd.sale_category = c.cat_id
inner join SUPPLIER sp on sm.sale_req_to = sp.supl_name 
where sm.sale_id = @saleinvoice
END
GO
/****** Object:  StoredProcedure [dbo].[st_searchCategorydata]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_searchCategorydata]
@data varchar(50)
as
select
c.cat_id as 'cid',
c.cat_name as 'name',
case when (cat_IsActive = 1) then 'Yes' else 'No' end as 'Status'
from CATEGORY c 
where 
c.cat_name like '%' + @data + '%'
or
c.cat_id like '%' + @data + '%'
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchConsumptionData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_searchConsumptionData]
@data varchar(20)
as
select
sc.Item_Code as 'code',
sc.Item_Desc as 'name',
sc.Item_Pckg as 'pack',
sc.Item_Opn_Bal as 'opnbalance',
sc.Item_Consumption as 'consumption',
sc.Item_Balance as 'clobalance',
sc.Item_Upd_dt as 'upddate',
sc.Item_Section as 'usrsection'
from SECTION_CONSUMPTION sc
where 
sc.Item_Code like '%' + @data + '%'
or
sc.Item_Desc like '%' + @data + '%'
order by sc.Item_Upd_dt desc
GO
/****** Object:  StoredProcedure [dbo].[st_searchInvRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_searchInvRoles]
@data varchar(10)
as
select
i.allowId as 'ID',
i.userId as 'usrid',
i.suplName as 'name',
i.suplLocId as 'locid',
i.suplnmCd as 'nmcode'
from INVOICE_ROLES i
where 
i.suplLocId like '%' + @data + '%'
or
i.suplName like '%' + @data + '%'
or
i.suplnmCd like '%' + @data + '%'
or
i.userId like '%' + @data + '%'
order by i.allowId asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchLocationData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
CREATE procedure [dbo].[st_searchLocationData]
@data varchar(50)
as
select
l.loc_id as 'ID',
l.loc_city as 'City',
l.loc_province as 'Province',
l.loc_street as 'Street'
from LOCATIONS l 
WHERE
l.loc_city like '%' + @data + '%'
or
l.loc_city like '%' + @data + '%'
ORDER BY l.loc_city asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchManagerData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
CREATE procedure [dbo].[st_searchManagerData]
@data varchar(50)
as
select
m.man_id as 'ID',
m.man_name as 'Name',
m.man_desig as 'Desig',
m.man_locId as 'Location',
m.man_email as 'Email',
m.man_contact as 'Contact'
from managers m
where 
m.man_name like '%' + @data + '%'
or
m.man_desig like '%' + @data + '%'
or
m.man_email like '%' + @data + '%'
or
m.man_locId like '%' + @data + '%'
order by m.man_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchProduct]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
create procedure [dbo].[st_searchProduct]
@data varchar(50)
as
select
p.product_id as 'pid',
p.product_code as 'code',
p.product_barcode as 'barcode',
p.product_name as 'pname',
p.product_unit as 'punit',
p.product_price as 'pprice',
p.product_qty_unit as 'p_q_unt',
p.product_quantity as 'p_qty',
p.product_barcode as 'pcatg',
p.product_min_level as 'pminlvl',
case when (product_status = 1) then 'Active' else 'In-Active' end as 'Status'
from products p
where 
p.product_code like '%' + @data + '%'
or
p.product_barcode like '%' + @data + '%'
or
p.product_name like '%' + @data + '%'
or
p.product_category like '%' + @data + '%'
or
p.product_status like '%' + @data + '%'
or
p.product_min_level like '%' + @data + '%'
order by p.product_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchPurchaseInvoiceByDate]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_searchPurchaseInvoiceByDate]
@frmdate as date,
@todate as date
as
select 
pm.PI_ID as 'Purch ID',
pm.PI_DATE as 'Date',
pd.PID_CODE as 'Code',
pd.PID_NAME as 'Name',
pd.PID_PACKING as 'packing',
pd.PID_Q_UNIT as 'Per Pack',
pd.PID_QUANTITY as 'Quantity',
pd.PID_CATEGORY as 'Category',
pd.PID_STATUS as 'Status'
from PURCHASEINVOICE pm
inner join PURCHASEINVOICEDETAILS pd on pm.PI_ID = pd.PID_PI
where pm.PI_DATE between @frmdate and @todate
order by pd.PID_ID desc
GO
/****** Object:  StoredProcedure [dbo].[st_searchRole]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
create procedure [dbo].[st_searchRole]
@data varchar(50)
as
select
r.role_id as 'tid',
r.role_name 'TypeName',
r.role_description 'RoleDesc'
from roles r 
where 
r.role_name like '%' + @data + '%'
or
r.role_description like '%' + @data + '%'
order by r.role_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchSaleInvoiceByDate]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_searchSaleInvoiceByDate]
@frmdate as date,
@todate as date
as
select 
sm.sale_id as 'Indent No',
sm.sale_date as 'Date',
sm.sale_req_from as 'Indent From',
sm.sale_req_to as 'Indent To',
sm.sale_done_by as 'User',
sm.sale_status as 'Status',
sm.sale_final_by as 'Final By'
from SALE_MASTER sm
where sm.sale_date between @frmdate and @todate
order by sm.sale_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_searchSection]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_searchSection]
@data varchar(50)
as
select
s.sec_id as 'id',
s.SEC_DESC 'SecDesc'
from SECTIONS s 
where 
s.SEC_DESC like '%' + @data + '%'
order by s.SEC_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchstaffdata]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_searchstaffdata]
@data varchar(50)
as
select
s.staff_id as 'sid',
s.first_name as 'fname',
s.last_name as 'lname',
s.username as 'uname',
s.password as 'pwd',
s.contact as 'contact',
s.address as 'addrs',
s.role_id as 'roleid',
s.type_id as 'typeid',
s.location_id as 'locid',
s.sec_id as 'secid',
s.manager_id as 'manId',
case when (status = 1) then 'Active' else 'In-Active' end as 'Status'
from staff s 
where 
s.first_name like '%' + @data + '%'
or
s.last_name like '%' + @data + '%'
or
s.username like '%' + @data + '%'
or
s.password like '%' + @data + '%'
or
s.contact like '%' + @data + '%'
or
s.address like '%' + @data + '%'
or
s.role_id like '%' + @data + '%'
or
s.type_id like '%' + @data + '%'
or
s.location_id like '%' + @data + '%'
or
s.status like '%' + @data + '%'
order by s.first_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchSupplierData]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
CREATE procedure [dbo].[st_searchSupplierData]
@data varchar(50)
as
select
s.supl_id as 'ID',
s.supl_name as 'Name',
s.supl_company as 'Company',
s.supl_locId as 'Location',
s.supl_contact as 'Contact',
s.supl_ntn as 'NTN',
s.supl_nm_code as 'ShCode',
s.supl_status as 'Status'
from supplier s
where 
s.supl_name like '%' + @data + '%'
or
s.supl_company like '%' + @data + '%'
or
s.supl_locId like '%' + @data + '%'
or
s.supl_contact like '%' + @data + '%'
order by s.supl_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_searchTypedata]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Search Record Procedure */
create procedure [dbo].[st_searchTypedata]
@data varchar(50)
as
select
t.id as 'tid',
t.TYPE_DESC 'TypeDesc'
from type t 
where 
t.TYPE_DESC like '%' + @data + '%'
order by t.TYPE_DESC asc
GO
/****** Object:  StoredProcedure [dbo].[st_showInventoryJournal]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_showInventoryJournal]
@fromdate date,
@todate date,
@itemcode varchar(20)
as
select
ij.Inv_Tr_ID as 'id',
ij.Inv_Tr_Dt as 'date',
ij.Inv_Indent_No as 'indent',
ij.Inv_Code as 'code',
ij.Inv_Name as 'name',
ij.Inv_Desc as 'desc',
ij.Inv_Opn_Bal as 'opnbal',
ij.Inv_Receive as 'recieve',
ij.Inv_Issued as 'issue',
ij.Inv_Balance as 'clobal'

from INVENTORY_JOURNAL ij 
where 
ij.Inv_Code = @itemcode
and
ij.Inv_Tr_Dt between @fromdate and @todate
order by ij.Inv_Tr_Dt,ij.Inv_Tr_Id
GO
/****** Object:  StoredProcedure [dbo].[st_showStockWithDetail]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_showStockWithDetail]
AS
BEGIN
SELECT [item_desc] AS 'ITEM'
      ,[item_pack] AS 'PACK'
      ,[item_category] AS 'CATG'
      ,[unit] AS 'UNIT'
      ,[opening_stock] AS 'OPENING'
      ,[received] AS 'RECVD'
      ,[issued] AS 'ISSUE'
      ,[closing_stock] AS 'CLOSING'
      ,[current_stock] AS 'CURRENT'
      ,[start_date] AS 'SDATE'
      ,[end_date] AS 'EDATE'
      ,[d1] AS 'D1'
      ,[d2] AS 'D2'
      ,[d3] AS 'D3'
      ,[d4] AS 'D4'
      ,[d5] AS 'D5'
      ,[d6] AS 'D6'
      ,[d7] AS 'D7'
      ,[d8] AS 'D8'
      ,[d9] AS 'D9'
      ,[d10] AS 'D10'
      ,[d11] AS 'D11'
      ,[d12] AS 'D12'
      ,[d13] AS 'D13'
      ,[d14] AS 'D14'
      ,[d15] AS 'D15'
      ,[d16] AS 'D16'
      ,[d17] AS 'D17'
      ,[d18] AS 'D18'
      ,[d19] AS 'D19'
      ,[d20] AS 'D20'
      ,[d21] AS 'D21'
      ,[d22] AS 'D22'
      ,[d23] AS 'D23'
      ,[d24] AS 'D24'
      ,[d25] AS 'D25'
      ,[d26] AS 'D26'
      ,[d27] AS 'D27'
      ,[d28] AS 'D28'
      ,[d29] AS 'D29'
      ,[d30] AS 'D30'
      ,[d31] AS 'D31'
	  ,C.cat_name AS CATG_NAME
  FROM [STOCK_DETAIL_REPORT] M
  INNER JOIN CATEGORY C ON cat_id = M.item_category
  ORDER BY item_desc 
  END
GO
/****** Object:  StoredProcedure [dbo].[st_stockPositionDetailReport]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_stockPositionDetailReport]
@fromDate as date,
@toDate as date
AS
BEGIN
	delete from IMS_DB.dbo.STOCK_DETAIL_REPORT
	SET NOCOUNT ON
	DECLARE
	@prodId int,
	@prodCode varchar(100),
	@prodBCode varchar(100),
	@prodName varchar(100),
	@prodPack varchar(20),
	@prodPrice float,
	@prodQtyUnit int,
	@prodQty decimal(18,0),
	@prodStatus tinyint,
	@prodCatg varchar(50),
	@prodMinLvl int,
	@prodDate date,
	@columName varchar(3)

	DELETE from IMS_DB.dbo.STOCK_DETAIL_REPORT
	-- GET ALL BASIC DATA FOR STOCK DETAIL REPORT 
	DECLARE cursor_get_stock CURSOR LOCAL FAST_FORWARD FOR
	SELECT [product_id], [product_code], [product_barcode], [product_name], [product_unit], [product_price], [product_qty_unit], [product_quantity], [product_status], [product_category], [product_min_level] FROM PRODUCTS

	OPEN cursor_get_stock
	FETCH NEXT FROM cursor_get_stock into @prodId,@prodCode,@prodBCode,@prodName,@prodPack,@prodPrice,@prodQtyUnit,@prodQty,@prodStatus,@prodCatg,@prodMinLvl
	WHILE @@FETCH_STATUS = 0
	BEGIN
		insert into IMS_DB.dbo.STOCK_DETAIL_REPORT values (
		@prodName,
		@prodPack,
		@prodCatg,
		@prodQtyUnit,
		0, 
		0,
		0,
		0,
		@prodQty,
		@fromDate,
		@toDate,
		0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)
		FETCH NEXT FROM cursor_get_stock into @prodId,@prodCode,@prodBCode,@prodName,@prodPack,@prodPrice,@prodQtyUnit,@prodQty,@prodStatus,@prodCatg,@prodMinLvl
	END
	CLOSE cursor_get_stock
	DEALLOCATE cursor_get_stock

	-- CALCULATE RECEIVE STOCK
	DECLARE cursor_rcv_stock CURSOR LOCAL FAST_FORWARD FOR
	SELECT [PID_NAME], SUM([PID_QUANTITY]) FROM PURCHASEINVOICEDETAILS WHERE PID_DATE >= @fromDate AND PID_STATUS = 'ISSUED' GROUP BY PID_NAME  

	OPEN cursor_rcv_stock
	FETCH NEXT FROM cursor_rcv_stock into @prodName,@prodQty
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE IMS_DB.dbo.STOCK_DETAIL_REPORT SET received = @prodQty WHERE item_desc = @prodName 
		FETCH NEXT FROM cursor_rcv_stock into @prodName,@prodQty
	END
	CLOSE cursor_rcv_stock
	DEALLOCATE cursor_rcv_stock

	-- CALCULATE OPENING STOCK FOR DETAIL REPORT
	UPDATE IMS_DB.DBO.STOCK_DETAIL_REPORT SET opening_stock = current_stock 
	DECLARE cursor_opn_stock CURSOR LOCAL FAST_FORWARD FOR
	SELECT [sale_desc], SUM([sale_qty]) FROM SALE_DETAILS WHERE sale_detail_date >= @fromDate AND sale_detail_status = 'ISSUED' GROUP BY sale_desc  

	OPEN cursor_opn_stock
	FETCH NEXT FROM cursor_opn_stock into @prodName,@prodQty
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE IMS_DB.dbo.STOCK_DETAIL_REPORT SET opening_stock = (@prodQty - received) + current_stock WHERE item_desc = @prodName 
		FETCH NEXT FROM cursor_opn_stock into @prodName,@prodQty
	END
	CLOSE cursor_opn_stock
	DEALLOCATE cursor_opn_stock

	-- CALCULATE ISSUED STOCK
	DECLARE cursor_isu_stock CURSOR LOCAL FAST_FORWARD FOR
	SELECT [sale_desc], SUM([sale_qty]) FROM SALE_DETAILS WHERE sale_detail_date >= @fromDate AND sale_detail_date <= @toDate AND sale_detail_status = 'ISSUED' GROUP BY sale_desc  

	OPEN cursor_isu_stock
	FETCH NEXT FROM cursor_isu_stock into @prodName,@prodQty
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE IMS_DB.dbo.STOCK_DETAIL_REPORT SET issued = @prodQty WHERE item_desc = @prodName 
		FETCH NEXT FROM cursor_isu_stock into @prodName,@prodQty
	END
	CLOSE cursor_isu_stock
	DEALLOCATE cursor_isu_stock

	-- CALCULATE STOCK ISSUED DETAIL
	--DECLARE cursor_isu_detail CURSOR LOCAL FAST_FORWARD FOR
	--SELECT [sale_desc], SUM([sale_qty]), [sale_detail_date] FROM SALE_DETAILS WHERE sale_detail_date >= '2022-06-01' AND sale_detail_date <= '2022-06-30' AND sale_detail_status = 'ISSUED' GROUP BY sale_detail_date,sale_desc  

	--OPEN cursor_isu_detail
	--FETCH NEXT FROM cursor_isu_detail into @prodName,@prodQty,@prodDate
	--WHILE @@FETCH_STATUS = 0
	--BEGIN
	--	SET @columName = CONCAT('d',DAY(@prodDate))
	--	print @columName + SPACE(5) + CONVERT(VARCHAR(50),@prodQty,101) + SPACE(5) + @prodName
	--	UPDATE IMS_DB.dbo.STOCK_DETAIL_REPORT SET ' + quotename(@columName) +' = @prodQty WHERE item_desc = @prodName 
	--	FETCH NEXT FROM cursor_isu_detail into @prodName,@prodQty,@prodDate
	--END
	--CLOSE cursor_isu_detail
	--DEALLOCATE cursor_isu_detail
END
GO
/****** Object:  StoredProcedure [dbo].[st_stockPositionReport]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_stockPositionReport]
@fromDate as date,
@toDate as date
as
BEGIN
select
	p.product_code,
    p.product_name,
	p.product_unit,
	p.product_category,
	p.product_qty_unit,
	(closingstock.csqty - (case when (purchaseinvoicedetails.puqty is null) then '0' else purchaseinvoicedetails.puqty end) + (case when (sale_details.sduqty is null) then '0' else sale_details.sduqty end)) as [Opening Stock], 
    case when (purchaseinvoicedetails.puqty is null) then '0' else purchaseinvoicedetails.puqty end as [Total Recieved],
	case when (sale_details.sduqty is null) then '0' else sale_details.sduqty end as [Total Issued],
	closingstock.csqty as [Closing Stock],
	p.product_quantity as [Current Stock],
	@fromdate as [StartDate],
	@todate as [EndDate]
from
    (
        (
            products p left join 
            (
                select 
					pu.PID_CODE, sum(pu.PID_QUANTITY) as puqty
				from 
					PURCHASEINVOICEDETAILS pu
				where 
					pu.pid_date >= @fromDate and 
					pu.pid_date <=  @toDate and
					pu.PID_STATUS = 'RECIEVED'
				group by 
					pu.PID_CODE
            ) 
            purchaseinvoicedetails on p.product_code = purchaseinvoicedetails.PID_CODE
			
			left join
			(
                select 
					sd.sale_item_cd, sum(sd.sale_qty) as sduqty
				from 
					SALE_DETAILS sd
				where 
					sd.sale_detail_date >= @fromDate and 
					sd.sale_detail_date <=  @toDate and
					sd.sale_detail_status = 'ISSUED'
				group by 
					sd.sale_item_cd
            )
			sale_details on p.product_code = sale_details.sale_item_cd
			)
        left join 
        (
            select 
                os.product_code, os.product_quantity as osqty
            from 
                [PRODUCTS] os
        )
        openingstock on p.product_code = openingstock.product_code
    )
    left join 
    (
        select 
            cs.product_code, cs.product_quantity as csqty
        from 
            [PRODUCTS] cs    
	)
    closingstock on p.product_code = closingstock.product_code
	order by p.product_code
END
GO
/****** Object:  StoredProcedure [dbo].[st_updateCategory]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
create procedure [dbo].[st_updateCategory]
@name varchar(50),
@IsActive tinyint,
@id int
as
update category
set
cat_name = @name,
cat_IsActive = @IsActive
where
cat_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_updateConsumption]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_updateConsumption]
@item_code varchar(20),
@item_desc varchar(200),
@item_pckg varchar(10),
@item_opn_bal decimal(18,0),
@item_consumption decimal(18,0),
@item_balance decimal(18,0),
@item_upd_date date,
@item_section varchar(50)
as
update SECTION_CONSUMPTION
set
Item_Desc = @item_desc,
Item_Pckg = @item_pckg,
Item_Opn_Bal = @item_opn_bal,
Item_Consumption = @item_consumption,
Item_Balance = @item_balance,
Item_Upd_dt = @item_upd_date,
Item_Section = @item_section
where
Item_Balance = @item_code
GO
/****** Object:  StoredProcedure [dbo].[st_updateInvRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_updateInvRoles]
@inv_id int,
@usrid int,
@suplname varchar(50),
@locid int,
@prefix varchar(5)
as
update INVOICE_ROLES
set
userId = @usrid,
suplName = @suplname,
suplLocId = @locid,
suplnmCd = @prefix
where
allowId = @inv_id
GO
/****** Object:  StoredProcedure [dbo].[st_updateLocation]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
CREATE procedure [dbo].[st_updateLocation]
@loc_city varchar(50),
@loc_province varchar(50),
@loc_street varchar(50),
@id int
as
update LOCATIONS
set
loc_city = @loc_city,
loc_province = @loc_province,
loc_Street = @loc_street
where
loc_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_updateManager]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
CREATE procedure [dbo].[st_updateManager]
@man_id int,
@man_name varchar(50),
@man_desig varchar(50),
@man_email varchar(50),
@man_contact varchar(50),
@man_locId int
as
update managers
set
man_name = @man_name,
man_desig = @man_desig,
man_locId = @man_locId,
man_email = @man_email,
man_contact = @man_contact
where
man_id = @man_id
GO
/****** Object:  StoredProcedure [dbo].[st_updateProduct]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For Update Record Procedure */
create procedure [dbo].[st_updateProduct]
@pid int,
@pro_code varchar(50),
@pro_bcode varchar(100),
@pro_name varchar(100),
@pro_unit varchar(50),
@pro_price float,
@pro_q_unt int,
@pro_qty decimal(18,0),
@pro_status tinyint,
@pro_catg int,
@pro_min_lvl int
as
update products set
product_code = @pro_code,
product_barcode = @pro_bcode,
product_name = @pro_name,
product_unit = @pro_unit,
product_price = @pro_price,
product_qty_unit = @pro_q_unt,
product_status = @pro_status,
product_category = @pro_catg,
product_min_level = @pro_min_lvl
where product_id = @pid
GO
/****** Object:  StoredProcedure [dbo].[st_updateRoles]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
create procedure [dbo].[st_updateRoles]
@rolename varchar(50),
@roledesc varchar(50),
@id int
as
update roles
set
role_name = @rolename,
role_description = @roledesc
where
role_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_updateSaleDetails]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[st_updateSaleDetails]
@sd_id as bigint,
@sd_code as varchar(10),
@sd_name as varchar(20),
@sd_packing as varchar(10),
@sd_qunit as int,
@sd_qty as decimal(18,0),
@sd_catg as varchar(20),
@sd_date as date,
@sd_status as varchar(20)
as
BEGIN
UPDATE SALE_DETAILS SET sale_item_cd = @sd_code, sale_desc = @sd_name, sale_packing = @sd_packing, sale_pack_unit = @sd_qunit, sale_qty = @sd_qty, sale_category = @sd_catg, sale_detail_date = @sd_date, sale_detail_status = @sd_status WHERE sale_id = @sd_id AND sale_desc = @sd_name AND sale_detail_date = @sd_date 
END
GO
/****** Object:  StoredProcedure [dbo].[st_updateSaleInvoice]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[st_updateSaleInvoice]
@id as bigint,
@sdate as date,
@reqfrom as varchar(50),
@reqto as varchar(50),
@user as varchar(20),
@status as varchar(10),
@issueperson as varchar(50)
as
BEGIN
UPDATE SALE_MASTER set sale_date = @sdate, sale_req_from = @reqfrom, sale_req_to = @reqto, sale_done_by = @user, sale_status = @status, sale_final_by = @issueperson where sale_id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[st_updateSection]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[st_updateSection]
@section varchar(100),
@id int
as
update SECTIONS
set
SEC_DESC = @section
where
sec_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_updateStaff]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateStaff]
@sid int,
@fname varchar(50),
@lname varchar(50),
@uname varchar(50),
@pwd varchar(50),
@contact varchar(50),
@address varchar(200),
@roleid int,
@typeid int,
@locid int,
@secid int,
@manager_id int,
@status tinyint
as
update staff set
first_name = @fname,
last_name = @lname,
username = @uname,
password = @pwd,
contact = @contact,
address = @address,
role_id = @roleid,
type_id = @typeid,
location_id = @locid,
sec_id = @secid,
manager_id = @manager_id,
status = @status
where staff_id = @sid
GO
/****** Object:  StoredProcedure [dbo].[st_updateStock]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[st_updateStock]
@proId varchar(10),
@quant int
as
update STOCK set
st_quantity = @quant
where st_prodId = @proId
GO
/****** Object:  StoredProcedure [dbo].[st_updateSupplier]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
CREATE procedure [dbo].[st_updateSupplier]
@supl_id int,
@supl_name varchar(50),
@supl_company varchar(50),
@supl_contact varchar(50),
@supl_locId int,
@supl_ntn varchar(20),
@supl_nm_code varchar(5),
@supl_status tinyint
as
update supplier
set
supl_name = @supl_name,
supl_company = @supl_company,
supl_locId = @supl_locId,
supl_contact = @supl_contact,
supl_ntn = @supl_ntn,
supl_nm_code = @supl_nm_code,
supl_status = @supl_status
where
supl_id = @supl_id
GO
/****** Object:  StoredProcedure [dbo].[st_updateType]    Script Date: 2/29/2024 10:58:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/* For update record */
create procedure [dbo].[st_updateType]
@type varchar(50),
@id int
as
update TYPE
set
TYPE_DESC = @type
where
id = @id
GO
USE [master]
GO
ALTER DATABASE [IMS_DB] SET  READ_WRITE 
GO
