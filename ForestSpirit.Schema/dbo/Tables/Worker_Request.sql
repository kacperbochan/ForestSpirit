CREATE TABLE [dbo].[Worker_Request] (
    [ID]                    INT             NOT NULL,
    [Title]                 NCHAR (69)      NOT NULL,
    [Content]               NCHAR (420)     NOT NULL,
    [WorkerID]              INT             NOT NULL,
    [ReceiverID]            INT             NOT NULL,
    [Created_By]            nvarchar(69)    NOT NULL,
    [Created_At]            datetime        NOT NULL,
    [Changed_By]            nvarchar(69)    NOT NULL,
    [Changed_At]            datetime        NOT NULL,
    CONSTRAINT [PK_Worker_Request] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Worker_Request_Worker] FOREIGN KEY ([ReceiverID]) REFERENCES [dbo].[Worker] ([ID]),
    CONSTRAINT [FK_Worker_Request_Worker1] FOREIGN KEY ([WorkerID]) REFERENCES [dbo].[Worker] ([ID])
);

