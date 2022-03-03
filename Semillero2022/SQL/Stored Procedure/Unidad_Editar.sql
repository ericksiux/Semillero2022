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