CREATE TABLE [dbo].[Professionals] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [EmployersID] INT NOT NULL,
    [BussinesDetailsID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

