CREATE PROCEDURE EliminarPersona
@Id UniqueIdentifier
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[Persona]
	WHERE Id=@Id
			   
END