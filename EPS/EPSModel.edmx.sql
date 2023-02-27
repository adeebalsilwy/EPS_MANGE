
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/25/2022 16:05:34
-- Generated from EDMX file: D:\مشاريعي المهمه\EPS-main_2\EPS-main\EPS\EPS\EPSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DEEB_EPS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TB_Categories_TB_Groups]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Categories] DROP CONSTRAINT [FK_TB_Categories_TB_Groups];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_Buy_TB_Categories]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Buy] DROP CONSTRAINT [FK_TB_Buy_TB_Categories];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_Buy_TB_Suppliers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Buy] DROP CONSTRAINT [FK_TB_Buy_TB_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_Sell_TB_Customers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Sell] DROP CONSTRAINT [FK_TB_Sell_TB_Customers];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_SellData_TB_Sell]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_SellData] DROP CONSTRAINT [FK_TB_SellData_TB_Sell];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_Pyments_TB_Sell]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Pyments] DROP CONSTRAINT [FK_TB_Pyments_TB_Sell];
GO
IF OBJECT_ID(N'[dbo].[FK_TB_Paymentsbuy_TB_Buy]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TB_Paymentsbuy] DROP CONSTRAINT [FK_TB_Paymentsbuy_TB_Buy];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TB_Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Categories];
GO
IF OBJECT_ID(N'[dbo].[TB_Groups]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Groups];
GO
IF OBJECT_ID(N'[dbo].[TB_Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Users];
GO
IF OBJECT_ID(N'[dbo].[TB_Note]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Note];
GO
IF OBJECT_ID(N'[dbo].[TB_SystemLogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_SystemLogs];
GO
IF OBJECT_ID(N'[dbo].[TB_Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Suppliers];
GO
IF OBJECT_ID(N'[dbo].[TB_Buy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Buy];
GO
IF OBJECT_ID(N'[dbo].[TB_Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Customers];
GO
IF OBJECT_ID(N'[dbo].[TB_Sell]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Sell];
GO
IF OBJECT_ID(N'[dbo].[TB_SellData]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_SellData];
GO
IF OBJECT_ID(N'[dbo].[TB_ABC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_ABC];
GO
IF OBJECT_ID(N'[dbo].[TB_Pyments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Pyments];
GO
IF OBJECT_ID(N'[dbo].[TB_CustomerPaymentLogs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_CustomerPaymentLogs];
GO
IF OBJECT_ID(N'[dbo].[TB_Paymentsbuy]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_Paymentsbuy];
GO
IF OBJECT_ID(N'[dbo].[TB_SuppliersPayments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TB_SuppliersPayments];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TB_Categories'
CREATE TABLE [dbo].[TB_Categories] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDGroups] int  NULL,
    [CatName] nvarchar(50)  NULL,
    [CatGroup] nvarchar(50)  NULL,
    [CatDes] nvarchar(max)  NULL,
    [CatQuantity] float  NULL,
    [CatDate] datetime  NULL
);
GO

-- Creating table 'TB_Groups'
CREATE TABLE [dbo].[TB_Groups] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [GroupName] nvarchar(50)  NULL,
    [GroupDate] datetime  NULL
);
GO

-- Creating table 'TB_Users'
CREATE TABLE [dbo].[TB_Users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(50)  NULL,
    [UserName] nvarchar(50)  NULL,
    [Password] nvarchar(50)  NULL,
    [Role] varbinary(max)  NULL,
    [ProfileCover] varbinary(max)  NULL,
    [UserState] int  NULL,
    [privlage] varchar(50)  NULL
);
GO

-- Creating table 'TB_Note'
CREATE TABLE [dbo].[TB_Note] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NoteDes] nvarchar(max)  NULL,
    [NoteDate] datetime  NULL,
    [NoteManger] nvarchar(50)  NULL,
    [NoteUser] nvarchar(50)  NULL,
    [NoteType] nvarchar(50)  NULL
);
GO

-- Creating table 'TB_SystemLogs'
CREATE TABLE [dbo].[TB_SystemLogs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [LogDes] nvarchar(max)  NULL,
    [LogDate] datetime  NULL
);
GO

-- Creating table 'TB_Suppliers'
CREATE TABLE [dbo].[TB_Suppliers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SupplierName] nvarchar(max)  NULL,
    [SupplierPhone] bigint  NULL,
    [SupplierAddress] nvarchar(max)  NULL,
    [SupplierDate] datetime  NULL,
    [SupplierBalance] float  NULL,
    [SupplierBalancePrim] float  NULL
);
GO

-- Creating table 'TB_Buy'
CREATE TABLE [dbo].[TB_Buy] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ID_Catgeory] int  NULL,
    [ID_Supplier] int  NULL,
    [Name] nvarchar(max)  NULL,
    [Category] nvarchar(50)  NULL,
    [Supplier] nvarchar(50)  NULL,
    [Quantity] float  NULL,
    [BarcodeValue] nvarchar(50)  NULL,
    [BarcodeImage] varbinary(max)  NULL,
    [CashSellPrimary] float  NULL,
    [CashSellSecondry] float  NULL,
    [BuyPrimary] float  NULL,
    [BuySecondry] float  NULL,
    [SupplierPyment] float  NULL,
    [BuyAllValue] float  NULL,
    [SellAllValue] float  NULL,
    [Benfit] float  NULL,
    [Cover] varbinary(max)  NULL,
    [DateAdd] datetime  NULL,
    [CreditSellPrimary] float  NULL,
    [CreditSellSecondry] float  NULL,
    [Description] nvarchar(max)  NULL,
    [SupplierPyment1] float  NULL
);
GO

-- Creating table 'TB_Customers'
CREATE TABLE [dbo].[TB_Customers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [SupplierName] nvarchar(max)  NULL,
    [SupplierBalance] float  NULL,
    [SupplierPhone] float  NULL,
    [SupplierAddress] nvarchar(max)  NULL,
    [SupplierDate] datetime  NULL,
    [SupplierBalanceprim] float  NULL
);
GO

-- Creating table 'TB_Sell'
CREATE TABLE [dbo].[TB_Sell] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDCustomer] int  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [CustomerBalance] float  NULL,
    [SellValue] float  NULL,
    [Date] datetime  NULL,
    [Barcode] nvarchar(50)  NULL,
    [BarcodeImage] varbinary(max)  NULL,
    [SellMenuName] nvarchar(max)  NULL,
    [CustomerBalanceprim] float  NULL
);
GO

-- Creating table 'TB_SellData'
CREATE TABLE [dbo].[TB_SellData] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDSell] int  NULL,
    [MatrialsName] nvarchar(50)  NULL,
    [Quantity] float  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [SellState] nvarchar(50)  NULL,
    [SellValue] float  NULL,
    [SellAllValue] float  NULL,
    [CustomerBalance] float  NULL,
    [CustomerBalanceprim] float  NULL
);
GO

-- Creating table 'TB_ABC'
CREATE TABLE [dbo].[TB_ABC] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [A] varbinary(max)  NULL,
    [B] varbinary(max)  NULL,
    [C] varbinary(max)  NULL,
    [D] varbinary(max)  NULL,
    [E] varbinary(max)  NULL
);
GO

-- Creating table 'TB_Pyments'
CREATE TABLE [dbo].[TB_Pyments] (
    [ID] int  NOT NULL,
    [IDSELL] int  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [Paymentone] float  NULL,
    [Paymenttwo] float  NULL,
    [PaymentDate] datetime  NULL,
    [CurrentPaymentone] float  NULL,
    [CurrentDate] datetime  NULL,
    [PaymentState] nvarchar(50)  NULL,
    [AddDate] datetime  NULL,
    [colone] nvarchar(50)  NULL,
    [coltwo] nvarchar(50)  NULL,
    [colthree] nvarchar(50)  NULL,
    [colfour] nvarchar(50)  NULL,
    [IDCustomer] int  NULL,
    [SellName] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_CustomerPaymentLogs'
CREATE TABLE [dbo].[TB_CustomerPaymentLogs] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CustomerID] int  NULL,
    [SellID] int  NULL,
    [Pamnent] float  NULL,
    [Date] datetime  NULL,
    [colone] float  NULL,
    [coltow] nvarchar(50)  NULL,
    [colthreee] nvarchar(50)  NULL
);
GO

-- Creating table 'TB_Paymentsbuy'
CREATE TABLE [dbo].[TB_Paymentsbuy] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [IDSELL] int  NULL,
    [CustomerName] nvarchar(50)  NULL,
    [Paymentone] float  NULL,
    [Paymenttwo] float  NULL,
    [PaymentDate] datetime  NULL,
    [CurrentPaymentone] float  NULL,
    [CurrentDate] datetime  NULL,
    [PaymentState] nvarchar(50)  NULL,
    [AddDate] datetime  NULL,
    [colone] nvarchar(50)  NULL,
    [coltwo] nvarchar(50)  NULL,
    [colthree] nvarchar(50)  NULL,
    [colfour] nvarchar(50)  NULL,
    [IDCustomer] int  NULL,
    [SellName] nvarchar(max)  NULL
);
GO

