USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0603]    Script Date: 03/17/2012 15:33:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP0603] (@UserID NVARCHAR(40), @Username NVARCHAR(50), @Password NVARCHAR(50), 
	@RoleID INT, @Birthday DATE, @Address NVARCHAR(100), @Phone NVARCHAR(50), @Email NVARCHAR(50),
	@IDSN NVARCHAR(10), @IssuedDate DATETIME, @ExpiredDate DATETIME, @Status INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE [dbo].[User]
	SET [Username] = @Username, 
		[Password] = @Password, 
		[RoleID] = @RoleID, 
		[Birthday] = @Birthday, 
		[Address] = @Address, 
		[Phone] = @Phone, 
		[Email] = @Email, 
		[IDSN] = @IDSN, 
		[IssuedDate] = @IssuedDate, 
		[ExpiredDate] = @ExpiredDate, 
		[Status] = @Status,
		[CreatedDate] = @CreatedDate, 
		[UpdatedDate] = @UpdatedDate
	WHERE UserID = @UserID;
END


