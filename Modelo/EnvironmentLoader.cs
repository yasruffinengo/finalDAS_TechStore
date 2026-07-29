namespace Modelo
{
    public static class EnvironmentLoader
    {
        private static readonly object Lock = new();
        private static bool loaded;
        private static string? loadedPath;

        public static string Load()
        {
            lock (Lock)
            {
                if (loaded)
                {
                    return loadedPath!;
                }

                string? envPath = FindEnvFile();
                if (envPath == null)
                {
                    throw new InvalidOperationException(
                        "No se encontro el archivo .env. Crealo en la carpeta raiz de la solucion o junto al ejecutable."
                    );
                }

                DotNetEnv.Env.Load(envPath);
                loadedPath = envPath;
                loaded = true;

                return envPath;
            }
        }

        public static string GetRequiredVariable(string variableName)
        {
            Load();

            string? value = Environment.GetEnvironmentVariable(variableName);
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidOperationException(
                    $"No se encontro la variable de entorno {variableName}. Revisa el archivo .env."
                );
            }

            return value;
        }

        private static string? FindEnvFile()
        {
            HashSet<string> visitedDirectories = new(StringComparer.OrdinalIgnoreCase);
            string? envPath = FindEnvFileFrom(AppContext.BaseDirectory, visitedDirectories);

            return envPath ?? FindEnvFileFrom(Directory.GetCurrentDirectory(), visitedDirectories);
        }

        private static string? FindEnvFileFrom(string startPath, HashSet<string> visitedDirectories)
        {
            DirectoryInfo? directory = new(startPath);

            while (directory != null)
            {
                if (!visitedDirectories.Add(directory.FullName))
                {
                    directory = directory.Parent;
                    continue;
                }

                string envPath = Path.Combine(directory.FullName, ".env");
                if (File.Exists(envPath))
                {
                    return envPath;
                }

                directory = directory.Parent;
            }

            return null;
        }
    }
}
