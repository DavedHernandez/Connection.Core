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

            //bool actualizar = false;

            //var key = parametro.item.Split(new string[] { "key" }, StringSplitOptions.RemoveEmptyEntries);

            //actualizar = !(key?.Length == 1);

            //if (actualizar)
            //{
            //    var value = key[1].Split(new string[] { "value" }, StringSplitOptions.RemoveEmptyEntries);

            //    if (value?.Length > 1)
            //    {
            //        string llave = value[0].Substring(1, value[0].Length - 1).Replace("\"", "").Trim();
            //        var appsetting = parametro.configparseado.appSetting.Find(i => i.key.Trim() == llave);

            //        actualizar = !string.IsNullOrWhiteSpace(appsetting?.key);

            //        if (actualizar)
            //            parametro.nuevosvalues.AppendLine($"<add key=\"{ appsetting.key }\" value=\"{ appsetting.value }\"/>");
            //        else
            //            parametro.nuevosvalues.AppendLine(parametro.item);
            //    }
            //}
            //else
            //    parametro.nuevosvalues.AppendLine(parametro.item);


        }
    }
}
