CREATE TABLE [dbo].[Outpost] (
    [ID]                    INT             NOT NULL,
    [Name]                  NCHAR (10)      NOT NULL,
    [Geo_Lat]               FLOAT (53)      NOT NULL,
    [Geo_Lng]               FLOAT (53)      NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Outpost] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Outpost_Outpost_ST] FOREIGN KEY ([ID]) REFERENCES [dbo].[Outpost_ST] ([ID])
);

