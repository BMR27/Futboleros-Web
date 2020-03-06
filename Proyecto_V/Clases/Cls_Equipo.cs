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
        #endregion


        //CONSTRUCTORES DE LA CLASE
        #region CONSTRUCTORES DE CLASE
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

        #endregion





    }
}