CREATE PROCEDURE [dbo].[sp_Roles_Delete]
	@RoleId INT
AS
	SET NOCOUNT ON
	DELETE FROM dbo.Roles
	WHERE RoleId = @RoleId
