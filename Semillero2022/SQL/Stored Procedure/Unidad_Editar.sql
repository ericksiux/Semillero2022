IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Unidad_Editar]') AND type in (N'P', N'PC'))
   DROP PROCEDURE Unidad_Editar
GO

/***************************************************************************
* Nombre:		Unidad_Editar											   *
* Autor:		Armando Carrizoza										   *
* Fecha:		03/03/2022												   *
* Descripción:	Procedimiento Almacenado de ejemplo para editar datos      *
****************************************************************************/
GO

CREATE PROC Unidad_Editar
(
	@idUnidad int,
	@fletero int,
	@permiso int,
	@tipoUnidad int,
	@numero_eco varchar(8),
	@tipoCarroceria int,
	@marca varchar(20),
	@modelo varchar(4),
	@largo varchar(10),
	@ancho varchar(10),
	@alto varchar(10),
	@peso int,
	@polizaSeguro int,
	@tarjetaCirculacion date,
	@placas int,
	@caract_especial varchar(50),
	@GPS bit
)
AS
BEGIN
	UPDATE UnidadCarga 
	SET fletero = @fletero, permiso = @permiso, tipoUnidad = @tipoUnidad, numero_eco = @numero_eco, tipoCarroceria = @tipoCarroceria,
	marca = @marca, modelo = @modelo, largo = @largo, ancho = @ancho, alto = @alto, peso = @peso, polizaSeguro = @polizaSeguro, 
	tarjetaCirculacion = @tarjetaCirculacion, placas = @placas, caract_especial = @caract_especial, GPS = @GPS
	WHERE idUnidad = @idUnidad;
END