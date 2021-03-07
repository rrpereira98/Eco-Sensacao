﻿using System;
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
        string filePath = @"C:\Users\rodri\OneDrive\Ambiente de Trabalho\Clientes.txt";
        string client;
        string[] entries;
        Person newPerson;
        string name;

        public AgendaClientes()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            panelClientBox.Controls.Clear();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            string[] nameEntries = textBoxPesquisa.Text.Split(' ');

            if (textBoxPesquisa.Text == " " || textBoxPesquisa.Text == "")
            {
                FailNotification(new AgendaNotification());
                return;
            }
            else if (nameEntries.Length == 1)
            {
                String nameFirstLetter = nameEntries[0].Substring(0, 1);
                String nameRest = nameEntries[0].Substring(1);
                name = nameFirstLetter.ToUpper() + nameRest.ToLower();
            }
            else if (nameEntries.Length == 2)
            {
                String nameFirstLetter = nameEntries[0].Substring(0, 1);
                String nameRest = nameEntries[0].Substring(1);
                String surnameFirstLetter = nameEntries[1].Substring(0, 1);
                String surnameRest = nameEntries[1].Substring(1);
                name = nameFirstLetter.ToUpper() + nameRest.ToLower() + " " + surnameFirstLetter.ToUpper() + surnameRest.ToLower();
            }

            if (nameEntries.Length == 1 || nameEntries.Length == 2)
            {
                foreach (string line in lines)
                {
                    string[] entries = name.Split(' ');

                    if (line.Contains(entries[0]) && entries.Length == 1)
                    {
                        entries = CreateBtn(line);
                    }
                    else if (line.Contains(entries[0]) && line.Contains(entries[1]) && entries.Length == 2)
                    {
                        entries = CreateBtn(line);
                    }
                }
            }
        }

        private string[] CreateBtn(string line)
        {
            string[] entries;
            client = line;

            entries = client.Split(',');
            newPerson = new Person();
            newPerson.FirstName = entries[0];
            newPerson.LastName = entries[1];

            // Make buttons for results
            Button btn = new Button();
            btn.Name = "btnClient";
            btn.Location = new Point(3, 16);
            btn.Size = new Size(110, 97);
            btn.Dock = DockStyle.Top;
            btn.Image = Agenda.Properties.Resources.icons8_user_60px;
            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.Font = new Font("Nirmala UI", 20);
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = $"{newPerson.FirstName} { newPerson.LastName }";

            btn.Click += new EventHandler(button_Click);

            panelClientBox.Controls.Add(btn);
            return entries;
        }

        private void panelCliente_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
         
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //AgendaComentario agendaComentario = new AgendaComentario(btn.Text);
            //agendaComentario.ShowDialog();
            openChildForm(new AgendaComentario(btn.Text));
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
    }
}
