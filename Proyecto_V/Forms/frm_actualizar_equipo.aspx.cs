using Proyecto_V.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_V.Forms
{
    public partial class frm_actualizar_equipo : System.Web.UI.Page
    {
        Cls_Equipo _equipo = new Cls_Equipo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_datos_equipo();
                txt_consecutivo.Enabled = false;
                _equipo.pc_limpiar_datos_equipo();
            }
        }

        void pc_cargar_datos_equipo()
        {
            foreach(var item in _equipo.pc_retornar_lista_equipo())
            {

               
                txt_nombre.Value = item.NombreEquipo;
                
                txt_fundacion.Value = item.Fundacion;
               
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            _equipo.NombreEquipo = txt_nombre.Value;
            _equipo.Fundacion = txt_fundacion.Value;
            if (_equipo.pc_actualizar_equipo() > 0)
            {
                Response.Redirect("frm_lista_equipos.aspx");
            }
            else
            {
                txt_mensaje.Text = "No se actualizaron los datos del equipo";
            }


        }
    }
}