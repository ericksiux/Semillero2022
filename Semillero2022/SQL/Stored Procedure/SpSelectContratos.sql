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
-- Description:	stored obtener datos 
-- =============================================
CREATE PROCEDURE sp_SelectContratos 
	-- Add the parameters for the stored procedure here
	@pIdContrato int, 
	@pLugarFirmaContrato VARCHAR,
	@pFechaFirmaContrato datetime,
	@pQuienFirmaHomeDepot varchar,
	@pQuienFirmaFletero varchar,
	@pQuienRealizoFirma varchar,
	@pFechaInicioContrato datetime,
	@pFechaTerminacionContrato datetime,
	@pRenovacionAutomatica bit,
	@pRegion varchar,
	@pDistrito varchar,
	@pTienda varchar,
	@pFletero varchar,
	@pStatusContrato int,
	@pTarifa int,
	@pArchivo int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.idContrato, 
	c.lugarFirmaContrato, 
	c.fechaFirmaContrato,
	c.quienFirmaHomeDepot,
	c.quienFirmaFletero,
	c.quienRealizoFirma,
	c.fechaInicioContrato,
	c.fechaTerminacionContrato,
	c.renovacionAutomatica,
	c.region,
	c.distrito,
	c.tienda,
	c.fletero,
	c.statusContrato,
	c.tarifa,
	c.archivo

	FROM Contratos c

	WHERE c.idContrato = @pIdContrato 
	AND 
	c.lugarFirmaContrato = @pLugarFirmaContrato 
	AND 
	c.fechaFirmaContrato = @pFechaFirmaContrato
	AND 
	c.quienFirmaHomeDepot = @pQuienFirmaHomeDepot
	AND
	c.quienFirmaFletero = @pQuienFirmaFletero
	AND 
	c.quienRealizoFirma = @pQuienRealizoFirma
	AND
	c.fechaInicioContrato = @pFechaInicioContrato
	AND
	c.fechaTerminacionContrato = @pFechaTerminacionContrato
	AND
	c.renovacionAutomatica = @pRenovacionAutomatica
	AND
	c.region = c.region
	AND
	c.distrito = @pDistrito
	AND 
	c.tienda = @pTienda
	AND
	c.fletero = @pFletero
	AND
	c.statusContrato = @pStatusContrato
	AND
	c.tarifa = @pTarifa
	AND
	c.archivo = @pArchivo
END
GO
