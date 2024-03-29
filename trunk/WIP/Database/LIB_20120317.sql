USE [LIB]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Author]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Author]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_User]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_User]
GO
/****** Object:  ForeignKey [FK_Catalogue_Category]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Category]
GO
/****** Object:  ForeignKey [FK_Catalogue_Publisher]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Publisher]
GO
/****** Object:  ForeignKey [FK_Copy_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Copy_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [FK_Copy_Catalogue]
GO
/****** Object:  ForeignKey [FK_RentalDetail_Copy]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_Copy]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_Copy]
GO
/****** Object:  ForeignKey [FK_RentalDetail_User]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_User]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role]
GO
/****** Object:  Table [dbo].[RentalDetail]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_Copy]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_Copy]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_User]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalDetail_ExpandCount]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_ExpandCount]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BorrowDetail_Fine]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_BorrowDetail_Fine]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalDetail_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_RentalDetail_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalDetail]') AND type in (N'U'))
DROP TABLE [dbo].[RentalDetail]
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Copy_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [FK_Copy_Catalogue]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Copy_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [DF_Copy_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Copy_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [DF_Copy_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Copy]') AND type in (N'U'))
DROP TABLE [dbo].[Copy]
GO
/****** Object:  Table [dbo].[AuthorOfBook]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Author]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AuthorOfBook_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [DF_AuthorOfBook_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_AuthorOfBook_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [DF_AuthorOfBook_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]') AND type in (N'U'))
DROP TABLE [dbo].[AuthorOfBook]
GO
/****** Object:  Table [dbo].[BookRegister]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_Catalogue]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_User]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BookRegister_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [DF_BookRegister_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_BookRegister_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [DF_BookRegister_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookRegister]') AND type in (N'U'))
DROP TABLE [dbo].[BookRegister]
GO
/****** Object:  Table [dbo].[Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Category]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Publisher]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Catalogue_RentalTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_RentalTime]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Catalogue_HitTime]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_HitTime]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Catalogue_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Catalogue_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Catalogue]') AND type in (N'U'))
DROP TABLE [dbo].[Catalogue]
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_User_Status]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_Status]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_User_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_User_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Variable_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Variable] DROP CONSTRAINT [DF_Variable_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Variable_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Variable] DROP CONSTRAINT [DF_Variable_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Variable]') AND type in (N'U'))
DROP TABLE [dbo].[Variable]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Category_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [DF_Category_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Category_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [DF_Category_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[DeletedCopy]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_DeletedCopy_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DeletedCopy] DROP CONSTRAINT [DF_DeletedCopy_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_DeletedCopy_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DeletedCopy] DROP CONSTRAINT [DF_DeletedCopy_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletedCopy]') AND type in (N'U'))
DROP TABLE [dbo].[DeletedCopy]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Publisher_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Publisher] DROP CONSTRAINT [DF_Publisher_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Publisher_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Publisher] DROP CONSTRAINT [DF_Publisher_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Publisher]') AND type in (N'U'))
DROP TABLE [dbo].[Publisher]
GO
/****** Object:  Table [dbo].[Quote]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Quote_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Quote] DROP CONSTRAINT [DF_Quote_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Quote_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Quote] DROP CONSTRAINT [DF_Quote_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quote]') AND type in (N'U'))
DROP TABLE [dbo].[Quote]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Role_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [DF_Role_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Role_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [DF_Role_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03/17/2012 01:52:50 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Author_CreatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_CreatedDate]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_Author_UpdatedDate]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_UpdatedDate]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
DROP TABLE [dbo].[Author]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Author]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Author](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Author_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Author_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Role]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Role]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Role](
	[RoleID] [int] NOT NULL,
	[RoleDescription] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Role_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Role_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Quote]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quote]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Quote](
	[QuoteID] [int] IDENTITY(1,1) NOT NULL,
	[QuoteContent] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Speaker] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Quote_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Quote_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Quote] PRIMARY KEY CLUSTERED 
(
	[QuoteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Publisher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Publisher_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Publisher_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[DeletedCopy]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeletedCopy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DeletedCopy](
	[Barcode] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ISBN] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_DeletedCopy_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_DeletedCopy_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_DeletedCopy] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[CategoryID] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CategoryName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Category_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Category_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Variable]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Variable](
	[VariableName] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Value] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Description] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Variable_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Variable_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Variable] PRIMARY KEY CLUSTERED 
(
	[VariableName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserID] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Username] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Password] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RoleID] [int] NOT NULL,
	[Birthday] [date] NOT NULL,
	[Address] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Phone] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IDSN] [nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IssuedDate] [datetime] NOT NULL,
	[ExpiredDate] [datetime] NOT NULL,
	[Status] [int] NOT NULL CONSTRAINT [DF_User_Status]  DEFAULT ((1)),
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_User_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_User_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Catalogue]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Catalogue](
	[ISBN] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Title] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[PublisherID] [int] NOT NULL,
	[ShortDescription] [nvarchar](max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CategoryID] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Language] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Year] [int] NOT NULL,
	[ExpandLimit] [int] NOT NULL,
	[ExpandDateLimit] [int] NOT NULL,
	[NumberOfCopies] [int] NOT NULL,
	[AvailableCopies] [int] NOT NULL,
	[Price] [float] NULL,
	[RentalTime] [int] NOT NULL CONSTRAINT [DF_Catalogue_RentalTime]  DEFAULT ((0)),
	[HitTime] [int] NOT NULL CONSTRAINT [DF_Catalogue_HitTime]  DEFAULT ((0)),
	[Image] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Catalogue_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Catalogue_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Catalogue] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[BookRegister]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BookRegister]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BookRegister](
	[UserID] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ISBN] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[RegisterDate] [datetime] NOT NULL,
	[Note] [ntext] COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_BookRegister_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_BookRegister_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Register] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[ISBN] ASC,
	[RegisterDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[AuthorOfBook]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[AuthorOfBook](
	[AuthorID] [int] NOT NULL,
	[ISBN] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_AuthorOfBook_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_AuthorOfBook_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_AuthorOfBook] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Copy]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Copy](
	[Barcode] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[ISBN] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_Copy_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_Copy_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Copy] PRIMARY KEY CLUSTERED 
(
	[Barcode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[RentalDetail]    Script Date: 03/17/2012 01:52:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RentalDetail]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[RentalDetail](
	[UserID] [nvarchar](40) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Barcode] [nvarchar](13) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[IssuedDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NULL,
	[ExpandCount] [int] NOT NULL CONSTRAINT [DF_RentalDetail_ExpandCount]  DEFAULT ((0)),
	[Fine] [float] NOT NULL CONSTRAINT [DF_BorrowDetail_Fine]  DEFAULT ((0.0)),
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL CONSTRAINT [DF_RentalDetail_CreatedDate]  DEFAULT (getdate()),
	[UpdatedDate] [datetime] NOT NULL CONSTRAINT [DF_RentalDetail_UpdatedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_BorrowDetail] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[Barcode] ASC,
	[IssuedDate] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Author]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorOfBook_Author] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Author]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] CHECK CONSTRAINT [FK_AuthorOfBook_Author]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorOfBook_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_AuthorOfBook_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[AuthorOfBook]'))
ALTER TABLE [dbo].[AuthorOfBook] CHECK CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister]  WITH CHECK ADD  CONSTRAINT [FK_BookRegister_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] CHECK CONSTRAINT [FK_BookRegister_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_User]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister]  WITH CHECK ADD  CONSTRAINT [FK_BookRegister_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BookRegister_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[BookRegister]'))
ALTER TABLE [dbo].[BookRegister] CHECK CONSTRAINT [FK_BookRegister_User]
GO
/****** Object:  ForeignKey [FK_Catalogue_Category]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue]  WITH CHECK ADD  CONSTRAINT [FK_Catalogue_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] CHECK CONSTRAINT [FK_Catalogue_Category]
GO
/****** Object:  ForeignKey [FK_Catalogue_Publisher]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue]  WITH CHECK ADD  CONSTRAINT [FK_Catalogue_Publisher] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Catalogue_Publisher]') AND parent_object_id = OBJECT_ID(N'[dbo].[Catalogue]'))
ALTER TABLE [dbo].[Catalogue] CHECK CONSTRAINT [FK_Catalogue_Publisher]
GO
/****** Object:  ForeignKey [FK_Copy_Catalogue]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Copy_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD  CONSTRAINT [FK_Copy_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Copy_Catalogue]') AND parent_object_id = OBJECT_ID(N'[dbo].[Copy]'))
ALTER TABLE [dbo].[Copy] CHECK CONSTRAINT [FK_Copy_Catalogue]
GO
/****** Object:  ForeignKey [FK_RentalDetail_Copy]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_Copy]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentalDetail_Copy] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Copy] ([Barcode])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_Copy]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] CHECK CONSTRAINT [FK_RentalDetail_Copy]
GO
/****** Object:  ForeignKey [FK_RentalDetail_User]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentalDetail_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_RentalDetail_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[RentalDetail]'))
ALTER TABLE [dbo].[RentalDetail] CHECK CONSTRAINT [FK_RentalDetail_User]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 03/17/2012 01:52:50 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_Role]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
