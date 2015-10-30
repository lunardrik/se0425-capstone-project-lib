USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0004]    Script Date: 03/16/2012 19:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of books rentals>
-- =============================================
ALTER PROCEDURE [dbo].[sp0004]
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@title nvarchar(20) = '',
	@status int = 0,
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
			rd.Status = @status and
			(rd.IssuedDate >= @fromDate and rd.IssuedDate<=@toDate)
			) as b
	WHERE b.No>=@rowStart and b.No<=@rowEnd
	
END
