CREATE PROCEDURE [dbo].[sp_Categories_DeleteParent]
	@CategoryId INT
AS
	UPDATE dbo.Categories
	SET ParentId = NULL
	WHERE CategoryId = @CategoryId
