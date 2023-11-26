CREATE TABLE [dbo].[Roles] (
    [RoleId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]   NVARCHAR (50) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([RoleId] ASC)
);

