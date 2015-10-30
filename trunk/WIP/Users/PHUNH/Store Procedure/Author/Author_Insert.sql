SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to author table>
-- =============================================
CREATE PROCEDURE SP0302 
	-- Add the parameters for the stored procedure here
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Author VALUES(@Param2,@Param3,@Param4)
END
GO
