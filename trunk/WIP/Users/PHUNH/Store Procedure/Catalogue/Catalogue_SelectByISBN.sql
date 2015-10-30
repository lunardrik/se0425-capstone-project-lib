SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific isbn>
-- =============================================
CREATE PROCEDURE SP0101ISBN
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Catalogue
	WHERE ISBN = @Param1
END
GO
