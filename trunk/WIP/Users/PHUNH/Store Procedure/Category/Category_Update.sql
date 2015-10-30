SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to category table>
-- =============================================
CREATE PROCEDURE SP0203
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40), 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Category
	SET CategoryName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE CategoryID = @Param1
END
GO
