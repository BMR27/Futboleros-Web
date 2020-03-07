using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Models;
using Proyecto_V.Clases;
namespace Proyecto_V.Forms
{
    public partial class frm_lista_jugadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_tabla_jugadores();
            }
        }
        void pc_cargar_tabla_jugadores()
        {
            Cls_Jugador _jugador = new Cls_Jugador();
            tbl_lista_jugadores.DataSource =  _jugador.pc_consultar_jugadores();
            tbl_lista_jugadores.DataBind();
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            tbl_lista_jugadores.Enabled = false;
        }

        protected void btn_cambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_jugadores.aspx");
        }

        protected void ch_tbl_jugadores_CheckedChanged(object sender, EventArgs e)
        {
            tbl_lista_jugadores.Enabled = false;
        }
    }
}