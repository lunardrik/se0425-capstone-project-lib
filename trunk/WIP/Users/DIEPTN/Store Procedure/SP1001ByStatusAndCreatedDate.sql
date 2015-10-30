USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1001ByRegisterDate]    Script Date: 04/03/2012 20:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP1001ByStatusAndCreatedDate] (@Status INT, @CreatedDate DATETIME)
AS
BEGIN
	SELECT * FROM BookRegister
	WHERE Status = @Status
		AND CreatedDate > @CreatedDate;
END


