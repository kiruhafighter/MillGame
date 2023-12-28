using Dapper;
using Microsoft.Data.SqlClient;
using MillGame.Entities;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MillGame.DataAccess.Repositories
{
    internal sealed class PlayerRepository
    {
        public bool CreateUser(string username)
        {
            string query = @"Insert Into Players (Name, Wins, Losses, Draws)
                                          Values (@Username, 0, 0, 0)";

            var parameters = new { Username = username };

            using (DbConnection connection = new SqlConnection(DbConnector.ConnectionValue()))
            {
                var create = connection.Execute(query, parameters);

                if (create < 1)
                {
                    return false;
                }

                return true;
            }
        }

        public bool UserExists(string username)
        {
            var query = "Select * from Players Where Name = @Username";

            var parameters = new DynamicParameters();
            parameters.Add("Username", username);

            using DbConnection connection = new SqlConnection(DbConnector.ConnectionValue());

            var player = connection.QueryFirstOrDefault<Player>(query, parameters);

            if (player == null)
            {
                return false;
            }

            return true;
        }

        public bool UserWinsRecordChange(string username)
        {
            string query = @"Update Players SET Wins=Wins + 1 
                             Where Name = @Name";

            var parameters = new DynamicParameters();
            parameters.Add("Name", username);

            using DbConnection connection = new SqlConnection(DbConnector.ConnectionValue());

            var update = connection.Execute(query, parameters);

            if (update < 1)
            {
                return false;
            }

            return true;
        }

        public bool UserLosesRecordChange(string username)
        {
            string query = @"Update Players SET Losses=Losses + 1 
                             Where Name = @Name";

            var parameters = new DynamicParameters();
            parameters.Add("Name", username);

            using DbConnection connection = new SqlConnection(DbConnector.ConnectionValue());

            var update = connection.Execute(query, parameters);

            if (update < 1)
            {
                return false;
            }

            return true;
        }

        public bool UserDrawsRecordChange(string username)
        {
            string query = @"Update Players SET Draws=Draws + 1 
                             Where Name = @Name";

            var parameters = new DynamicParameters();
            parameters.Add("Name", username);

            using DbConnection connection = new SqlConnection(DbConnector.ConnectionValue());

            var update = connection.Execute(query, parameters);

            if (update < 1)
            {
                return false;
            }

            return true;
        }

        public List<Player>? GetScoreboard()
        {
            var query = @"Select * from Players
                          Order by Wins DESC, Losses, Draws DESC";

            using DbConnection connection = new SqlConnection(DbConnector.ConnectionValue());

            return connection.Query<Player>(query).ToList();
        }
    }
}
