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
        public Cls_Jugador(int id_provincia, int id_canton,int id_distrito):base(id_provincia, id_canton,id_distrito)
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

        ////METODO CONSULTA LOS JUGADORES
        public List<SP_CONSULTAR_LISTA_JUGADORES_Result> pc_consultar_jugadores()
        {
            List<SP_CONSULTAR_LISTA_JUGADORES_Result> lista_jugadores = this.ModeloDB.SP_CONSULTAR_LISTA_JUGADORES().ToList();
            return lista_jugadores;
        }
        #endregion
    }
}