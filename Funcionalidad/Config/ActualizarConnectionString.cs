using Analizador.Data.Entity;
using Analizador.Interfaz;
using System;

namespace Analizador.Funcionalidad.Config
{
    public class ActualizarConnectionString : IProcesar
    {
        private ParametrosEntity parametro;
        string nombre = string.Empty;

        public ActualizarConnectionString(ParametrosEntity parametro)
        {
            this.parametro = parametro;
            var datos = parametro.item.Split(new string[] { "name" }, StringSplitOptions.RemoveEmptyEntries);

            if (datos?.Length > 1)
            {
                var conexion = datos[1].Split(new string[] { "connectionString" }, StringSplitOptions.RemoveEmptyEntries);
              
                if (conexion?.Length > 1)
                    nombre = conexion[0].Substring(1, conexion[0].Length - 1).Replace("\"", "").Trim();
            }
        }

        public void Iniciar()
        {
            if (parametro.configparseado.connectionStrings.Exists(i => i.name.Trim() == nombre))
            {
                var appsetting = parametro.configparseado.connectionStrings.Find(i => i.name.Trim() == nombre);
                parametro.nuevosvalues.AppendLine(string.Format("<add name=\"{0}\" connectionString=\"{1}", appsetting.name, appsetting.connectionString));
            }
            else
                parametro.nuevosvalues.AppendLine(parametro.item);


        }
    }
}

