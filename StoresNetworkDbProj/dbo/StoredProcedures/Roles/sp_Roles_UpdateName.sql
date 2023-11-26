CREATE PROCEDURE [dbo].[sp_Roles_UpdateName]
	@RoleId INT,
	@NewName NVARCHAR(50)
AS
	UPDATE dbo.Roles
	SET Name = @NewName
	WHERE RoleId = @RoleId
