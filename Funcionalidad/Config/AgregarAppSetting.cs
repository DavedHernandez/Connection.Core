using Analizador.Data.Entity;
using Analizador.Interfaz;
using System.Linq;

namespace Analizador.Funcionalidad.Config
{
    public class AgregarAppSetting : IProcesar
    {
        public ParametrosEntity parametro;

        public AgregarAppSetting(ParametrosEntity parametro)
        {
            this.parametro = parametro;
        }

        public void Iniciar()
        {
            var nuevosappsettings = parametro.configparseado.appSetting.Where(i => parametro.config.appSetting.All(b => b.key != i.key)).ToList();
            foreach (var x in nuevosappsettings)
            {
                parametro.nuevosvalues.AppendLine($"<add key=\"{ x.key }\" value=\"{ x.value }\"/>     <!--Agregado-->");
            }
        }
    }
}
