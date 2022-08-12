using System;
namespace apiAuditoriaSoftware.ENTIDADES
{
    public class ActionForeignKeys
    {
        public string nombre_fk { get; set; }
        public string tabla_padre { get; set; }
        public string delete_action { get; set; }
        public string update_action { get; set; }
        public string tabla_ref { get; set; }
    }
}

