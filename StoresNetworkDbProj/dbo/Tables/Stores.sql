CREATE TABLE [dbo].[Stores] (
    [StoreId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50)  NULL,
    [Address] NVARCHAR (100) NULL,
    [ZipCode] INT            NULL,
    [Email]   NVARCHAR (50)  NULL,
    [Phone]   NVARCHAR (16)  NULL,
    [CityId]  INT            NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([StoreId] ASC),
    CONSTRAINT [FK_Stores_Cities] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([CityId]) ON DELETE SET NULL
);

