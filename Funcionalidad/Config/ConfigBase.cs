using Analizador.Interfaz;

namespace Analizador.Funcionalidad.Config
{
    public class ConfigBase
    {
        public IProcesar metodo;
        public ConfigBase(IProcesar metodo)
        {
            this.metodo = metodo;
        }
        public ConfigBase()
        {

        }
        public void Iniciarproceso() => metodo.Iniciar();
       
        
    }
}
