using Analizador.Data.Entity;
using Analizador.Interfaz;

namespace Analizador.Funcionalidad.Config
{
    public class NodoBuilder
    {

        public IProcesar Builder(ParametrosEntity parametro)
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
