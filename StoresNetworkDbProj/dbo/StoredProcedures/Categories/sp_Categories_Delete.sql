CREATE PROCEDURE [dbo].[sp_Categories_Delete]
	@CategoryId INT
AS
	SET NOCOUNT ON
	UPDATE dbo.Categories
	SET ParentId = NULL WHERE ParentId = @CategoryId
	DELETE FROM dbo.Categories
	WHERE CategoryId = @CategoryId
