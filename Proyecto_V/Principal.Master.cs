﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_V
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        Cls_Usuario _datos_usuario = new Cls_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            pc_validar_sesion();
            pc_mostrar_nombre_usuario();
        }
        //METODOS DE LA CLASE
        #region METODOS
        //MUESTRA EL NOMBRE DEL USUARIO
        void pc_mostrar_nombre_usuario()
        {
            lbl_Nombre.Text = _datos_usuario.pc_retornar_nombre_usuario();
        }

        //METODO QUE VALIDA SI LA VARIABLE USUARIO ESTA LLENA
        void pc_validar_sesion()
        {
            if (Session["NombreUsuario"] == null)
            {
                Response.Redirect("frm_Inicio.aspx");
            }
        }

        //METODO PARA CERRAR LA SESSION
        void pc_cerrar_sesion()
        {
            Session.Clear();
            pc_validar_sesion();
        }
        #endregion

        protected void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            pc_cerrar_sesion();
        }
    }
}