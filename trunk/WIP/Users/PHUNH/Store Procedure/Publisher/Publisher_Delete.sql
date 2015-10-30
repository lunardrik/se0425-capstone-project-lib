SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on Publisher table>
-- =============================================
CREATE PROCEDURE SP0404
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM Publisher
	WHERE PublisherID = @Param1
END
GO
