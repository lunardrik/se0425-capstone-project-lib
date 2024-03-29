USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001author]    Script Date: 03/15/2012 13:28:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001author]
	-- Add the parameters for the stored procedure here
	@authorId nvarchar(100) = '',
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
from LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID join AuthorOfBook aob on c.ISBN = aob.ISBN join Category cate on c.CategoryID = cate.CategoryID
	WHERE aob.AuthorID = @authorId 
	) as b
	WHERE b.No>=@rowStart and b.No<=@rowEnd
END
