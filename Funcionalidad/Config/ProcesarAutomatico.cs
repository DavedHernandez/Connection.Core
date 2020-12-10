using Analizador.Data.Entity;
using Analizador.Funcionalidad.xml;
using Analizador.Interfaz;
using System;
using System.Text;
using XML.Core.Funcionalidad.Maping;

namespace Analizador.Funcionalidad.Config
{
    public class ProcesarAutomatico : IProcesar
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

            ConfigBase procesador = new ConfigBase();
            parametro.nuevosvalues = new StringBuilder();
            bool agregar = false;

            parametro.configparseado = new MapearConfig(Crearxml.Crear(parametro.nodoseleccionado, nuevosparametros)).Mapear();

            foreach (var item in parametro.confignodo.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                //procesador.MetodoBuilder(new ParametrosEntity { item = item, contenidoxml = contenidoxml, nodoseleccionado = nodoseleccionado, nuevoxml = nuevoxml });
                parametro.item = item;
                procesador.metodo = new NodoBuilder().Builder(parametro);
                procesador.Iniciarproceso();

                if (agregar)
                {
                    procesador.metodo = new AgregarAppSetting(parametro);
                    procesador.Iniciarproceso();
                    agregar = false;
                }
            }

        }
    }
}
