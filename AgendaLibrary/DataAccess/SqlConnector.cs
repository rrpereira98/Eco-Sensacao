using AgendaLibrary.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//@FirstName nvarchar(100),
//@LastName nvarchar(100),
//@id int = 0 output

namespace AgendaLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        private const string db = "Eco-Sensacao";
        // TODO - make the createClient method actually save to the databae
        // Saves new client to the database
        public ClientModel CreateClient(ClientModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClient_Insert", p, commandType:CommandType.StoredProcedure);

                model.ClientID = p.Get<int>("@id");

                return model;
            }
        }

        public CommentModel CreateComment(CommentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ClientID", model.ClientID);
                p.Add("@Comment", model.Comment);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spComment_Insert", p, commandType: CommandType.StoredProcedure);

                model.CommentID = p.Get<int>("@id");

                return model;
            }
        }

        public List<ClientModel> GetClient_All()
        {
            List<ClientModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClientModel>("dbo.spClient_GetAll").ToList();
            }

            return output;
        }

        public List<ClientModel> GetClient_ByFirstName(string name)
        {
            List<ClientModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<ClientModel>($"select * from Client where FirstName = '{name}'").ToList();
            }

            return output;
        }

        public List<CommentModel> GetComment_ByClientID(int clientID)
        {
            List<CommentModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<CommentModel>($"select * from Comment where ClientID = '{clientID}'").ToList();
            }

            return output;
        }

        public void DeleteComment_ByCommentID(int commentID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                connection.Query<CommentModel>($"DELETE FROM Comment WHERE CommentID = '{commentID}'");
            }
        }
    }
}
