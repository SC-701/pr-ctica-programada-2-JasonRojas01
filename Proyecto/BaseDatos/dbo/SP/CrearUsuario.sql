CREATE PROCEDURE [dbo].[CrearUsuario]
	@Id uniqueidentifier,
	@Nombre varchar(MAX),
	@Correo varchar(MAX)
AS
	BEGIN 
	SET NOCOUNT ON;
	INSERT INTO [dbo].[Usuario]([Id],[Nombre],[Correo])
     VALUES (@Id,@Nombre,@Correo)    
	END
