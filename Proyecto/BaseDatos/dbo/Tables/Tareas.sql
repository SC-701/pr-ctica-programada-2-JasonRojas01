﻿CREATE TABLE [dbo].[Tareas]
(
	[Id] INT NOT NULL PRIMARY KEY,
    [Nombre] VARCHAR(MAX) NOT NULL, 
    [Descripcion] VARCHAR(MAX) NOT NULL, 
    [FechaIni] INT NOT NULL, 
    [Asignado] VARCHAR(MAX) NOT NULL, 
    [Estado] VARCHAR(MAX) NOT NULL,
    [IdUser] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_Tareas_Tareas] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Usuario] ([Id]) ON UPDATE CASCADE
)
