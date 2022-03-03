CREATE PROC Unidad_Agregar
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

INSERT INTO UnidadCarga(idUnidad,fletero,permiso,tipoUnidad,numero_eco,tipoCarroceria,marca,
modelo,largo,ancho,alto,peso,polizaSeguro,tarjetaCirculacion,placas,caract_especial,GPS)
VALUES (@idUnidad,@fletero,@permiso,@tipoUnidad,@numero_eco,@tipoCarroceria,@marca,@modelo,
@largo,@ancho,@alto,@peso,@polizaSeguro,@tarjetaCirculacion,@placas,@caract_especial,@GPS);
select * from UnidadCarga where idUnidad = @idUnidad;

END