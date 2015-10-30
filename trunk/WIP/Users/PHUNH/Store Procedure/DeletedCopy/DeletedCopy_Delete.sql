SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on DeletedCopy table>
-- =============================================
CREATE PROCEDURE SP1104
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	DELETE FROM DeletedCopy WHERE Barcode = @Param1
END
GO
