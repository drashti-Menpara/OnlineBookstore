CREATE TABLE [dbo].[User] (
    [Id]       INT          IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Type]     VARCHAR (50) DEFAULT ('CUSROMER') NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

