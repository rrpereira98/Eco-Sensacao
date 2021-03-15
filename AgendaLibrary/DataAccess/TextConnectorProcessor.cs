using AgendaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<ClientModel> ConvertToClientModel(this List<string> lines)
        {
            List<ClientModel> output = new List<ClientModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                ClientModel c = new ClientModel();
                c.ClientID = int.Parse(cols[0]);
                c.FirstName = cols[1];
                c.LastName = cols[2];
                output.Add(c);
            }

            return output;
        }

        public static void SaveToClientFile(this List<ClientModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ClientModel c in models)
            {
                lines.Add($"{ c.ClientID },{ c.FirstName },{ c.LastName }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
