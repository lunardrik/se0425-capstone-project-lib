USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0201ALL]    Script Date: 03/15/2012 02:18:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on category table minus uncategorized category>
-- =============================================
CREATE PROCEDURE [dbo].[SP0201MASTER]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Category
	WHERE CategoryID <> '0' AND CHARINDEX('.', CategoryID) = 0
END
