USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0601All]    Script Date: 03/13/2012 00:17:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SP0601All]
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
END


GO

