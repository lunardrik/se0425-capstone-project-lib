USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1001ByStatus]    Script Date: 03/13/2012 00:20:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1001ByStatus] (@Status INT)
AS
BEGIN
	SELECT * 
	FROM BookRegister
	WHERE BookRegister.Status = @Status;
END


GO

