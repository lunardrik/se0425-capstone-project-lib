USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1201VarName]    Script Date: 03/17/2012 01:33:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP1203VarName]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40),
	@Param2 NVARCHAR(MAX)
AS
BEGIN	
	SET NOCOUNT ON;
	
	UPDATE Variable
	SET Value = @Param2
	WHERE VariableName = @Param1
END
