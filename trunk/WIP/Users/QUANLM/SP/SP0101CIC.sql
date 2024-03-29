USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0101CI]    Script Date: 03/15/2012 02:29:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on catalogue table which have specific publisher ID>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101CIC]
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(40)
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT COUNT(*)
	FROM Catalogue
	WHERE CategoryID LIKE @Param1 + '%'
END
