CREATE TABLE [dbo].[Worker] (
    [Name]   NCHAR (69) NOT NULL,
    [Wage]   INT        NOT NULL,
    [Type]   INT        NOT NULL,
    [Status] INT        NOT NULL,
    [ID]     INT        NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([ID] ASC)
);

