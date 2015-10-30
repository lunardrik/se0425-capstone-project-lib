SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to publisher table>
-- =============================================
CREATE PROCEDURE SP0403
	-- Add the parameters for the stored procedure here
	@Param1 int, 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Publisher
	SET PublisherName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE PublisherID = @Param1
END
GO
