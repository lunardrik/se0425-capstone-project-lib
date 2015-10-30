USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1001All]    Script Date: 03/13/2012 00:19:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1001All]
AS
BEGIN
	SELECT * FROM dbo.BookRegister;
END


GO

