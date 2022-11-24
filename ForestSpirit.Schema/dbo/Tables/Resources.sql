CREATE TABLE [dbo].[Resources] (
    [Name]           NCHAR (69) NOT NULL,
    [Quantity]       INT        NOT NULL,
    [ExpirationDate] DATE       NOT NULL,
    [BuyDate]        DATE       NOT NULL,
    [ID]             INT        NOT NULL,
    [OutpostID]      INT        NOT NULL,
    CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Resources_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID])
);

