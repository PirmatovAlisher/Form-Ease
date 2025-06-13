namespace FormEase.UI.Extensions
{
    public static class ConnectionStringHandler
    {
        public static string GetProductionConnectionString()
        {
            // Parse Render's DATABASE_URL environment variable
            var databaseUrl = Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection");
            if (string.IsNullOrEmpty(databaseUrl))
                throw new Exception("ConnectionStrings__DefaultConnection environment variable is not set");

            var uri = new Uri(databaseUrl);
            var userInfo = uri.UserInfo.Split(':');

            return $"Host={uri.Host};" +
                   $"Port={uri.Port};" +
                   $"Database={uri.AbsolutePath.TrimStart('/')};" +
                   $"Username={userInfo[0]};" +
                   $"Password={userInfo[1]};" +
                   "SSL Mode=Require;" +
                   "Trust Server Certificate=true";
        }
    }
}
