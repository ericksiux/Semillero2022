using Fletero.Administracion.Services.Contracs.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fletero2022.Areas.Administracion.Models
{
    public class FleteroModel
    {
        public FleteroModel()
        {
        }
		public List<DistTiendaDTO> distTiendas { get; set; }
        public List<TiendaDTO> Stores { get; set; }
        public List<DistritoDTO> Districts { get; set; }
        public List<FleteroDTO> TodosFleteros { get; set; }
		public List<FleteroDTO> FleterosDetalle { get; set; }
		public List<MunicipioDTO> MunicipiosF { get; set; }
        public List<MunicipioDTO> MunicipiosB { get; set; }
        public List<EstadoDTO> EstadoF { get; set; }
        public List<EstadoDTO> EstadoB { get; set; }
		public int idFletero { get; set; }
		public string nombreFletero { get; set; }
		public string RFC { get; set; }
		public string dirFCalle { get; set; }
		public int dirFNum { get; set; }
		public string dirFCol { get; set; }
		public int dirFMunicipio { get; set; }
		public int dirFCP { get; set; }
		public string dirBCalle { get; set; }
		public int dirBNum { get; set; }
		public string dirBCol { get; set; }
		public int dirBMunicipio { get; set; }
		public int dirBCP { get; set; }
		public string nombreRepresentante { get; set; }
		public string nombreCont { get; set; }
		public string telCelCont { get; set; }
		public string telOficinaCont { get; set; }
		public string telNextelCont { get; set; }
		public string correoPrincipal { get; set; }
		public DateTime fechaAlta { get; set; }
		public int indicadorCertif { get; set; }
		public int estado { get; set; }
		public int motivo { get; set; }

		/***********Atributos de búsqueda general***********/
		public string DistrictName { get; set; }
		public string StoreName { get; set; }
		public string tipoEstado { get; set; }
		public string tituloMotivo { get; set; }

		/***********Atributos de búsqueda detallada***********/
		public string dirFMunicipio_Estado { get; set; }
		public string dirFMunicipio_Municipio { get; set; }
		public string dirBMunicipio_Estado { get; set; }
		public string dirBMunicipio_Municipio { get; set; }
		/**********ID'S distrito/Tienda*********************/
		public int idDistritoDistTienda { get; set; }
		public int idTiendaDistTienda { get; set; }
		/**********/
		public int distrito { get; set; }
		public int tienda { get; set; }

	}
}