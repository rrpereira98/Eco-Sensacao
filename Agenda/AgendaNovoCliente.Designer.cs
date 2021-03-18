
namespace Agenda
{
    partial class AgendaNovoCliente
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
            this.labelNovoCliente = new System.Windows.Forms.Label();
            this.btnCriarCliente = new System.Windows.Forms.Button();
            this.labelPrimeiroNome = new System.Windows.Forms.Label();
            this.labelUltimoNome = new System.Windows.Forms.Label();
            this.textBoxPrimeiroNome = new System.Windows.Forms.TextBox();
            this.textBoxUltimoNome = new System.Windows.Forms.TextBox();
            this.labelMobile = new System.Windows.Forms.Label();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNovoCliente
            // 
            this.labelNovoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNovoCliente.AutoSize = true;
            this.labelNovoCliente.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovoCliente.Location = new System.Drawing.Point(218, 34);
            this.labelNovoCliente.Name = "labelNovoCliente";
            this.labelNovoCliente.Size = new System.Drawing.Size(303, 65);
            this.labelNovoCliente.TabIndex = 0;
            this.labelNovoCliente.Text = "Novo Cliente";
            // 
            // btnCriarCliente
            // 
            this.btnCriarCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCriarCliente.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCliente.Location = new System.Drawing.Point(238, 449);
            this.btnCriarCliente.Name = "btnCriarCliente";
            this.btnCriarCliente.Size = new System.Drawing.Size(273, 65);
            this.btnCriarCliente.TabIndex = 2;
            this.btnCriarCliente.Text = "Criar Cliente";
            this.btnCriarCliente.UseVisualStyleBackColor = true;
            this.btnCriarCliente.Click += new System.EventHandler(this.btnCriarCliente_Click);
            // 
            // labelPrimeiroNome
            // 
            this.labelPrimeiroNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPrimeiroNome.AutoSize = true;
            this.labelPrimeiroNome.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrimeiroNome.Location = new System.Drawing.Point(128, 142);
            this.labelPrimeiroNome.Name = "labelPrimeiroNome";
            this.labelPrimeiroNome.Size = new System.Drawing.Size(217, 40);
            this.labelPrimeiroNome.TabIndex = 0;
            this.labelPrimeiroNome.Text = "Primeiro Nome:";
            // 
            // labelUltimoNome
            // 
            this.labelUltimoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUltimoNome.AutoSize = true;
            this.labelUltimoNome.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUltimoNome.Location = new System.Drawing.Point(128, 252);
            this.labelUltimoNome.Name = "labelUltimoNome";
            this.labelUltimoNome.Size = new System.Drawing.Size(196, 40);
            this.labelUltimoNome.TabIndex = 0;
            this.labelUltimoNome.Text = "Ultimo Nome:";
            // 
            // textBoxPrimeiroNome
            // 
            this.textBoxPrimeiroNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrimeiroNome.Font = new System.Drawing.Font("Nirmala UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrimeiroNome.Location = new System.Drawing.Point(360, 139);
            this.textBoxPrimeiroNome.Name = "textBoxPrimeiroNome";
            this.textBoxPrimeiroNome.Size = new System.Drawing.Size(246, 46);
            this.textBoxPrimeiroNome.TabIndex = 1;
            this.textBoxPrimeiroNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxUltimoNome
            // 
            this.textBoxUltimoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUltimoNome.Font = new System.Drawing.Font("Nirmala UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUltimoNome.Location = new System.Drawing.Point(360, 249);
            this.textBoxUltimoNome.Name = "textBoxUltimoNome";
            this.textBoxUltimoNome.Size = new System.Drawing.Size(246, 46);
            this.textBoxUltimoNome.TabIndex = 1;
            this.textBoxUltimoNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelMobile
            // 
            this.labelMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMobile.AutoSize = true;
            this.labelMobile.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMobile.Location = new System.Drawing.Point(128, 357);
            this.labelMobile.Name = "labelMobile";
            this.labelMobile.Size = new System.Drawing.Size(231, 40);
            this.labelMobile.TabIndex = 0;
            this.labelMobile.Text = "Nª de Telemóvel:";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMobile.Font = new System.Drawing.Font("Nirmala UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMobile.Location = new System.Drawing.Point(360, 354);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(246, 46);
            this.textBoxMobile.TabIndex = 1;
            this.textBoxMobile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgendaNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 552);
            this.Controls.Add(this.btnCriarCliente);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.textBoxUltimoNome);
            this.Controls.Add(this.labelMobile);
            this.Controls.Add(this.textBoxPrimeiroNome);
            this.Controls.Add(this.labelUltimoNome);
            this.Controls.Add(this.labelPrimeiroNome);
            this.Controls.Add(this.labelNovoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendaNovoCliente";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovoCliente;
        private System.Windows.Forms.Button btnCriarCliente;
        private System.Windows.Forms.Label labelPrimeiroNome;
        private System.Windows.Forms.Label labelUltimoNome;
        private System.Windows.Forms.TextBox textBoxPrimeiroNome;
        private System.Windows.Forms.TextBox textBoxUltimoNome;
        private System.Windows.Forms.Label labelMobile;
        private System.Windows.Forms.TextBox textBoxMobile;
    }
}