SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on author table>
-- =============================================
CREATE PROCEDURE SP0304
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM Author
	WHERE AuthorID = @Param1
END
GO
