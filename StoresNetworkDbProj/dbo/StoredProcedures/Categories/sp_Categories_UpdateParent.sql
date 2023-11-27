CREATE PROCEDURE [dbo].[sp_Categories_UpdateParent]
	@CategoryId INT,
	@NewParentId INT
AS
	UPDATE dbo.Categories
	SET ParentId = @NewParentId
	WHERE CategoryId = @CategoryId