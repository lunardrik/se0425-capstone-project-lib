USE [LIB]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Author]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Author]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_User]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_User]
GO
/****** Object:  ForeignKey [FK_Catalogue_Category]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Category]
GO
/****** Object:  ForeignKey [FK_Catalogue_Publisher]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Publisher]
GO
/****** Object:  ForeignKey [FK_Copy_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [FK_Copy_Catalogue]
GO
/****** Object:  ForeignKey [FK_RentalDetail_Copy]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_Copy]
GO
/****** Object:  ForeignKey [FK_RentalDetail_User]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_User]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 03/15/2012 10:32:12 ******/
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role]
GO
/****** Object:  Table [dbo].[RentalDetail]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_Copy]
GO
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [FK_RentalDetail_User]
GO
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_ExpandCount]
GO
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_BorrowDetail_Fine]
GO
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_CreatedDate]
GO
ALTER TABLE [dbo].[RentalDetail] DROP CONSTRAINT [DF_RentalDetail_UpdatedDate]
GO
DROP TABLE [dbo].[RentalDetail]
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [FK_Copy_Catalogue]
GO
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [DF_Copy_CreatedDate]
GO
ALTER TABLE [dbo].[Copy] DROP CONSTRAINT [DF_Copy_UpdatedDate]
GO
DROP TABLE [dbo].[Copy]
GO
/****** Object:  Table [dbo].[AuthorOfBook]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Author]
GO
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [DF_AuthorOfBook_CreatedDate]
GO
ALTER TABLE [dbo].[AuthorOfBook] DROP CONSTRAINT [DF_AuthorOfBook_UpdatedDate]
GO
DROP TABLE [dbo].[AuthorOfBook]
GO
/****** Object:  Table [dbo].[BookRegister]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_Catalogue]
GO
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [FK_BookRegister_User]
GO
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [DF_BookRegister_CreatedDate]
GO
ALTER TABLE [dbo].[BookRegister] DROP CONSTRAINT [DF_BookRegister_UpdatedDate]
GO
DROP TABLE [dbo].[BookRegister]
GO
/****** Object:  Table [dbo].[Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Category]
GO
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [FK_Catalogue_Publisher]
GO
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_RentalTime]
GO
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_HitTime]
GO
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_CreatedDate]
GO
ALTER TABLE [dbo].[Catalogue] DROP CONSTRAINT [DF_Catalogue_UpdatedDate]
GO
DROP TABLE [dbo].[Catalogue]
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/15/2012 10:32:12 ******/
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Role]
GO
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_Status]
GO
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_CreatedDate]
GO
ALTER TABLE [dbo].[User] DROP CONSTRAINT [DF_User_UpdatedDate]
GO
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 03/15/2012 10:32:12 ******/
ALTER TABLE [dbo].[Variable] DROP CONSTRAINT [DF_Variable_CreatedDate]
GO
ALTER TABLE [dbo].[Variable] DROP CONSTRAINT [DF_Variable_UpdatedDate]
GO
DROP TABLE [dbo].[Variable]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [DF_Category_CreatedDate]
GO
ALTER TABLE [dbo].[Category] DROP CONSTRAINT [DF_Category_UpdatedDate]
GO
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[DeletedCopy]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[DeletedCopy] DROP CONSTRAINT [DF_DeletedCopy_CreatedDate]
GO
ALTER TABLE [dbo].[DeletedCopy] DROP CONSTRAINT [DF_DeletedCopy_UpdatedDate]
GO
DROP TABLE [dbo].[DeletedCopy]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Publisher] DROP CONSTRAINT [DF_Publisher_CreatedDate]
GO
ALTER TABLE [dbo].[Publisher] DROP CONSTRAINT [DF_Publisher_UpdatedDate]
GO
DROP TABLE [dbo].[Publisher]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [DF_Role_CreatedDate]
GO
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [DF_Role_UpdatedDate]
GO
DROP TABLE [dbo].[Role]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_CreatedDate]
GO
ALTER TABLE [dbo].[Author] DROP CONSTRAINT [DF_Author_UpdatedDate]
GO
DROP TABLE [dbo].[Author]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Role]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[DeletedCopy]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Category]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 03/15/2012 10:32:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[User]    Script Date: 03/15/2012 10:32:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[BookRegister]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[AuthorOfBook]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Copy]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[RentalDetail]    Script Date: 03/15/2012 10:32:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Author]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[AuthorOfBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorOfBook_Author] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
GO
ALTER TABLE [dbo].[AuthorOfBook] CHECK CONSTRAINT [FK_AuthorOfBook_Author]
GO
/****** Object:  ForeignKey [FK_AuthorOfBook_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[AuthorOfBook]  WITH CHECK ADD  CONSTRAINT [FK_AuthorOfBook_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
ALTER TABLE [dbo].[AuthorOfBook] CHECK CONSTRAINT [FK_AuthorOfBook_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[BookRegister]  WITH CHECK ADD  CONSTRAINT [FK_BookRegister_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
ALTER TABLE [dbo].[BookRegister] CHECK CONSTRAINT [FK_BookRegister_Catalogue]
GO
/****** Object:  ForeignKey [FK_BookRegister_User]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[BookRegister]  WITH CHECK ADD  CONSTRAINT [FK_BookRegister_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[BookRegister] CHECK CONSTRAINT [FK_BookRegister_User]
GO
/****** Object:  ForeignKey [FK_Catalogue_Category]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Catalogue]  WITH CHECK ADD  CONSTRAINT [FK_Catalogue_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Catalogue] CHECK CONSTRAINT [FK_Catalogue_Category]
GO
/****** Object:  ForeignKey [FK_Catalogue_Publisher]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Catalogue]  WITH CHECK ADD  CONSTRAINT [FK_Catalogue_Publisher] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
GO
ALTER TABLE [dbo].[Catalogue] CHECK CONSTRAINT [FK_Catalogue_Publisher]
GO
/****** Object:  ForeignKey [FK_Copy_Catalogue]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[Copy]  WITH CHECK ADD  CONSTRAINT [FK_Copy_Catalogue] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Catalogue] ([ISBN])
GO
ALTER TABLE [dbo].[Copy] CHECK CONSTRAINT [FK_Copy_Catalogue]
GO
/****** Object:  ForeignKey [FK_RentalDetail_Copy]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[RentalDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentalDetail_Copy] FOREIGN KEY([Barcode])
REFERENCES [dbo].[Copy] ([Barcode])
GO
ALTER TABLE [dbo].[RentalDetail] CHECK CONSTRAINT [FK_RentalDetail_Copy]
GO
/****** Object:  ForeignKey [FK_RentalDetail_User]    Script Date: 03/15/2012 10:32:11 ******/
ALTER TABLE [dbo].[RentalDetail]  WITH CHECK ADD  CONSTRAINT [FK_RentalDetail_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[RentalDetail] CHECK CONSTRAINT [FK_RentalDetail_User]
GO
/****** Object:  ForeignKey [FK_User_Role]    Script Date: 03/15/2012 10:32:12 ******/
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
