USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0902]    Script Date: 04/05/2012 11:47:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP0902] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, @ExpandCount INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO RentalDetail
	VALUES (@UserID, @Barcode, @IssuedDate, @DueDate, @ReturnDate, @ExpandCount, @Fine,
		@Status, @CreatedDate, @UpdatedDate);
END
