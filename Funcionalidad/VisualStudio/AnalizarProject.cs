using Framework.XML.Data.Model;
using Framework.XML.Funcionalidad.Maping;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
                ObtenerDependenciasVisualStudioModel modelo = new ObtenerDependenciasVisualStudioModel(item.FullName);
                lstresultado.Add(modelo.Mapear().VisualStudio);
            }

            return lstresultado.OrderBy(i=> i.VisualStudio.TotalDependencias).ToList();

        }

    }
}
