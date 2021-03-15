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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class AgendaComentario : Form
    {
        ClientModel model = new ClientModel();
        string filePath = @"C:\Users\rodri\OneDrive\Ambiente de Trabalho\Comentarios.txt";
        private bool wasEdited = false;

        public AgendaComentario(String Client)
        {
            InitializeComponent();
            LoadClientData(Client);
        }

        private void LoadClientData(string Client)
        {
            string[] entries = Client.Split(' ');

            model = GlobalConfig.Connection.GetClient_ByFirstName(entries[0])[0];
            labelNome.Text = $"{ model.FirstName } { model.LastName }";

            List<CommentModel> comments = GlobalConfig.Connection.GetComment_ByClientID(model.ClientID);
            foreach (CommentModel comment in comments)
            {
                Form form = new AgendaComentarioBox(comment, this);
                form.Name = $"form_{model.ClientID}";
                form.Dock = DockStyle.Top;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;

                panelGroup.Controls.Add(form);
                this.Tag = form;
                form.BringToFront();
                form.Show();

                Panel margin = new Panel();
                margin.Size = new Size(50, 3);
                margin.BackColor = Color.FromArgb(1, 225, 225, 225);
                margin.Dock = DockStyle.Top;
                panelGroup.Controls.Add(margin);
                margin.BringToFront();
                margin.Show();
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
            openChildForm(new AgendaNovoTrabalho(model));
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
