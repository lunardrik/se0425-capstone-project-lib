SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on Publisher table which have specific PublisherName>
-- =============================================
CREATE PROCEDURE SP0401Name
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(50)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherName LIKE @Param1
END
GO
