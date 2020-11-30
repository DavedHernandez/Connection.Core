using IronXL;

using NPOI.SS.UserModel;

namespace Analizador.Funcionalidad.Excel
{
    public static class CrearFilaExcel
    {
        public static void Crear(WorkSheet xlsSheet)
        {
            AplicarFormato(xlsSheet, "A1", "PROYECTO");
            AplicarFormato(xlsSheet, "B1", "DEPENDECIA");
            AplicarFormato(xlsSheet, "C1", "NUGET");
            AplicarFormato(xlsSheet, "D1", "VERSIÓN");
            AplicarFormato(xlsSheet, "E1", "FRAMEWORK");
        }

        private static void AplicarFormato(WorkSheet xlsSheet, string celda, string value)
        {
            xlsSheet[celda].Value = value;
            xlsSheet[celda].Style.BottomBorder.SetColor("#ff6600");
            xlsSheet[celda].Style.BottomBorder.Type = IronXL.Styles.BorderType.Double;
        }

        internal static IRow Crear(ref ISheet sheet, int indexFila)
        {
            return sheet.CreateRow(indexFila);
        }
    }
}
