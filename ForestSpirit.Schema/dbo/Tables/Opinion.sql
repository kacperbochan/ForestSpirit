CREATE TABLE [dbo].[Opinion] (
    [Text]        NCHAR (69) NOT NULL,
    [Rating]      INT        NOT NULL,
    [CreateDate]  DATE       NOT NULL,
    [ID]          INT        NOT NULL,
    [CusteomerID] INT        NOT NULL,
    [ProductID]   INT        NOT NULL,
    CONSTRAINT [PK_Opinion] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Opinion_Customer] FOREIGN KEY ([CusteomerID]) REFERENCES [dbo].[Customer] ([ID]),
    CONSTRAINT [FK_Opinion_Outpost_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Outpost_Product] ([ID]),
    CONSTRAINT [FK_Opinion_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);

