using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace Analizador.Funcionalidad.Excel
{
    public struct CrearCeldaHeaderExcel
    {

        public static void Crear(IRow fila, int columnaIndex, string value, ref ISheet sheet, HSSFWorkbook hssfworkbook)
        {
            //font style1: underlined, italic, red color, fontsize=20
            IFont font = hssfworkbook.CreateFont();
            font.Color = HSSFColor.DarkBlue.Index;
            font.IsItalic = true;
            font.Boldweight = (short)FontBoldWeight.Bold;
            font.Underline = FontUnderlineType.DoubleAccounting;
            font.FontHeightInPoints = 9;
            font.FontName = "Abadi";


            ICellStyle estilo = hssfworkbook.CreateCellStyle();
            estilo.BorderBottom = BorderStyle.Thin;
            estilo.BottomBorderColor = IndexedColors.Orange.Index;

            estilo.SetFont(font);

            //apply font styles
            ICell cell1 = CellUtil.CreateCell(fila, columnaIndex, value);
            cell1.CellStyle = estilo;

            
            sheet.AutoSizeColumn(columnaIndex);
        }
    }
}
