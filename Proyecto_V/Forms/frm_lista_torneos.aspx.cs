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
        //METODOS
        #region METODOS
        //ELIMINA UN TORNEO
        void pc_eliminar()
        {
            for (int i = 0; i < tbl_lista_torneos.Rows.Count; i++)
            {
                CheckBox check = (CheckBox)tbl_lista_torneos.Rows[i].FindControl("ch_tbl_torneos");
                if (check.Checked == true)
                {
                    _torneo.idConsecutivo_Torneo = Convert.ToInt32(tbl_lista_torneos.Rows[i].Cells[0].Text);
                    break;
                }
            }
            //EJECUTAMOS EL METODO
            lbl_mensaje.Text = _torneo.pc_eliminar_torneo();
            switch (lbl_mensaje.Text)
            {
                case "El torneo fue eliminado de la base datos":
                    pc_cargar_tabla_torneo();
                    break;
                default:
                    break;
            }
        }

        //inicia torneo
        void pc_iniciar()
        {
            for (int i = 0; i < tbl_lista_torneos.Rows.Count; i++)
            {
                CheckBox check = (CheckBox)tbl_lista_torneos.Rows[i].FindControl("ch_tbl_torneos");
                if (check.Checked == true)
                {
                    _torneo.idConsecutivo_Torneo = Convert.ToInt32(tbl_lista_torneos.Rows[i].Cells[0].Text);
                    break;
                }
            }
            //EJECUTAMOS EL METODO
            lbl_mensaje.Text = _torneo.pc_iniciar_torneo();
        }
        //CONUSLTA POR FECHA
        void pc_consulta_por_fecha()
        {
            //CAPTURAMOS LA FECHA
            _torneo.Fecha_Inicio = Convert.ToDateTime(c_fecha_inicial.SelectedDate.ToShortDateString());
            _torneo.Fecha_Final = Convert.ToDateTime(c_fecha_final.SelectedDate.ToShortDateString());

            //EJECUTAMOS LA CONSULTA
            tbl_lista_torneos.DataSource = _torneo.pc_consultar_torneos();
            tbl_lista_torneos.DataBind();
        }
        #endregion
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
            pc_eliminar();
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

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            pc_consulta_por_fecha();
        }

        protected void btn_iniciar_Click(object sender, EventArgs e)
        {
            pc_iniciar();   
        }
    }
}