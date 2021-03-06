﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Models;
using Proyecto_V.Clases;


namespace Proyecto_V.Forms
{
    public partial class frm_Registro_de_Equipos : System.Web.UI.Page
    {
        //INSTANCIAS DE CLASE
        Cls_Provincia _provincia = new Cls_Provincia();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_provincias();
                Calendar1.Visible = false;
            }
        }

        void pc_cargar_provincias()
        {
            dl_lista_provincia.DataSource = _provincia.pc_consultar_provincias();
            dl_lista_provincia.DataBind();
        }

        protected void dl_lista_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cls_Canton _Canton = new Cls_Canton(Convert.ToInt32(dl_lista_provincia.SelectedValue));
            if (_Canton.pc_consultar_cantones() != "")
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

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            Cls_Equipo _equipo = new Cls_Equipo(Convert.ToInt32(dl_lista_provincia.SelectedValue),
                    Convert.ToInt32(dl_lista_cantones.SelectedValue), Convert.ToInt32(dl_lista_distritos.SelectedValue));
            _equipo.NombreEquipo = TxtNombreEquipo.Text;
            _equipo.Fundacion = txt_fundacion.Text;


            //VALIDACION DE REGISTRO DEL EQUIPO
            switch (_equipo.pc_registrar_equipo())
            {
                case -100:
                    lbl_mensaje.Text = "Ocurrio un error";
                    break;
                default:
                    lbl_mensaje.Text = "Equipo registrado";
                    break;
            }

        }

        protected void btn_imagen_calendar_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txt_fundacion.Text = this.Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {

        }
    }
}