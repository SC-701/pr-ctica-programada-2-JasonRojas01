CREATE PROCEDURE AgregarPersona
@Id UniqueIdentifier,
@Nombre varchar(Max),
@Extracto varchar(Max),
@Contacto int,
@Foto image
AS
BEGIN

    SET NOCOUNT ON;

    INSERT INTO [dbo].[Persona]
               ([Id]
               ,[Nombre]
               ,[Extracto]
               ,[Contacto]
               ,[Foto])
         VALUES
               (@Id
               ,@Nombre
               ,@Extracto
               ,@Contacto
               ,@Foto)
END