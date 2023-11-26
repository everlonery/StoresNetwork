CREATE PROCEDURE [dbo].[sp_Cities_UpdateName]
	@CityId INT,
	@NewName NVARCHAR(50)
AS
	UPDATE dbo.Cities
	SET Name = @NewName
	WHERE CityId = @CityId
