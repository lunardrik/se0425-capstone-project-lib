USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0901ByStatus]    Script Date: 03/13/2012 00:18:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0901ByStatus] (@Status INT)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE RentalDetail.Status = @Status;
END


GO

