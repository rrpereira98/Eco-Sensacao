
namespace Agenda
{
    partial class AgendaComentario
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panelGroup = new System.Windows.Forms.Panel();
            this.labelID = new System.Windows.Forms.Label();
            this.labelMobile = new System.Windows.Forms.Label();
            this.labelNameField = new System.Windows.Forms.Label();
            this.labelIDField = new System.Windows.Forms.Label();
            this.labelMobileField = new System.Windows.Forms.Label();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(118, 51);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome:";
            this.labelNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitulo.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(0, 155);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(723, 45);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Ultimos Trabalhos:";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(260, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(204, 49);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Novo Trabalho";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelGroup
            // 
            this.panelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGroup.AutoScroll = true;
            this.panelGroup.Location = new System.Drawing.Point(12, 208);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Size = new System.Drawing.Size(699, 260);
            this.panelGroup.TabIndex = 4;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 60);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(300, 51);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "Nº de Identificação:";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMobile
            // 
            this.labelMobile.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(12, 111);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(262, 51);
            this.labelMobile.TabIndex = 0;
            this.labelMobile.Text = "Nº de Telemóvel:";
            this.labelMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNameField
            // 
            this.labelNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameField.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameField.Location = new System.Drawing.Point(136, 9);
            this.labelNameField.Name = "labelNameField";
            this.labelNameField.Size = new System.Drawing.Size(575, 51);
            this.labelNameField.TabIndex = 0;
            this.labelNameField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIDField
            // 
            this.labelIDField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDField.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDField.Location = new System.Drawing.Point(318, 60);
            this.labelIDField.Name = "labelIDField";
            this.labelIDField.Size = new System.Drawing.Size(393, 51);
            this.labelIDField.TabIndex = 0;
            this.labelIDField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMobileField
            // 
            this.labelMobileField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMobileField.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobileField.Location = new System.Drawing.Point(280, 111);
            this.labelMobileField.Name = "labelMobileField";
            this.labelMobileField.Size = new System.Drawing.Size(431, 51);
            this.labelMobileField.TabIndex = 0;
            this.labelMobileField.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteClient.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(8, 504);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(75, 36);
            this.buttonDeleteClient.TabIndex = 5;
            this.buttonDeleteClient.Text = "Apagar Cliente";
            this.buttonDeleteClient.UseVisualStyleBackColor = false;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // AgendaComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 552);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelMobileField);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.labelIDField);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelNameField);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaComentario";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelGroup;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.Label labelNameField;
        private System.Windows.Forms.Label labelIDField;
        private System.Windows.Forms.Label labelMobileField;
        private System.Windows.Forms.Button buttonDeleteClient;
    }
}