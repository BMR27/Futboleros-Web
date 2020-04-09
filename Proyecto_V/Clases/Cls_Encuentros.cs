using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Encuentros:Cls_Torneo
    {
        //INSTANCIAS
        #region INSTANCIAS
        programacion5Entities _modeloDB = new programacion5Entities();
        #endregion


        //ATRIBUTOS
        #region ATRIBUTOS
        public DateTime FechaEncuentro { get; set; }
        public int GolCasa { get; set; }
        public int GolVisita { get; set; }
        public Boolean Estado { get; set; }
        #endregion


        //COSNTRUCTORES
        #region COSNTRUCTORES
        public Cls_Encuentros()
        {

        }
        #endregion


        //METODOS
        #region METODOS
        //METODO CONSULTA LOS EQUIPOS POR EL TORNEO
        public List<SP_CONSULTAR_EQUIPOS_ECUENTRO_Result> pc_cosultar_equipos_casa_x_torneo()
        {
            return this._modeloDB.SP_CONSULTAR_EQUIPOS_ECUENTRO(this.idConsecutivo_Torneo,null).ToList();
        }

        //METODO CONSULTA LOS EQUIPOS POR EL TORNEO
        public List<SP_CONSULTAR_EQUIPOS_ECUENTRO_Result> pc_cosultar_equipos_visita_x_torneo()
        {
            return this._modeloDB.SP_CONSULTAR_EQUIPOS_ECUENTRO(this.idConsecutivo_Torneo,this.idConsecutivo).ToList();
        }
        #endregion
    }
}