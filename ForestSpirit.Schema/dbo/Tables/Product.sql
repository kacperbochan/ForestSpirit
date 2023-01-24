CREATE TABLE [dbo].[Product] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (69)      NOT NULL,
    [Category]              INT             NOT NULL,
    [Procentage]            INT             NOT NULL,
    [Price]                 INT             NOT NULL,
    [Ingridience]           NCHAR (420)     NOT NULL,
    [Tastes]                NCHAR (420)     NOT NULL,
    [Rating]                INT             NOT NULL,
    [Number_Of_Opinions]    INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ID] ASC)
);

