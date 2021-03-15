using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLibrary.Models
{
    public class ClientModel
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ClientModel()
        {

        }

        public ClientModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
