using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;

namespace Proyecto_V.Clases
{
    public class Cls_Jugador:Cls_Distrito
    {
        //INSTANCIA DE CLASE
        #region INSTANCIA
        programacion5Entities ModeloDB = new programacion5Entities();
        #endregion

        //ATRIBUTOS DE CLASE
        #region ATRIBUTOS DE CLASE
        public int idConsecutivo { get; set; }
        public string NumeroCedula { get; set; }
        public string Genero { get; set; }
        public string FechaNacimiento { get; set; }
        public string NumeroTelefono { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string DireccionCasa { get; set; }
        public string Activo { get; set; }
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES DE CLASE
        public Cls_Jugador()
        {

        }
        #endregion

        //METODOS
        #region METODOS DE LA CLASES
        //METODO QUE HACE EL INSERT DE LOS JUGADORES
        public int pc_registrar_jugador()
        {
            int filas = 0;
            try
            {
                filas = this.ModeloDB.SP_REGISTRAR_JUGADOR(NumeroCedula,Genero,Convert.ToDateTime(FechaNacimiento), Nombre, Apellido1, Apellido2, NumeroTelefono,
                    Correo, IdProvincia, IdCanton, IdDistrito, DireccionCasa);
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