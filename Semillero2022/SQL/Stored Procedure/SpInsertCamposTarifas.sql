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
CREATE PROCEDURE sp_InsertarCamposTarifas
	-- Add the parameters for the stored procedure here
	@pIdCampoTarifa int,
	@pMetodoPagoLocal bit,
	@pTarifaRentaDiaria decimal,
	@pDistanciaZonaLocal int,
	@pHorasLaboral int,
	@pTarifaHoraExtra decimal,
	@pTarifaEntregaLocal decimal,
	@pTarifaVueltaLocal decimal,
	@pTarifaReparto decimal,
	@pIncluyeManiobra bit,
	@pUnidadCarga int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [CamposTarifas] (idCampoTarifa,
	metodoPagoLocal,
	tarifaRentaDiaria,
	distanciaZonaLocal,
	horasLaboral,
	tarifaHoraExtra,
	tarifaEntregaLocal,
	tarifaVueltaLocal,
	tarifaReparto,
	incluyeManiobra,
	unidadCarga
	)
	VALUES(@pIdCampoTarifa,
	@pMetodoPagoLocal,
	@pTarifaRentaDiaria,
	@pDistanciaZonaLocal,
	@pHorasLaboral,
	@pTarifaHoraExtra,
	@pTarifaEntregaLocal,
	@pTarifaVueltaLocal,
	@pTarifaReparto,
	@pIncluyeManiobra,
	@pUnidadCarga
	)
END
GO
