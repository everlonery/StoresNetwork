CREATE PROCEDURE [dbo].[sp_Products_UpdateName]
	@ProductId INT,
	@Name NVARCHAR(50)
AS
	UPDATE dbo.Products
	SET Name = @Name
	WHERE ProductId = @ProductId
