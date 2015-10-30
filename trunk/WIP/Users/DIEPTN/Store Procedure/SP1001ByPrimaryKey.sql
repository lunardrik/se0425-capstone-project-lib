USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByUserID]    Script Date: 03/18/2012 00:17:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP1001ByPrimaryKey] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), @RegisterDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE 
		UserID = @UserID AND
		ISBN = @ISBN AND
		RegisterDate = @RegisterDate;
END


