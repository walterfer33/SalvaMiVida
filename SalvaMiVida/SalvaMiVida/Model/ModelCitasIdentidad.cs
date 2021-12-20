using System;
using System.Collections.Generic;
using System.Text;

namespace SalvaMiVida.Model
{



    public class ItemIdentidad
    {
        public int id_consulta { get; set; }
        public string identidad_persona { get; set; }
        public string nombre_persona { get; set; }
        public string descripcion_diagnostico { get; set; }
        public DateTime fdiag_diagnosticopaciente { get; set; }
        public DateTime fconsulta_consulta { get; set; }
        public DateTime fproxima_consulta { get; set; }
        public string medico_consulta { get; set; }
        public string descripcion_sede { get; set; }
        public DateTime finicio_diagnosticopaciente { get; set; }
    }

    public class LinkIdentidad
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class ModelCitasIdentidad
    {
        public List<Item> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<Link> links { get; set; }
    }

}
