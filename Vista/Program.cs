using Modelo;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                EnvironmentLoader.Load();
                EnsureDatabaseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo iniciar TechStore.{Environment.NewLine}{Environment.NewLine}{ex.Message}",
                    "Error de configuracion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            Application.Run(new frmInicio());
        }

        private static void EnsureDatabaseConnection()
        {
            using Context context = new();

            if (!context.Database.CanConnect())
            {
                throw new InvalidOperationException("No se pudo establecer la conexion a la base de datos.");
            }
        }
    }
}
