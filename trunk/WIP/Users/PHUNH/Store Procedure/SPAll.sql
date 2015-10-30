USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1104]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on DeletedCopy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP1104]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM DeletedCopy WHERE Barcode = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP1103]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to DeletedCopy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP1103]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE DeletedCopy
	SET ISBN = @Param2,
		"Status" = @Param3,
		CreatedDate = @Param4,
		UpdatedDate = @Param5
	WHERE Barcode = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP1102]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to DeletedCopy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP1102] 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO DeletedCopy VALUES(@Param1,@Param2,@Param3,@Param4,@Param5)
END
GO
/****** Object:  StoredProcedure [dbo].[SP1101ISBN]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific isbn>
-- =============================================
CREATE PROCEDURE [dbo].[SP1101ISBN]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM DeletedCopy
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP1101BC]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP1101BC]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM DeletedCopy
	WHERE Barcode = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0404]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on Publisher table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0404]
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM Publisher
	WHERE PublisherID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0403]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to publisher table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0403]
	-- Add the parameters for the stored procedure here
	@Param1 int, 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Publisher
	SET PublisherName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE PublisherID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0402]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to publisher table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0402] 
	-- Add the parameters for the stored procedure here
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Publisher VALUES(@Param2,@Param3,@Param4)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401PI]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on Publisher table which have specific PublisherID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0401PI]
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401Name]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on Publisher table which have specific PublisherName>
-- =============================================
CREATE PROCEDURE [dbo].[SP0401Name]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(50)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherName LIKE @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401ALL]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on publisher table minus unknown publisher>
-- =============================================
CREATE PROCEDURE [dbo].[SP0401ALL]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherID <> 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP0304]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on author table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0304]
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM Author
	WHERE AuthorID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0303]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to author table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0303]
	-- Add the parameters for the stored procedure here
	@Param1 int, 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Author
	SET AuthorName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE AuthorID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0302]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to author table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0302] 
	-- Add the parameters for the stored procedure here
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Author VALUES(@Param2,@Param3,@Param4)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301Name]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on author table which have specific authorName>
-- =============================================
CREATE PROCEDURE [dbo].[SP0301Name]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(50)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Author
	WHERE AuthorName LIKE @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301ALL]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on author table minus unknown author>
-- =============================================
Create PROCEDURE [dbo].[SP0301ALL]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Author
	WHERE AuthorID <> 0
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301AI]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on author table which have specific authorID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0301AI]
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Author
	WHERE AuthorID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0204]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on category table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0204]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM Category
	WHERE CategoryID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0203]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to category table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0203]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40), 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Category
	SET CategoryName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE CategoryID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0202]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to category table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0202] 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40), 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Category VALUES(@Param1,@Param2,@Param3,@Param4)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201Name]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on category table which have specific categoryName>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201Name]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(50)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryName LIKE @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201CI]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on category table which have specific categoryID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201CI]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201ALL]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on category table minus uncategorized category>
-- =============================================
Create PROCEDURE [dbo].[SP0201ALL]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID <> '0'
END
GO
/****** Object:  StoredProcedure [dbo].[SP0104]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on catalogue table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0104]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Catalogue
	SET AvailableCopies = -1,
		NumberOfCopies = -1
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0103]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to catalogue table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0103]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(100),
	@Param3 int,
	@Param4 NVARCHAR(MAX),
	@Param5 NVARCHAR(40),
	@Param6 NVARCHAR(50),
	@Param7 int,
	@Param8 int,
	@Param9 int,
	@Param10 int,
	@Param11 int,
	@Param12 float,
	@Param13 NVARCHAR(100),
	@Param14 DATETIME,
	@Param15 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Catalogue
	SET Title = @Param2,
		PublisherID = @Param3,
		ShortDescription = @Param4,
		CategoryID = @Param5,
		"Language" = @Param6,
		"Year" = @Param7,
		ExpandLimit = @Param8,
		ExpandDateLimit = @Param9,
		NumberOfCopies = @Param10,
		AvailableCopies = @Param11,
		Price = @Param12,
		"Image" = @Param13,
		CreatedDate = @Param14,
		UpdatedDate = @Param15
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0102]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to catalogue table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0102] 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(100),
	@Param3 int,
	@Param4 NVARCHAR(MAX),
	@Param5 NVARCHAR(40),
	@Param6 NVARCHAR(50),
	@Param7 int,
	@Param8 int,
	@Param9 int,
	@Param10 int,
	@Param11 int,
	@Param12 float,
	@Param13 NVARCHAR(100),
	@Param14 DATETIME,
	@Param15 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Catalogue VALUES(@Param1,@Param2,@Param3,@Param4,@Param5,@Param6,@Param7,@Param8,@Param9,@Param10,@Param11,@Param12,@Param13,@Param14,@Param15)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101PI]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101PI]
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE PublisherID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101ISBN]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific isbn>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101ISBN]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101CI]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101CI]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE CategoryID = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0804]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on AuthorOfBook table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0804]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;	
	DELETE FROM AuthorOfBook WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0802]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to AuthorOfBook table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0802] 
	-- Add the parameters for the stored procedure here
	@Param1 int, 
	@Param2 NVARCHAR(13),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO AuthorOfBook VALUES(@Param1,@Param2,@Param3,@Param4)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0801ISBN]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific isbn>
-- =============================================
Create PROCEDURE [dbo].[SP0801ISBN]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM AuthorOfBook
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0504]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on Copy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0504]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Copy
	SET Status = 3 
	WHERE Barcode = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0503]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to copy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0503]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Copy
	SET ISBN = @Param2,
		"Status" = @Param3,
		CreatedDate = @Param4,
		UpdatedDate = @Param5
	WHERE Barcode = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0502]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to copy table>
-- =============================================
CREATE PROCEDURE [dbo].[SP0502] 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Copy VALUES(@Param1,@Param2,@Param3,@Param4,@Param5)
END
GO
/****** Object:  StoredProcedure [dbo].[SP0501ISBN]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on copy table which have specific isbn>
-- =============================================
CREATE PROCEDURE [dbo].[SP0501ISBN]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Copy
	WHERE ISBN = @Param1
END
GO
/****** Object:  StoredProcedure [dbo].[SP0501BC]    Script Date: 03/09/2012 12:49:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on copy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP0501BC]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Copy
	WHERE Barcode = @Param1
END
GO
