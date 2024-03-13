CREATE TABLE [dbo].[Employers] (
    [Id]                INT           NOT NULL,
    [FirstName]         NVARCHAR (50) NOT NULL,
    [LastName]          NVARCHAR (50) NOT NULL,
    [AddressID]         INT           NOT NULL,
    [ProfessionalID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employers_ToAddresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([Id]),
    CONSTRAINT [FK_Employers_ToProfessionals] FOREIGN KEY ([ProfessionalID]) REFERENCES [dbo].[Professionals] ([Id])
);

