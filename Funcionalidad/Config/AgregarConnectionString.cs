using Analizador.Data.Entity;
using Analizador.Interfaz;
using System.Linq;

namespace Analizador.Funcionalidad.Config
{
    public class AgregarConnectionString : IProcesar
    {
        public ParametrosEntity parametro;

        public AgregarConnectionString(ParametrosEntity parametro) => this.parametro = parametro;

        public void Iniciar()
        {
            var connectionString = parametro.configparseado.connectionStrings.Where(i => parametro.config.connectionStrings.All(b => b.name != i.name)).ToList();

            if (connectionString?.Any() == true)
                parametro.nuevosvalues.AppendLine("<!--Nuevos valores-->");

            foreach (var x in connectionString)
            {
                parametro.nuevosvalues.AppendLine(x.cadenacompleta);
            }
        }
    }
}
