using Analizador.Data.Entity;
using Analizador.Interfaz;
using System;

namespace Analizador.Funcionalidad.Config
{
    public class ActualizarAppSetting : IProcesar
    {
        private ParametrosEntity parametro;

        public ActualizarAppSetting(ParametrosEntity parametro)
        {
            this.parametro = parametro;
        }
        public void Iniciar()
        {
            bool actualizar = false;

            var key = parametro.item.Split(new string[] { "key" }, StringSplitOptions.RemoveEmptyEntries);

            actualizar = !(key?.Length == 1);

            if (actualizar)
            {
                var value = key[1].Split(new string[] { "value" }, StringSplitOptions.RemoveEmptyEntries);

                if (value?.Length > 1)
                {
                    string llave = value[0].Substring(1, value[0].Length - 1).Replace("\"", "").Trim();
                    var appsetting = parametro.configparseado.appSetting.Find(i => i.key.Trim() == llave);

                    actualizar = !string.IsNullOrWhiteSpace(appsetting?.key);

                    if (actualizar)
                        parametro.nuevosvalues.AppendLine($"<add key=\"{ appsetting.key }\" value=\"{ appsetting.value }\"/>");
                    else
                        parametro.nuevosvalues.AppendLine(parametro.item);
                }
            }
            else
                parametro.nuevosvalues.AppendLine(parametro.item);


        }
    }
}
