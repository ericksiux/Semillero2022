IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[TipoUnidad_Consulta]') AND type in (N'P', N'PC'))
   DROP PROCEDURE TipoUnidad_Consulta
GO

/***************************************************************************
* Nombre:		TipoUnidad_Consulta										   *
* Autor:		Armando Carrizoza										   *
* Fecha:		16/03/2022												   *
* Descripción:	Procedimiento Almacenado para obtener el Tipo de Unidad    *
****************************************************************************/

create procedure TipoUnidad_Consulta
(
	@idTipoUnidad int
)
as
begin
	select idTipoUnidad, nombreUnidad, descripcion
	from TipoUnidad
end