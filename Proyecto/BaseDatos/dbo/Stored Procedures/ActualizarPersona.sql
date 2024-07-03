CREATE PROCEDURE ActualizarPersona
@Id UniqueIdentifier,
@Nombre varchar(Max),
@Extracto varchar(Max),
@Contacto int,
@Foto image
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE [dbo].[Persona]
	SET [Nombre] = @Nombre,
	    [Extracto] = @Extracto,
	    [Contacto] = @Contacto,
	    [Foto] = @Foto
	WHERE Id = @Id;
			   
END