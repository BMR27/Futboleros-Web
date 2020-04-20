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
        Cls_Encuentros _Encuentros = new Cls_Encuentros();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_mostrar_torneos_lista();
                //pc_mostrar_listas();
                pc_mostrar_torneos_lista2();
            }
        }
        //METODOS
        #region Metodos
        //METODO CONSULTA EN UNA LISTA LOS TORNEOS ACTIVOS
        void pc_mostrar_torneos_lista()
        {
            dl_lista_torneos.DataSource = _Torneo.pc_consultar_torneos();
            dl_lista_torneos.DataBind();
            dl_lista_torneos.Items.Insert(0, new ListItem("Seleccione un torneo", ""));
            dl_lista_torneos.SelectedValue = "";
        }

        //METODO CONSULTA EN UNA LISTA LOS TORNEOS ACTIVOS
        void pc_mostrar_torneos_lista2()
        {
            dl_lista_torneo2.DataSource = _Torneo.pc_consultar_torneos();
            dl_lista_torneo2.DataBind();
            dl_lista_torneo2.Items.Insert(0, new ListItem("Todos", "-1"));
            dl_lista_torneo2.SelectedValue = "-1";
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
            dl_lista_casa.Items.Insert(0, new ListItem("--Seleccione un equipo casa--", ""));
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

        //CONSULTAR_PARTIDOS
        void pc_consultar_partidos()
        {
            _Encuentros.idConsecutivo_Torneo = Convert.ToInt32(dl_lista_torneo2.SelectedValue);
            tbl_lista_partidos.DataSource = _Encuentros.pc_consultar_partidos();
            tbl_lista_partidos.DataBind();
        }

        //CONSULTAR JUGADORES POR EQUIPO
        void pc_consultar_jugadores()
        {
            //verificamos la tabla
            CheckBox ch;
            foreach (GridViewRow item in tbl_lista_partidos.Rows)
            {
                ch = (CheckBox)item.Cells[7].FindControl("ch_seleccionar");
                if (ch.Checked == true)
                {
                    _Encuentros.IdEncuentro = Convert.ToInt32(item.Cells[0].Text);
                    break;
                }
            }
            dl_lista_jugadores_casa.DataSource = _Encuentros.pc_jugadores_casa();
            dl_lista_jugadores_casa.DataBind();
            dl_lista_jugadores_casa.Items.Insert(0, new ListItem("--Ninguno--", "-1"));
            dl_lista_jugadores_casa.SelectedValue = "-1";
            //MOSTRASMO LA VISITA
            dl_lista_jugadores_visita.DataSource = _Encuentros.pc_jugadores_visita();
            dl_lista_jugadores_visita.DataBind();
            dl_lista_jugadores_visita.Items.Insert(0, new ListItem("--Ninguno--", "-1"));
            dl_lista_jugadores_visita.SelectedValue = "-1";
        }


        //METODO ACTUALIZA EL PARTIDO
        void pc_actualizar_partido()
        {
            //CAPTURAMOS LOS DATOS
            //verificamos la tabla
            CheckBox ch;
            foreach (GridViewRow item in tbl_lista_partidos.Rows)
            {
                ch = (CheckBox)item.Cells[7].FindControl("ch_seleccionar");
                if (ch.Checked == true)
                {
                    _Encuentros.IdEncuentro = Convert.ToInt32(item.Cells[0].Text);
                    break;
                }
            }
            _Encuentros.GolCasa = Convert.ToInt32(txt_cant_gol_casa.Text);
            _Encuentros.GolVisita = Convert.ToInt32(txt_cant_gol_visita.Text);
            _Encuentros.IdAnotadorCasa = Convert.ToInt32(dl_lista_jugadores_casa.SelectedValue);
            _Encuentros.IdAnotadorVisita = Convert.ToInt32(dl_lista_jugadores_visita.SelectedValue);
            if (_Encuentros.GolCasa == 0 && _Encuentros.IdAnotadorCasa != -1 ||
                _Encuentros.GolVisita == 0 && _Encuentros.IdAnotadorVisita != -1)
            {
                lbl_mensaje_erro.Text = "Si el gol casa o visita es 0, no debe seleccionar un anotador, favor seleccionar ninguno";
            }
            else
            if (_Encuentros.GolCasa > 0 && _Encuentros.IdAnotadorCasa == -1 ||
                     _Encuentros.GolVisita > 0 && _Encuentros.IdAnotadorVisita == -1)
            {
                lbl_mensaje_erro.Text = "Si el gol casa o visita es mayor que 0, debe seleccionar un anotador, favor seleccionar un jugador";
            }
            else
            {
                lbl_mensaje_erro.Text = _Encuentros.pc_actualizar_partidos();
                if (lbl_mensaje_erro.Text == "Partido actualizado y finalizado")
                {
                    pc_consultar_partidos();
                }
            }
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

        protected void btn_buscar_partido_Click(object sender, EventArgs e)
        {
            pc_consultar_partidos();
        }

        protected void tbl_lista_partidos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ///asignar el nuevo índice
            this.tbl_lista_partidos.PageIndex = e.NewPageIndex;
            ///volver a cargar el grid
            this.pc_consultar_partidos();
        }


        protected void btn_actualizar_partido_Click(object sender, EventArgs e)
        {
            pc_actualizar_partido();
        }

        protected void btn_ver_datos_Click(object sender, EventArgs e)
        {

            pc_consultar_jugadores();
        }
    }
}