CREATE TABLE [dbo].[BussinesDetails] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [businessName] NVARCHAR (50) NOT NULL,
    [Experience]   INT           NOT NULL,
    [CityId]       INT           NOT NULL,
    [PriceRange]   NVARCHAR (50) NOT NULL,
    [ProfessionalID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BussinesDetails_ToAddresses] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Addresses] ([Id]),
    CONSTRAINT [FK_BussinesDetails_ToProfessionals] FOREIGN KEY ([ProfessionalID]) REFERENCES [dbo].[Professionals] ([Id])
);

