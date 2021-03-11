using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLibrary.Models
{
    class CommentModel
    {
        public int CommentID { get; set; }
        public int ClientID { get; set; }
        public string Comment { get; set; }
        public string Date { get; set; }
    }
}
