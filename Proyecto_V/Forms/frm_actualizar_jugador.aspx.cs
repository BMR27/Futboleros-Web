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
            }
        }
        void pc_cargar_datos_jugador()
        {
            foreach (var item in _jugador.pc_retornar_lista_jugador())
            {
                txt_nombre.Value = item.Nombre;
            }
        }
    }
}