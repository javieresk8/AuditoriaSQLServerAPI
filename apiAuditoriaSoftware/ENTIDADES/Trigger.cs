using System;
namespace apiAuditoriaSoftware.ENTIDADES
{
    public class Trigger
    {
        public string nombre_trigger { get; set; }
        public string nombre_schema { get; set; }
        public Boolean esta_deshabilitado { get; set; }
        public int id_trigger { get; set; }
        public string operacion { get; set; }
    }
}

