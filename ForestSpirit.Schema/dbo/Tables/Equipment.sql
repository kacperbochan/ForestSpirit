CREATE TABLE [dbo].[Equipment] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (69)      NOT NULL,
    [SerialNumber]          NCHAR (69)      NOT NULL,
    [OutpostID]             INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Equipment] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Equipment_Outpost] FOREIGN KEY ([OutpostID]) REFERENCES [dbo].[Outpost] ([ID])
);

