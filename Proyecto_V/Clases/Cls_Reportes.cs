using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Reportes
    {
        programacion5Entities Modelodb = new programacion5Entities();
        //ATRIBUTOS
        #region ATRIBUTOS
        public string RutaReporte { get; set; }
        public int IdReporte { get; set; }
        #endregion

        //CONSTRUCTORES
        #region CONSTRUCTOR
        public Cls_Reportes()
        {

        }
        #endregion

        //METODOS
        #region METODOS
        public string pc_retorna_ruta()
        {
            switch (this.IdReporte)
            {
                case 1:
                    this.RutaReporte = "~/Reporte/InformeGoleadores.rdlc";
                    break;
                case 2:
                    this.RutaReporte = "~/Reporte/InformePosiciones.rdlc";
                    break;
                default:
                    break;
            }

            return this.RutaReporte;
        }

        //METODO CONUSLTA LOS DATOS DEL REPORTE
        public List<SP_CONSULTAR_GOLEADORES_X_TORNEO_Result> pc_Goleadores()
        {
            return this.Modelodb.SP_CONSULTAR_GOLEADORES_X_TORNEO().ToList();
        }

        public List<SP_POSICIONES_X_TORNEO_Result> pc_posiciones()
        {
            return this.Modelodb.SP_POSICIONES_X_TORNEO().ToList();
        }

        #endregion
    }
}