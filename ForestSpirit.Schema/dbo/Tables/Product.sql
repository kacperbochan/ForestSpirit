CREATE TABLE [dbo].[Product] (
    [Name]             NCHAR (69)  NOT NULL,
    [Procentage]       INT         NOT NULL,
    [Price]            INT         NOT NULL,
    [Ingridience]      NCHAR (420) NOT NULL,
    [Rating]           INT         NOT NULL,
    [ID]               INT         NOT NULL,
    [NumberOfOpinions] INT         NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([ID] ASC)
);

