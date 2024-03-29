USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0903]    Script Date: 03/14/2012 20:56:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP0903] (@UserID NVARCHAR(40), @Barcode NVARCHAR(13), @IssuedDate DATETIME,
	@DueDate DATETIME, @ReturnDate DATETIME, @Fine FLOAT, @Status INT, @ExpandCount INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	UPDATE RentalDetail
	SET DueDate = @DueDate,
		ReturnDate = @ReturnDate,
		Fine = @Fine,
		RentalDetail.Status = @Status,
		ExpandCount = @ExpandCount,
		CreatedDate = @CreatedDate,
		UpdatedDate = @UpdatedDate
	WHERE UserID = @UserID AND Barcode = @Barcode AND IssuedDate = @IssuedDate;
END

