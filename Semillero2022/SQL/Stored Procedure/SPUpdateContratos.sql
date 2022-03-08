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
-- Author:		Sergio Tello
-- Create date: 3/2/2022
-- Description: SP for update 
-- =============================================
CREATE PROCEDURE Contratos_Editar(
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
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [Contratos] SET [idContrato] = ISNULL(@pIdContrato,idContrato),
	[lugarFirmaContrato] = ISNULL(@pIdContrato,@pLugarFirmaContrato),
	[fechaFirmaContrato] = ISNULL(@pIdContrato,@pFechaFirmaContrato),
	[quienFirmaHomeDepot] = ISNULL(@pIdContrato,@pQuienFirmaHomeDepot),
	[quienFirmaFletero] = ISNULL(@pIdContrato,@pQuienFirmaFletero),
	[quienRealizoFirma] = ISNULL(@pIdContrato,@pQuienRealizoFirma),
	[fechaInicioContrato] = ISNULL(@pIdContrato,@pFechaInicioContrato),
	[fechaTerminacionContrato] = ISNULL(@pIdContrato,@pFechaTerminacionContrato),
	[renovacionAutomatica] = ISNULL(@pIdContrato,@pRenovacionAutomatica),
	[renovacionAutomatica] = ISNULL(@pIdContrato,@pRenovacionAutomatica),
	[region] = ISNULL(@pIdContrato,@pRegion),
	[distrito] = ISNULL(@pIdContrato,@pDistrito),
	[tienda] = ISNULL(@pIdContrato,@pTienda),
	[fletero] = ISNULL(@pIdContrato,@pFletero),
	[statusContrato] = ISNULL(@pIdContrato,@pStatusContrato),
	[tarifa] = ISNULL(@pIdContrato,@pTarifa),
	[Archivo] = ISNULL(@pIdContrato,@pArchivo)
END
GO
