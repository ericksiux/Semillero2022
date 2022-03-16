use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_Fletero_ConsultasFiltro' and type = 'P')
	drop procedure sp_Fletero_ConsultasFiltro
GO
/****************************************************************************
* Nombre:		sp_Fletero_ConsultasFiltro												                     *
* Autor:		Edna Lecea																		*
* Fecha:		02/03/2022																	    *
* Descripción:	Procedimiento Almacenado para traer informacion por filtros de la tabla fleteros*
****************************************************************************/

create procedure sp_Fletero_ConsultasFiltro(
	@idDistrito int = null, --filtro nombre distrito
	@idTienda int = null, --filtro nombre tienda
	@fletero int = null, --filtro nombre fletero
	@estado int = null --filtro estado del fletero
)
AS
BEGIN
	select idFletero, DISTRICTNAME, STORENAME, f.nombreFletero, f.nombreCont, f.telCelCont, f.telOficinaCont, f.telNextelCont, f.correoPrincipal, e.estado EstadoDescripcion, tm.motivo MotivoTitulo
  		  from DistTienda dt
			inner join Catalogo_Tienda ct
				inner join Catalogo_Distrito cd
					on cd.IDDISTRICT = ct.IDDISTRICT
				on dt.tienda = ct.IDSTORE
  			inner join Fletero f
				inner join Estado e
					on e.idEstado = f.estado
				left join Motivo m
					inner join TituloMotivo tm
						on tm.idTituloM = m.motivo
					on m.idMotivo = f.motivo
				on f.idFletero = dt.fletero
		where (@fletero = 0 or idFletero = @fletero)
		and (@idDistrito = 0 or dt.distrito = @idDistrito)
		and (@idTienda = 0 or dt.tienda = @idTienda)
		and (@estado = 0 or f.estado = @estado)

END