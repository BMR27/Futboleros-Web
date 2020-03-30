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
        Cls_Jugador _Jugador = new Cls_Jugador();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_consultar_equipos();
                pc_consultar_jugadores_activos();
            }
        }
        //NETODOS DE CLASE
        #region METODOS DE CLASE
        //CONSULTA LOS EQUIPOS
        void pc_consultar_equipos()
        {
            dl_lista_equipos.DataSource = _equipos.pc_consultar_equipos();
            dl_lista_equipos.DataBind();
            dl_lista_equipos.Items.Insert(0,new ListItem("Seleccione un equipo",""));
            dl_lista_equipos.SelectedValue = "";
        }

        //CONSULTA JUGADORES
        void pc_consultar_jugadores_activos()
        {
            tbl_jugadores.DataSource = _Jugador.pc_consultar_jugadores_activos();
            tbl_jugadores.DataBind();
        }

        //CAPTURA DATOS DEL JUGADOR

        void pc_capturar_datos_jugador()
        {
            //LISTA MANTIENE LOS DATOS
            List<Cls_Jugador> lista_datos_jug = new List<Cls_Jugador>();
            //VARIABLE CHECK
            CheckBox ch;
            foreach (GridViewRow item in tbl_jugadores.Rows)
            {
                Cls_Jugador _datos = new Cls_Jugador();
                ch = (CheckBox)item.Cells[4].FindControl("ch_seleccionar");
                if (ch.Checked == true)
                {
                    _datos.NumeroCedula = item.Cells[0].Text;
                    _datos.idConsecutivo = Convert.ToInt32(dl_lista_equipos.SelectedValue);
                    lista_datos_jug.Add(_datos);
                }
            }

            //ENVIAMOS LOS DATOS 
            if (_Jugador.pc_jug_x_equipo(lista_datos_jug) > 0)
            {
                pc_consultar_jugadores_activos();
            }
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

        protected void btn_agregar_jugador_Click(object sender, EventArgs e)
        {
            pc_capturar_datos_jugador();
        }
    }
}