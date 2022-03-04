-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author: Sergio Tello
-- Create date: 2/3/2022
-- Description:	Stored de habilitar y deshabilitar contratos
-- =============================================
CREATE PROCEDURE sp_DeshabilitarHabilitarContratos 
	-- Add the parameters for the stored procedure here
	@opc int, --Habilitar o deshabilitar
	@idContrato int,
	@motivo int,
	@fechaMotivo date,
	@descripcion varchar(300)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @opc = 1 --Habilitar
	BEGIN
		update into Motivo(motivo, descripcion, fechaMotivo) values (@motivo, @descripcion, @fechaMotivo)

		DECLARE @id int
		SET @id = (select @@IDENTITY)

		update Contratos
		set estado = 1 --id del estado habilitar
		motivo = @id
		where idContrato = @idContrato

		select @id id
	END

	IF @opc = 2 --Deshabilitar
	BEGIN
		insert into Motivo(motivo, descripcion, fechaMotivo)values(@motivo, @descripcion, @fechaMotivo)

		DECLARE @id int
		SET @id = (select @@IDENTITY)

		update Contratos
		set estado = 2 --id del estado deshabilitar
		motivo = @id
		where idContrato = @idContrato

		select @id id
	END
END
GO
