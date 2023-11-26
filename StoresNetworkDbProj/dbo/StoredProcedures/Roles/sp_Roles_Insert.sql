CREATE PROCEDURE [dbo].[sp_Roles_Insert]
	@RoleName NVARCHAR(50)
AS
	INSERT INTO dbo.Roles(Name)
	VALUES (@RoleName)