CREATE TABLE [dbo].[Categories] (
    [CategoryId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NULL,
    [ParentId]   INT           NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryId] ASC),
    CONSTRAINT [FK_Categories_Categories] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[Categories] ([CategoryId])
);

