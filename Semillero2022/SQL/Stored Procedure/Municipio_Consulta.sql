use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'Municipio_Consulta' and type = 'P')
	drop procedure Municipio_Consulta;
GO

/****************************************************************************
* Nombre:		Estado_Consulta									 *
* Autor:		Edna Lecea										 *
* Fecha:		02/03/2022										 *
* Descripción:	Procedimiento Almacenado para traer municipios*
****************************************************************************/
create procedure Municipio_Consulta
(@id int
)
as 
begin
	if @id != 0
	begin
	select ID_MUNICIPIO, NOMBRE, ID_ESTADO
	from Catalogo_Municipios
	where ID_ESTADO = @id
	end

	if @id = 0
	begin
	select ID_MUNICIPIO, NOMBRE, ID_ESTADO
	from Catalogo_Municipios
	end
end