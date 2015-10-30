USE [LIB]
GO

/****** Object:  StoredProcedure [dbo].[SP1001ByRegisterDate]    Script Date: 03/13/2012 00:19:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP1001ByRegisterDate] (@RegisterDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE RegisterDate = @RegisterDate;
END


GO

