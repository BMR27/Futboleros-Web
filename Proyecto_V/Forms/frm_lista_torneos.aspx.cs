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
    public partial class frm_lista_torneos : System.Web.UI.Page
    {
        Cls_Torneo _torneo = new Cls_Torneo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_tabla_torneo();
            }
        }

        void pc_cargar_tabla_torneo()
        {
            tbl_lista_torneos.DataSource = _torneo.pc_consultar_torneos();
            tbl_lista_torneos.DataBind();
        }

        protected void btn_cambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_torneos.aspx");
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_torneos.Rows.Count; i++)
            {

                CheckBox check = (CheckBox)tbl_lista_torneos.Rows[i].FindControl("ch_tbl_torneos");
                if (check.Checked == true)
                {
                    _torneo.idConsecutivo_Torneo = Convert.ToInt32(tbl_lista_torneos.Rows[i].Cells[0].Text);
                    filas = _torneo.pc_eliminar_torneo();
                    break;
                }
            }

            if (filas > 0)
            {
                Response.Redirect("frm_lista_torneos.aspx");
            }
            else
            {
                lbl_mensaje.Text = "No se elimino el torneo";
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_torneos.Rows.Count; i++)
            {
                CheckBox check = (CheckBox)tbl_lista_torneos.Rows[i].FindControl("ch_tbl_torneos");
                if (check.Checked == true)
                {
                    //CAPTURAMOS LOS DATOS DE LA TABLA
                    _torneo.idConsecutivo_Torneo = Convert.ToInt32(tbl_lista_torneos.Rows[i].Cells[0].Text);
                    _torneo.Fecha_Inicio = Convert.ToDateTime(tbl_lista_torneos.Rows[i].Cells[2].Text);
                    _torneo.Fecha_Final = Convert.ToDateTime(tbl_lista_torneos.Rows[i].Cells[3].Text);
                    _torneo.NombreTorneo = tbl_lista_torneos.Rows[i].Cells[1].Text;
                    _torneo.CantidadEquipos = Convert.ToInt16(tbl_lista_torneos.Rows[i].Cells[4].Text);
                    //EJECUTAMOS EL METODO DE GUARDARLO EN MEMORIA
                    _torneo.pc_captura_datos_torneos();
                    filas = 10;
                    break;
                }
            }
            if (filas == 10)
            {
                Response.Redirect("frm_actualizar_torneo.aspx");
            }
            else
            {
                lbl_mensaje.Text = "Debe seleccionar un equipo";
            }

        }

        protected void ch_tbl_torneos_CheckedChanged(object sender, EventArgs e)
        {
            tbl_lista_torneos.Enabled = false;
        }

        protected void tbl_lista_jugadores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///asignar el nuevo índice
            this.tbl_lista_torneos.PageIndex = e.NewPageIndex;
            ///volver a cargar el grid
            this.pc_cargar_tabla_torneo();
        }
    }
}