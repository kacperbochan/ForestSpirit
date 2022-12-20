CREATE TABLE [dbo].[Customer] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (69)      NOT NULL,
    [PublicName]            NCHAR (69)      NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([ID] ASC)
);

