SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Update data to catalogue table>
-- =============================================
CREATE PROCEDURE SP0103
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
	UPDATE Catalogue
	SET Title = @Param2,
		PublisherID = @Param3,
		ShortDescription = @Param4,
		CategoryID = @Param5,
		"Language" = @Param6,
		"Year" = @Param7,
		ExpandLimit = @Param8,
		ExpandDateLimit = @Param9,
		NumberOfCopies = @Param10,
		AvailableCopies = @Param11,
		Price = @Param12,
		"Image" = @Param13,
		CreatedDate = @Param14,
		UpdatedDate = @Param15
	WHERE ISBN = @Param1
END
GO
