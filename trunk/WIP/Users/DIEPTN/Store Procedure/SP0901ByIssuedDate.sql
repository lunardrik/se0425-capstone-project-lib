USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0901ByIssuedDate]    Script Date: 03/13/2012 00:18:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0901ByIssuedDate] (@IssuedDate DATETIME)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE IssuedDate = @IssuedDate;
END


GO

