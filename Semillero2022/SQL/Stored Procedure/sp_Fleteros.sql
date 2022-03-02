use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_Fleteros' and type = 'P')
	drop procedure sp_Fleteros;
GO

/****************************************************************************
* Nombre:		sp_ConsultasFletero												                *
* Autor:		Edna Lecea																		*
* Fecha:		02/03/2022																		*
* Descripción:	Procedimiento Almacenado para ingresar o modificar informacion en tabla fleteros*
****************************************************************************/

create procedure sp_Fleteros(
	@opc int,
	@idFletero int,
	@nombreFletero varchar(100),
	@RFC varchar(12),
	@dirFCalle varchar(100),
	@dirFNum int,
	@dirFCol varchar(100),
	@dirFMunicipio int,
	@dirFCP int,
	@dirBCalle varchar(100),
	@dirBNum int,
	@dirBCol varchar(100),
	@dirBMunicipio int,
	@dirBCP int,
	@nombreRepresentante varchar(50),
	@nombreCont varchar(50),
	@telCelCont varchar(12),
	@telOficinaCont varchar(20),
	@telNextelCont	varchar(15),
	@correoPrincipal varchar(50),
	@fechaAlta date,
	@indicadorCertif int,
	@estado int, --FK
	@motivo int --FK NULL
)
AS
BEGIN
	IF @opc = 1
	BEGIN
		insert into Fletero(nombreFletero, RFC, dirFCalle, dirFNum, dirFCol, dirFMunicipio, dirFCP, dirBCalle, dirBNum, dirBCol, dirBMunicipio, dirBCP, nombreRepresentante, nombreCont, telCelCont, telOficinaCont, telNextelCont, correoPrincipal, fechaAlta, indicadorCertif, estado, motivo)values (@nombreFletero, @RFC, @dirFCalle, @dirFNum, @dirFCol, @dirFMunicipio, @dirFCP, @dirBCalle, @dirBNum, @dirBCol, @dirBMunicipio, @dirBCP, @nombreRepresentante, @nombreCont, @telCelCont, @telOficinaCont, @telNextelCont, @correoPrincipal, @fechaAlta, @indicadorCertif, @estado, @motivo);
	END

	IF @opc = 2
	BEGIN
	update Fletero
		set nombreFletero = @nombreFletero, RFC = @RFC, dirFCalle = @dirFCalle, dirFNum = @dirFNum, dirFCol = @dirFCol, dirFMunicipio = @dirFMunicipio, dirFCP = @dirFCP, dirBCalle = @dirBCalle , dirBNum = @dirBNum, dirBCol = @dirBCol, 	dirBMunicipio = @dirBMunicipio, dirBCP = @dirBCP, nombreRepresentante = @nombreRepresentante, nombreCont = @nombreCont, telCelCont = @telCelCont, telOficinaCont = @telOficinaCont, telNextelCont = @telNextelCont, correoPrincipal = @correoPrincipal, fechaAlta = @fechaAlta, indicadorCertif = @indicadorCertif, estado = @estado, motivo = @motivo
		where idFletero = @idFletero
	
	END
END