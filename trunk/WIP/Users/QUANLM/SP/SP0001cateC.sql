USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001basic]    Script Date: 03/15/2012 03:08:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<BaoTHQ>
-- Create date: <03/05/2012>
-- Description:	<Basically search a list of book based on their titles>
-- =============================================
CREATE PROCEDURE [dbo].[sp0001cateC]
	-- Add the parameters for the stored procedure here
	@categoryId nvarchar(100) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT COUNT(*) FROM Catalogue c
	WHERE c.CategoryID like @categoryId + '%' 
END
