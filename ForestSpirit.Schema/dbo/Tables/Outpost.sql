CREATE TABLE [dbo].[Outpost] (
    [Name]    NCHAR (10) NOT NULL,
    [Geo_Lat] FLOAT (53) NOT NULL,
    [Geo_Lng] FLOAT (53) NOT NULL,
    [ID]      INT        NOT NULL,
    CONSTRAINT [PK_Outpost] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Outpost_Outpost_ST] FOREIGN KEY ([ID]) REFERENCES [dbo].[Outpost_ST] ([ID])
);

