using Proyecto_V.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_V.Forms
{
    public partial class frm_actualizar_jugador : System.Web.UI.Page
    {
        Cls_Jugador _jugador = new Cls_Jugador();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_datos_jugador();
                txt_cedula.Enabled = false;
            }
        }
        void pc_cargar_datos_jugador()
        {
            foreach (var item in _jugador.pc_retornar_lista_jugador())
            {
                txt_cedula.Text = item.NumeroCedula;
                txt_nombre.Value = item.Nombre;
                txt_apellido1.Value = item.Apellido1;
                txt_apellido2.Value = item.Apellido2;
                txt_telefono.Value = item.NumeroTelefono;
                txt_correo.Value = item.Correo;
                txt_direccion.Value = item.DireccionCasa;
            }
        }
    }
}