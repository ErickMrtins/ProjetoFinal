
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/25/2018 19:52:48
-- Generated from EDMX file: C:\Users\EHQSMOVEL002\Source\Repos\ProjetoFinal\PetShop\PetShop\DataBasePetShop.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PrimeiraDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteAnimal_Cliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteAnimal] DROP CONSTRAINT [FK_ClienteAnimal_Cliente];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteAnimal_Animal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ClienteAnimal] DROP CONSTRAINT [FK_ClienteAnimal_Animal];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Funcionarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Funcionarios];
GO
IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Animais]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Animais];
GO
IF OBJECT_ID(N'[dbo].[Agendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Agendas];
GO
IF OBJECT_ID(N'[dbo].[ClienteAnimal]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteAnimal];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Funcionarios'
CREATE TABLE [dbo].[Funcionarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Cargo] nvarchar(max)  NOT NULL,
    [Salario] float  NOT NULL,
    [Tipo] bit  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [Valor] float  NOT NULL,
    [Codigo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Animal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Animais'
CREATE TABLE [dbo].[Animais] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Raca] nvarchar(max)  NOT NULL,
    [Porte] nvarchar(max)  NOT NULL,
    [Peso] float  NOT NULL,
    [Cor] nvarchar(max)  NOT NULL,
    [Dono] nvarchar(max)  NOT NULL,
    [Idade] int  NOT NULL
);
GO

-- Creating table 'Agendas'
CREATE TABLE [dbo].[Agendas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data] datetime  NOT NULL,
    [Horario] time  NOT NULL,
    [Especialidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClienteAnimal'
CREATE TABLE [dbo].[ClienteAnimal] (
    [Cliente_Id] int  NOT NULL,
    [Animal1_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [PK_Funcionarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Animais'
ALTER TABLE [dbo].[Animais]
ADD CONSTRAINT [PK_Animais]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Agendas'
ALTER TABLE [dbo].[Agendas]
ADD CONSTRAINT [PK_Agendas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Cliente_Id], [Animal1_Id] in table 'ClienteAnimal'
ALTER TABLE [dbo].[ClienteAnimal]
ADD CONSTRAINT [PK_ClienteAnimal]
    PRIMARY KEY CLUSTERED ([Cliente_Id], [Animal1_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Cliente_Id] in table 'ClienteAnimal'
ALTER TABLE [dbo].[ClienteAnimal]
ADD CONSTRAINT [FK_ClienteAnimal_Cliente]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Animal1_Id] in table 'ClienteAnimal'
ALTER TABLE [dbo].[ClienteAnimal]
ADD CONSTRAINT [FK_ClienteAnimal_Animal]
    FOREIGN KEY ([Animal1_Id])
    REFERENCES [dbo].[Animais]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteAnimal_Animal'
CREATE INDEX [IX_FK_ClienteAnimal_Animal]
ON [dbo].[ClienteAnimal]
    ([Animal1_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------