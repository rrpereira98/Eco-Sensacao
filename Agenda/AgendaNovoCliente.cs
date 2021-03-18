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
using AgendaLibrary;
using AgendaLibrary.Models;
using AgendaLibrary.DataAccess;

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
            if (ValidateForm())
            {
                ClientModel model = new ClientModel(textBoxPrimeiroNome.Text, textBoxUltimoNome.Text, textBoxMobile.Text);

                
                GlobalConfig.Connection.CreateClient(model);
                

                textBoxPrimeiroNome.Text = "";
                textBoxUltimoNome.Text = "";
                textBoxMobile.Text = "";
                SuccessNotification(new AgendaNotification());
            }
            else
            {
                FailNotification(new AgendaNotification());
            }
        }

        bool ValidateForm()
        {
            bool output = true;

            if (textBoxPrimeiroNome.Text.Length == 0 || textBoxUltimoNome.Text.Length == 0)
                output = false;
            
            int value;
            if (!int.TryParse(textBoxMobile.Text, out value))
                output = false;

            return output;
        }

        private void CreateNewClient()
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

            textBoxPrimeiroNome.Text = null;
            textBoxUltimoNome.Text = null;
        }

        private Form activeForm = null;
        public void SuccessNotification(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void FailNotification(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            childForm.BackColor = Color.IndianRed;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            childForm.Controls.OfType<Label>().First().Text = "Erro a Criar Cliente";
        }
    }
}
