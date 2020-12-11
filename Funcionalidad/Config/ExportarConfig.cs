using Analizador.Data.Entity;
using System.Collections.Generic;
using System.Text;
using XML.Core.Data.Model;

namespace Analizador.Funcionalidad.Config
{
    public class ExportarConfig
    {
        public static void Exportar(List<ConfigNodoEntity> nuevositems, ConfigModel config, string PathSave)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                //contenido.AppendLine($"<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                //contenido.AppendLine("<configuration>");

                foreach (var item in config.nodos)
                {
                    var nodo = nuevositems.Find(i => i.name == item.name);
                    contenido.AppendLine(string.IsNullOrWhiteSpace(nodo?.content) ? item.content : nodo.content);
                }
                CrearConfig.Crear(contenido.ToString(), PathSave);
                //contenido.AppendLine("</configuration>");

                //var xml = XDocument.Parse(contenido.ToString());
                //xml.Save(PathSave);

                //exportarxml.Clear();
            }
            catch (System.Exception ex)
            {


            }
        }
    }
}
