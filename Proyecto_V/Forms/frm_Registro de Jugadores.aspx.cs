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
    public partial class frm_Registro_de_Jugadores : System.Web.UI.Page
    {
        //INSTANCIAS DE CLASE
        Cls_Provincia _provincia = new Cls_Provincia();
        protected void Page_Load(object sender, EventArgs e)
        {
                pc_cargar_provincias();
        }

        void pc_cargar_provincias()
        {
            dl_lista_provincia.DataSource = _provincia.pc_consultar_provincias();
            dl_lista_provincia.DataBind();
        }

        protected void dl_lista_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Canton _Canton = new Cls_Canton(Convert.ToInt32(dl_lista_provincia.SelectedValue));
            if (_Canton.pc_consultar_cantones()!="")
            {
                dl_lista_cantones.DataSource = _Canton.pc_retornar_lista();
                dl_lista_cantones.DataBind();
                _Canton.pc_limpiar_lista_canton();
            }
        }

        protected void dl_lista_cantones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Distrito _distrito = new Cls_Distrito(0, Convert.ToInt32(dl_lista_cantones.SelectedValue));
            dl_lista_distritos.DataSource = _distrito.pc_retornar_distrito();
            dl_lista_distritos.DataBind();
        }
    }
}