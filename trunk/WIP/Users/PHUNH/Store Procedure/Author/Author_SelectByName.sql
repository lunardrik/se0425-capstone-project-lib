SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on author table which have specific authorName>
-- =============================================
CREATE PROCEDURE SP0301Name
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
