USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByRegisterDate]    Script Date: 04/02/2012 22:49:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP1001ByCreatedDate] (@CreatedDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE CreatedDate > @CreatedDate;
END


