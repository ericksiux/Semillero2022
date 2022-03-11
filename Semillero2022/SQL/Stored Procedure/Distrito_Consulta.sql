use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'Distrito_Consulta' and type = 'P')
	drop procedure Distrito_Consulta;
GO

/****************************************************************************
* Nombre:		Distrito_Consulta								 *
* Autor:		Edna Lecea										 *
* Fecha:		02/03/2022										 *
* Descripción:	Procedimiento Almacenado para traer los distritos*
****************************************************************************/
create procedure Distrito_Consulta
as 
begin
	select IDDISTRICT, DISTRICTNAME
	from Catalogo_Distrito;
end