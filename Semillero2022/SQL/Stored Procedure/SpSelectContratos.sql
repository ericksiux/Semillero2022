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
CREATE PROCEDURE Contratos_Obtener 
	-- Add the parameters for the stored procedure here
	@pIdContrato int,
	@pRegion varchar,
	@pDistrito varchar,
	@pTienda varchar,
	@pFletero varchar
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.idContrato,
	c.region,
	c.distrito,
	c.tienda,
	c.fletero,

	FROM Contratos c

	WHERE c.idContrato = @pIdContrato 
	AND 
	c.region = c.region
	AND
	c.distrito = @pDistrito
	AND 
	c.tienda = @pTienda
	AND
	c.fletero = @pFletero
END
GO
