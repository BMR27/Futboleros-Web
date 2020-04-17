using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_V.Clases;
namespace Proyecto_V.Forms
{
    public partial class frm_Reportes : System.Web.UI.Page
    {
        #region INSTANCIAS DE CLASE
        Cls_Reportes _Reporte = new Cls_Reportes();
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                pc_lista_reportes();
            }
        }
        //METODOS DE CLASE
        #region METODOS 
        //LISTA REPORTES
        void pc_lista_reportes()
        {
            dl_lista_reportes.Items.Insert(0,new ListItem("--Seleccione un reporte--",""));
            dl_lista_reportes.Items.Insert(1, new ListItem("Goleadores", "1"));
            dl_lista_reportes.Items.Insert(2, new ListItem("Tabla Posiciones", "2"));
            dl_lista_reportes.SelectedValue = "";
        }

        //GENERAR REPORTE
        void contruirReporte()
        {

            //CAPTURAMOS EL REPORTE 
            _Reporte.IdReporte = Convert.ToInt32(dl_lista_reportes.SelectedValue);
            ///indicar la ruta del reporte
            string rutaReporte = _Reporte.pc_retorna_ruta(); ;
            ///construir la ruta física
            string rutaServidor = this.MapPath(rutaReporte);
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lbl_meensaje.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpv_reportes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpv_reportes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpv_reportes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                ReportDataSource fuenteDatos = new ReportDataSource();
                switch (_Reporte.IdReporte)
                {
                    case 1:
                        fuenteDatos.Name = infoFuenteDatos[0];
                        fuenteDatos.Value = _Reporte.pc_Goleadores();
                        break;
                    case 2:
                        fuenteDatos.Name = infoFuenteDatos[0];
                        fuenteDatos.Value = _Reporte.pc_posiciones();
                        break;
                    default:
                        break;
                }
                // agregar la fuente de datos al reporte
                this.rpv_reportes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpv_reportes.LocalReport.Refresh();
            }
        }


        #endregion

        protected void btn_consultar_Click(object sender, EventArgs e)
        {
            contruirReporte();
        }
    }
}