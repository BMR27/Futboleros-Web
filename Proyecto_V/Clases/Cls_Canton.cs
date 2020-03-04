using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Canton: Cls_Provincia
    {
        //INSTANCIAS DE CASE
        #region INSTANCIAS
        programacion5Entities modeloDB = new programacion5Entities();
        #endregion

        //ATRUBUTOS DE CLASE
        #region ATRIBUTOS DE CLASE
        int IdCanton { get; set; }
        string NombreCanton { get; set; }
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES DE CLASE
        public Cls_Canton()
        {

        }

        #endregion

        //METODOS DE CLASE
        #region METODOS DE CLASE

        public void pc_prueba()
        {
        }

        #endregion


    }
}