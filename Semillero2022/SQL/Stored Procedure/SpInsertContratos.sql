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
-- Description:	Stored insertar datos
-- =============================================
CREATE PROCEDURE sp_InsertarContrato
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
	INSERT INTO [Contratos](idContrato, 
	lugarFirmaContrato, 
	fechaFirmaContrato,
	quienFirmaHomeDepot,
	quienFirmaFletero,
	quienRealizoFirma,
	fechaInicioContrato,
	fechaTerminacionContrato,
	renovacionAutomatica,
	region,
	distrito,
	tienda,
	fletero,
	statusContrato,
	tarifa,
	archivo
	)

	VALUES(@pIdContrato,
	@pLugarFirmaContrato,
	@pFechaFirmaContrato,
	@pQuienFirmaHomeDepot,
	@pQuienFirmaFletero,
	@pQuienRealizoFirma,
	@pFechaInicioContrato,
	@pFechaTerminacionContrato,
	@pRenovacionAutomatica,
	@pRegion,
	@pDistrito,
	@pTienda,
	@pFletero,
	@pStatusContrato,
	@pTarifa,
	@pArchivo
	)
END
GO
