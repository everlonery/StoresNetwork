CREATE TABLE [dbo].[Users] (
    [UserId]         INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       NVARCHAR (50) NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [ParentName]     NVARCHAR (50) NULL,
    [BirthDate]      DATE          NULL,
    [EmploymentDate] DATE          NULL,
    [RoleId]         INT           NULL,
    [Email]          NVARCHAR (50) NULL,
    [Phone]          NVARCHAR (16) NULL,
    [IsActive]       BIT           NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Worker_Roles] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Roles] ([RoleId]) ON DELETE SET NULL
);

