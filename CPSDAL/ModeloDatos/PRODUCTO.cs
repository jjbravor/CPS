//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CPSDAL.ModeloDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public int pro_id { get; set; }
        public int pro_parentid { get; set; }
        public string pro_codigo { get; set; }
        public int pro_emp_id { get; set; }
        public string pro_nombre { get; set; }
        public string pro_descripcion { get; set; }
        public int pro_umedida { get; set; }
        public int pro_tipo { get; set; }
        public bool pro_formulado { get; set; }
        public int pro_capa { get; set; }
        public int pro_familia { get; set; }
        public int pro_subfamilia { get; set; }
        public bool pro_estado { get; set; }
    }
}
