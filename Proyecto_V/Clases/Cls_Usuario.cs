using Proyecto_V.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_V
{
    public class Cls_Usuario
    {
        //INSTANCIAS DE CLASE
        #region INSTANCIAS DE CLASE

        programacion5Entities ModeloDB = new programacion5Entities();

        #endregion

        //VARIABLES ESTATICAS
        #region VARIABLES ESTATICAS
        static List<Cls_Usuario> Lista_Datos_Usuario = new List<Cls_Usuario>();
        #endregion

        //ATRIBUTOS DE LA CLASE
        #region Atributos de la clase
        int IdUsuario { get; set; }
        string Nombre { get; set; }
        string Apellido1 { get; set; }
        string Apellido2 { get; set; }
        string NombreUsuario { get; set; }
        string Pass { get; set; }
        string Activo { get; set; }
        int TipoUsuario { get; set; }
        string NombreTipo { get; set; }
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES
        public Cls_Usuario()
        {

        }

        public Cls_Usuario(string pUsuario,string pPass)
        {
            this.NombreUsuario = pUsuario;
            this.Pass = pPass;
        }

        #endregion

        //METODOS DE LA CLASE
        #region METODOS DE CLASE
        //METODO CONSULTA LOS DATOS DE LOS USUARIOS PARA VALIDAR EL USUARIO
        public int pc_validar_sesion()
        {
            try
            {
                //LIMPIAMOS LA LISTA 
                Lista_Datos_Usuario.Clear();
                //TRAEMOS LO DATOS DEL USUARIO
                List<SP_VALIDAR_INICIO_SESION_Result> Datos_Usuario = this.ModeloDB.SP_VALIDAR_INICIO_SESION(NombreUsuario, Pass).ToList();
                //VALIDAMOS SI VIENEN DATOS EN LA CONSULTA
                if (Datos_Usuario.Count > 0)
                {
                    foreach (var item in Datos_Usuario)
                    {
                        Cls_Usuario datos = new Cls_Usuario();
                        datos.IdUsuario = item.C_CONSECUTIVO;
                        datos.Nombre = item.C_NOMBRE;
                        datos.Apellido1 = item.C_APELLIDO1;
                        datos.Apellido2 = item.C_APELLIDO2;
                        datos.NombreUsuario = item.C_NOM_USUARIO;
                        datos.Activo = Convert.ToString(item.C_ACTIVO);
                        datos.NombreTipo = item.C_NOM_TIPO;
                        Lista_Datos_Usuario.Add(datos);
                    }
                }
                
            }
            catch (Exception ex)
            {
               
            }

            return Lista_Datos_Usuario.Count;
        }

        //METODO RETORNA EL NOMBRE DEL USUARIO 
        public string pc_retornar_nombre_usuario()
        {
            return Lista_Datos_Usuario[0].Nombre;
        }
        //METODO RETORNA EL NOMBRE DE USUARIO 
        public string pc_retornar_usuario()
        {
            return Lista_Datos_Usuario[0].NombreUsuario;
        }
        //METODO RETORNA EL ID DE USUARIO 
        public int pc_retornar_id_usuario()
        {
            return Lista_Datos_Usuario[0].IdUsuario;
        }
        #endregion
    }
}