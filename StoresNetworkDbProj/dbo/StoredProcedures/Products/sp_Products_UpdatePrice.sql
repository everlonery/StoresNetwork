CREATE PROCEDURE [dbo].[sp_Products_UpdatePrice]
	@ProductId INT,
	@Price MONEY
AS
	UPDATE dbo.Products
	SET Price = @Price
	WHERE ProductId = @ProductId
