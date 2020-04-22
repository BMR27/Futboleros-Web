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
        public int IdEncuentro { get; set; }
        public DateTime FechaEncuentro { get; set; }
        public int IdCasa { get; set; }
        public int IdVisita { get; set; }
        public int GolCasa { get; set; }
        public int GolVisita { get; set; }
        public Boolean Estado { get; set; }
        public int IdAnotadorCasa { get; set; }
        public int IdAnotadorVisita { get; set; }
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

        //METODO REGISTRA UN ENCUENTRO

        public string pc_registrar_encuentro()
        {
            string mensaje = "";
            int filas = 0;
            try
            {
                filas = this._modeloDB.SP_REGISTRAR_ENCUENTRO_X_TORNEO(this.IdCasa, this.IdVisita, this.idConsecutivo_Torneo, this.FechaEncuentro);
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            if (filas > 0)
            {
                mensaje = "Exito al registrar el partido";
            }
            else
            {
                mensaje = "El partido no se registro verifique que el torneo ya este iniciado";
            }
            return mensaje;
        }

        //METODO CONSULTA LOS PARTIDOS
        public List<SP_CONSULTAR_PARTIDOS_POR_TORNEO_Result> pc_consultar_partidos()
        {
            return this._modeloDB.SP_CONSULTAR_PARTIDOS_POR_TORNEO(this.idConsecutivo_Torneo).ToList();
        }

        //METODO CONSULTA JUGADORES CASA
        public List<SP_CONSULTAR_JUG_CASA_Result> pc_jugadores_casa()
        {
            return this._modeloDB.SP_CONSULTAR_JUG_CASA(this.IdEncuentro).ToList();
        }


        //METODO CONSULTA JUGADORES VISITA
        public List<SP_CONSULTAR_JUG_VISITA_Result> pc_jugadores_visita()
        {
            return this._modeloDB.SP_CONSULTAR_JUG_VISITA(this.IdEncuentro).ToList();
        }

        //METODO REGISTRA Y ACTUALIZA LOS DATOS DE LOS PARTIDOS
        public string pc_actualizar_partidos()
        {
            string mensaje = "";
            int filas = 0;
            try
            {
                filas = this._modeloDB.SP_ACTUALIZAR_RESULTADO_PARTIDO(this.IdEncuentro, GolCasa, GolVisita, IdAnotadorCasa, IdAnotadorVisita);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
            }
            if (filas > 0)
            {
                mensaje = "Partido actualizado y finalizado";
            }
            return mensaje;
        }
        #endregion
    }
}