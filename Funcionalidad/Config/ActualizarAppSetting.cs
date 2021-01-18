using Analizador.Data.Entity;
using Analizador.Interfaz;
using System;

namespace Analizador.Funcionalidad.Config
{
    public class ActualizarAppSetting : IProcesar
    {
        private ParametrosEntity parametro;
        private string nombre;

        public ActualizarAppSetting(ParametrosEntity parametro)
        {
            this.parametro = parametro;
            var datos = parametro.item.Split(new string[] { "key" }, StringSplitOptions.RemoveEmptyEntries);

            if (datos?.Length > 1)
            {
                var conexion = datos[1].Split(new string[] { "value" }, StringSplitOptions.RemoveEmptyEntries);

                if (conexion?.Length > 0)
                    nombre = conexion[0].Substring(1, conexion[0].Length - 1).Replace("\"", "").Trim();
            }
        }
        public void Iniciar()
        {
            if (parametro.configparseado.appSetting.Exists(i => i.key.Trim() == nombre))
            {
                var appsetting = parametro.configparseado.appSetting.Find(i => i.key.Trim() == nombre);
                parametro.nuevosvalues.AppendLine($"<add key=\"{ appsetting.key }\" value=\"{ appsetting.value }\"/>");
            }
            else
                parametro.nuevosvalues.AppendLine(parametro.item);
           
        }
    }
}
