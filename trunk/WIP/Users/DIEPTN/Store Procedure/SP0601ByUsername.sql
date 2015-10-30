USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP0601ByUsername]    Script Date: 03/13/2012 00:17:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP0601ByUsername] (@Username NVARCHAR(50))
AS
BEGIN
	SELECT *
	FROM [dbo].[User]
	WHERE Username = @Username;
END


GO

