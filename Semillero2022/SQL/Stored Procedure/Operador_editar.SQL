
/****************************************************************************
* Nombre:		sp_editarOperador												                *
* Autor:		Pedro Ochoa																		*
* Fecha:		03/03/2022																		*
* Descripción:	Procedimiento Almacenado para editar un operador                              *
****************************************************************************/
CREATE PROCEDURE sp_editarOperador(
@idOperador int,
@calle text ,
@numero int,
@colonia nvarchar,
@municipio text,
@estado text,
@cp int,
@noCredencialElector int,
@fechaVigenciaLicencia date,
@noLicencia int,
@padecimientos text ,
@curp nvarchar(18),
@noIMSS int ,
@estatusConfiabilidad text,
@motivoRechazo text,
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
	update operadores set calle=@calle,numero=@numero ,colonia=@colonia,municipio=@municipio,estado=@estado,cp=@cp,noCredencialElector=@noCredencialElector,fechaVigenciaLicencia=@fechaVigenciaLicencia,noLicencia=@noLicencia ,padecimientos=@padecimientos ,curp=@curp,noIMSS=@noIMSS ,estatusConfiabilidad=@estatusConfiabilidad,motivoRechazo=@motivoRechazo,puesto=@puesto,capacitadoChofer=@capacitadoChofer,estatus=@estatus,motivo=@motivo,descripcion=@descripcion,fechaMotivo=@fechaMotivo,fotografia=@fotografia, placas=@placas,tipoUnidad=@tipoUnidad
	where idOperador=@idOperador
end
GO