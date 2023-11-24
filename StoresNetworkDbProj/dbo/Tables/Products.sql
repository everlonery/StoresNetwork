CREATE TABLE [dbo].[Products] (
    [ProductId]   INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)  NOT NULL,
    [Price]       MONEY          NOT NULL,
    [IsForAdults] BIT            NOT NULL,
    [IsExcise]    BIT            NOT NULL,
    [PicturePath] NVARCHAR (100) NULL,
    [CategoryId]  INT            NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ProductId] ASC),
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId])
);

