USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1001ByUserID]    Script Date: 03/13/2012 00:20:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1001ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE UserID = @UserID;
END


GO

