using Analizador.Data.Entity;
using System.Collections.Generic;

namespace Analizador.Funcionalidad.Config
{
    public class AgregarNodo
    {
        public static void Agregar(List<ConfigNodoEntity> exportarxml, string nodo, string contenido)
        {
            var item = exportarxml?.Find(i => i.name == nodo);
            if (item != null)
                exportarxml.Remove(item);

            exportarxml.Add(new ConfigNodoEntity { name = nodo, content = contenido });

        }
    }
}
