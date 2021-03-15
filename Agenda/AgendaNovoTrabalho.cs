using AgendaLibrary;
using AgendaLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaNovoTrabalho : Form
    {
        ClientModel Client;

        public AgendaNovoTrabalho(ClientModel client)
        {
            InitializeComponent();
            Client = client;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxComentario.Text != "")
            {
                CommentModel comment = new CommentModel(Client.ClientID, textBoxComentario.Text);
                GlobalConfig.Connection.CreateComment(comment);

                openChildForm(new AgendaComentario($"{ Client.FirstName } { Client.LastName }"));
            }
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

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
    }
}
