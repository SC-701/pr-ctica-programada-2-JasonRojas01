﻿CREATE TABLE [dbo].[Usuario]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(MAX) NOT NULL, 
    [Correo] VARCHAR(MAX) NOT NULL
)
