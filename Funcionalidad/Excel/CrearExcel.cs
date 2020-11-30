using Framework.XML.Data.Model;

using IronXL;

using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Analizador.Funcionalidad.Excel
{
    public static class CrearExcel
    {
        static HSSFWorkbook hssfworkbook;
        static void InitializeWorkbook()
        {
            hssfworkbook = new HSSFWorkbook();

            //create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "NPOI Team";
            hssfworkbook.DocumentSummaryInformation = dsi;

            //create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "NPOI SDK Example";
            hssfworkbook.SummaryInformation = si;
        }

        public static void Crear(string filesalida, List<VisualStudioModel> lstvalues)
        {
            InitializeWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("Dependencias");

            var fila = sheet.CreateRow(0);

            CrearCeldaHeaderExcel.Crear(fila, 1, "PROYECTO", ref sheet, hssfworkbook);
            CrearCeldaHeaderExcel.Crear(fila, 2, "DEPENDECIA", ref sheet, hssfworkbook);
            CrearCeldaHeaderExcel.Crear(fila, 3, "NUGET", ref sheet, hssfworkbook);
            CrearCeldaHeaderExcel.Crear(fila, 4, "VERSIÓN", ref sheet, hssfworkbook);
            CrearCeldaHeaderExcel.Crear(fila, 5, "FRAMEWORK", ref sheet, hssfworkbook);

            int index = 1;
            foreach (VisualStudioModel item in lstvalues)
            {
                var row = sheet.CreateRow(index++);

                CrearCeldaExcel.Crear(row, 1, item.VisualStudio.AssemblyName, ref sheet);

                foreach (string project in item.VisualStudio.Proyectos)
                {
                    CrearCeldaExcel.Crear(row, 2, project, ref sheet);
                    var nuget = item.Packages.FirstOrDefault();

                    if (!string.IsNullOrWhiteSpace(nuget.id))
                    {
                        CrearCeldaExcel.Crear(row, 3, nuget.id, ref sheet);
                        CrearCeldaExcel.Crear(row, 4, nuget.version, ref sheet);
                        CrearCeldaExcel.Crear(row, 5, nuget.targetFramework, ref sheet);

                        item.Packages.Remove(nuget);
                    }
                   
                    row = sheet.CreateRow(index++);
                }

                for (int i = 0; i < item.Packages.Count; i++)
                {
                    CrearCeldaExcel.Crear(row, 3, item.Packages[i].id, ref sheet);
                    CrearCeldaExcel.Crear(row, 4, item.Packages[i].version, ref sheet);
                    CrearCeldaExcel.Crear(row, 5, item.Packages[i].targetFramework, ref sheet);

                    row = sheet.CreateRow(index++);
                }

            }

            WriteToFile(filesalida);


            return;


















            WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            xlsxWorkbook.Metadata.Author = "David Hernandez";

            //Add a blank WorkSheet
            WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet("Dependencias");
            CrearFilaExcel.Crear(xlsSheet);

            //int index = 1;
            //int fila = 2;
            foreach (VisualStudioModel item in lstvalues)
            {
                ++index;
                xlsSheet[$"A{index }"].Value = item.VisualStudio.AssemblyName;

                //fila = index;
                foreach (string project in item.VisualStudio.Proyectos)
                {
                    xlsSheet[$"B{index}"].Value = project;
                    ++index;
                }

                foreach (var pack in item.Packages)
                {
                    xlsSheet[$"C{fila }"].Value = pack.id;
                    xlsSheet[$"D{fila }"].Value = pack.version + ".0"; // Se agrego el cero porque tiene un bug el nuget excel y convierte el valor a fecha
                    xlsSheet[$"E{fila }"].Value = pack.targetFramework;
                    //++fila;
                    //index = fila;
                }

            }

            //Save the excel file
            xlsxWorkbook.SaveAs(filesalida);
        }
        static void WriteToFile(string filesalida)
        {
            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(filesalida, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }


    }
}
