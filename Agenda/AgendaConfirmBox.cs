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
        CommentModel Comment;
        AgendaComentarioBox ComentarioBox;

        public AgendaConfirmBox(CommentModel comment, AgendaComentarioBox comentarioBox)
        {
            InitializeComponent();
            Comment = comment;
            ComentarioBox = comentarioBox;
            this.CenterToScreen();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            GlobalConfig.Connection.DeleteComment_ByCommentID(Comment.CommentID);
            this.Close();
            ComentarioBox.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
