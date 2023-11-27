CREATE PROCEDURE [dbo].[sp_Categories_Insert]
	@CategoryName NVARCHAR(50)
AS
	INSERT INTO dbo.Categories(Name)
	VALUES (@CategoryName)