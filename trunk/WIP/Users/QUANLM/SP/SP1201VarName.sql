USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1201VarName]    Script Date: 03/17/2012 01:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
ALTER PROCEDURE [dbo].[SP1201VarName]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	
	SELECT * 
	FROM Variable
	WHERE VariableName = @Param1
END
