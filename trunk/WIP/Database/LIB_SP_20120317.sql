USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0004]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0004]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0004]
GO
/****** Object:  StoredProcedure [dbo].[SP0901All]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901All]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0901All]
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByBarcode]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByBarcode]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0901ByBarcode]
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByIssuedDate]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByIssuedDate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0901ByIssuedDate]
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByStatus]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0901ByStatus]
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0901ByUserID]
GO
/****** Object:  StoredProcedure [dbo].[SP0902]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0902]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0902]
GO
/****** Object:  StoredProcedure [dbo].[SP0903]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0903]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0903]
GO
/****** Object:  StoredProcedure [dbo].[SP1001All]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001All]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1001All]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByISBN]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByISBN]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1001ByISBN]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByRegisterDate]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByRegisterDate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1001ByRegisterDate]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByStatus]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByStatus]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1001ByStatus]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1001ByUserID]
GO
/****** Object:  StoredProcedure [dbo].[SP1002]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1002]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1002]
GO
/****** Object:  StoredProcedure [dbo].[SP1003]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1003]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1003]
GO
/****** Object:  StoredProcedure [dbo].[SP1004]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1004]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1004]
GO
/****** Object:  StoredProcedure [dbo].[SP0501BC]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0501BC]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0501BC]
GO
/****** Object:  StoredProcedure [dbo].[SP0501ISBN]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0501ISBN]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0501ISBN]
GO
/****** Object:  StoredProcedure [dbo].[SP0502]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0502]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0502]
GO
/****** Object:  StoredProcedure [dbo].[SP0503]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0503]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0503]
GO
/****** Object:  StoredProcedure [dbo].[SP0504]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0504]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0504]
GO
/****** Object:  StoredProcedure [dbo].[sp0001author]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001author]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0001author]
GO
/****** Object:  StoredProcedure [dbo].[sp0001authorC]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001authorC]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0001authorC]
GO
/****** Object:  StoredProcedure [dbo].[sp0001hit]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001hit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0001hit]
GO
/****** Object:  StoredProcedure [dbo].[SP0801ISBN]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0801ISBN]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0801ISBN]
GO
/****** Object:  StoredProcedure [dbo].[SP0802]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0802]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0802]
GO
/****** Object:  StoredProcedure [dbo].[SP0804]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0804]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0804]
GO
/****** Object:  StoredProcedure [dbo].[sp0002]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0002]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0002]
GO
/****** Object:  StoredProcedure [dbo].[SP0601All]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601All]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0601All]
GO
/****** Object:  StoredProcedure [dbo].[SP0601ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601ByUserID]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0601ByUserID]
GO
/****** Object:  StoredProcedure [dbo].[SP0601ByUsername]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601ByUsername]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0601ByUsername]
GO
/****** Object:  StoredProcedure [dbo].[SP0603]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0603]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0603]
GO
/****** Object:  StoredProcedure [dbo].[SP0101CI]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101CI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0101CI]
GO
/****** Object:  StoredProcedure [dbo].[SP0101CIC]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101CIC]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0101CIC]
GO
/****** Object:  StoredProcedure [dbo].[SP0101ISBN]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101ISBN]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0101ISBN]
GO
/****** Object:  StoredProcedure [dbo].[SP0101PI]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101PI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0101PI]
GO
/****** Object:  StoredProcedure [dbo].[SP0102]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0102]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0102]
GO
/****** Object:  StoredProcedure [dbo].[SP0103]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0103]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0103]
GO
/****** Object:  StoredProcedure [dbo].[SP0104]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0104]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0104]
GO
/****** Object:  StoredProcedure [dbo].[SP0201ALL]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201ALL]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0201ALL]
GO
/****** Object:  StoredProcedure [dbo].[SP0201CI]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201CI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0201CI]
GO
/****** Object:  StoredProcedure [dbo].[SP0201MASTER]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201MASTER]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0201MASTER]
GO
/****** Object:  StoredProcedure [dbo].[SP0201Name]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201Name]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0201Name]
GO
/****** Object:  StoredProcedure [dbo].[SP0201SUB]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201SUB]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0201SUB]
GO
/****** Object:  StoredProcedure [dbo].[SP0202]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0202]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0202]
GO
/****** Object:  StoredProcedure [dbo].[SP0203]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0203]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0203]
GO
/****** Object:  StoredProcedure [dbo].[SP0204]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0204]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0204]
GO
/****** Object:  StoredProcedure [dbo].[SP0301AI]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301AI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0301AI]
GO
/****** Object:  StoredProcedure [dbo].[SP0301ALL]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301ALL]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0301ALL]
GO
/****** Object:  StoredProcedure [dbo].[SP0301Name]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301Name]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0301Name]
GO
/****** Object:  StoredProcedure [dbo].[SP0302]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0302]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0302]
GO
/****** Object:  StoredProcedure [dbo].[SP0303]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0303]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0303]
GO
/****** Object:  StoredProcedure [dbo].[SP0304]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0304]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0304]
GO
/****** Object:  StoredProcedure [dbo].[SP0401ALL]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401ALL]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0401ALL]
GO
/****** Object:  StoredProcedure [dbo].[SP0401Name]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401Name]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0401Name]
GO
/****** Object:  StoredProcedure [dbo].[SP0401PI]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401PI]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0401PI]
GO
/****** Object:  StoredProcedure [dbo].[SP0402]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0402]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0402]
GO
/****** Object:  StoredProcedure [dbo].[SP0403]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0403]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0403]
GO
/****** Object:  StoredProcedure [dbo].[SP0404]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0404]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP0404]
GO
/****** Object:  StoredProcedure [dbo].[SP1101BC]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1101BC]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1101BC]
GO
/****** Object:  StoredProcedure [dbo].[SP1101ISBN]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1101ISBN]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1101ISBN]
GO
/****** Object:  StoredProcedure [dbo].[SP1102]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1102]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1102]
GO
/****** Object:  StoredProcedure [dbo].[SP1103]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1103]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1103]
GO
/****** Object:  StoredProcedure [dbo].[SP1104]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1104]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1104]
GO
/****** Object:  StoredProcedure [dbo].[SP1201VarName]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1201VarName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1201VarName]
GO
/****** Object:  StoredProcedure [dbo].[SP1203VarName]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1203VarName]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1203VarName]
GO
/****** Object:  StoredProcedure [dbo].[SP1301RAND]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1301RAND]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[SP1301RAND]
GO
/****** Object:  StoredProcedure [dbo].[sp0001detail]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001detail]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0001detail]
GO
/****** Object:  StoredProcedure [dbo].[sp0001detailC]    Script Date: 03/17/2012 01:54:43 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001detailC]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp0001detailC]
GO
/****** Object:  StoredProcedure [dbo].[sp0001detailC]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001detailC]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001detailC]
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = '''',
	@categoryId nvarchar(100) = '''',
	@shortdescription nvarchar(32) = '''',
	@authorname nvarchar(32) = ''''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

    -- Insert statements for procedure here
    DECLARE @SQL NVARCHAR(MAX)
SET @SQL = ''SELECT COUNT(*)
			FROM   (SELECT ROW_NUMBER() over(order by ISBN) as No, * 
					FROM (SELECT c.ISBN, c.Title, c.ShortDescription, STUFF(
							   (SELECT ''''; '''' + au.AuthorName
								FROM (Catalogue ca
									JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN 
									JOIN Author au ON aob.AuthorID = au.AuthorID)
								WHERE ca.ISBN = c.ISBN
								FOR XML PATH('''''''')),1,2,'''''''') AS AuthorName, cate.CategoryID
						   FROM LIB.dbo.Catalogue c
								JOIN Category cate ON cate.CategoryID = c.CategoryID
					) AS b''
	IF (@categoryId <> '''')
		SET @SQL = @SQL + '' WHERE (CategoryID LIKE ''''''+ @categoryId + ''.%'''' OR CategoryID = '''''' + @categoryId +'''''')''
	ELSE
		SET @SQL = @SQL + '' WHERE (CategoryID LIKE ''''%'''')''
		
	IF (@shortdescription <> '''' OR @title <> '''' OR @authorname <> '''')
	BEGIN
		SET @SQL = @SQL + '' AND (''
		DECLARE @TMP NVARCHAR(MAX) = ''''
		IF (@shortdescription <> '''')
			SET @TMP = @TMP + '' ShortDescription LIKE ''''%'' + @shortdescription + ''%'''' ''
		IF (@authorname <> '''')
		BEGIN
			IF (@TMP <> '''') 
				SET @TMP = @TMP + '' OR ''
			SET @TMP = @TMP + '' AuthorName LIKE ''''%'' + @authorname + ''%'''' ''
		END
		IF (@title <> '''')
		BEGIN
			IF (@TMP <> '''') 
				SET @TMP = @TMP + '' OR ''
			SET @TMP = @TMP + '' Title like ''''%'' + @title + ''%'''' ''
		END
		SET @SQL = @SQL + @TMP + '')''
	END
SET @SQL = @SQL + '') AS d''
	--PRINT @SQL
	EXEC(@SQL)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0001detail]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001detail]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001detail]
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = '''',
	@categoryId nvarchar(100) = '''',
	@shortdescription nvarchar(32) = '''',
	@authorname nvarchar(32) = '''',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    DECLARE @SQL NVARCHAR(MAX)
SET @SQL = ''SELECT * 
			FROM   (SELECT ROW_NUMBER() over(order by ISBN) as No, * 
					FROM (SELECT c.ISBN, c.Title, p.PublisherName, c.ShortDescription, STUFF(
							   (SELECT ''''; '''' + au.AuthorName
								FROM (Catalogue ca
									JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN 
									JOIN Author au ON aob.AuthorID = au.AuthorID)
								WHERE ca.ISBN = c.ISBN
								FOR XML PATH('''''''')),1,2,'''''''') AS AuthorName, cate.CategoryName, cate.CategoryID, c.Image
						   FROM LIB.dbo.Catalogue c
								INNER JOIN LIB.dbo.Publisher p ON c.PublisherID = p.PublisherID 
								JOIN Category cate ON cate.CategoryID = c.CategoryID
					) AS b''
	IF (@categoryId <> '''')
		SET @SQL = @SQL + '' WHERE (CategoryID LIKE ''''''+ @categoryId + ''.%'''' OR CategoryID = '''''' + @categoryId +'''''')''
	ELSE
		SET @SQL = @SQL + '' WHERE (CategoryID LIKE ''''%'''')''
		
	IF (@shortdescription <> '''' OR @title <> '''' OR @authorname <> '''')
	BEGIN
		SET @SQL = @SQL + '' AND (''
		DECLARE @TMP NVARCHAR(MAX) = ''''
		IF (@shortdescription <> '''')
			SET @TMP = @TMP + '' ShortDescription LIKE ''''%'' + @shortdescription + ''%'''' ''
		IF (@authorname <> '''')
		BEGIN
			IF (@TMP <> '''') 
				SET @TMP = @TMP + '' OR ''
			SET @TMP = @TMP + '' AuthorName LIKE ''''%'' + @authorname + ''%'''' ''
		END
		IF (@title <> '''')
		BEGIN
			IF (@TMP <> '''') 
				SET @TMP = @TMP + '' OR ''
			SET @TMP = @TMP + '' Title like ''''%'' + @title + ''%'''' ''
		END
		SET @SQL = @SQL + @TMP + '')''
	END
SET @SQL = @SQL + '') AS d
			WHERE d.No>='' + CAST(@rowStart AS NVARCHAR(10)) +'' and d.No<= '' + CAST(@rowEnd AS NVARCHAR(10))
	--PRINT @SQL
	EXEC(@SQL)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1301RAND]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1301RAND]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP1301RAND]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	
	SELECT TOP 1 QuoteContent, Speaker FROM Quote
	ORDER BY NEWID()

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1203VarName]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1203VarName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP1203VarName]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40),
	@Param2 NVARCHAR(MAX)
AS
BEGIN	
	SET NOCOUNT ON;
	
	UPDATE Variable
	SET Value = @Param2
	WHERE VariableName = @Param1
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1201VarName]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1201VarName]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP1201VarName]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	
	SELECT * 
	FROM Variable
	WHERE VariableName = @Param1
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1104]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1104]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1103]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1103]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1102]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1102]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1101ISBN]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1101ISBN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1101BC]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1101BC]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0404]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0404]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0403]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0403]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0402]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0402]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401PI]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401PI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401Name]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401Name]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0401ALL]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0401ALL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0304]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0304]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0303]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0303]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0302]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0302]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301Name]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301Name]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301ALL]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301ALL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0301AI]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0301AI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0204]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0204]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0203]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0203]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0202]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0202]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201SUB]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201SUB]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on category table minus uncategorized category>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201SUB]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID LIKE @Param1 + ''.%'' AND CHARINDEX(''.'', CategoryID, LEN(@Param1 + ''.'') + 1) = 0
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201Name]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201Name]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201MASTER]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201MASTER]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on category table minus uncategorized category>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201MASTER]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID <> ''0'' AND CHARINDEX(''.'', CategoryID) = 0
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201CI]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201CI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0201ALL]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0201ALL]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
	WHERE CategoryID <> ''0''
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0104]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0104]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0103]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0103]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0102]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0102]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
	INSERT INTO Catalogue(ISBN, Title, PublisherID, ShortDescription, CategoryID, Language, Year, ExpandLimit, ExpandDateLimit, NumberOfCopies, AvailableCopies, Price, Image, CreatedDate, UpdatedDate) 
	VALUES(@Param1,@Param2,@Param3,@Param4,@Param5,@Param6,@Param7,@Param8,@Param9,@Param10,@Param11,@Param12,@Param13,@Param14,@Param15)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101PI]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101PI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101ISBN]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101ISBN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
	
	UPDATE Catalogue
	SET HitTime = HitTime + 1
	WHERE ISBN = @Param1
	
	SELECT * 
	FROM Catalogue
	WHERE ISBN = @Param1
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101CIC]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101CIC]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101CIC]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT COUNT(*)
	FROM Catalogue
	WHERE CategoryID LIKE @Param1 + ''%''
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0101CI]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0101CI]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0603]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0603]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0603] (@UserID NVARCHAR(40), @Username NVARCHAR(50), @Password NVARCHAR(50), 
	@RoleID INT, @Birthday DATE, @Address NVARCHAR(100), @Phone NVARCHAR(50), @Email NVARCHAR(50),
	@IDSN NVARCHAR(10), @IssuedDate DATETIME, @ExpiredDate DATETIME, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE [dbo].[User]
	SET [Username] = @Username, 
		[Password] = @Password, 
		[RoleID] = @RoleID, 
		[Birthday] = @Birthday, 
		[Address] = @Address, 
		[Phone] = @Phone, 
		[Email] = @Email, 
		[IDSN] = @IDSN, 
		[IssuedDate] = @IssuedDate, 
		[ExpiredDate] = @ExpiredDate, 
		[CreatedDate] = @CreatedDate, 
		[UpdatedDate] = @UpdatedDate
	WHERE UserID = @UserID;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0601ByUsername]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601ByUsername]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP0601ByUsername] (@Username NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE Username = @Username;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0601ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601ByUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP0601ByUserID] (@UserID NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE UserID = @UserID;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0601All]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0601All]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0601All]
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0002]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0002]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of users>
-- =============================================
CREATE PROCEDURE [dbo].[sp0002] 
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '''',
	@role int = 1,
	@eMail nvarchar(50) = '''',
	@idsn nvarchar(10) = '''',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM (SELECT ROW_NUMBER() over(order by u.UserID) as No, u.UserID, u.Username, r.RoleDescription, u.IDSN FROM LIB.dbo.[User] u
	INNER JOIN LIB.dbo.Role r on r.RoleID = u.RoleID
	WHERE u.Username like ''%'' + @username + ''%'' 
			or u.RoleID = @role
			or u.Email like ''%'' + @eMail + ''%''
			or u.IDSN like ''%'' + @idsn + ''%'' )as b
	WHERE b.No>@rowStart and b.No<=@rowEnd
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0804]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0804]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0802]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0802]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0801ISBN]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0801ISBN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0001hit]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001hit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001hit]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT TOP 9 No, ISBN, Title, PublisherName, ShortDescription, HitTime, AuthorName, CategoryName, Image  FROM 
	(SELECT ROW_NUMBER() over(order by c.ISBN) as No, c.ISBN, c.Title, p.PublisherName, c.ShortDescription, c.HitTime, STUFF(
(SELECT ''; '' + au.AuthorName
FROM (Catalogue ca
JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN JOIN Author au ON aob.AuthorID = au.AuthorID)
WHERE ca.ISBN = c.ISBN
FOR XML PATH('''')),1,2,'''') AS AuthorName, cate.CategoryName, c.Image
from LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID join Category cate on cate.CategoryID = c.CategoryID
	) as b
	WHERE 1=1
	ORDER BY HitTime DESC
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0001authorC]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001authorC]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001authorC]
	-- Add the parameters for the stored procedure here
	@authorId nvarchar(100) = ''''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT COUNT(*) FROM Catalogue c join AuthorOfBook aob on  c.ISBN = aob.ISBN
	WHERE aob.AuthorID = @authorId
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0001author]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0001author]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001author]
	-- Add the parameters for the stored procedure here
	@authorId nvarchar(100) = '''',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT * FROM (SELECT ROW_NUMBER() over(order by c.ISBN) as No, c.ISBN, c.Title, p.PublisherName, c.ShortDescription, STUFF(
(SELECT ''; '' + au.AuthorName
FROM (Catalogue ca
JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN JOIN Author au ON aob.AuthorID = au.AuthorID)
WHERE ca.ISBN = c.ISBN
FOR XML PATH('''')),1,2,'''') AS AuthorName, cate.CategoryName, c.Image
from LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID join AuthorOfBook aob on c.ISBN = aob.ISBN join Category cate on c.CategoryID = cate.CategoryID
	WHERE aob.AuthorID = @authorId 
	) as b
	WHERE b.No>=@rowStart and b.No<=@rowEnd
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0504]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0504]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0503]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0503]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0502]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0502]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0501ISBN]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0501ISBN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0501BC]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0501BC]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
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
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1004]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1004]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1004] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME)
AS
BEGIN
	DELETE FROM BookRegister
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1003]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1003]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP1003] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note Text, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE BookRegister
	SET Note = @Note,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate,
		[Status] = @Status
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1002]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1002]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1002] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note Text, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO BookRegister
	VALUES (@UserID, @ISBN, @RegisterDate, @Note, @Status, @CreatedDate, @UpdatedDate);
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1001ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE UserID = @UserID;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByStatus]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByStatus]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1001ByStatus] (@Status INT)
AS
BEGIN
	SELECT * 
	FROM BookRegister
	WHERE BookRegister.Status = @Status;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByRegisterDate]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByRegisterDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1001ByRegisterDate] (@RegisterDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE RegisterDate = @RegisterDate;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByISBN]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001ByISBN]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1001ByISBN] (@ISBN NVARCHAR(13))
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE ISBN = @ISBN;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP1001All]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP1001All]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP1001All]
AS
BEGIN
	SELECT * FROM dbo.BookRegister;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0903]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0903]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0903] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, @ExpandCount INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE RentalDetail
	SET DueDate = @DueDate,
		ReturnDate = @ReturnDate,
		Fine = @Fine,
		RentalDetail.Status = @Status,
		ExpandCount = @ExpandCount,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate
	WHERE UserID = @UserID AND Barcode = @Barcode AND IssuedDate = @IssuedDate;
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0902]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0902]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0902] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, @ExpandCount INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE Catalogue
	SET RentalTime = RentalTime + 1
	WHERE (ISBN = (SELECT c.ISBN FROM Copy c WHERE c.Barcode = @Barcode))

	INSERT INTO RentalDetail
	VALUES (@UserID, @Barcode, @IssuedDate, @DueDate, @ReturnDate, @Fine,
		@Status, @ExpandCount, @CreatedDate, @UpdatedDate);
END

' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByUserID]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByUserID]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0901ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE UserID = @UserID;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByStatus]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByStatus]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP0901ByStatus] (@Status INT)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE RentalDetail.Status = @Status;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByIssuedDate]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByIssuedDate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP0901ByIssuedDate] (@IssuedDate DATETIME)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE IssuedDate = @IssuedDate;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0901ByBarcode]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901ByBarcode]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE PROCEDURE [dbo].[SP0901ByBarcode] (@Barcode NVARCHAR(13))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE Barcode = @Barcode;
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP0901All]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP0901All]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE PROCEDURE [dbo].[SP0901All]
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
END


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp0004]    Script Date: 03/17/2012 01:54:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp0004]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of books rentals>
-- =============================================
CREATE PROCEDURE [dbo].[sp0004]
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '''',
	@title nvarchar(20) = '''',
	@status int = 0,
	@issuedDate datetime = ''2012-01-01'',
	@dueDate datetime = ''2012-01-01'',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM (SELECT ROW_NUMBER() over(order by rd.DueDate desc) as No, rd.Barcode, u.Username, rd.Status, rd.IssuedDate, rd.DueDate FROM LIB.dbo.RentalDetail rd 
	INNER JOIN LIB.dbo.[User] u on u.UserID = rd.UserID
	INNER JOIN LIB.dbo.Copy co on co.Barcode = rd.Barcode
	INNER JOIN LIB.dbo.Catalogue c on c.ISBN = co.ISBN
	where u.Username like ''%'' + @username + ''%'' or
			c.Title like ''%'' + @title + ''%'' or
			rd.Status = @status or
			rd.IssuedDate >= @issuedDate or 
			rd.DueDate >= @dueDate) as b
	WHERE b.No>@rowStart and b.No<=@rowEnd
	
END
' 
END
GO
