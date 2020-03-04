using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Provincia
    {
        //INSTANCIA
        programacion5Entities ModeloDB = new programacion5Entities();
        //ATRIBUTOS DE CLASE
        #region ATRIBUTOS DE LA CLASE
        int IdProvincia { get; set; }
        string NombreProvincia { get; set; }
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES
        public Cls_Provincia()
        {

        }

        public Cls_Provincia(int pIdProvincia)
        {
            this.IdProvincia = pIdProvincia;
        }
        #endregion

        //METODOS DE LA CLASE
        #region METODOS DE CLASE

        //CONSULTA LAS PROVINCIAS 
        public List<SP_CONSULTAR_PROVINCIAS_Result> pc_consultar_provincias()
        {
            List<SP_CONSULTAR_PROVINCIAS_Result> list_provincias = this.ModeloDB.SP_CONSULTAR_PROVINCIAS(null).ToList();
            return list_provincias;
        }
        #endregion






    }
}