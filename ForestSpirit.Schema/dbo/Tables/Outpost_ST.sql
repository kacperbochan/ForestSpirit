CREATE TABLE [dbo].[Outpost_ST] (
    [ID]                    INT             NOT NULL,
    [NumberOfOrders]        INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Outpost_ST] PRIMARY KEY CLUSTERED ([ID] ASC)
);

