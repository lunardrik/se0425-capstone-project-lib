SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on author table which have specific authorID>
-- =============================================
CREATE PROCEDURE SP0301AI
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
