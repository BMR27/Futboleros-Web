using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;
namespace Proyecto_V.Froms
{
    public partial class frm_entrada : System.Web.UI.Page
    {
        Cls_Usuario _Usuario = new Cls_Usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_mostrar_mensaje();
            }
        }

        void pc_mostrar_mensaje()
        {
            lbl_mensaje.Text = "Bienvenido Usuario: " + _Usuario.pc_retornar_nombre_usuario();
        }
    }
}