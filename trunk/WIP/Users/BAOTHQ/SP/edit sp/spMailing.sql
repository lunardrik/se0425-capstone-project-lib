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
ALTER PROCEDURE spMailing 
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT u.Username, u.Email, rd.Barcode, ca.Title FROM RentalDetail rd
	JOIN [User] u on u.UserID=rd.UserID
	JOIN Copy co on co.Barcode=rd.Barcode
	JOIN Catalogue ca on ca.ISBN=co.ISBN
	WHERE rd.DueDate<=GETDATE()
	AND rd.Status = 1
END
GO
