USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1003]    Script Date: 03/13/2012 00:20:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1003] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note NTEXT, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE BookRegister
	SET Note = @Note,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate,
		[Status] = @Status
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END


GO

