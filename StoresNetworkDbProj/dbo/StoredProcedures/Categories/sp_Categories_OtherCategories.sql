CREATE PROCEDURE [dbo].[sp_Categories_OtherCategories]
	@CategoryId INT
AS
	SELECT *
	FROM dbo.Categories
	WHERE CategoryId != @CategoryId
