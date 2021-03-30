using AgendaLibrary;
using AgendaLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaClientes : Form
    {
        string firstName;
        string lastName;
        string id;

        List<ClientModel> Clients = GlobalConfig.Connection.GetClient_All();

        public AgendaClientes()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            foreach (ClientModel client in Clients)
            {
                firstName = client.FirstName;
                lastName = client.LastName;
                id = client.ClientID.ToString();
                CreateBtn();
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            panelClientBox.Controls.Clear();

            int value;
            if (textBoxPesquisa.Text.Length == 0)
            {
                Clients = GlobalConfig.Connection.GetClient_All();
            }
            else if (int.TryParse(textBoxPesquisa.Text, out value))
            {
                Clients = GlobalConfig.Connection.GetClient_ByClientID(int.Parse(textBoxPesquisa.Text));
            }
            else
            {
                Clients = GlobalConfig.Connection.GetClient_ByFirstName(textBoxPesquisa.Text);
            }

            foreach (ClientModel client in Clients)
            {
                firstName = client.FirstName;
                lastName = client.LastName;
                id = client.ClientID.ToString();
                CreateBtn();
            }

            textBoxPesquisa.Text = "";
        }

        private void CreateBtn()
        {
            // Make buttons for results
            Button btn = new Button();
            btn.Name = $"{ firstName }{ lastName }";
            btn.Location = new Point(3, 16);
            btn.Size = new Size(110, 97);
            btn.Dock = DockStyle.Top;
            btn.Image = Agenda.Properties.Resources.icons8_user_60px_1;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.Font = new Font("Nirmala UI", 22);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.ImageAlign = ContentAlignment.MiddleRight;
            btn.Text = $"{id}  { firstName } { lastName }";
            btn.Tag = id;

            btn.Click += new EventHandler(button_Click);

            panelClientBox.Controls.Add(btn);
        }

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            openChildForm(new AgendaComentario(btn.Tag.ToString()));
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

            private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private Form activeNotification = null;
        public void FailNotification(Form childForm)
        {
            if (activeNotification != null)
                activeNotification.Close();

            activeNotification = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            childForm.BackColor = Color.IndianRed;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            childForm.Controls.OfType<Label>().First().Text = "Pesquisa Não Pode Estar Vazia";
        }

        private void textBoxPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonPesquisar.PerformClick();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
