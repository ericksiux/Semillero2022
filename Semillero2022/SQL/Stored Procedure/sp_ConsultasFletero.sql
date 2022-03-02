IF EXISTS (Select 1 from sysobjects where name = 'sp_ConsultasFletero' and type = 'P')
	drop procedure sp_ConsultasFletero
GO

create procedure sp_ConsultasFletero(
	@opc int,
	@id int
)
AS
BEGIN
	IF @opc = 1 --Información general Fletero
	BEGIN
		 select DISTRICTNAME, STORENAME, f.nombreFletero, f.nombreCont, f.telCelCont, f.telOficinaCont, f.telNextelCont, f.correoPrincipal, e.estado, tm.motivo
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
		 select DISTRICTNAME, STORENAME, f.nombreFletero, f.RFC, f.dirFCalle, f.dirFNum, f.dirFCol, ce.NOMBRE as 'Estado', cm.NOMBRE as 'Municipio', f.dirFCP, f.nombreRepresentante, f.nombreCont, f.telCelCont, 		f.telOficinaCont, f.telNextelCont, f.correoPrincipal, f.fechaAlta
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
	END
END

