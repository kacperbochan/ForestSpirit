CREATE TABLE [dbo].[Order_Item] (
    [ID]                    INT             NOT NULL,
    [Quantity]              INT             NULL,
    [OrderID]               INT             NOT NULL,
    [Outpost_ProductID]     INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Order_Item] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Item_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([ID]),
    CONSTRAINT [FK_Order_Item_Outpost_Product] FOREIGN KEY ([Outpost_ProductID]) REFERENCES [dbo].[Outpost_Product] ([ID])
);

