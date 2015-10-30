USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1301RAND]    Script Date: 04/04/2012 08:22:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select data on DeletedCopy table which have specific barcode>
-- =============================================
CREATE PROCEDURE [dbo].[SP0101RAND]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	
	SELECT TOP 1 * FROM Catalogue
	ORDER BY NEWID()

END
