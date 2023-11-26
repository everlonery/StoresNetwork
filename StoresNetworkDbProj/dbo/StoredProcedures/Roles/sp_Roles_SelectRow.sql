CREATE PROCEDURE [dbo].[sp_Roles_SelectRow]
	@RoleId INT
AS
	SELECT *
	FROM dbo.Roles
	WHERE RoleId = @RoleId
