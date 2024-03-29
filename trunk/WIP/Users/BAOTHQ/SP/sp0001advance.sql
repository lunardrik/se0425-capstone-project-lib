USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001advance]    Script Date: 04/07/2012 08:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp0001advance] 
	-- Add the parameters for the stored procedure here
	@param1 nvarchar (200) = '',
	@param2 nvarchar (200) = '',
	@param3 nvarchar (200) = '',
	@sRow nvarchar(10) = '1',
	@eRow nvarchar(10) = '1'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	exec('SELECT * FROM (SELECT ROW_NUMBER() over(order by c.ISBN) as No, c.ISBN, c.Title, p.PublisherName, c.ShortDescription, STUFF( 
                 (SELECT ''; '' + au.AuthorName 
                 FROM (Catalogue ca 
                 JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN JOIN Author au ON aob.AuthorID = au.AuthorID) 
                 WHERE ca.ISBN = c.ISBN 
                 FOR XML PATH('''')),1,2,'''') AS AuthorName, cate.CategoryName, c.Image 
                 FROM LIB.dbo.Catalogue c 
                 inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID 
                 inner join LIB.dbo.AuthorOfBook aob on aob.ISBN = c.ISBN 
                 inner join LIB.dbo.Author a on aob.AuthorID = a.AuthorID 
                 inner join LIB.dbo.Category cate on cate.CategoryID = c.CategoryID 
                 WHERE '+@param1 + @param2 + @param3 + '
                 )as b WHERE b.No>=' + @srow+ ' and b.No<='+@eRow)
END
