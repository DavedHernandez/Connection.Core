using Analizador.Data.Entity;
using Analizador.Interfaz;
using System.Text;

namespace Analizador.Funcionalidad.Config
{
    public struct ProcesarManual : IProcesar
    {
        private ParametrosEntity parametro;
        private string contenido;
        public ProcesarManual(ParametrosEntity parametro,string contenido)
        {
            this.parametro = parametro;
            this.contenido = contenido;
        }
        public void Iniciar()
        {
            parametro.nuevosvalues = new StringBuilder();
            parametro.nuevosvalues.AppendLine(contenido);
        }

        
    }
}
