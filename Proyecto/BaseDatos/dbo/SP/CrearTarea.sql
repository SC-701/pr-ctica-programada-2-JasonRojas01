CREATE PROCEDURE [dbo].[CrearTarea]
    @Id UNIQUEIDENTIFIER,
    @Nombre NVARCHAR(MAX),
    @Descripcion NVARCHAR(MAX),
    @FechaIni INT,
    @Asignado NVARCHAR(MAX),
    @Estado NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON; 

    INSERT INTO Tareas (Id, Nombre, Descripcion, FechaIni, Asignado, Estado)
    VALUES (@Id, @Nombre, @Descripcion, @FechaIni, @Asignado, @Estado);
    
    SELECT @Id AS Id;
END;
GO

