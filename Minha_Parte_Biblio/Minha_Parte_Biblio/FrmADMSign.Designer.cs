namespace Minha_Parte_Biblio
{
    partial class FrmADMSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmADMSign));
            bntCircle1 = new BntCircle();
            bntCircle2 = new BntCircle();
            txtUsername = new TextBox();
            txtpass = new TextBox();
            LbTipo = new Label();
            SuspendLayout();
            // 
            // bntCircle1
            // 
            bntCircle1.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle1.FlatAppearance.BorderSize = 0;
            bntCircle1.FlatStyle = FlatStyle.Flat;
            bntCircle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle1.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle1.Location = new Point(30, 535);
            bntCircle1.Name = "bntCircle1";
            bntCircle1.Size = new Size(378, 99);
            bntCircle1.TabIndex = 0;
            bntCircle1.Text = "LogIn como ADM";
            bntCircle1.UseVisualStyleBackColor = false;
            bntCircle1.Click += bntCircle1_Click;
            // 
            // bntCircle2
            // 
            bntCircle2.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle2.FlatAppearance.BorderSize = 0;
            bntCircle2.FlatStyle = FlatStyle.Flat;
            bntCircle2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle2.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle2.Location = new Point(426, 535);
            bntCircle2.Name = "bntCircle2";
            bntCircle2.Size = new Size(378, 99);
            bntCircle2.TabIndex = 1;
            bntCircle2.Text = "Retornar para Log In";
            bntCircle2.UseVisualStyleBackColor = false;
            bntCircle2.Click += bntCircle2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(43, 59, 92);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(167, 226);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(448, 20);
            txtUsername.TabIndex = 2;
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(43, 59, 92);
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.ForeColor = Color.White;
            txtpass.Location = new Point(167, 378);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(448, 20);
            txtpass.TabIndex = 3;
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // LbTipo
            // 
            LbTipo.AutoSize = true;
            LbTipo.BackColor = Color.Transparent;
            LbTipo.Font = new Font("Sigmar One", 26F, FontStyle.Bold);
            LbTipo.ForeColor = Color.White;
            LbTipo.Location = new Point(70, 46);
            LbTipo.Name = "LbTipo";
            LbTipo.Size = new Size(206, 73);
            LbTipo.TabIndex = 4;
            LbTipo.Text = "label1";
            // 
            // FrmADMSign
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(LbTipo);
            Controls.Add(txtpass);
            Controls.Add(txtUsername);
            Controls.Add(bntCircle2);
            Controls.Add(bntCircle1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmADMSign";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += FrmADMSign_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BntCircle bntCircle1;
        private BntCircle bntCircle2;
        private TextBox txtUsername;
        private TextBox txtpass;
        private Label LbTipo;
    }
}