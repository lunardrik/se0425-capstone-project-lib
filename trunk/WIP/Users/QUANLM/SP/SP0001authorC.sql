USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001authorC]    Script Date: 03/15/2012 13:32:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001authorC]
	-- Add the parameters for the stored procedure here
	@authorId nvarchar(100) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT COUNT(*) FROM Catalogue c join AuthorOfBook aob on  c.ISBN = aob.ISBN
	WHERE aob.AuthorID = @authorId
END
