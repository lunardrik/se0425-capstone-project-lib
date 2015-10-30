SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to category table>
-- =============================================
CREATE PROCEDURE SP0202 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40), 
	@Param2 NVARCHAR(50),
	@Param3 DATETIME,
	@Param4 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Category VALUES(@Param1,@Param2,@Param3,@Param4)
END
GO
