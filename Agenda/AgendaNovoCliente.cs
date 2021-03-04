using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda
{
    public partial class AgendaNovoCliente : Form
    {
        string filePath = @"C:\Users\rodri\OneDrive\Ambiente de Trabalho\Clientes.txt";
        public AgendaNovoCliente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarCliente_Click(object sender, EventArgs e)
        {
            String nameFirstLetter = textBoxPrimeiroNome.Text.Substring(0, 1);
            String nameRest = textBoxPrimeiroNome.Text.Substring(1);
            string name = nameFirstLetter.ToUpper() + nameRest.ToLower();

            String surnameFirstLetter = textBoxUltimoNome.Text.Substring(0, 1);
            String surnameRest = textBoxUltimoNome.Text.Substring(1);
            string surname = surnameFirstLetter.ToUpper() + surnameRest.ToLower();

            StreamWriter sw = new StreamWriter(filePath, true);
            sw.WriteLine($"{name},{surname}");
            sw.Close();
        }
    }
}
