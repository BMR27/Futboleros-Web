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
    }
}