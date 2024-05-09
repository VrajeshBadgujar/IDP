CREATE TABLE [dbo].[Address] (
    [Id]            INT           NOT NULL,
    [PersonId]      INT           NOT NULL,
    [StreetAddress] NVARCHAR (50) NULL,
    [City]          NVARCHAR (50) NULL,
    [State]         NVARCHAR (50) NULL,
    [ZipCode]       NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Address_Person ] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id])
);

