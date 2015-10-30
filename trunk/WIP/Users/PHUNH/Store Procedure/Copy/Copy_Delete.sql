SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		PhuNH
-- Create date: <03/03/2012>
-- Description:	<Delete data on Copy table>
-- =============================================
CREATE PROCEDURE SP0504
	-- Add the parameters for the stored procedure here
	@Param1 NVARCHAR(13)
AS
BEGIN	
	SET NOCOUNT ON;
	INSERT INTO DeletedCopy SELECT Barcode,ISBN,"Status",CreatedDate,UpdatedDate FROM Copy WHERE Barcode = @Param1
	
	DELETE FROM Copy WHERE Barcode = @Param1
END
GO
