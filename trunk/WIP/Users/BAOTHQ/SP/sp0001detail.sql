USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001detail]    Script Date: 03/15/2012 10:01:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp0001detail] 
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = '',
	@author nvarchar(50) = '',
	@cate nvarchar(50) = '',
	@publisher nvarchar(50) = '',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM (SELECT ROW_NUMBER() over(order by c.ISBN) as No, c.ISBN, c.Title, p.PublisherName, c.ShortDescription, STUFF(
(SELECT '; ' + au.AuthorName
FROM (Catalogue ca
JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN JOIN Author au ON aob.AuthorID = au.AuthorID)
WHERE ca.ISBN = c.ISBN
FOR XML PATH('')),1,2,'') AS AuthorName, cate.CategoryName, c.Image
	FROM LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID
	inner join LIB.dbo.AuthorOfBook aob on aob.ISBN = c.ISBN
	inner join LIB.dbo.Author a on aob.AuthorID = a.AuthorID
	inner join LIB.dbo.Category cate on cate.CategoryID = c.CategoryID
	WHERE c.Title like '%'+@title+'%'
		or a.AuthorName like '%'+@author+'%'
		or p.PublisherName like '%'+@publisher+'%'
		or c.CategoryID = @cate) as b
	WHERE b.No>=@rowStart and b.No<=@rowEnd
END
