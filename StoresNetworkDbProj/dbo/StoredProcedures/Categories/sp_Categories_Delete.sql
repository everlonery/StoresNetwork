CREATE PROCEDURE [dbo].[sp_Categories_Delete]
	@CategoryId INT
AS
	SET NOCOUNT ON
	DELETE FROM dbo.Categories
	WHERE CategoryId = @CategoryId
