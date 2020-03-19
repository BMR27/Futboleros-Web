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
    public partial class frm_lista_equipos : System.Web.UI.Page
    {
        Cls_Equipo _equipo = new Cls_Equipo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_tabla_equipo();
            }
        }

        void pc_cargar_tabla_equipo()
        {
            tbl_lista_equipos.DataSource = _equipo.pc_consultar_equipos();
            tbl_lista_equipos.DataBind();
        }

        protected void btn_cambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_equipos.aspx");
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_equipos.Rows.Count; i++)
            {

                CheckBox check = (CheckBox)tbl_lista_equipos.Rows[i].FindControl("ch_tbl_equipos");
                if (check.Checked == true)
                {
                    _equipo.idConsecutivo = Convert.ToInt32( tbl_lista_equipos.Rows[i].Cells[0].Text);
                    filas = _equipo.pc_eliminar_equipo();
                    break;
                }
            }

            if (filas > 0)
            {
                Response.Redirect("frm_lista_equipos.aspx");
            }
            else
            {
                lbl_mensaje.Text = "No se elimino el equipo";
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_equipos.Rows.Count; i++)
            {
                CheckBox check = (CheckBox)tbl_lista_equipos.Rows[i].FindControl("ch_tbl_equipos");
                if (check.Checked == true)
                {
                    _equipo.NombreEquipo = tbl_lista_equipos.Rows[i].Cells[0].Text;
                    _equipo.Fundacion = tbl_lista_equipos.Rows[i].Cells[1].Text;
                    
                    
                    _equipo.pc_captura_datos();
                    filas = 10;
                    break;
                }
            }
            if (filas == 10)
            {
                Response.Redirect("frm_actualizar_equipo.aspx");
            }
            else
            {
                lbl_mensaje.Text = "Debe seleccionar un equipo";
            }
        }

        protected void ch_tbl_equipos_CheckedChanged(object sender, EventArgs e)
        {
            tbl_lista_equipos.Enabled = false;
        }
    }
}


    