CREATE PROCEDURE [dbo].[sp_Categories_SelectParent]
	@ParentId INT
AS
	SELECT *
	FROM dbo.Categories
	WHERE CategoryId = @ParentId
