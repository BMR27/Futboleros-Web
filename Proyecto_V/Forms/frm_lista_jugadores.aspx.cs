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
        Cls_Jugador _jugador = new Cls_Jugador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_tabla_jugadores();
            }
        }
        void pc_cargar_tabla_jugadores()
        {
            
            tbl_lista_jugadores.DataSource =  _jugador.pc_consultar_jugadores();
            tbl_lista_jugadores.DataBind();
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_jugadores.Rows.Count; i++)
            {
                CheckBox check = (CheckBox)tbl_lista_jugadores.Rows[i].FindControl("ch_tbl_jugadores");
                if (check.Checked == true)
                {
                    _jugador.NumeroCedula = tbl_lista_jugadores.Rows[i].Cells[0].Text;
                    _jugador.Nombre = tbl_lista_jugadores.Rows[i].Cells[1].Text;
                    _jugador.Apellido1 = tbl_lista_jugadores.Rows[i].Cells[2].Text;
                    _jugador.Apellido2 = tbl_lista_jugadores.Rows[i].Cells[3].Text;
                    _jugador.NumeroTelefono = tbl_lista_jugadores.Rows[i].Cells[5].Text;
                    _jugador.Correo = tbl_lista_jugadores.Rows[i].Cells[6].Text;
                    _jugador.DireccionCasa = tbl_lista_jugadores.Rows[i].Cells[8].Text;
                    _jugador.pc_captura_datos();
                    filas = 10;
                    break;
                }
            }
            if (filas == 10)
            {
                Response.Redirect("frm_actualizar_jugador.aspx");
            }
            else
            {
                lbl_mensaje.Text = "Debe seleccionar un jugador";
            }
           
        }

        protected void btn_cambiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("frm_lista_jugadores.aspx");
        }

        protected void ch_tbl_jugadores_CheckedChanged(object sender, EventArgs e)
        {
            tbl_lista_jugadores.Enabled = false;
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            int filas = 0;
            for (int i = 0; i < tbl_lista_jugadores.Rows.Count; i++)
            {

                CheckBox check = (CheckBox)tbl_lista_jugadores.Rows[i].FindControl("ch_tbl_jugadores");
                if (check.Checked == true)
                {
                    _jugador.NumeroCedula = tbl_lista_jugadores.Rows[i].Cells[0].Text;
                    filas = _jugador.pc_eliminar_jugador();
                    break;
                }
            }

            if (filas > 0)
            {
                Response.Redirect("frm_lista_jugadores.aspx");
            }
        }
    }
}