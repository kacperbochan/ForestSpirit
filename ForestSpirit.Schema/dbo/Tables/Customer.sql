CREATE TABLE [dbo].[Customer] (
    [Name]       NCHAR (69) NOT NULL,
    [PublicName] NCHAR (69) NOT NULL,
    [ID]         INT        NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([ID] ASC)
);

