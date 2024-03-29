USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0902]    Script Date: 03/15/2012 00:54:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP0902] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, @ExpandCount INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE Catalogue
	SET RentalTime = RentalTime + 1
	WHERE (ISBN = (SELECT c.ISBN FROM Copy c WHERE c.Barcode = @Barcode))

	INSERT INTO RentalDetail
	VALUES (@UserID, @Barcode, @IssuedDate, @DueDate, @ReturnDate, @Fine,
		@Status, @ExpandCount, @CreatedDate, @UpdatedDate);
END

