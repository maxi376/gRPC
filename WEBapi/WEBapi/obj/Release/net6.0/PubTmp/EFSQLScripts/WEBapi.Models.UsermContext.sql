IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230108182017_Initial')
BEGIN
    CREATE TABLE [Userms] (
        [UsermId] int NOT NULL IDENTITY,
        [UsermName] nvarchar(max) NOT NULL,
        [UsermRole] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Userms] PRIMARY KEY ([UsermId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230108182017_Initial')
BEGIN
    CREATE TABLE [Devices] (
        [DeviceId] int NOT NULL IDENTITY,
        [UsermId] int NOT NULL,
        [DeviceDescription] nvarchar(max) NOT NULL,
        [DeviceAddress] nvarchar(max) NOT NULL,
        [DeviceMaxHEnergyConsumption] int NOT NULL,
        CONSTRAINT [PK_Devices] PRIMARY KEY ([DeviceId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230108182017_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230108182017_Initial', N'7.0.1');
END;
GO

COMMIT;
GO

