using Analizador.Data.Entity;
using Analizador.Funcionalidad.xml;
using Analizador.Interfaz;
using System;
using System.Text;
using XML.Core.Funcionalidad.Maping;

namespace Analizador.Funcionalidad.Config
{
    public struct ProcesarAutomatico : IProcesar
    {
        private ParametrosEntity parametro;
        private string nuevosparametros;
        public ProcesarAutomatico(ParametrosEntity parametro, string nuevosparametros)
        {
            this.parametro = parametro;
            this.nuevosparametros = nuevosparametros;
        }
        public void Iniciar()
        {
            if (string.IsNullOrWhiteSpace(nuevosparametros))
                throw new Exception("Especifique los nuevos values del config.");


            parametro.nuevosvalues = new StringBuilder();
            int index = 0;

            parametro.configparseado = new MapearConfig(Crearxml.Crear(parametro.nodoseleccionado, nuevosparametros)).Mapear();

            foreach (var item in parametro.confignodo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                parametro.item = item;

                if (index == 1)
                    Procesardatos(true); // Nuevos values.

                Procesardatos();
                index++;
            }
        }

        private void Procesardatos(bool agregar = false)
        {
            ConfigBase procesador = new ConfigBase();
            procesador.metodo = new NodoBuilder().Builder(parametro, agregar);
            procesador.Iniciarproceso();
        }
    }
}
