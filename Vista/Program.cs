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
            // Cargamos las variables de entorno desde el archivo .env
            DotNetEnv.Env.Load("./.env");
            DotNetEnv.Env.Load("./../.env");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmInicio());
        }
    }
}