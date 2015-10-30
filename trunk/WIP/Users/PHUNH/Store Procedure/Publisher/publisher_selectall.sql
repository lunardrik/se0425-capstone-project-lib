USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0201CI]    Script Date: 03/09/2012 12:37:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Select all data on publisher table minus unknown publisher>
-- =============================================
CREATE PROCEDURE [dbo].[SP0401ALL]
	-- Add the parameters for the stored procedure here
AS
BEGIN	
	SET NOCOUNT ON;
	SELECT * 
	FROM Publisher
	WHERE PublisherID <> 0
END
