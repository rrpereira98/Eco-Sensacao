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
    public partial class AgendaConfirmBox : Form
    {
        string ClientID;
        CommentModel Comment;
        AgendaComentarioBox ComentarioBox;

        public AgendaConfirmBox(CommentModel comment, AgendaComentarioBox comentarioBox)
        {
            InitializeComponent();
            Comment = comment;
            ComentarioBox = comentarioBox;
            this.CenterToScreen();
        }

        public AgendaConfirmBox(string clientID)
        {
            InitializeComponent();
            ClientID = clientID;
            this.CenterToScreen();

            labelTitle.Text = "Tem a Certeza Que Quer Apagar Este Cliente?";
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            if (Comment != null)
            {
                GlobalConfig.Connection.DeleteComment_ByCommentID(Comment.CommentID);
                this.Close();
                ComentarioBox.Close();
            }
            else if(ClientID != null)
            {
                GlobalConfig.Connection.DeleteCLient_ByClientID(int.Parse(ClientID));
                openChildForm(new AgendaDashboardform());
                this.Close();
            }
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
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
            AgendaDashboardform.ActiveForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
