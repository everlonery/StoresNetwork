CREATE TABLE [dbo].[Users] (
    [UserId]         INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NOT NULL,
    [FirstName]      NVARCHAR (50) NOT NULL,
    [ParentName]     NVARCHAR (50) NOT NULL,
    [BirthDate]      DATE          NOT NULL,
    [EmploymentDate] DATE          NOT NULL,
    [RoleId]         INT           NULL,
    [Email]          NVARCHAR (50) NULL,
    [Phone]          NVARCHAR (16) NOT NULL,
    [IsActive]       BIT           NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Worker_Roles] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([RoleId])
);

