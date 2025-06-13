using Npgsql;

namespace FormEase.UI.Extensions
{
    public static class ConnectionStringHandler
    {
        public static string GetRenderConnectionString()
        {
            var databaseUrl = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
            if (string.IsNullOrEmpty(databaseUrl))
                throw new Exception("ConnectionStrings__DefaultConnection environment variable is not set");

            // Parse using Uri and handle different formats
            var uri = new Uri(databaseUrl);
            var userInfo = uri.UserInfo.Split(':');

            // Validate components
            if (userInfo.Length != 2)
                throw new FormatException("Invalid ConnectionStrings__DefaultConnection format - user info missing");

            if (string.IsNullOrEmpty(uri.Host))
                throw new FormatException("Invalid ConnectionStrings__DefaultConnection format - host missing");

            // Default to 5432 if port is missing
            var port = uri.Port > 0 ? uri.Port : 5432;

            // Get database name from path
            var database = uri.AbsolutePath.TrimStart('/');
            if (string.IsNullOrEmpty(database))
                throw new FormatException("Invalid ConnectionStrings__DefaultConnection format - database name missing");

            // Build connection string
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = uri.Host,
                Port = port,
                Database = database,
                Username = userInfo[0],
                Password = userInfo[1],
                SslMode = SslMode.Require,
                TrustServerCertificate = true,
                Pooling = true,
                // Reduce timeouts for Render environment
                Timeout = 15,
                CommandTimeout = 15
            };

            return builder.ToString();
        }
    }
}
