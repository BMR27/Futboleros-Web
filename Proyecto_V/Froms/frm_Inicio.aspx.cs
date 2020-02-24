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

        protected void btn_iniciar_Click(object sender, EventArgs e)
        {
            pc_pagina_inicio();
        }
        void pc_pagina_inicio()
        {
            Response.Redirect("frm_entrada.aspx");
        }
    }
}