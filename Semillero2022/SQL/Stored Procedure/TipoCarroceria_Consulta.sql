IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[TipoCarroceria_Consulta]') AND type in (N'P', N'PC'))
   DROP PROCEDURE TipoCarroceria_Consulta
GO

/***************************************************************************
* Nombre:		TipoCarroceria_Consulta									   *
* Autor:		Armando Carrizoza										   *
* Fecha:		16/03/2022												   *
* Descripción:	Procedimiento Almacenado para obtener el Tipo de Carroceria*
****************************************************************************/

create procedure TipoCarroceria_Consulta
(
	@idCarroceria int
)
as
begin
	select idCarroceria, TipoCarroceria
	from TipoCarroceria
end