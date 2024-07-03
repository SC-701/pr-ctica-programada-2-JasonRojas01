CREATE PROCEDURE ObtenerPersona
@Id UniqueIdentifier
AS
BEGIN

	SET NOCOUNT ON;

	SELECT Id, Nombre 
	FROM Persona
	WHERE Id=@Id
			   
END