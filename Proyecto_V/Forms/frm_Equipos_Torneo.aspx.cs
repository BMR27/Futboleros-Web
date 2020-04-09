using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;


namespace Proyecto_V.Forms
{
    public partial class frm_Equipos_Torneo : System.Web.UI.Page
    {
        #region INSTANCIAS DE CLASE
        Cls_Equipo _equipos = new Cls_Equipo();
        Cls_Torneo _torneos = new Cls_Torneo();
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //pc_consultar_equipos();
                pc_consultar_torneos();
            }

        }

        //METODOS DE CLASE
        #region METODOS DE CLASE
        //CONSULTA LOS TORNEOS
        void pc_consultar_torneos()
        {
            dl_lista_torneos.DataSource = _torneos.pc_consultar_torneos();
            dl_lista_torneos.DataBind();
            dl_lista_torneos.Items.Insert(0, new ListItem("Seleccione un torneo", ""));
            dl_lista_torneos.SelectedValue = "";
        }

        //CONSULTA LOS EQUIPOS
        void pc_consultar_equipos()
        {
            tbl_equipos.DataSource = _equipos.pc_consultar_equipos();
            tbl_equipos.DataBind();
        }

        //CAPTURA DATOS DEL EQUIPO

        void pc_capturar_datos_equipo()
        {
            //LISTA MANTIENE LOS DATOS
            List<Cls_Equipo> lista_datos_equipo = new List<Cls_Equipo>();
            //VARIABLE CHECK
            CheckBox ch;
            foreach (GridViewRow item in tbl_equipos.Rows)
            {
                Cls_Equipo _datos = new Cls_Equipo();
                ch = (CheckBox)item.Cells[1].FindControl("ch_seleccionar");
                if (ch.Checked == true)
                {
                    _datos.NombreEquipo = item.Cells[1].Text;
                    _datos.idConsecutivo = Convert.ToInt32(dl_lista_torneos.SelectedValue);


                    lista_datos_equipo.Add(_datos);
                }
            }

            //ENVIAMOS LOS DATOS
            if (_equipos.pc_equipo_x_torneo(lista_datos_equipo) > 0)
            {
                pc_capturar_datos_equipo();
            }
        }

        #endregion


        protected void dl_lista_torneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dl_lista_torneos.Enabled = false;
        }

        protected void btn_cambiar_seleccion_Click(object sender, EventArgs e)
        {
            dl_lista_torneos.Enabled = true;
        }

        protected void btn_agregar_equipo_Click(object sender, EventArgs e)
        {
            pc_capturar_datos_equipo();
        }
    }
}
