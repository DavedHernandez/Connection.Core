using Analizador.Data.Entity;
using Analizador.Interfaz;

namespace Analizador.Funcionalidad.Config
{
    public class ActualizarNodo
    {

        public IProcesar BuilderConstructor(ParametrosEntity parametro)
        {
            switch (parametro.nodoseleccionado.ToLower())
            {
                case "appsettings":
                    return new ActualizarAppSetting(parametro);
                case "connectionstrings":
                    return new ActualizarConnectionString(parametro);

                default:
                    break;
            }
            return default;
        }


    }
}
