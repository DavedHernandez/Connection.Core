using NPOI.SS.UserModel;

namespace Analizador.Funcionalidad.Excel
{
    public struct CrearCeldaExcel 
    {
        public static void Crear(IRow fila, int indexcelda, string value, ref ISheet sheet)
        {
            var cell = fila.CreateCell(indexcelda);

            cell.SetCellValue(value);
            sheet.AutoSizeColumn(indexcelda);
        }
    }
}
