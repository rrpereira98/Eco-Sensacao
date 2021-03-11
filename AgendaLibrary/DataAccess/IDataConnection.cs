using AgendaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLibrary.DataAccess
{
    public interface IDataConnection
    {
        ClientModel CreateClient(ClientModel model);
        List<ClientModel> GetClient_All();
        List<ClientModel> GetClient_ByFirstName(string name);
    }
}
