SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to author table>
-- =============================================
CREATE PROCEDURE SP0303
	-- Add the parameters for the stored procedure here
	@Param1 int, 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	UPDATE Author
	SET AuthorName = @Param2,
		CreatedDate = @Param3,
		UpdatedDate = @Param4
	WHERE AuthorID = @Param1
END
GO
