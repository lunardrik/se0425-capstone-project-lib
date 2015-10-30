USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1003]    Script Date: 03/04/2012 14:19:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SP0601All]
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
END

GO

CREATE PROCEDURE [dbo].[SP0601ByUsername] (@Username NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE Username = @Username;
END

GO

CREATE PROCEDURE [dbo].[SP0602] (@UserID NVARCHAR(40), @Username NVARCHAR(50), @Password NVARCHAR(50), 
	@RoleID INT, @Birthday DATE, @Address NVARCHAR(100), @Phone NVARCHAR(50), @Email NVARCHAR(50),
	@ISDN NVARCHAR(10), @IssuedDate DATETIME, @ExpiredDate DATETIME, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO [dbo].[User]
	VALUES (@UserID, @Username, @Password, @RoleID, @Birthday, @Address, 
		@Phone, @Email, @ISDN, @IssuedDate, @ExpiredDate, @CreatedDate, @UpdatedDate);
END

GO

CREATE PROCEDURE [dbo].[SP0603] (@UserID NVARCHAR(40), @Username NVARCHAR(50), @Password NVARCHAR(50), 
	@RoleID INT, @Birthday DATE, @Address NVARCHAR(100), @Phone NVARCHAR(50), @Email NVARCHAR(50),
	@IDSN NVARCHAR(10), @IssuedDate DATETIME, @ExpiredDate DATETIME, 
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
		[CreatedDate] = @CreatedDate, 
		[UpdatedDate] = @UpdatedDate
	WHERE UserID = @UserID;
END

GO

CREATE PROCEDURE [dbo].[SP0901All]
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
END

GO

CREATE PROCEDURE [dbo].[SP0901ByBarcode] (@Barcode NVARCHAR(13))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE Barcode = @Barcode;
END

GO

CREATE PROCEDURE [dbo].[SP0901ByIssuedDate] (@IssuedDate DATETIME)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE IssuedDate = @IssuedDate;
END

GO

CREATE PROCEDURE [dbo].[SP0901ByStatus] (@Status INT)
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE RentalDetail.Status = @Status;
END

GO

CREATE PROCEDURE [dbo].[SP0901ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT *
	FROM dbo.RentalDetail
	WHERE UserID = @UserID;
END

GO

CREATE PROCEDURE [dbo].[SP0902] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO RentalDetail
	VALUES (@UserID, @Barcode, @IssuedDate, @DueDate, @ReturnDate, @Fine,
		@Status, @CreatedDate, @UpdatedDate);
END

GO

CREATE PROCEDURE [dbo].[SP0903] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE RentalDetail
	SET DueDate = @DueDate,
		ReturnDate = @ReturnDate,
		Fine = @Fine,
		RentalDetail.Status = @Status,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate
	WHERE UserID = @UserID AND Barcode = @Barcode AND IssuedDate = @IssuedDate;
END

GO

CREATE PROCEDURE [dbo].[SP1001All]
AS
BEGIN
	SELECT * FROM dbo.BookRegister;
END

GO

CREATE PROCEDURE [dbo].[SP1001ByISBN] (@ISBN NVARCHAR(13))
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE ISBN = @ISBN;
END

GO

CREATE PROCEDURE [dbo].[SP1001ByRegisterDate] (@RegisterDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE RegisterDate = @RegisterDate;
END

GO

CREATE PROCEDURE [dbo].[SP1001ByStatus] (@Status INT)
AS
BEGIN
	SELECT * 
	FROM BookRegister
	WHERE BookRegister.Status = @Status;
END

GO

CREATE PROCEDURE [dbo].[SP1001ByUserID] (@UserID NVARCHAR(40))
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE UserID = @UserID;
END

GO

CREATE PROCEDURE [dbo].[SP1002] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note Text, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO BookRegister
	VALUES (@UserID, @ISBN, @RegisterDate, @Note, @Status, @CreatedDate, @UpdatedDate);
END

GO

CREATE PROCEDURE [dbo].[SP1003] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note Text, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE BookRegister
	SET Note = @Note,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END

GO

CREATE PROCEDURE [dbo].[SP1004] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME)
AS
BEGIN
	DELETE FROM BookRegister
	WHERE UserID = @UserID AND ISBN = @ISBN AND RegisterDate = @RegisterDate
END

GO
