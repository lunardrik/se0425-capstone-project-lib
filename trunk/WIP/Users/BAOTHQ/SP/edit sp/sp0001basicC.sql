USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001basicC]    Script Date: 04/17/2012 22:20:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
ALTER PROCEDURE [dbo].[sp0001basicC]
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT COUNT(*) FROM (SELECT distinct ROW_NUMBER() over(order by c.ISBN) as No, c.ISBN, c.Title, p.PublisherName, c.ShortDescription, STUFF(
(SELECT '; ' + au.AuthorName
FROM (Catalogue ca
JOIN AuthorOfBook aob ON ca.ISBN = aob.ISBN JOIN Author au ON aob.AuthorID = au.AuthorID)
WHERE ca.ISBN = c.ISBN
FOR XML PATH('')),1,2,'') AS AuthorName, cate.CategoryName, c.Image
from LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID 
	inner join Category cate on cate.CategoryID = c.CategoryID
	WHERE c.Title like '%' + @title + '%'
	AND c.AvailableCopies >= 0
	) as b
END
