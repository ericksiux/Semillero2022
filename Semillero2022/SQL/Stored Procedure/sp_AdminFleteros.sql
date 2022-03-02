use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_AdminFleteros' and type = 'P')
	drop procedure sp_AdminFleteros;
GO
/****************************************************************************
* Nombre:		sp_AdminFleteros											    *
* Autor:		Edna Lecea												        *
* Fecha:		02/03/2022													    *
* Descripción:	Procedimiento Almacenado para habilitar y deshabilitar fleteros *
****************************************************************************/
create procedure sp_AdminFleteros(
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
		SET @idmot = (select max(idMotivo) from Motivo)

		update Fletero
		set estado = 1, --id del estado habilitar
		motivo = @idmot
		where idFletero = @idFletero
	END

	IF @opc = 2 --Deshabilitar
	BEGIN
		insert into Motivo(motivo, descripcion, fecha)values(@motivo, @descripcion, @fechaMotivo)

		DECLARE @idmotd int
		SET @idmotd = (select max(idMotivo) from Motivo)

		update Fletero
		set estado = 2, --id del estado deshabilitar
		motivo = @idmotd
		where idFletero = @idFletero
	END
END
