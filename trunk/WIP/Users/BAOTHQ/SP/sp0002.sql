USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0002]    Script Date: 04/07/2012 08:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of users>
-- =============================================
ALTER PROCEDURE [dbo].[sp0002] 
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@status int = 1,
	@eMail nvarchar(50) = '',
	@idsn nvarchar(10) = '',
	@rowStart int = 1,
	@rowEnd int = 1
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT u.UserID, u.Username, r.RoleDescription, u.IDSN, u.Email,
	 u.Address, u.Birthday, u.Phone, u.IssuedDate, u.ExpiredDate, u.Status
	 FROM LIB.dbo.[User] u
	INNER JOIN LIB.dbo.Role r on r.RoleID = u.RoleID
	WHERE u.Username like '%' + @username + '%' 
			or u.Status = @status
			or u.Email like '%' + @eMail + '%'
			or u.IDSN like '%' + @idsn + '%'
END
