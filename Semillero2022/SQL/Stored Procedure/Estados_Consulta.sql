use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'Estado_Consulta' and type = 'P')
	drop procedure Estado_Consulta;
GO

/****************************************************************************
* Nombre:		Estado_Consulta									 *
* Autor:		Edna Lecea										 *
* Fecha:		02/03/2022										 *
* Descripción:	Procedimiento Almacenado para traer estados*
****************************************************************************/
create procedure Estado_Consulta
as 
begin
	
	select ID_ESTADO, NOMBRE
	from Catalogo_Estados

end