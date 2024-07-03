-- =============================================
-- Author:		Jason
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE ObtenerTodosPersona 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(Id) FROM Persona
END