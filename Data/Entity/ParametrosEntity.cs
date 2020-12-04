using System.Text;
using XML.Core.Data.Model;

namespace Analizador.Data.Entity
{
    public class ParametrosEntity
    {
        public ParametrosEntity()
        {
            nuevosvalues = new StringBuilder();
        }
        public string nodoseleccionado { get; set; }
        public string confignodo { get; set; }
        public ConfigModel configparseado { get; set; }
        public StringBuilder nuevosvalues { get; set; }
        public string item { get; set; }
        public ConfigModel config { get; set; }
    }
}
