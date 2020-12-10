using Analizador.Data.Entity;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Analizador.Funcionalidad.Config
{
    public class ExportarConfigtmp
    {
        public static void Exportar(List<ConfigNodoEntity> nuevositems, string PathSave)
        {
            try
            {
                StringBuilder contenido = new StringBuilder();
                string nombre = Path.GetFileNameWithoutExtension(PathSave) + "_export" + Path.GetExtension(PathSave);
                string ruta = Path.Combine(Path.GetDirectoryName(PathSave), nombre);

                foreach (var item in nuevositems)
                {
                    contenido.AppendLine(item.content);
                }
                CrearConfig.Crear(contenido.ToString(), ruta);
            }
            catch (System.Exception ex)
            {
            }
        }
    }
}
