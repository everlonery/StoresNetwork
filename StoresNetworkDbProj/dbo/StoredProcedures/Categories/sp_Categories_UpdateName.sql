CREATE PROCEDURE [dbo].[sp_Categories_UpdateName]
	@CategoryId INT,
	@NewName NVARCHAR(50)
AS
	UPDATE dbo.Categories
	SET Name = @NewName
	WHERE CategoryId = @CategoryId
