USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001basicC]    Script Date: 03/15/2012 12:40:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
ALTER PROCEDURE [dbo].[sp0001detailC]
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = '',
	@categoryId nvarchar(100) = '',
	@shortdescription nvarchar(32) = '',
	@authorname nvarchar(32) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

    -- Insert statements for procedure here
    DECLARE @SQL NVARCHAR(MAX)
SET @SQL = 'SELECT COUNT(*)
			FROM   (SELECT ROW_NUMBER() over(order by ISBN) as No, * 
					FROM (SELECT c.ISBN, c.Title, c.ShortDescription, STUFF(
							   (SELECT ''; '' + au.AuthorName
								FROM (Catalogue ca
									JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN 
									JOIN Author au ON aob.AuthorID = au.AuthorID)
								WHERE ca.ISBN = c.ISBN
								FOR XML PATH('''')),1,2,'''') AS AuthorName, cate.CategoryID
						   FROM LIB.dbo.Catalogue c
								JOIN Category cate ON cate.CategoryID = c.CategoryID
					) AS b'
	IF (@categoryId <> '')
		SET @SQL = @SQL + ' WHERE (CategoryID LIKE '''+ @categoryId + '.%'' OR CategoryID = ''' + @categoryId +''')'
	ELSE
		SET @SQL = @SQL + ' WHERE (CategoryID LIKE ''%'')'
		
	IF (@shortdescription <> '' OR @title <> '' OR @authorname <> '')
	BEGIN
		SET @SQL = @SQL + ' AND ('
		DECLARE @TMP NVARCHAR(MAX) = ''
		IF (@shortdescription <> '')
			SET @TMP = @TMP + ' ShortDescription LIKE ''%' + @shortdescription + '%'' '
		IF (@authorname <> '')
		BEGIN
			IF (@TMP <> '') 
				SET @TMP = @TMP + ' OR '
			SET @TMP = @TMP + ' AuthorName LIKE ''%' + @authorname + '%'' '
		END
		IF (@title <> '')
		BEGIN
			IF (@TMP <> '') 
				SET @TMP = @TMP + ' OR '
			SET @TMP = @TMP + ' Title like ''%' + @title + '%'' '
		END
		SET @SQL = @SQL + @TMP + ')'
	END
SET @SQL = @SQL + ') AS d'
	--PRINT @SQL
	EXEC(@SQL)
END
