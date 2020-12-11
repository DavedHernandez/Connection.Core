//using Framework.XML.Data.Model;
//using Framework.XML.Funcionalidad.Maping;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using XML.Core.Data.Model;
using XML.Core.Funcionalidad.Maping;

namespace Analizador.Funcionalidad.VisualStudio
{
    public struct AnalizarProject
    {
        public static List<VisualStudioModel> Analizar(string rutaProyecto)
        {
            DirectoryInfo directorio = new DirectoryInfo(rutaProyecto);

            StringBuilder texto = new StringBuilder();
            List<VisualStudioModel> lstresultado = new List<VisualStudioModel>();

            foreach (var item in directorio.GetFiles("*.csproj", SearchOption.AllDirectories))
            {
                MapearVisualStudio modelo = new MapearVisualStudio(XDocument.Load(item.FullName), item.FullName);
                lstresultado.Add(modelo.Mapear());
            }

            return lstresultado.OrderBy(i=> i.VisualStudio.TotalDependencias).ToList();

        }

    }
}
