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
    using System.Collections.Generic;
    
    public partial class TBL_TABLA_POSICIONES
    {
        public int C_CONSECUTIVO { get; set; }
        public Nullable<int> C_FK_ENC_TORNEO { get; set; }
        public Nullable<int> C_FK_EQUIPO { get; set; }
        public short C_PUNTO { get; set; }
        public Nullable<int> C_FK_ENCUENTRO { get; set; }
    
        public virtual TBL_EQUIPO TBL_EQUIPO { get; set; }
        public virtual TBL_ENC_TORNEOS TBL_ENC_TORNEOS { get; set; }
    }
}
