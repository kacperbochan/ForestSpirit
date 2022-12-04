CREATE TABLE [dbo].[Order] (
    [OrderDate]            NCHAR (10) NOT NULL,
    [CustomerID]           INT        NOT NULL,
    [Price]                NCHAR (10) NOT NULL,
    [Status]               NCHAR (10) NOT NULL,
    [ID]                   INT        NOT NULL,
    [ProdictedDeliveryDay] DATE       NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([ID])
);

