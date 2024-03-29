USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0101ISBN]    Script Date: 03/15/2012 00:40:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific isbn>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101ISBN]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	
	UPDATE Catalogue
	SET HitTime = HitTime + 1
	WHERE ISBN = @Param1
	
	SELECT * 
	FROM Catalogue
	WHERE ISBN = @Param1
END
