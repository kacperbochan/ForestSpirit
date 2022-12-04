CREATE TABLE [dbo].[Worker_Request] (
    [WorkerID]   INT         NOT NULL,
    [Title]      NCHAR (69)  NOT NULL,
    [CreateDate] NCHAR (10)  NOT NULL,
    [ReceiverID] INT         NOT NULL,
    [ID]         INT         NOT NULL,
    [Content]    NCHAR (420) NOT NULL,
    CONSTRAINT [PK_Worker_Request] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Worker_Request_Worker] FOREIGN KEY ([ReceiverID]) REFERENCES [dbo].[Worker] ([ID]),
    CONSTRAINT [FK_Worker_Request_Worker1] FOREIGN KEY ([WorkerID]) REFERENCES [dbo].[Worker] ([ID])
);

