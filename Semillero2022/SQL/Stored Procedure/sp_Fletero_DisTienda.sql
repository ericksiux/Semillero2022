use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_Fletero_DisTienda' and type = 'P')
	drop procedure sp_Fletero_DisTienda
GO
/****************************************************************************
* Nombre:		sp_DisTienda												                            *
* Autor:		Edna Lecea																			    *
* Fecha:		02/03/2022																			    *
* Descripción:	Procedimiento Almacenado para registrar la lista de las tiendas que se asocia un fletero*
****************************************************************************/

create procedure sp_Fletero_DisTienda(
	@opc int,
	@idFletero int,
	@idTienda int
)
AS
BEGIN
	IF @opc = 1 --Agregar en la tabla toda la lista de las tiendas de un fletero
	BEGIN
		DECLARE @idDistrito int
		SET @idDistrito = (select IDDISTRICT from Catalogo_Tienda where IDSTORE = @idTienda)
		
		DECLARE @id int
		SET @id = (select @@IDENTITY)

		insert into DistTienda(tienda, distrito, fletero)values(@idTienda, @idDistrito, @id)
		select @@IDENTITY ultimoIdDistTienda
	END
END
