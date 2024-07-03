﻿CREATE TABLE [dbo].[Persona]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(MAX) NOT NULL, 
    [Extracto] VARCHAR(MAX) NOT NULL, 
    [Contacto] INT NOT NULL, 
    [Foto] IMAGE NOT NULL
)
