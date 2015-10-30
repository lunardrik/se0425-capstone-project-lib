SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to copy table>
-- =============================================
CREATE PROCEDURE SP0503
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Copy
	SET ISBN = @Param2,
		"Status" = @Param3,
		CreatedDate = @Param4,
		UpdatedDate = @Param5
	WHERE Barcode = @Param1
END
GO
