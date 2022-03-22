IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Unidad_Agregar]') AND type in (N'P', N'PC'))
   DROP PROCEDURE Unidad_Agregar
GO

/***************************************************************************
* Nombre:		Unidad_Agregar											   *
* Autor:		Armando Carrizoza										   *
* Fecha:		03/03/2022												   *
* Descripci�n:	Procedimiento Almacenado de ejemplo para agregar datos     *
****************************************************************************/
GO

CREATE PROC Unidad_Agregar
(
	@tienda int,
	@fletero int,
	@modalidad bit,
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

INSERT INTO UnidadCarga(tienda,fletero,modalidad,permiso,tipoUnidad,numero_eco,tipoCarroceria,marca,
modelo,largo,ancho,alto,peso,polizaSeguro,tarjetaCirculacion,placas,caract_especial,GPS)
VALUES (@tienda,@fletero,@modalidad,@permiso,@tipoUnidad,@numero_eco,@tipoCarroceria,@marca,@modelo,
@largo,@ancho,@alto,@peso,@polizaSeguro,@tarjetaCirculacion,@placas,@caract_especial,@GPS);

select @@IDENTITY idUnidad;

END