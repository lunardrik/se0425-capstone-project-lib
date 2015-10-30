USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1004]    Script Date: 03/13/2012 00:20:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1004] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME)
AS
BEGIN
	DELETE FROM BookRegister
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END


GO

