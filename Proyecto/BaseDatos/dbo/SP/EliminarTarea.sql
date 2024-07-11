CREATE PROCEDURE [dbo].[EliminarTarea]
	@Id UniqueIdentifier
AS
BEGIN

	SET NOCOUNT ON;

	DELETE FROM [dbo].[Tareas]
	WHERE Id=@Id
			   
END
