USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1301RAND]    Script Date: 03/17/2012 01:45:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
ALTER PROCEDURE [dbo].[SP1301RAND]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	
	SELECT TOP 1 QuoteContent, Speaker FROM Quote
	ORDER BY NEWID()

END
