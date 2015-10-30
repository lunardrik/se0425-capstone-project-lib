-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE sp0004AllStt
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@title nvarchar(20) = '',
	@fromDate datetime = '2012-01-01',
	@toDate datetime = '2012-01-01',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM (SELECT ROW_NUMBER() over(order by rd.DueDate desc) as No, 
	c.Title,rd.ReturnDate,rd.Fine, rd.ExpandCount,
	rd.Barcode, u.Username, rd.Status, rd.IssuedDate, rd.DueDate 
	FROM LIB.dbo.RentalDetail rd 
	INNER JOIN LIB.dbo.[User] u on u.UserID = rd.UserID
	INNER JOIN LIB.dbo.Copy co on co.Barcode = rd.Barcode
	INNER JOIN LIB.dbo.Catalogue c on c.ISBN = co.ISBN
	where u.Username like '%' + @username + '%' and
			c.Title like '%' + @title + '%' and
			(rd.IssuedDate >= @fromDate and rd.IssuedDate<=@toDate)
			) as b
	WHERE b.No>=@rowStart and b.No<=@rowEnd
END
GO
