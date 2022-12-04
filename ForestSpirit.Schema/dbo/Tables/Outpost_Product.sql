CREATE TABLE [dbo].[Outpost_Product] (
    [ProductID]      INT  NOT NULL,
    [OutpostID]      INT  NOT NULL,
    [Quantity]       INT  NOT NULL,
    [ProductionDate] DATE NOT NULL,
    [ID]             INT  NOT NULL,
    CONSTRAINT [PK_Outpost_Product] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Outpost_Product_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID]),
    CONSTRAINT [FK_Outpost_Product_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);

