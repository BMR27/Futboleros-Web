using Proyecto_V.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_V.Forms
{
    public partial class frm_actualizar_torneo : System.Web.UI.Page
    {
        //INSTANCIAS
        #region INSTANCIAS
        Cls_Torneo _torneo = new Cls_Torneo();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_datos_torneo();
                pc_bloquear_casillas();
                
            }
        }

        void pc_bloquear_casillas()
        {
            txt_consecutivo.Enabled = false;
       
        }
        void pc_cargar_datos_torneo()
        {
            foreach (var item in _torneo.pc_retornar_datos_torneos())
            {
                //MOSTRAMOS LOS DATOS DE LA LISTA
                txt_consecutivo.Text = Convert.ToString(item.idConsecutivo_Torneo);
                txt_nombre_torneo.Text = Convert.ToString(item.NombreTorneo);
                txt_fecha_Inicio.Text = Convert.ToString(item.Fecha_Inicio);
                txt_fecha_Final.Text = Convert.ToString(item.Fecha_Final);
                txtCantidad_Equipos.Text = Convert.ToString(item.CantidadEquipos);
               
            }
            //HACEMOS LA LIMPIEZA DE LA VARIABLE ESTATICA
            _torneo.pc_limpiar_datos_torneo();
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            _torneo.idConsecutivo_Torneo = Convert.ToInt32(txt_consecutivo.Text);
            _torneo.NombreTorneo = txt_nombre_torneo.Text;
            _torneo.Fecha_Inicio = Convert.ToDateTime(txt_fecha_Inicio.Text);
            _torneo.Fecha_Final = Convert.ToDateTime(txt_fecha_Final.Text);
            _torneo.CantidadEquipos = Convert.ToInt32(txtCantidad_Equipos.Text);
           
            if (_torneo.pc_actualizar_torneos() > 0)
            {
                Response.Redirect("frm_lista_torneos.aspx");
            }
            else
            {
                txt_mensaje.Text = "No se actualizaron los datos del torneo";
            }

        }
    }
}