using System.Windows.Forms;

namespace Vista
{
    internal static class FormatoMoneda
    {
        private const string FormatoPesos = "$ #,##0.00";

        public static string Texto(decimal monto)
        {
            return monto.ToString(FormatoPesos);
        }

        public static void Aplicar(DataGridViewColumn? columna)
        {
            if (columna == null)
                return;

            columna.DefaultCellStyle.Format = FormatoPesos;
        }
    }
}
