using System.Text;
using System.Xml.Linq;

namespace Analizador.Funcionalidad.xml
{
    public class Crearxml
    {
        public static XDocument Crear(string nodo, string datos)
        {
            StringBuilder contenido = new StringBuilder();
            contenido.AppendLine($"<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            contenido.AppendLine("<configuration>");
            contenido.AppendLine($"<{nodo}>");
            contenido.AppendLine(datos);
            contenido.AppendLine($"</{nodo}>");
            contenido.AppendLine("</configuration>");
            

            return  XDocument.Parse(contenido.ToString());
        }
    }
}
