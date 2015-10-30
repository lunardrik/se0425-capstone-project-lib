USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP1002]    Script Date: 04/05/2012 20:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP1002] (@UserID NVARCHAR(40), @ISBN NVARCHAR(13), 
	@RegisterDate DATETIME, @Note NTEXT, @Status INT, 
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO [LIB].[dbo].[BookRegister]
           ([UserID]
           ,[ISBN]
           ,[RegisterDate]
           ,[Note]
           ,[Status]
           ,[CreatedDate]
           ,[UpdatedDate])
     VALUES
           (@UserID,
            @ISBN,
            @RegisterDate,
            @Note,
            @Status,
            @CreatedDate,
            @UpdatedDate);

END
