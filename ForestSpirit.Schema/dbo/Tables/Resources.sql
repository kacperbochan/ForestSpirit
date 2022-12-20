CREATE TABLE [dbo].[Resources] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (69)      NOT NULL,
    [BuyDate]               DATE            NOT NULL,
    [ExpirationDate]        DATE            NOT NULL,
    [Quantity]              INT             NOT NULL,
    [OutpostID]             INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Resources_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID])
);

