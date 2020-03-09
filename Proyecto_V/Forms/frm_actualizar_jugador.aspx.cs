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
                _jugador.pc_limpiar_datos_jugador();
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

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            _jugador.NumeroCedula = txt_cedula.Text;
            _jugador.Nombre = txt_nombre.Value;
            _jugador.Apellido1 = txt_apellido1.Value;
            _jugador.Apellido2 = txt_apellido2.Value;
            _jugador.NumeroTelefono = txt_telefono.Value;
            _jugador.Correo = txt_correo.Value;
            _jugador.DireccionCasa = txt_direccion.Value;
            if (_jugador.pc_actualizar_jugador() > 0)
            {
                Response.Redirect("frm_lista_jugadores.aspx");
            }
            else
            {
                txt_mensaje.Text = "No se actualizaron los datos del jugador";
            }
        }
    }
}