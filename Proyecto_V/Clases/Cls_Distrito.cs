using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Clases;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Distrito:Cls_Canton
    {
        //INSTANCIAS DE CLASE
        #region INSTANCIAS
        programacion5Entities ModeloDB = new programacion5Entities();

        #endregion

        //ATRIBUTOS DE CLASE
        #region ATRIBUTOS DE LA CLASE
        protected int IdDistrito { get; set; }
        protected string NombreDistrito { get; set; }
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES
        public Cls_Distrito()
        {

        }
        public Cls_Distrito(int id_provincia,int id_canton):base(id_provincia,id_canton)
        {

        }
        public Cls_Distrito(int id_provincia, int id_canton,int id_distrito) : base(id_provincia, id_canton)
        {
            this.IdDistrito = id_distrito;
        }
        #endregion

        //METODOS DE CLASE
        #region METODOS DE LA CLASE
       // METODO QUE HACE LA CONSULTA DE LOS DISTRITOS POR CANTON
        public List<SP_RETORNAR_DISTRITO_Result> pc_retornar_distrito()
        {
            List<SP_RETORNAR_DISTRITO_Result> lista_distrito = this.ModeloDB.SP_RETORNAR_DISTRITO(null, IdCanton).ToList();
            return lista_distrito;
        }
        #endregion
    }
}