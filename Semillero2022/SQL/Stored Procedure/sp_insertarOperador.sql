
/****************************************************************************
* Nombre:		sp_insertarOperador												                *
* Autor:		Pedro Ochoa																		*
* Fecha:		03/03/2022																		*
* Descripción:	Procedimiento Almacenado para insertar un operador                              *
****************************************************************************/
GO  
CREATE PROCEDURE sp_insertarOperador(
@distrito int ,
@fletero int,
@unidad int ,
@nombre text ,
@apellidoPat text,
@apellidoMat text,
@calle text,
@numero int ,
@colonia nvarchar ,
@municipio text,
@estado text ,
@cp int,
@noCredencialElector int,
@fechaVigenciaLicencia date,
@noLicencia int,
@padecimientos text,
@curp nvarchar(18),
@noIMSS int,
@estatusConfiabilidad text,
@motivoRechazo text,
@fechaRegistro date,
@puesto text ,
@capacitadoChofer char,
@estatus text ,
@motivo text,
@descripcion text,
@fechaMotivo date,
@fotografia image, 
@placas nvarchar,
@tipoUnidad  text)
AS  
begin
	insert into operadores (distrito,fletero ,unidad ,nombre ,apellidoPat ,apellidoMat ,calle,numero ,colonia,municipio,estado,cp,noCredencialElector,fechaVigenciaLicencia,noLicencia ,padecimientos ,curp,noIMSS ,estatusConfiabilidad,motivoRechazo,fechaRegistro,puesto,capacitadoChofer,estatus,motivo,descripcion,fechaMotivo,fotografia, placas,tipoUnidad)
	values( @distrito,@fletero ,@unidad ,@nombre ,@apellidoPat ,@apellidoMat ,@calle,@numero ,@colonia,@municipio,@estado,@cp,@noCredencialElector,@fechaVigenciaLicencia,@noLicencia ,@padecimientos ,@curp,@noIMSS ,@estatusConfiabilidad,@motivoRechazo,@fechaRegistro,@puesto,@capacitadoChofer,@estatus,@motivo,@descripcion,@fechaMotivo,@fotografia, @placas,@tipoUnidad)
end