USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[sp0001advance]    Script Date: 04/03/2012 00:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp0001advance] 
	-- Add the parameters for the stored procedure here
	@advance nvarchar(MAX) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	exec(@advance)
END
