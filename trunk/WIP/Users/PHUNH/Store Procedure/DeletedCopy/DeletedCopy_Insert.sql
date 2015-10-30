SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to DeletedCopy table>
-- =============================================
CREATE PROCEDURE SP1102 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(13),
	@Param3 int,
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO DeletedCopy VALUES(@Param1,@Param2,@Param3,@Param4,@Param5)
END
GO
