using Analizador.Data.Entity;
using Analizador.Forms;
using Analizador.Funcionalidad.Config;
using Analizador.Funcionalidad.Excel;
using Analizador.Funcionalidad.VisualStudio;
using Analizador.Funcionalidad.xml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using XML.Core.Data.Entity.VisualStudio;
using XML.Core.Data.Model;
using XML.Core.Funcionalidad.Maping;

namespace Analizador
{
    public partial class Form1 : Form
    {
        static List<VisualStudioModel> lstProyectos;
        private ConfigModel config;
        private List<ConfigNodoEntity> lstnodos;
        private ParametrosEntity parametro;

        public Form1()
        {
            InitializeComponent();

            lstnodos = new List<ConfigNodoEntity>();
            parametro = new ParametrosEntity();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (viewFolder.ShowDialog() == DialogResult.OK)
            {
                txtruta.Text = viewFolder.SelectedPath;
                lstProyectos = AnalizarProject.Analizar(viewFolder.SelectedPath);

                gridPrincipal.DataSource = (from VisualStudioModel item in lstProyectos
                                            select item.VisualStudio).ToList();

                gridDetalle.DataSource = null;
                gvExternos.DataSource = null;
                gvProyectos.DataSource = null;
                gvConfiguracion.DataSource = null;
                lblConexion.Text = "";
                btnExportar.Enabled = lstProyectos.Any();
                rbConfig.Checked = false;

            }
        }


        private void gridPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lstProyectos?.Any() == true && e.RowIndex > -1)
            {
                var proyecto = lstProyectos.Find(i => i.VisualStudio.AssemblyName == gridPrincipal.Rows[e.RowIndex].Cells["AssemblyName"].Value.ToString());

                gridDetalle.DataSource = proyecto.Packages.OrderBy(x => x.targetFramework).ToList();
                gvProyectos.DataSource = (from object item in proyecto.VisualStudio.Proyectos select new { Proyecto = item }).ToList();

                List<PackagesEntity> nugets = new List<PackagesEntity>();
                foreach (var item in lstProyectos)
                {
                    nugets.AddRange(item.Packages);
                }

                gvExternos.DataSource = (from PackagesEntity item in nugets.GroupBy(i => i.id).Select(x => x.First())
                                         where !item.id.Contains("Microsoft") && !item.id.Contains("System") && !item.id.Contains("Test")
                                         select item).OrderBy(p => p.id).ToList();

                rbConfig.Checked = proyecto.ValuesConfig.Any();

                if (rbConfig.Checked)
                {
                    lblConexion.Text = proyecto.ValuesConfig.First().connectionStrings;
                    gvConfiguracion.DataSource = (from ConfigEntity item in proyecto.ValuesConfig select new { Key = item.key, Value = item.value }).OrderBy(i => i.Value).ToList();
                }
                else
                {
                    gvConfiguracion.DataSource = null;
                    lblConexion.Text = "";
                }

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (viewFolder.ShowDialog() == DialogResult.OK)
            {
                string carpeta = Path.GetFileName(txtruta.Text) + ".xls";

                CrearExcel.Crear(Path.Combine(viewFolder.SelectedPath, carpeta), lstProyectos);
                MessageBox.Show("Archivo generado");
            }
        }

        private void btnCargarConfig_Click(object sender, EventArgs e)
        {
            if (selectFile.ShowDialog() == DialogResult.OK)
            {
                txtRutaconfig.Text = selectFile.FileName;
                config = new MapearConfig(XDocument.Load(txtRutaconfig.Text)).Mapear();

                txtConfigOriginal.Clear();
                cmbNodos.Items.Clear();
                cmbNodos.Items.AddRange((from x in config.nodos select x.name).ToArray());


                lstnodos = new List<ConfigNodoEntity>();
                parametro = new ParametrosEntity();
            }
        }

        private void cmbNodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (config != null)
            {
                string seleccion = ((ComboBox)sender).Text;
                bool automatico = seleccion.ToLower() == "appsettings" || seleccion.ToLower() == "connectionstrings";

                txtConfigOriginal.Text = !lstnodos.Exists(i => i.name == seleccion) ?
                    config.nodos.Find(i => i.name == seleccion).content : lstnodos.Find(i => i.name == seleccion).content;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (config != null)
                {

                    string nodoseleccionado = cmbNodos.Text;

                    if (string.IsNullOrWhiteSpace(nodoseleccionado))
                    {
                        MessageBox.Show("Seleccione un nodo");
                        return;
                    }

                    StringBuilder contenidoxml = new StringBuilder();
                    IniciarParametros();

                    new ProcesarManual(parametro, txtConfigOriginal.Text).Iniciar();
                    txtConfigOriginal.Text = parametro.nuevosvalues.ToString();

                    AgregarNodo.Agregar(lstnodos, nodoseleccionado, txtConfigOriginal.Text);
                    MessageBox.Show($"Se actualizo el nodo: {nodoseleccionado}");

                    RestablecerControl();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private ParametrosEntity IniciarParametros()
        {
            parametro.nodoseleccionado = cmbNodos.Text;
            parametro.confignodo = txtConfigOriginal.Text;
            parametro.config = config;
            return parametro;
        }

        private void btnExportarxml_Click(object sender, EventArgs e)
        {
            if (!lstnodos.Any())
                MessageBox.Show("Modifique el .config para iniciar la descarga..");
            else if (viewFolder.ShowDialog() == DialogResult.OK)
            {
                string nombre = Path.GetFileName(txtRutaconfig.Text);
                string ruta = Path.Combine(viewFolder.SelectedPath, nombre);

                ExportarConfig.Exportar(lstnodos, config, ruta);
                ExportarConfigtmp.Exportar(lstnodos, ruta);

                MessageBox.Show($"Exportado en: {ruta}");
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            lstnodos.RemoveAll(i => i.name == cmbNodos.Text);
            RestablecerControl();
            txtConfigOriginal.Text = config.nodos.Find(i => i.name == cmbNodos.Text).content;
        }

        private void RestablecerControl()
        {
            txtConfigOriginal.ReadOnly = true;
            txtConfigOriginal.ForeColor = System.Drawing.Color.FromArgb(105, 154, 231);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string seleccion = cmbNodos.Text;
            bool automatico = seleccion.ToLower() == "appsettings" || seleccion.ToLower() == "connectionstrings";

            txtConfigOriginal.ReadOnly = automatico;
            txtConfigOriginal.ForeColor = !automatico ? System.Drawing.Color.FromArgb(97, 205, 223) : System.Drawing.Color.FromArgb(105, 154, 231);

            if (automatico)
            {
                FormConfigDetalle detalle = new FormConfigDetalle(IniciarParametros());
                detalle.ShowDialog();

                if (!string.IsNullOrWhiteSpace(parametro.nuevosvalues.ToString()))
                {
                    txtConfigOriginal.Text = parametro.nuevosvalues.ToString();
                    AgregarNodo.Agregar(lstnodos, parametro.nodoseleccionado, txtConfigOriginal.Text);
                    MessageBox.Show($"Se actualizo el nodo: {parametro.nodoseleccionado}");
                }
            }
        }
    }
}
