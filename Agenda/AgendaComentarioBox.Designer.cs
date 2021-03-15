
namespace Agenda
{
    partial class AgendaComentarioBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaComentarioBox));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonRemoveComment = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.labelComment);
            this.panel2.Controls.Add(this.buttonRemoveComment);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 93);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(111, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 96);
            this.panel3.TabIndex = 6;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDate.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.labelDate.Location = new System.Drawing.Point(0, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(113, 93);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "label1";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRemoveComment
            // 
            this.buttonRemoveComment.BackColor = System.Drawing.Color.IndianRed;
            this.buttonRemoveComment.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemoveComment.Location = new System.Drawing.Point(555, 0);
            this.buttonRemoveComment.Name = "buttonRemoveComment";
            this.buttonRemoveComment.Size = new System.Drawing.Size(20, 93);
            this.buttonRemoveComment.TabIndex = 9;
            this.buttonRemoveComment.UseVisualStyleBackColor = false;
            this.buttonRemoveComment.Click += new System.EventHandler(this.buttonRemoveComment_Click);
            // 
            // labelComment
            // 
            this.labelComment.BackColor = System.Drawing.Color.Transparent;
            this.labelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelComment.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComment.Location = new System.Drawing.Point(113, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(442, 93);
            this.labelComment.TabIndex = 10;
            this.labelComment.Text = resources.GetString("labelComment.Text");
            this.labelComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AgendaComentarioBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(579, 97);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaComentarioBox";
            this.Text = "AgendaComentarioBox";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonRemoveComment;
    }
}