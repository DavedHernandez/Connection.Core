using Analizador.Data.Entity;
using Analizador.Funcionalidad.Config;
using System;
using System.Windows.Forms;

namespace Analizador.Forms
{
    public partial class FormConfigDetalle : Form
    {
        public static string texto;
        private ParametrosEntity parametro;
        public FormConfigDetalle(ParametrosEntity parametro)
        {
            this.parametro = parametro;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            new ProcesarAutomatico(parametro, txtReemplazar.Text).Iniciar();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
