CREATE PROCEDURE [dbo].[sp_Cities_Delete]
	@CityId INT
AS
	SET NOCOUNT ON
	DELETE FROM dbo.Cities
	WHERE CityId = @CityId
