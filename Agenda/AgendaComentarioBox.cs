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
    public partial class AgendaComentarioBox : Form
    {
        CommentModel Comment;
        Form Parent;

        public AgendaComentarioBox(CommentModel comment, Form parent)
        {
            InitializeComponent();
            Comment = comment;
            Parent = parent;
            labelComment.Text = comment.Comment;
            labelDate.Text = comment.Date;
        }

        private void buttonRemoveComment_Click(object sender, EventArgs e)
        {
            openChildForm(new AgendaConfirmBox(Comment, this));
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            Parent.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
