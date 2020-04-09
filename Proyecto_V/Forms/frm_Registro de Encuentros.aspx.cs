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
                //pc_mostrar_listas();
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

        //METODO OCULTA LAS LISTAS DE CASA Y VISITA
        void pc_mostrar_listas()
        {
            dl_lista_casa.Visible = false;
            dl_lista_visita.Visible = false;
        }

        //METODO CONSULTA LOS EQUIPOS CASA 
        void pc_consultar_casa()
        {
            //CAPTURAMOS EL DATOS
            Cls_Encuentros _Encuentros = new Cls_Encuentros();
            _Encuentros.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_torneos.SelectedValue);

            //EJECUTAMOS LA CONSULTA
            dl_lista_casa.DataSource = _Encuentros.pc_cosultar_equipos_casa_x_torneo();
            dl_lista_casa.DataBind();
            dl_lista_casa.Items.Insert(0,new ListItem("--Seleccione un equipo casa--",""));
            dl_lista_casa.SelectedValue = "";
        }

        //METODO CONSULTA VISITA
        void pc_consultar_VISITA()
        {
            //CAPTURAMOS EL DATOS
            Cls_Encuentros _Encuentros = new Cls_Encuentros();
            _Encuentros.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_torneos.SelectedValue);
            _Encuentros.idConsecutivo = Convert.ToInt32(dl_lista_casa.SelectedValue);

            //EJECUTAMOS LA CONSULTA
            dl_lista_visita.DataSource = _Encuentros.pc_cosultar_equipos_visita_x_torneo();
            dl_lista_visita.DataBind();
            dl_lista_visita.Items.Insert(0, new ListItem("--Seleccione un equipo Visita--", ""));
            dl_lista_visita.SelectedValue = "";
        }

        //METODO REGISTRA EL PARTIDO
        void pc_registrar_partido()
        {
            //CAPTURAMOS LOS DATOS
            Cls_Encuentros _Encuentros = new Cls_Encuentros();
            _Encuentros.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_torneos.SelectedValue);
            _Encuentros.IdCasa = Convert.ToInt32(dl_lista_casa.SelectedValue);
            _Encuentros.IdVisita = Convert.ToInt32(dl_lista_visita.SelectedValue);
            _Encuentros.FechaEncuentro = Convert.ToDateTime(id_fecha.SelectedDate.ToShortDateString());

            //EJECUTAMOS EL PROCEDIMIENTO

            lbl_mensaje.Text = _Encuentros.pc_registrar_encuentro();
        }
        #endregion

        protected void dl_lista_torneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dl_lista_torneos.SelectedValue == "")
            {
                dl_lista_casa.SelectedValue = "";
                dl_lista_visita.SelectedValue = "";
            }
            else
            {

                pc_consultar_casa();
            }
        }

        protected void dl_lista_casa_SelectedIndexChanged(object sender, EventArgs e)
        {
            pc_consultar_VISITA();
        }

        protected void btn_agregar_encuentro_Click(object sender, EventArgs e)
        {
            pc_registrar_partido();
        }
    }
}