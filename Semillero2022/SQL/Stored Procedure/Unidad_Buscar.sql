CREATE PROC [dbo].[Unidad_Buscar]
(
	@idUnidad int
)
AS
BEGIN
-- procesamiento de informacion
select * from UnidadCarga where idUnidad = @idUnidad;
end