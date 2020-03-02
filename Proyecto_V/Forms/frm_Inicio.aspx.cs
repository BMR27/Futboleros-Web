using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Proyecto_V.Froms
{
    public partial class frm_Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region METODOS DEL FORMS
        //BOTON DE INICIO SESION
        protected void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                Cls_Usuario _procesos_usuario = new Cls_Usuario(txt_usuario.Text, txt_clave.Text);
                if (_procesos_usuario.pc_validar_sesion() > 0)
                {
                    Session["NombreUsuario"] = _procesos_usuario.pc_retornar_nombre_usuario();
                    Response.Redirect("frm_entrada.aspx");
                }
                else
                {
                    lbl_mensaje.Text = "Usuario ó Contraseña incorrectos";
                }
            }
        }
        //VALIDAMOS QUE EL USUARIO NO ESTE NULL
        void pc_validar_usuario_null()
        {
            if (Session["NombreUsuario"] == null)
            {
                Response.Redirect("frm_Inicio.aspx");
            }
        }
        #endregion

    }
}