-- Creating table 'TB_SuppliersPayments'
CREATE TABLE [dbo].[TB_SuppliersPayments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [CustomerID] int  NULL,
    [SellID] int  NULL,
    [Pamnent] float  NULL,
    [Date] datetime  NULL,
    [colone] float  NULL,
    [coltow] nvarchar(50)  NULL,
    [colthreee] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'TB_Categories'
ALTER TABLE [dbo].[TB_Categories]
ADD CONSTRAINT [PK_TB_Categories]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Groups'
ALTER TABLE [dbo].[TB_Groups]
ADD CONSTRAINT [PK_TB_Groups]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Users'
ALTER TABLE [dbo].[TB_Users]
ADD CONSTRAINT [PK_TB_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Note'
ALTER TABLE [dbo].[TB_Note]
ADD CONSTRAINT [PK_TB_Note]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_SystemLogs'
ALTER TABLE [dbo].[TB_SystemLogs]
ADD CONSTRAINT [PK_TB_SystemLogs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Suppliers'
ALTER TABLE [dbo].[TB_Suppliers]
ADD CONSTRAINT [PK_TB_Suppliers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Buy'
ALTER TABLE [dbo].[TB_Buy]
ADD CONSTRAINT [PK_TB_Buy]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Customers'
ALTER TABLE [dbo].[TB_Customers]
ADD CONSTRAINT [PK_TB_Customers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Sell'
ALTER TABLE [dbo].[TB_Sell]
ADD CONSTRAINT [PK_TB_Sell]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_SellData'
ALTER TABLE [dbo].[TB_SellData]
ADD CONSTRAINT [PK_TB_SellData]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_ABC'
ALTER TABLE [dbo].[TB_ABC]
ADD CONSTRAINT [PK_TB_ABC]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Pyments'
ALTER TABLE [dbo].[TB_Pyments]
ADD CONSTRAINT [PK_TB_Pyments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_CustomerPaymentLogs'
ALTER TABLE [dbo].[TB_CustomerPaymentLogs]
ADD CONSTRAINT [PK_TB_CustomerPaymentLogs]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_Paymentsbuy'
ALTER TABLE [dbo].[TB_Paymentsbuy]
ADD CONSTRAINT [PK_TB_Paymentsbuy]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TB_SuppliersPayments'
ALTER TABLE [dbo].[TB_SuppliersPayments]
ADD CONSTRAINT [PK_TB_SuppliersPayments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IDGroups] in table 'TB_Categories'
ALTER TABLE [dbo].[TB_Categories]
ADD CONSTRAINT [FK_TB_Categories_TB_Groups]
    FOREIGN KEY ([IDGroups])
    REFERENCES [dbo].[TB_Groups]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Categories_TB_Groups'
CREATE INDEX [IX_FK_TB_Categories_TB_Groups]
ON [dbo].[TB_Categories]
    ([IDGroups]);
GO

-- Creating foreign key on [ID_Catgeory] in table 'TB_Buy'
ALTER TABLE [dbo].[TB_Buy]
ADD CONSTRAINT [FK_TB_Buy_TB_Categories]
    FOREIGN KEY ([ID_Catgeory])
    REFERENCES [dbo].[TB_Categories]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Buy_TB_Categories'
CREATE INDEX [IX_FK_TB_Buy_TB_Categories]
ON [dbo].[TB_Buy]
    ([ID_Catgeory]);
GO

-- Creating foreign key on [ID_Supplier] in table 'TB_Buy'
ALTER TABLE [dbo].[TB_Buy]
ADD CONSTRAINT [FK_TB_Buy_TB_Suppliers]
    FOREIGN KEY ([ID_Supplier])
    REFERENCES [dbo].[TB_Suppliers]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Buy_TB_Suppliers'
CREATE INDEX [IX_FK_TB_Buy_TB_Suppliers]
ON [dbo].[TB_Buy]
    ([ID_Supplier]);
GO

-- Creating foreign key on [IDCustomer] in table 'TB_Sell'
ALTER TABLE [dbo].[TB_Sell]
ADD CONSTRAINT [FK_TB_Sell_TB_Customers]
    FOREIGN KEY ([IDCustomer])
    REFERENCES [dbo].[TB_Customers]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Sell_TB_Customers'
CREATE INDEX [IX_FK_TB_Sell_TB_Customers]
ON [dbo].[TB_Sell]
    ([IDCustomer]);
GO

-- Creating foreign key on [IDSell] in table 'TB_SellData'
ALTER TABLE [dbo].[TB_SellData]
ADD CONSTRAINT [FK_TB_SellData_TB_Sell]
    FOREIGN KEY ([IDSell])
    REFERENCES [dbo].[TB_Sell]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_SellData_TB_Sell'
CREATE INDEX [IX_FK_TB_SellData_TB_Sell]
ON [dbo].[TB_SellData]
    ([IDSell]);
GO

-- Creating foreign key on [IDSELL] in table 'TB_Pyments'
ALTER TABLE [dbo].[TB_Pyments]
ADD CONSTRAINT [FK_TB_Pyments_TB_Sell]
    FOREIGN KEY ([IDSELL])
    REFERENCES [dbo].[TB_Sell]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Pyments_TB_Sell'
CREATE INDEX [IX_FK_TB_Pyments_TB_Sell]
ON [dbo].[TB_Pyments]
    ([IDSELL]);
GO

-- Creating foreign key on [IDSELL] in table 'TB_Paymentsbuy'
ALTER TABLE [dbo].[TB_Paymentsbuy]
ADD CONSTRAINT [FK_TB_Paymentsbuy_TB_Buy]
    FOREIGN KEY ([IDSELL])
    REFERENCES [dbo].[TB_Buy]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TB_Paymentsbuy_TB_Buy'
CREATE INDEX [IX_FK_TB_Paymentsbuy_TB_Buy]
ON [dbo].[TB_Paymentsbuy]
    ([IDSELL]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------