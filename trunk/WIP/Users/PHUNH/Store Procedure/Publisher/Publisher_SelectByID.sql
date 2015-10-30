SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on Publisher table which have specific PublisherID>
-- =============================================
CREATE PROCEDURE SP0401PI
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherID = @Param1
END
GO
