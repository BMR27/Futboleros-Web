using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;
namespace Proyecto_V.Forms
{
    public partial class frm_jug_x_equipo : System.Web.UI.Page
    {
        #region INSTANCIAS DE CLASE
        Cls_Equipo _equipos = new Cls_Equipo();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_consultar_equipos();
            }
        }

        #region METODOS DE CLASE
        //CONSULTA LOS EQUIPOS
        void pc_consultar_equipos()
        {
            dl_lista_equipos.DataSource = _equipos.pc_consultar_equipos();
            dl_lista_equipos.DataBind();
            dl_lista_equipos.Items.Insert(0,new ListItem("Seleccione un equipo",""));
            dl_lista_equipos.SelectedValue = "";
        }
        #endregion

        protected void dl_lista_equipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl_lista_equipos.Enabled = false;
        }

        protected void btn_cambiar_seleccion_Click(object sender, EventArgs e)
        {
            dl_lista_equipos.Enabled = true;
        }
    }
}