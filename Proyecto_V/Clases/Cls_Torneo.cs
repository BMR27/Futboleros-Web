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
            List<SP_CONSULTAR_LISTA_TORNEOS_Result> lista_torneos = this.ModeloDB.SP_CONSULTAR_LISTA_TORNEOS(this.Fecha_Inicio,this.Fecha_Final).ToList();
            return lista_torneos;
        }

        //METODO QUE CAPTURA LOS DATOS DEL TORNEO Y LOS ACTUALIZA
        public void pc_captura_datos_torneos()
        {
            pc_limpiar_datos_torneo();
            //CAPTURAMOS LOS DATOS DEL TORNEO
            Cls_Torneo datos = new Cls_Torneo();
            datos.idConsecutivo_Torneo = this.idConsecutivo_Torneo;
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


        public int pc_torneo_x_equipo(List<Cls_Torneo> datos)
        {
            int filas = 0;
            foreach (var item in datos)
            {
                filas = this.ModeloDB.SP_REGISTRAR_EQUIPOS_A_TORNEOS(Convert.ToInt32(item.NombreEquipo), item.idConsecutivo_Torneo);
            }
            return filas;
        }

        //ELIMINAR UN TORNEO
        public string pc_eliminar_torneo()
        {
            string mensaje = "";
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ELIMINAR_TORNEOS(this.idConsecutivo_Torneo);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
            }

            if (filas > 0)
            {
                mensaje = "El torneo fue eliminado de la base datos";
            }
            else
            {
                mensaje = "No se elimino el torneo ya que tiene partidos disputados";
            }

            return mensaje;
        }

        //INICIAR UN TORNEO 
        public string pc_iniciar_torneo()
        {
            string mensaje = "";
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_INICIAR_TORNEO(this.idConsecutivo_Torneo);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
            }

            if (filas > 0)
            {
                mensaje = "El torneo se ha iniciado, visite registro por encuentros y agregue los partidos";
            }
            else
            {
                mensaje = "No puede inicar requiere equipos";
            }

            return mensaje;
        }


        public string pc_validar_cant_juegos()
        {
            string mensaje = "";
            int cont = 0;
            //consultamos  LOS JUEGOS 
            List<SP_CONSULTAR_CANT_PARTIDOS_X_TORNEO_EQUIPO_Result> lista_partidos =
                this.ModeloDB.SP_CONSULTAR_CANT_PARTIDOS_X_TORNEO_EQUIPO(this.idConsecutivo_Torneo).ToList();
            foreach (var item in lista_partidos)
            {
                cont = Convert.ToInt32(item.JUEGOS);
                for (int i = 1; i < lista_partidos.Count; i++)
                {
                    if (cont != lista_partidos[i].JUEGOS)
                    {
                        mensaje = "El torneo no se puede cerrar faltan equipos de jugar";
                        break;
                    }
                }
                break;
            }

            return mensaje;
        }
        #endregion
    }
}
