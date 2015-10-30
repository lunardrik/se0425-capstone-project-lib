SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE SP0101CI
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE CategoryID = @Param1
END
GO
