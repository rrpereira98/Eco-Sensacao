using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLibrary.Models
{
    public class CommentModel
    {
        public int CommentID { get; set; }
        public int ClientID { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }

        public CommentModel()
        {

        }

        public CommentModel(int clientID, string comment)
        {
            ClientID = clientID;
            Comment = comment;
        }
    }
}
