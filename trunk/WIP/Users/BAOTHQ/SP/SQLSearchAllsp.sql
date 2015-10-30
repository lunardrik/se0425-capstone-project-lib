USE LIB
GO
--Search book basically sp[0001basic]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE sp0001basic
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.ISBN, c.Title, p.PublisherName from LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID
	WHERE c.Title like '%' + @title + '%' 
END
GO

--Search book in details sp[0001detail]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search a list of book based with more detail information>
-- =============================================
CREATE PROCEDURE sp0001detail 
	-- Add the parameters for the stored procedure here
	@title nvarchar(100) = '',
	@author nvarchar(50) = '',
	@publisher nvarchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.ISBN, c.Title, p.PublisherName FROM LIB.dbo.Catalogue c
	inner join LIB.dbo.Publisher p on c.PublisherID = p.PublisherID
	inner join LIB.dbo.AuthorOfBook aob on aob.ISBN = c.ISBN
	inner join LIB.dbo.Author a on aob.AuthorID = a.AuthorID
	WHERE c.Title like '%' + @title + '%' 
		or a.AuthorName like '%' + @author + '%' 
		or p.PublisherName like '%' + @publisher + '%' 
END
GO

--Search user sp[0002]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of users>
-- =============================================
CREATE PROCEDURE sp0002 
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@role int = 1,
	@eMail nvarchar(50) = '',
	@idsn nvarchar(10) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT u.UserID, u.Username, r.RoleDescription, u.IDSN FROM LIB.dbo.[User] u
	INNER JOIN LIB.dbo.Role r on r.RoleID = u.RoleID
	WHERE u.Username like '%' + @username + '%' 
			or u.RoleID = @role
			or u.Email like '%' + @eMail + '%'
			or u.IDSN like '%' + @idsn + '%' 
END
GO

--Search book rental register sp[0003]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of books rental register>
-- =============================================
CREATE PROCEDURE sp0003
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@title nvarchar(20) = '',
	@status int = 1,
	@regDate datetime = '2012-01-01'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT br.ISBN, u.Username, br.RegisterDate, br.Status FROM LIB.dbo.BookRegister br 
	INNER JOIN LIB.dbo.[User] u on u.UserID = br.UserID
	INNER JOIN LIB.dbo.Catalogue c on c.ISBN = br.ISBN
	where u.Username like '%' + @username + '%' or
			c.Title like '%' + @title + '%' or
			br.Status = @status or
			br.RegisterDate >= @regDate
	order by br.RegisterDate desc
END
GO

--Search book rental sp[0004]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Search for a list of books rentals>
-- =============================================
CREATE PROCEDURE sp0004
	-- Add the parameters for the stored procedure here
	@username nvarchar(20) = '',
	@title nvarchar(20) = '',
	@status int = 0,
	@issuedDate datetime = '2012-01-01',
	@dueDate datetime = '2012-01-01'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT rd.Barcode, u.Username, rd.Status, rd.IssuedDate, rd.DueDate FROM LIB.dbo.RentalDetail rd 
	INNER JOIN LIB.dbo.[User] u on u.UserID = rd.UserID
	INNER JOIN LIB.dbo.Copy co on co.Barcode = rd.Barcode
	INNER JOIN LIB.dbo.Catalogue c on c.ISBN = co.ISBN
	where u.Username like '%' + @username + '%' or
			c.Title like '%' + @title + '%' or
			rd.Status = @status or
			rd.IssuedDate >= @issuedDate or 
			rd.DueDate >= @dueDate
	order by rd.DueDate desc
END
GO