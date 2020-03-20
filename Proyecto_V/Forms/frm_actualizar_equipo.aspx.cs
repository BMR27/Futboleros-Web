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
            }
        }

        void pc_cargar_datos_equipo()
        {
            foreach (var item in _equipo.pc_retornar_datos_equipo())
            {
                //MOSTRAMOS LOS DATOS DE LA LISTA
                txt_consecutivo.Text = Convert.ToString(item.idConsecutivo);
                txt_nombre.Value = item.NombreEquipo;
                txt_provincia.Value = item.NombreProvincia;
                txt_canton.Value = item.NombreCanton;
                txt_distrito.Value = item.NombreDistrito;
                txt_fundacion.Value = item.Fundacion;
            }
            //HACEMOS LA LIMPIEZA DE LA VARIABLE ESTATICA
            _equipo.pc_limpiar_datos_equipo();
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            _equipo.NombreEquipo = txt_nombre.Value;
            _equipo.Fundacion = txt_fundacion.Value;
            if (_equipo.pc_actualizar_equipo() > 0)
            {
                Response.Redirect("frm_lista_jugadores.aspx");
            }
            else
            {
                txt_mensaje.Text = "No se actualizaron los datos del equipo";
            }


        }
    }
}