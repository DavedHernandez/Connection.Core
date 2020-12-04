using Analizador.Data.Entity;
using Analizador.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador.Funcionalidad.Config
{
    public class ProcesarManual : IProcesar
    {
        private ParametrosEntity parametro;
        public ProcesarManual(ParametrosEntity parametro)
        {
            this.parametro = parametro;
        }
        public void Iniciar()
        {
           
        }

        
    }
}
