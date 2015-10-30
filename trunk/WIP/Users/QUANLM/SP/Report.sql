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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9901
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [Status], COUNT(*) as NOC FROM Copy WHERE [Status] = 1 OR [Status] = 2 GROUP BY Status
END
GO


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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9902
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT CategoryName, COUNT(*) as NOC FROM (SELECT LEFT(c.CategoryID, CI) as RCI FROM Catalogue c JOIN (SELECT CASE  WHEN CHARINDEX('.',CategoryID) = 0 THEN LEN(CategoryID) ELSE CHARINDEX('.',CategoryID)-1 END CI, ISBN FROM Catalogue) d ON c.ISBN = d.ISBN WHERE NumberOfCopies > -1) e JOIN Category ca ON e.RCI = ca.CategoryID GROUP BY RCI, CategoryName
END
GO

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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9903Chart
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    SELECT COUNT(*) AS NOC FROM RentalDetail WHERE (Status = 1)
    UNION
	SELECT COUNT(*) AS NOC FROM RentalDetail WHERE (Status = 1) AND (DueDate < GETDATE() OR (ISNULL(ReturnDate,'') <> '' AND DueDate < ReturnDate))
END
GO

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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9903Detail
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID, Barcode, IssuedDate, DueDate FROM RentalDetail WHERE (Status = 1) AND (DueDate < GETDATE() OR (ISNULL(ReturnDate,'') <> '' AND DueDate < ReturnDate))
END
GO

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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9904
	@ISBN NVARCHAR(13)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ISBN as 'Mã đầu mục', td.Barcode as 'Mã ĐKCB', td.UserID as 'Mã độc giả', IssuedDate as 'Ngày mượn', DueDate as 'Ngày hết hạn', ReturnDate as 'Ngày trả', Fine as 'Tiền phạt', CASE WHEN td.[Status] = 1 THEN N'Đang mượn' WHEN td.[Status] = 2 THEN N'Đã trả' END AS 'Tình trạng' FROM RentalDetail td JOIN Copy cp ON td.Barcode = cp.Barcode WHERE cp.ISBN = @ISBN
END
GO

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
-- Author:		QUANLM
-- Create date: 2012/08/04
-- Description:	
-- =============================================
CREATE PROCEDURE SP9905
	@UserID NVARCHAR(40)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Barcode as 'Mã ĐKCB', UserID as 'Mã độc giả', IssuedDate as 'Ngày nhận sách', DueDate as 'Ngày hết hạn', ReturnDate as 'Ngày trả', CASE WHEN [Status] = 1 THEN N'Đang mượn' WHEN [Status] = 2 THEN N'Đã trả' END AS 'Tình trạng' FROM RentalDetail WHERE UserId = @UserID
END
GO



