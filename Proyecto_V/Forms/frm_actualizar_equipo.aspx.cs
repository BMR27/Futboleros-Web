using Proyecto_V.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_V.Forms
{
    public partial class frm_actualizar_equipo : System.Web.UI.Page
    {
        //INSTANCIAS
        #region INSTANCIAS
        Cls_Equipo _equipo = new Cls_Equipo();
        Cls_Distrito _procesos_region = new Cls_Distrito();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_cargar_datos_equipo();
                pc_bloquear_casillas();
                pc_cargar_provincias();
            }
        }
        void pc_cargar_provincias()
        {
            dl_provincia.DataSource = _procesos_region.pc_consultar_provincias();
            dl_provincia.DataBind();
            dl_provincia.Items.Insert(0,new ListItem("Seleccione una Provincia",""));
            dl_provincia.SelectedValue = "";
        }
        void pc_bloquear_casillas()
        {
            txt_consecutivo.Enabled = false;
            txt_provincia.Enabled = false;
            txt_canton.Enabled = false;
            txt_distrito.Enabled = false;
        }
        void pc_cargar_datos_equipo()
        {
            foreach (var item in _equipo.pc_retornar_datos_equipo())
            {
                //MOSTRAMOS LOS DATOS DE LA LISTA
                txt_consecutivo.Text = Convert.ToString(item.idConsecutivo);
                txt_nombre.Text = item.NombreEquipo;
                txt_provincia.Text = item.NombreProvincia;
                txt_canton.Text = item.NombreCanton;
                txt_distrito.Text = item.NombreDistrito;
                txt_fundacion.Text = item.Fundacion;
            }
            //HACEMOS LA LIMPIEZA DE LA VARIABLE ESTATICA
            _equipo.pc_limpiar_datos_equipo();
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (dl_provincia.SelectedValue != "")
            {
                //CAPTURAMOS LOS DATOS
                _equipo.idConsecutivo = Convert.ToInt32(txt_consecutivo.Text);
                _equipo.NombreEquipo = txt_nombre.Text;
                _equipo.IdProvincia = Convert.ToInt32(dl_provincia.SelectedValue);
                _equipo.IdCanton = Convert.ToInt32(dl_canton.SelectedValue);
                _equipo.IdDistrito = Convert.ToInt32(dl_distrito.SelectedValue);
                _equipo.Fundacion = txt_fundacion.Text;
                //EJECUTAMOS EL SP
                if (_equipo.pc_actualizar_equipo() > 0)
                {
                    Response.Redirect("frm_lista_equipos.aspx");
                }
                else
                {
                    txt_mensaje.Text = "No se actualizaron los datos";
                }
            }
            else
            {
                _equipo.idConsecutivo = Convert.ToInt32(txt_consecutivo.Text);
                _equipo.NombreEquipo = txt_nombre.Text;
                _equipo.Fundacion = txt_fundacion.Text;
                //EJECUTAMOS EL SP
                if (_equipo.pc_actualizar_equipo() > 0)
                {
                    Response.Redirect("frm_lista_equipos.aspx");
                }
                else
                {
                    txt_mensaje.Text = "No se actualizaron los datos";
                }

            }
        }

        protected void dl_provincia_TextChanged(object sender, EventArgs e)
        {
            if (dl_provincia.SelectedValue != "")
            {
                btn_actualizar.Enabled = false;
                dl_canton.Enabled = true;
                dl_distrito.Enabled = true;
            }
            else if(dl_provincia.SelectedValue.Equals(""))
            {
                dl_canton.Enabled = false;
                dl_distrito.Enabled = false;
                btn_actualizar.Enabled = true;
                dl_canton.ClearSelection();
                dl_distrito.ClearSelection();
            }
        }

        protected void dl_provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dl_provincia.SelectedValue != " ")
            {
                Cls_Canton _Canton = new Cls_Canton(Convert.ToInt32(dl_provincia.SelectedValue));
                if (_Canton.pc_consultar_cantones() != "")
                {
                    dl_canton.DataSource = _Canton.pc_retornar_lista();
                    dl_canton.DataBind();
                    dl_canton.Items.Insert(0, new ListItem("Seleccione un Cantón", ""));
                    dl_canton.SelectedValue = "";
                    _Canton.pc_limpiar_lista_canton();
                }
            }
        }

        protected void dl_canton_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dl_canton.SelectedValue != "")
            {
                Cls_Distrito _distrito = new Cls_Distrito(0, Convert.ToInt32(dl_canton.SelectedValue));
                dl_distrito.DataSource = _distrito.pc_retornar_distrito();
                dl_distrito.DataBind();
                dl_distrito.Items.Insert(0, new ListItem("Seleccione un Distrito",""));
                dl_distrito.SelectedValue = "";
            }
        }
    }
}