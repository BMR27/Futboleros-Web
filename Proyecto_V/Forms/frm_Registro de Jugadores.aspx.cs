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
            if (!this.IsPostBack)
            {
                pc_cargar_provincias();
                dt_fechas.Visible = false;
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

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            Cls_Jugador _jugador = new Cls_Jugador(Convert.ToInt32(dl_lista_provincia.SelectedValue),
                    Convert.ToInt32(dl_lista_cantones.SelectedValue),Convert.ToInt32(dl_lista_distritos.SelectedValue));
            _jugador.NumeroCedula = txt_cedula.Text;
            if (rb_masculino.Checked == true)
            {
                _jugador.Genero = "M";
            }
            else
            {
                _jugador.Genero = "F";
            }
            _jugador.FechaNacimiento = txt_fecha_nacimiento.Text;
            _jugador.NumeroTelefono = txt_telefono.Text;
            _jugador.Correo = txt_correo.Text;
            _jugador.Nombre = txt_nombre.Text;
            _jugador.Apellido1 = txt_apellido1.Text;
            _jugador.Apellido2 = txt_apellido2.Text;
            _jugador.DireccionCasa = txt_direccion.Value;

            //HACEMOS LA VALIDACION SI SE REGISTRP EL JUGADOR
            switch (_jugador.pc_registrar_jugador())
            {
                case -100:
                    lbl_mensaje.Text = "Ocurrio un error";
                    break;
                default:
                    lbl_mensaje.Text = "Jugador registrado";
                    break;
            }


        }

        protected void btn_imagen_calendar_Click(object sender, ImageClickEventArgs e)
        {
            if (dt_fechas.Visible)
            {
                dt_fechas.Visible = false;
            }
            else
            {
                dt_fechas.Visible = true;
            }
        }

        protected void dt_fechas_SelectionChanged(object sender, EventArgs e)
        {
            txt_fecha_nacimiento.Text = this.dt_fechas.SelectedDate.ToShortDateString();
            dt_fechas.Visible = false;
        }
    }
}