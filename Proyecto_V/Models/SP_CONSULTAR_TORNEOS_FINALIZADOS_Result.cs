//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_V.Models
{
    using System;
    
    public partial class SP_CONSULTAR_TORNEOS_FINALIZADOS_Result
    {
        public int C_CONSECUTIVO { get; set; }
        public int C_FK_USUARIO { get; set; }
        public System.DateTime C_FECHA_INICIAL { get; set; }
        public System.DateTime C_FECHA_FINAL { get; set; }
        public string C_NOMBRE_TORNEO { get; set; }
        public short C_CANT_EQUIPOS { get; set; }
        public bool C_ESTADO { get; set; }
        public Nullable<bool> C_FINALIZADO { get; set; }
    }
}
