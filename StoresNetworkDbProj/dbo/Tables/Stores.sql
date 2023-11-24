CREATE TABLE [dbo].[Stores] (
    [StoreId] INT            IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50)  NOT NULL,
    [Address] NVARCHAR (100) NULL,
    [ZipCode] INT            NOT NULL,
    [Email]   NVARCHAR (50)  NULL,
    [Phone]   NVARCHAR (16)  NOT NULL,
    [CityId]  INT            NULL,
    CONSTRAINT [PK_Stores] PRIMARY KEY CLUSTERED ([StoreId] ASC),
    CONSTRAINT [FK_Stores_Cities] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Cities] ([CityId])
);

