USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0003AllStt]    Script Date: 03/26/2012 01:45:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp0003AllStt]
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@title nvarchar(20) = '',
	@fromDate datetime = '2012-01-01',
	@toDate datetime = '2012-12-01',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM (SELECT ROW_NUMBER() over(order by br.RegisterDate) as No,
		u.Username, c.Title, br.RegisterDate, br.Status 
	FROM LIB.dbo.BookRegister br 
	INNER JOIN LIB.dbo.[User] u on u.UserID = br.UserID
	INNER JOIN LIB.dbo.Catalogue c on c.ISBN = br.ISBN
	where u.Username like '%'+@username+'%' and 
			c.Title like '%'+@title+'%' and
			(br.RegisterDate >= @fromDate and br.RegisterDate<=@toDate))as reg
			WHERE reg.No>=@rowStart and reg.No<=@rowEnd
END
