using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;

namespace Proyecto_V.Clases
{
    public class Cls_Torneo:Cls_Usuario
    {
        //INSTANCIA DE LA CLASE
        #region INSTANCIA
        programacion5Entities ModeloDB = new programacion5Entities();
        #endregion

        //ATRIBUTOS DE LA CLASE
        #region ATRIBUTOS DE LA CLASE
        public int idConsecutivo_Torneo { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Final { get; set; }
        public string NombreTorneo { get; set; }
        public int CantidadEquipos { get; set; }
        public string Estado { get; set; }

        static List<Cls_Torneo> datos_torneo = new List<Cls_Torneo>();
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES DE CLASE
        public Cls_Torneo()
        {

        }
        #endregion

        #region METODOS DE CLASE
        //REGISTRAR TORNEOS

        public string  pc_registrar_torneos()
        {
            string mensaje = "";
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_REGISTRAR_TORNEO(1, this.Fecha_Inicio,this.Fecha_Final,this.NombreTorneo,Convert.ToInt16(this.CantidadEquipos));
            }
            catch (Exception)
            {

                throw;
            }

            return mensaje;
        }


        //METODO CONSULTA LOS TORNEOS
        public List<SP_CONSULTAR_LISTA_TORNEOS_Result> pc_consultar_torneos()
        {
            List<SP_CONSULTAR_LISTA_TORNEOS_Result> lista_torneos = this.ModeloDB.SP_CONSULTAR_LISTA_TORNEOS().ToList();
            return lista_torneos;
        }

        //METODO PARA ELIMINAR UN TORNEO
        public int pc_eliminar_torneo()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ELIMINAR_TORNEOS(idConsecutivo_Torneo);
            }
            catch (Exception)
            {
                throw;
            }

            return filas;
        }


        //METODO QUE CAPTURA LOS DATOS DEL TORNEO Y LOS ACTUALIZA
        public void pc_captura_datos_torneos()
        {
            pc_limpiar_datos_torneo();
            //CAPTURAMOS LOS DATOS DEL TORNEO
            Cls_Torneo datos = new Cls_Torneo();
            datos.idConsecutivo_Torneo = this.idConsecutivo_Torneo;
            datos.IdUsuario = this.IdUsuario;
            datos.NombreTorneo = this.NombreTorneo;
            datos.Fecha_Inicio = this.Fecha_Inicio;
            datos.Fecha_Final = this.Fecha_Final;
            datos.CantidadEquipos = this.CantidadEquipos;
            //AGREGAMOS LOS DATOS A UNA LISTA STATICA PARA RETORNARLOS
            datos_torneo.Add(datos);
        }


        //METODO QUE RETORNA LA LISTA CON LOS DATOS DE LOS EQUIPOS A ACTUALIZAR
        public List<Cls_Torneo> pc_retornar_datos_torneos()
        {
            return datos_torneo;
        }
        //METODO PARA LIMPIAR LA TABLA
        public void pc_limpiar_datos_torneo()
        {
            datos_torneo.Clear();
        }

        //METODOS PARA ACTUALIZAR EL EQUIPO
        public int pc_actualizar_torneos()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ACTUALIZAR_TORNEO(1, this.Fecha_Inicio, this.Fecha_Final, this.NombreTorneo, Convert.ToInt16(this.CantidadEquipos));

            }
            catch
            {
                throw;
            }

            return filas;
        }
        #endregion
    }
}
