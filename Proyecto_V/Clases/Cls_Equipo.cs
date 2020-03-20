using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;

namespace Proyecto_V.Clases
{
    public class Cls_Equipo:Cls_Distrito
    {
        //INSTANCIA DE LA CLASE
        #region INSTANCIA
        programacion5Entities ModeloDB = new programacion5Entities();
        #endregion


        //ATRIBUTOS DE LA CLASE
        #region ATRIBUTOS DE CLASE
        public int idConsecutivo { get; set; }
        public string NombreEquipo { get; set; }
        public string Fundacion { get; set; }

        static List<Cls_Equipo> datos_equipo = new List<Cls_Equipo>();
        #endregion


        //CONSTRUCTORES DE LA CLASE
        #region CONSTRUCTORES DE CLASE

        public Cls_Equipo()
        {

        }


        public Cls_Equipo(int id_provincia, int id_canton, int id_distrito) : base(id_provincia, id_canton, id_distrito)
        {

        }
        #endregion

        //METODOS
        #region METODOS DE LA CLASE
        //METODO QUE INSERTA EL EQUIPO
        public int pc_registrar_equipo()
        {
            int filas = 0;
            try
            {
               filas = this.ModeloDB.SP_REGISTRA_EQUIPO(IdProvincia, IdCanton, IdDistrito, NombreEquipo, Convert.ToDateTime(Fundacion));   
            }
            catch (Exception)
            {
                filas = -100;
            }
            return filas;
        }


        //METODO CONSULTA DE EQUIPOS
        public List<SP_CONSULTAR_LISTA_EQUIPOS_Result> pc_consultar_equipos()
        {
            List<SP_CONSULTAR_LISTA_EQUIPOS_Result> lista_equipos = this.ModeloDB.SP_CONSULTAR_LISTA_EQUIPOS().ToList();
            return lista_equipos;
        }

        //METODO PARA ELIMINAR UN EQUIPO
        public int pc_eliminar_equipo()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ELIMINAR_EQUIPO(idConsecutivo);
            }
            catch (Exception)
            {
                throw;
            }

            return filas;
        }


        //METODO QUE CAPTURA LOS DATOS DE LOS EQUIPOS Y LOS ACTUALIZA
        public void pc_captura_datos()
        {
            pc_limpiar_datos_equipo();
            //CAPTURAMOS LOS DATOS DEL EQUIPO
            Cls_Equipo datos = new Cls_Equipo();
            datos.idConsecutivo = this.idConsecutivo;
            datos.NombreEquipo = this.NombreEquipo;
            datos.NombreProvincia = this.NombreProvincia;
            datos.NombreCanton = this.NombreCanton;
            datos.NombreDistrito = this.NombreDistrito;                   
            datos.Fundacion = this.Fundacion;
            //AGREGAMOS LOS DATOS A UNA LISTA STATICA PARA RETORNARLOS
            datos_equipo.Add(datos);
        }


        //METODO QUE RETORNA LA LISTA CON LOS DATOS DE LOS EQUIPOS A ACTUALIZAR
        public List<Cls_Equipo> pc_retornar_datos_equipo()
        {
            return datos_equipo;
        }
        //METODO PARA LIMPIAR LA TABLA
        public void pc_limpiar_datos_equipo()
        {
            datos_equipo.Clear();
        }

        //METODOS PARA ACTUALIZAR EL EQUIPO
        public int pc_actualizar_equipo()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_ACTUALIZAR_EQUIPO(IdProvincia, IdCanton, IdDistrito, NombreEquipo, Convert.ToDateTime(Fundacion));

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