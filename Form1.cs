using Analizador.Funcionalidad.Excel;
using Analizador.Funcionalidad.VisualStudio;

using Framework.XML.Data.Entity.VisualStudio;
using Framework.XML.Data.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Analizador
{
    public partial class Form1 : Form
    {
        static List<VisualStudioModel> lstProyectos;
        public Form1()
        {
            InitializeComponent();
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
    }
}
