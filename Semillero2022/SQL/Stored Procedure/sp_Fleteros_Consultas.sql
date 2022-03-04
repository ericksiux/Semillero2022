use Fleteros2022;
IF EXISTS (Select 1 from sysobjects where name = 'sp_Fletero_Consultas' and type = 'P')
	drop procedure sp_Fletero_Consultas
GO
/****************************************************************************
* Nombre:		sp_ConsultasFletero												                     *
* Autor:		Edna Lecea																			 *
* Fecha:		02/03/2022																			 *
* Descripción:	Procedimiento Almacenado para traer informacion general y detallada de tabla fleteros*
****************************************************************************/

create procedure sp_Fletero_Consultas(
	@opc int,
	@id int
)
AS
BEGIN
	IF @opc = 1 --Información general Fletero sin filtro
	BEGIN
		 select DISTRICTNAME, STORENAME, nombreFletero, nombreCont, telCelCont, telOficinaCont, telNextelCont, correoPrincipal, e.estado TipoEstado, tm.motivo TituloMotivo
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
	END

	IF @opc = 2 --Informacion detallada Fletero
	BEGIN
		select DISTRICTNAME, STORENAME, f.nombreFletero, f.RFC, f.dirFCalle, f.dirFNum, f.dirFCol, ce.NOMBRE EstadoF, cm.NOMBRE MunicipioF, f.dirFCP, f.nombreRepresentante, f.nombreCont, f.telCelCont, f.telOficinaCont, f.telNextelCont, f.correoPrincipal, f.fechaAlta
  		from DistTienda dt
			inner join Catalogo_Tienda ct
				inner join Catalogo_Distrito cd
					on cd.IDDISTRICT = ct.IDDISTRICT
				on dt.tienda = ct.IDSTORE
  			inner join Fletero f
				inner join Catalogo_Municipios cm
					inner join Catalogo_Estados ce
						on ce.ID_ESTADO = cm.ID_ESTADO
					on cm.ID_MUNICIPIO = f.dirFMunicipio
				on f.idFletero = dt.fletero
			where f.idFletero = @id
	END

	IF @opc = 3 --Informacion un Fletero
	BEGIN
		select DISTRICTNAME, STORENAME, f.nombreFletero, f.dirFCalle, f.dirFNum, f.dirFCol, ce.NOMBRE EstadoF, cm.NOMBRE MunicipioF, f.dirFCP,  f.dirBCalle, f.dirBNum, f.dirBCol, ceB.NOMBRE EstadoB, cmB.NOMBRE MunicipioB, f.dirBCP,f.nombreRepresentante, f.nombreCont, f.telCelCont, f.telOficinaCont, f.telNextelCont, f.correoPrincipal, f.fechaAlta, f.indicadorCertif
  		from DistTienda dt
			inner join Catalogo_Tienda ct
				inner join Catalogo_Distrito cd
					on cd.IDDISTRICT = ct.IDDISTRICT
				on dt.tienda = ct.IDSTORE
  			inner join Fletero f
				inner join Catalogo_Municipios cm
					inner join Catalogo_Estados ce
						on ce.ID_ESTADO = cm.ID_ESTADO
					on cm.ID_MUNICIPIO = f.dirFMunicipio
				inner join Catalogo_Municipios cmB
					inner join Catalogo_Estados ceB
						on ceB.ID_ESTADO = cmB.ID_ESTADO
					on cmB.ID_MUNICIPIO = f.dirBMunicipio
				on f.idFletero = dt.fletero
			where f.idFletero = @id
	END

END

