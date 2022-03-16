use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'TituloMotivos_Consulta' and type = 'P')
	drop procedure TituloMotivos_Consulta;
GO
/****************************************************************************
* Nombre:		TituloMotivos_Consulta											    *
* Autor:		Edna Lecea												        *
* Fecha:		02/03/2022													    *
* Descripción:	Procedimiento Almacenado para obtener los titulos de los motivos *
****************************************************************************/
create procedure TituloMotivos_Consulta
AS
BEGIN
 select idTituloM, motivo
 from TituloMotivo;
END