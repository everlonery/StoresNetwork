CREATE PROCEDURE [dbo].[sp_Cities_Delete]
	@CityId INT
AS
	DELETE FROM dbo.Cities
	WHERE CityId = @CityId
