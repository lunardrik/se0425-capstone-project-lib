SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Insert data to catalogue table>
-- =============================================
CREATE PROCEDURE SP0102 
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13), 
	@Param2 NVARCHAR(100),
	@Param3 int,
	@Param4 NVARCHAR(MAX),
	@Param5 NVARCHAR(40),
	@Param6 NVARCHAR(50),
	@Param7 int,
	@Param8 int,
	@Param9 int,
	@Param10 int,
	@Param11 int,
	@Param12 float,
	@Param13 NVARCHAR(100),
	@Param14 DATETIME,
	@Param15 DATETIME
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO Catalogue VALUES(@Param1,@Param2,@Param3,@Param4,@Param5,@Param6,@Param7,@Param8,@Param9,@Param10,@Param11,@Param12,@Param13,@Param14,@Param15)
END
GO
