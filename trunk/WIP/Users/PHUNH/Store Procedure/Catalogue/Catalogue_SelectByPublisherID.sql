SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE SP0101PI
	-- Add the parameters for the stored procedure here
	@Param1 int
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE PublisherID = @Param1
END
GO
