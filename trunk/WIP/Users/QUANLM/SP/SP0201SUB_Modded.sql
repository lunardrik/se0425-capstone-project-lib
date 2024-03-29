USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0201MASTER]    Script Date: 03/15/2012 02:39:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on category table minus uncategorized category>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201SUB]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID LIKE @Param1 + '.%' AND CHARINDEX('.', CategoryID, LEN(@Param1 + '.') + 1) = 0
END
