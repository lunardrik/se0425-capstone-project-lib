USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0701All]    Script Date: 03/17/2012 14:22:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP0701ByID] (@RoleID INT)
AS
BEGIN
	SELECT *
	FROM [dbo].[Role]
	WHERE RoleID = @RoleID
END


