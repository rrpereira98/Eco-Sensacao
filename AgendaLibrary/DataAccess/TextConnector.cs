using AgendaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaLibrary.DataAccess.TextHelpers;

namespace AgendaLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        private const string ClientsFile = "ClientModels.csv";
        public ClientModel CreateClient(ClientModel model)
        {
            // Load text file and Convert text to a list<ClientModel>
            List<ClientModel> clients = ClientsFile.FullFilePath().LoadFile().ConvertToClientModel();

            // Find the max id
            int currentID = 1;

            if(clients.Count > 0)
            {
                currentID = clients.OrderByDescending(x => x.ClientID).First().ClientID + 1;
            }

            model.ClientID = currentID;

            // Add the new record with the new id (max + 1)
            clients.Add(model);

            // Convert the prizes to list<string>
            // Save the list<string> to the text file
            clients.SaveToClientFile(ClientsFile);

            return model;
        }

        public CommentModel CreateComment(CommentModel model)
        {
            throw new NotImplementedException();
        }

        public void DeleteCLient_ByClientID(int clientID)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment_ByCommentID(int commentID)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClients_All()
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClient_All()
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClient_ByClientID(int clientID)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetClient_ByFirstName(string name)
        {
            throw new NotImplementedException();
        }

        public List<CommentModel> GetComment_ByClientID(int clientID)
        {
            throw new NotImplementedException();
        }
    }
}
