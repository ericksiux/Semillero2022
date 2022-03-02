use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_DisTienda' and type = 'P')
	drop procedure sp_DisTienda
GO

create procedure sp_DisTienda(
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
		SET @id = (select max(idFletero) from Fletero)

		insert into DistTienda(tienda, distrito, fletero)values(@idTienda, @idDistrito, @id)
	END
END
