USE [LIB]
GO
/****** Object:  StoredProcedure [dbo].[SP0602]    Script Date: 04/05/2012 20:43:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP0602] (@UserID NVARCHAR(40), @Username NVARCHAR(50), @Password NVARCHAR(50), 
	@RoleID INT, @Birthday DATE, @Address NVARCHAR(100), @Phone NVARCHAR(50), @Email NVARCHAR(50),
	@IDSN NVARCHAR(10), @IssuedDate DATETIME, @ExpiredDate DATETIME, @Status INT,
	@CreatedDate DATETIME, @UpdatedDate DATETIME)
AS
BEGIN
	INSERT INTO [LIB].[dbo].[User]
           ([UserID]
           ,[Username]
           ,[Password]
           ,[RoleID]
           ,[Birthday]
           ,[Address]
           ,[Phone]
           ,[Email]
           ,[IDSN]
           ,[IssuedDate]
           ,[ExpiredDate]
           ,[Status]
           ,[CreatedDate]
           ,[UpdatedDate])
     VALUES
           (@UserID,
            @Username,
            @Password,
            @RoleID,
            @Birthday,
            @Address,
            @Phone,
            @Email,
            @IDSN,
            @IssuedDate,
            @ExpiredDate,
            @Status,
            @CreatedDate,
            @UpdatedDate);

END