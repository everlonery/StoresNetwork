CREATE PROCEDURE [dbo].[sp_Cities_SelectRow]
	@CityId INT
AS
	SELECT *
	FROM dbo.Cities
	WHERE CityId = @CityId
