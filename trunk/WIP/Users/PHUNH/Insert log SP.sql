-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<PhuNH>
-- Create date: <05/04/2012>
-- Description:	<Write log to the database>
-- =============================================
CREATE PROCEDURE SP1402Log
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(50),
	@Param2 NVARCHAR(max),
	@Param3 NVARCHAR(50),
	@Param4 DATETIME,
	@Param5 DATETIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Log(Username,"Action",LogType,CreatedDate,UpdatedDate) 
	VALUES(@Param1,@Param2,@Param3,@Param4,@Param5);
END
GO
