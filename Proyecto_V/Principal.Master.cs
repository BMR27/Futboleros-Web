using System;
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
            pc_validar_tipo_usuario();
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

        //METODO PARA VALIDAR LOS DERECHOS DE LOS USUARIOS
        void pc_validar_tipo_usuario()
        {
            foreach (var item in _datos_usuario.pc_retornar_lista())
            {
                switch (item.NombreTipo)
                {
                    case "JUNIOR":
                        btn_torneo.Visible = false;
                        navbarDropdown2.Visible = false;
                        navbarDropdown.Visible = false;
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        protected void btn_cerrar_sesion_Click(object sender, EventArgs e)
        {
            pc_cerrar_sesion();
        }

        protected void btn_lista_jugadores_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_jugadores.aspx");
        }

        protected void btn_registrar_jugador_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_Registro de Jugadores.aspx");
        }


        protected void btn_registrar_equipo_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_Registro de Equipos.aspx");
        }

        protected void btn_lista_equipo_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_equipos.aspx");
        }

        protected void btn_registrar_torneo_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_Registro_Torneos.aspx");
        }
    }
}