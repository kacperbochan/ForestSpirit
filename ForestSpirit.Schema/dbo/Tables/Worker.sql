CREATE TABLE [dbo].[Worker] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (69)      NOT NULL,
    [Wage]                  INT             NOT NULL,
    [Type]                  INT             NOT NULL,
    [Status]                INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED ([ID] ASC)
);

