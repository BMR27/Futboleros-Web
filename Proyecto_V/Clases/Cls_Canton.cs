﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_V.Models;
namespace Proyecto_V.Clases
{
    public class Cls_Canton : Cls_Provincia
    {
        //INSTANCIAS DE CASE
        #region INSTANCIAS
        programacion5Entities modeloDB = new programacion5Entities();
        #endregion

        //ATRUBUTOS DE CLASE
        #region ATRIBUTOS DE CLASE
        public int IdCanton { get; set; }
        public string NombreCanton { get; set; }
        static List<RetornaCantones1_Result> lista_canton = new List<RetornaCantones1_Result>();
        #endregion

        //CONSTRUCTORES DE CLASE
        #region CONSTRUCTORES DE CLASE
        public Cls_Canton()
        {

        }
        public Cls_Canton(int id_provincia) : base(id_provincia)
        {
        }
        public Cls_Canton(int id_provincia,int id_canton):base(id_provincia)
        {
            this.IdCanton = id_canton;
        }
        #endregion

        //METODOS DE CLASE
        #region METODOS DE CLASE

        public string pc_consultar_cantones()
        {
            try
            {
                lista_canton = this.modeloDB.RetornaCantones1(null, this.IdProvincia).ToList();
            }
            catch (Exception ex)
            {

                this.Error = ex.Message;
            }
            return Error;
        }

        //METODO QUE RETORNA LA LISTA DE LOS CANTONES
        public List<RetornaCantones1_Result> pc_retornar_lista()
        {
            return lista_canton;
        }

        //LIMPIAMOS LA LISTA 
        public void pc_limpiar_lista_canton()
        {
            lista_canton.Clear();
        }
        #endregion


    }
}