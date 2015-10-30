USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0901ByBarcode]    Script Date: 03/13/2012 00:18:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0901ByBarcode] (@Barcode NVARCHAR(13))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE Barcode = @Barcode;
END


GO

