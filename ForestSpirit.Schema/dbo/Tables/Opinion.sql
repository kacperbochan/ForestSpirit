CREATE TABLE [dbo].[Opinion] (
    [ID]                    INT             NOT NULL,
    [Text]                  NCHAR (69)      NOT NULL,
    [Rating]                INT             NOT NULL,
    [CusteomerID]           INT             NOT NULL,
    [ProductID]             INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Opinion] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Opinion_Customer] FOREIGN KEY ([CusteomerID]) REFERENCES [dbo].[Customer] ([ID]),
    CONSTRAINT [FK_Opinion_Outpost_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Outpost_Product] ([ID]),
    CONSTRAINT [FK_Opinion_Product] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Product] ([ID])
);

