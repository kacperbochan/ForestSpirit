CREATE TABLE [dbo].[Outpost_Product] (
    [ID]                    INT             NOT NULL,
    [ProductionDate]        DATE            NOT NULL,
    [Quantity]              INT             NOT NULL,
    [ProductID]             INT             NOT NULL,
    [OutpostID]             INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Outpost_Product] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Outpost_Product_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID]),
    CONSTRAINT [FK_Outpost_Product_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);

