CREATE PROCEDURE [dbo].[sp_Products_Insert]
	@Name NVARCHAR(50),
	@Price MONEY
AS
	INSERT INTO dbo.Products(Name, Price)
	VALUES(@Name, @Price)
