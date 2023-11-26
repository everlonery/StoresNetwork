CREATE PROCEDURE [dbo].[sp_Cities_Insert]
	@CityName NVARCHAR(50)
AS
	INSERT INTO dbo.Cities(Name)
	VALUES (@CityName)