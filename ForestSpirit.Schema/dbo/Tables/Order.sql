CREATE TABLE [dbo].[Order] (
    [ID]                    INT             NOT NULL,
    [Price]                 NCHAR (10)      NOT NULL,
    [OrderDate]             NCHAR (10)      NOT NULL,
    [ProdictedDeliveryDay]  DATE            NULL,
    [Status]                NCHAR (10)      NOT NULL,
    [CustomerID]            INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customer] ([ID])
);

