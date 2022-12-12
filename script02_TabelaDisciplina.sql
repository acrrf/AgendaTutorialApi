BEGIN TRANSACTION;
GO

CREATE TABLE [Agendamentos] (
    [Id] int NOT NULL IDENTITY,
    [DataAgendamento] datetime2 NOT NULL,
    [HoraAgendamento] datetime2 NOT NULL,
    CONSTRAINT [PK_Agendamentos] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Disciplinas] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Descricao] nvarchar(max) NULL,
    CONSTRAINT [PK_Disciplinas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Disponibilidades] (
    [Id] int NOT NULL IDENTITY,
    [DataDisponibilidade] datetime2 NOT NULL,
    [HoraDisponibilidade] datetime2 NOT NULL,
    CONSTRAINT [PK_Disponibilidades] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(max) NULL,
    [Login] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Senha] nvarchar(max) NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [TipoUsuario] int NOT NULL DEFAULT 1,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Email', N'Login', N'Nome', N'PasswordHash', N'PasswordSalt', N'Senha', N'TipoUsuario') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] ON;
INSERT INTO [Usuarios] ([Id], [Email], [Login], [Nome], [PasswordHash], [PasswordSalt], [Senha], [TipoUsuario])
VALUES (1, NULL, NULL, N'Admin', 0x9BBF12E70A929314E807E07208C7CC2724F2F394BAF55F8EB0A3967D99CDAE5D67989A8A60B0A752D3B822E8865EF308CCA38EB5EE4C52B2F16CC735FC01B1D1, 0xFCE6D4FE1F13A58E60FAD9706270E53BF970D9A7F00EEA1F7171531A5B9B41430C2E2AB4708D0BB723D1EA0B5DC5570B2720EFF8D1E047142F833EC76632D902D43356F1FFC01854B2B5C94107D23058C2FF94D780FB99FA6B30524EBD8E2D6CCA780514AE684F0612C5C359ADDF82D6EF6A09CCE8B906AA29101CCEBE37676D, N'', 4),
(2, N'ana.felippe3@etec.sp.gov.br', N'AnaClaudia', N'Ana Claudia', NULL, NULL, NULL, 1),
(3, N'maroyofelippe@gmail.com', N'mrroyo', N'Marco Royo', NULL, NULL, NULL, 1),
(4, N'rafaelTutor@gmail.com', N'rafaroyo', N'Rafael Royo', NULL, NULL, NULL, 3);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Email', N'Login', N'Nome', N'PasswordHash', N'PasswordSalt', N'Senha', N'TipoUsuario') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221211211408_Usuarios', N'7.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

UPDATE [Usuarios] SET [PasswordHash] = 0xF4993035C0E1F4A7F681606EE8091BFC34A7A27EB5DD6C33D73E389D454E1472C364E4852F67DBD4E7F5B9D5A0D7D6BCDCF2CC724A641CB71F08020C59D70CBB, [PasswordSalt] = 0x8E6767666479CD2B8B45BC1FB71BF0B523A86ABC0C3AB9F6E23D86967144A98F726F6D4D385A2200377A9B49D68E50E03C65DFE423A0E57D8DA5EBDA99B28B7A9E69B8134C1171B32FD5CB0B39ECDEF5B5C8E330E1A8B0AB6AEA18480DB03FFCBE1094CF5429B7154B4095A262E4C82365063C4F695339E6E6EF1B8514172FCC
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221211222927_MigracaoDisciplina', N'7.0.0');
GO

COMMIT;
GO

