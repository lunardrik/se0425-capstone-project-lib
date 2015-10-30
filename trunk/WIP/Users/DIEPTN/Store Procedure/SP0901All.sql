USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0901All]    Script Date: 03/13/2012 00:18:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0901All]
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
END


GO

