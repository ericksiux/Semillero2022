use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'Tienda_Consulta' and type = 'P')
	drop procedure Tienda_Consulta;
GO

/****************************************************************************
* Nombre:		Tienda_Consulta									 *
* Autor:		Edna Lecea										 *
* Fecha:		02/03/2022										 *
* Descripción:	Procedimiento Almacenado para traer las tiendas*
****************************************************************************/
create procedure Tienda_Consulta(
	@id int
)
as 
begin
	if @id = 0
	begin
		select IDSTORE, STORENAME, IDDISTRICT
		from Catalogo_Tienda
	end

	if @id != 0
	begin
		select IDSTORE, STORENAME, IDDISTRICT
		from Catalogo_Tienda
		where IDDISTRICT = @id;
	end

end