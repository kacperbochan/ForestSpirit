CREATE TABLE [dbo].[Equipment] (
    [Name]         NCHAR (69) NOT NULL,
    [SerialNumber] NCHAR (69) NOT NULL,
    [ID]           INT        NOT NULL,
    [OutpostID]    INT        NOT NULL,
    CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Equipment_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID])
);

