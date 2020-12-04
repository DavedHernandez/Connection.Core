using Analizador.Data.Entity;
using Analizador.Interfaz;
using System;

namespace Analizador.Funcionalidad.Config
{
    public class ActualizarConnectionString : IProcesar
    {
        private ParametrosEntity parametro;

        public ActualizarConnectionString(ParametrosEntity parametro)
        {
            this.parametro = parametro;
        }

        public void Iniciar()
        {
            bool actualizar = false;

            var key = parametro.item.Split(new string[] { "name" }, StringSplitOptions.RemoveEmptyEntries);

            actualizar = !(key?.Length == 1);

            if (actualizar)
            {
                var value = key[1].Split(new string[] { "connectionString" }, StringSplitOptions.RemoveEmptyEntries);

                if (value?.Length > 1)
                {
                    string llave = value[0].Substring(1, value[0].Length - 1).Replace("\"", "").Trim();
                    var appsetting = parametro.configparseado.connectionStrings.Find(i => i.name.Trim() == llave);

                    actualizar = !string.IsNullOrWhiteSpace(appsetting?.name);

                    if (actualizar)
                        parametro.nuevosvalues.AppendLine($"<add name=\"{ appsetting.name }\" connectionString=\"{ appsetting.connectionString }\"/>");
                    else
                        parametro.nuevosvalues.AppendLine(parametro.item);
                }
            }
            else
                parametro.nuevosvalues.AppendLine(parametro.item);
        }
    }
}

