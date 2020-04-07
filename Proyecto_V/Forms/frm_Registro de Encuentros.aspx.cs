using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;
namespace Proyecto_V.Forms
{
    public partial class frm_Registro_de_Encuentros : System.Web.UI.Page
    {
        #region INSTANCIAS
        Cls_Torneo _Torneo = new Cls_Torneo();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_mostrar_torneos_lista();

            }
        }
        //METODOS
        #region Metodos
        //METODO CONSULTA EN UNA LISTA LOS TORNEOS ACTIVOS
        void pc_mostrar_torneos_lista()
        {
            dl_lista_torneos.DataSource = _Torneo.pc_consultar_torneos();
            dl_lista_torneos.DataBind();
            dl_lista_torneos.Items.Insert(0,new ListItem("Seleccione un torneo",""));
            dl_lista_torneos.SelectedValue = "";
        }
        #endregion
    }
}