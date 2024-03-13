drop table BussinesDetails

CREATE TABLE [dbo].[BussinesDetails] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [ProfessionID] INT           NOT NULL,
    [businessName] NVARCHAR (50) NOT NULL,
    [Experience]   INT           NOT NULL,
    [CityId]       INT           NOT NULL,
    [PriceRange]   NVARCHAR (50) NOT NULL,
    [EmployerID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BussinesDetails_ToAddresses] FOREIGN KEY ([CityId]) REFERENCES [dbo].[Addresses] ([Id]),
    CONSTRAINT [FK_BussinesDetails_ToProfessionals] FOREIGN KEY ([ProfessionID]) REFERENCES [dbo].[Professionals] ([Id]),
	CONSTRAINT [FK_BussinesDetails_ToEmployers] FOREIGN KEY ([EmployerID]) REFERENCES [dbo].[Employers] ([Id])
);

address table CONSTRAINT [FK_Employers_ToBussinesDetails] FOREIGN KEY ([BussinesDetailsID]) REFERENCES [dbo].[BussinesDetails] ([Id])

drop table Addresses
CREATE TABLE [dbo].[Employers] (
    [Id]                INT           NOT NULL,
    [FirstName]         NVARCHAR (50) NOT NULL,
    [LastName]          NVARCHAR (50) NOT NULL,
    [AddressID]         INT           NOT NULL,
    [BussinesDetailsID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employers_ToAddresses] FOREIGN KEY ([AddressID]) REFERENCES [dbo].[Addresses] ([Id])
    
);