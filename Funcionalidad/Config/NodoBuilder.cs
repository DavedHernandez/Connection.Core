using Analizador.Data.Entity;
using Analizador.Interfaz;

namespace Analizador.Funcionalidad.Config
{
    public class NodoBuilder
    {

        public IProcesar Builder(ParametrosEntity parametro, bool nuevo = false)
        {
            switch (parametro.nodoseleccionado.ToLower())
            {
                case "appsettings":
                    if (nuevo)
                        return new AgregarAppSetting(parametro);
                    else return new ActualizarAppSetting(parametro);

                case "connectionstrings":
                    if (nuevo)
                        return new AgregarConnectionString(parametro);
                    else return new ActualizarConnectionString(parametro);
                default:
                    break;
            }
            return default;
        }


    }
}
