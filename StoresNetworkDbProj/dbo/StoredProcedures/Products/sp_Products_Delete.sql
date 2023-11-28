CREATE PROCEDURE [dbo].[sp_Products_Delete]
	@ProductId INT
AS
	DELETE
	FROM dbo.Products
	WHERE ProductId = @ProductId