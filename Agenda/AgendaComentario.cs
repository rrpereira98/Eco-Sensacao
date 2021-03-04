using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaComentario : Form
    {
        string personName;
        string filePath = @"C:\Users\rodri\OneDrive\Ambiente de Trabalho\Comentarios.txt";
        private bool wasEdited = false;

        public AgendaComentario(String person)
        {
            InitializeComponent();
            personName = person;
            labelNome.Text = person;

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                if (line.Contains(personName))
                {
                    string[] entries = line.Split('£');
                    textBoxComentario.Text = entries[1];
                }
            }
        }

        private void textBoxComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (File.ReadAllText(filePath).Contains(personName))
            {
                string clientLine = "111";
                List<string> lines = File.ReadAllLines(filePath).ToList();

                foreach (string line in lines)
                {
                    if (line.Contains(personName))
                    {
                        clientLine = line;
                    }
                }

                string strFile = File.ReadAllText(filePath);
                strFile = Regex.Replace(strFile, clientLine, $"{personName}£{textBoxComentario.Text}");
                File.WriteAllText(filePath, strFile);

                wasEdited = true;

            }
            

            if (!wasEdited)
            {
                StreamWriter sw = new StreamWriter(filePath, true);
                sw.WriteLine($"{personName}£{textBoxComentario.Text}");
                sw.Close();
            }

            this.Close();
        }
    }
}
