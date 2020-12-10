using System.Text;
using System.Xml.Linq;

namespace Analizador.Funcionalidad.Config
{
    public class CrearConfig
    {
        public static void Crear(string datos, string PathSave)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                contenido.AppendLine($"<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                contenido.AppendLine("<configuration>");
                contenido.AppendLine(datos);
                contenido.AppendLine("</configuration>");

                var xml = XDocument.Parse(contenido.ToString());
                xml.Save(PathSave);
            }
            catch (System.Exception ex)
            {


            }
        }
    }
}
