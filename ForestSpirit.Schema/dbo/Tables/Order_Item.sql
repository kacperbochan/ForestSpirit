CREATE TABLE [dbo].[Order_Item] (
    [OrderID]           INT NOT NULL,
    [Quantity]          INT NULL,
    [Outpost_ProductID] INT NOT NULL,
    [ID]                INT NOT NULL,
    CONSTRAINT [PK_Order_Item] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Item_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([ID]),
    CONSTRAINT [FK_Order_Item_Outpost_Product] FOREIGN KEY ([Outpost_ProductID]) REFERENCES [dbo].[Outpost_Product] ([ID])
);

