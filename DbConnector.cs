using System.Configuration;

namespace MillGame
{
    internal static class DbConnector
    {
        public static string ConnectionValue()
        {
            return ConfigurationManager.ConnectionStrings["MillGame"].ConnectionString;
        }
    }
}
