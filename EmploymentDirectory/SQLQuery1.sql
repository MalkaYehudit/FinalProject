drop table Employers
drop table Professionals
drop table BussinesDetails



CREATE TABLE [dbo].[Professionals] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [EmployersID] INT NOT NULL,
    [BussinesDetailsID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

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