use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_Fleteros_CambiarEstado' and type = 'P')
	drop procedure sp_Fleteros_CambiarEstado;
GO
/****************************************************************************
* Nombre:		sp_Fleteros_CambiarEstado											    *
* Autor:		Edna Lecea												        *
* Fecha:		02/03/2022													    *
* Descripción:	Procedimiento Almacenado para habilitar y deshabilitar fleteros *
****************************************************************************/
create procedure sp_Fleteros_CambiarEstado(
	@opc int, --Habilitar o deshabilitar
	@idFletero int,
	@motivo int,
	@fechaMotivo date,
	@descripcion varchar(300)
	
)
AS
BEGIN
	IF @opc = 1 --Habilitar
	BEGIN
		insert into Motivo(motivo, descripcion, fecha)values(@motivo, @descripcion, @fechaMotivo)

		DECLARE @idmot int
		SET @idmot =(select @@IDENTITY)

		update Fletero
		set estado = 1, --id del estado habilitar
		motivo = @idmot
		where idFletero = @idFletero

		select @idmot idmot

	END

	IF @opc = 2 --Deshabilitar
	BEGIN
		insert into Motivo(motivo, descripcion, fecha)values(@motivo, @descripcion, @fechaMotivo)

		DECLARE @idmotd int
		SET @idmotd = (select @@IDENTITY)

		update Fletero
		set estado = 2, --id del estado deshabilitar
		motivo = @idmotd
		where idFletero = @idFletero

		select @idmotd idmotd
	END
END
