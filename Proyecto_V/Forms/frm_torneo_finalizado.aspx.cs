using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;
namespace Proyecto_V.Forms
{
    public partial class frm_torneo_finalizado : System.Web.UI.Page
    {
        #region INSTANCIAS
        Cls_Torneo _Torneo = new Cls_Torneo();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_torneos_finalizados();
            }
        }
        #region METODOS
        ///CONSULTA LOS TORNEOS FINALIZADOS
        void pc_torneos_finalizados()
        {
            dl_lista_finalizados.DataSource = _Torneo.pc_torneos_finalizados();
            dl_lista_finalizados.DataBind();
            dl_lista_finalizados.Items.Insert(0, new ListItem("--Seleccione un torneo--",""));
            dl_lista_finalizados.SelectedValue = "";
        }

        //CONSULTA EL CAMPEON
        void pc_consultar_campeon()
        {
            _Torneo.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_finalizados.SelectedValue);
            //consulamos los datos
            tbl_campeon.DataSource = _Torneo.pc_consultar_campeon();
            tbl_campeon.DataBind();
        }

        //CONSULTAMOS EL GOLEADOR
        void pc_consultar_goleador_torneo()
        {
            _Torneo.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_finalizados.SelectedValue);
            //consulamos los datos
            tbl_goleador.DataSource = _Torneo.pc_consultar_goleador();
            tbl_goleador.DataBind();
        }
        #endregion

        protected void dl_lista_finalizados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dl_lista_finalizados.SelectedValue != "")
            {
                pc_consultar_campeon();
                pc_consultar_goleador_torneo();
            }
        }
    }
}