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
    public partial class frm_Registro_Torneos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
       
                dt_Fecha_Inicio.Visible = false;
                dt_Fecha_Final.Visible = false;

            }
        }

        protected void btn_imagen_calendar_Click(object sender, ImageClickEventArgs e)
        {
            if (dt_Fecha_Inicio.Visible)
            {
                dt_Fecha_Inicio.Visible = false;
            }
            else
            {
                dt_Fecha_Inicio.Visible = true;
            }

        }

        protected void dt_Fecha_Inicio_SelectionChanged(object sender, EventArgs e)
        {
            txt_fecha_Inicio.Text = this.dt_Fecha_Inicio.SelectedDate.ToShortDateString();
            dt_Fecha_Inicio.Visible = false;
        }

        protected void btn_imagen_calendar1_Click(object sender, ImageClickEventArgs e)
        {
            if (dt_Fecha_Final.Visible)
            {
                dt_Fecha_Final.Visible = false;
            }
            else
            {
                dt_Fecha_Final.Visible = true;
            }
        }

        protected void dt_Fecha_Final_SelectionChanged(object sender, EventArgs e)
        {
            txt_fecha_Final.Text = this.dt_Fecha_Final.SelectedDate.ToShortDateString();
            dt_Fecha_Final.Visible = false;
        }

        protected void btn_agregar_Torneo_Click(object sender, EventArgs e)
        {
            Cls_Torneo _torneo = new Cls_Torneo();
            _torneo.NombreTorneo = TxtNombreTorneo.Text;
            if (rb_activo.Checked == true)
            {
                _torneo.Estado = "A";
            }
            else
            {
                _torneo.Estado = "I";
            }
            _torneo.Fecha_Inicio = txt_fecha_Inicio.Text;
            _torneo.Fecha_Final = txt_fecha_Final.Text;
            _torneo.CantidadEquipos = txt_Cantidad_Equipos.Text;
            _torneo.id_Usuario = txtUsuario.Text;

           
            ////HACEMOS LA VALIDACION SI SE REGISTRP EL TORNEO
            //switch (_torneo.pc_registrar_torneo())
            //{
            //    case -100:
            //        lbl_mensaje.Text = "Ocurrio un error";
            //        break;
            //    default:
            //        lbl_mensaje.Text = "Torneo registrado";
            //        break;
            //}
        }
        
    }
}