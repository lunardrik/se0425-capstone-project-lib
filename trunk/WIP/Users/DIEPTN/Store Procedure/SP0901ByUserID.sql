USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0901ByUserID]    Script Date: 03/13/2012 00:19:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0901ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE UserID = @UserID;
END


GO

