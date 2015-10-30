SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on AuthorOfBook table>
-- =============================================
CREATE PROCEDURE SP0804
	-- Add the parameters for the stored procedure here
	@Param1 int,
	@Param2 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;	
	DELETE FROM AuthorOfBook WHERE AuthorID = @Param1 AND ISBN = @Param2
END
GO
