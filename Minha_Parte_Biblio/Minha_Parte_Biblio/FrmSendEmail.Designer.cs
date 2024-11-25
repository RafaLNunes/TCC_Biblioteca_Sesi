namespace Minha_Parte_Biblio
{
    partial class FrmSendEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSendEmail));
            SendEmail = new BntCircle();
            txtIndexMail = new TextBox();
            txtAssunto = new TextBox();
            txtFirstName = new TextBox();
            txtSecondName = new TextBox();
            txtMensagem = new TextBox();
            txtremetente = new TextBox();
            SuspendLayout();
            // 
            // SendEmail
            // 
            SendEmail.BackColor = Color.Black;
            SendEmail.FlatAppearance.BorderSize = 0;
            SendEmail.FlatStyle = FlatStyle.Flat;
            SendEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            SendEmail.ForeColor = Color.White;
            SendEmail.Location = new Point(504, 598);
            SendEmail.Name = "SendEmail";
            SendEmail.Size = new Size(477, 80);
            SendEmail.TabIndex = 0;
            SendEmail.Text = "Enviar Mensagem";
            SendEmail.UseVisualStyleBackColor = false;
            SendEmail.Click += SendEmail_Click;
            // 
            // txtIndexMail
            // 
            txtIndexMail.BackColor = Color.FromArgb(195, 195, 195);
            txtIndexMail.BorderStyle = BorderStyle.None;
            txtIndexMail.Location = new Point(494, 199);
            txtIndexMail.Name = "txtIndexMail";
            txtIndexMail.Size = new Size(514, 20);
            txtIndexMail.TabIndex = 1;
            // 
            // txtAssunto
            // 
            txtAssunto.BackColor = Color.FromArgb(195, 195, 195);
            txtAssunto.BorderStyle = BorderStyle.None;
            txtAssunto.Location = new Point(207, 296);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(299, 20);
            txtAssunto.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.FromArgb(195, 195, 195);
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.Location = new Point(207, 446);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(299, 20);
            txtFirstName.TabIndex = 3;
            // 
            // txtSecondName
            // 
            txtSecondName.BackColor = Color.FromArgb(195, 195, 195);
            txtSecondName.BorderStyle = BorderStyle.None;
            txtSecondName.ImeMode = ImeMode.NoControl;
            txtSecondName.Location = new Point(207, 548);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(299, 20);
            txtSecondName.TabIndex = 4;
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = Color.FromArgb(195, 195, 195);
            txtMensagem.BorderStyle = BorderStyle.None;
            txtMensagem.ImeMode = ImeMode.NoControl;
            txtMensagem.Location = new Point(587, 285);
            txtMensagem.Multiline = true;
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(689, 292);
            txtMensagem.TabIndex = 5;
            // 
            // txtremetente
            // 
            txtremetente.BackColor = Color.FromArgb(195, 195, 195);
            txtremetente.BorderStyle = BorderStyle.None;
            txtremetente.Location = new Point(494, 107);
            txtremetente.Name = "txtremetente";
            txtremetente.Size = new Size(514, 20);
            txtremetente.TabIndex = 6;
            // 
            // FrmSendEmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(txtremetente);
            Controls.Add(txtMensagem);
            Controls.Add(txtSecondName);
            Controls.Add(txtFirstName);
            Controls.Add(txtAssunto);
            Controls.Add(txtIndexMail);
            Controls.Add(SendEmail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSendEmail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSendEmail";
            Load += FrmSendEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BntCircle SendEmail;
        private TextBox txtIndexMail;
        private TextBox txtAssunto;
        private TextBox txtFirstName;
        private TextBox txtSecondName;
        private TextBox txtMensagem;
        private TextBox txtremetente;
    }
}