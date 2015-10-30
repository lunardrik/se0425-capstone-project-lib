USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0601ByUserID]    Script Date: 03/13/2012 00:17:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0601ByUserID] (@UserID NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE UserID = @UserID;
END


GO

