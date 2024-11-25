namespace Minha_Parte_Biblio
{
    partial class FrmBoasVindas
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
            PbImage_User = new PictureBox();
            LbNomeComp = new Label();
            PnBntViajar = new Panel();
            BntViajar = new Button();
            ((System.ComponentModel.ISupportInitialize)PbImage_User).BeginInit();
            PnBntViajar.SuspendLayout();
            SuspendLayout();
            // 
            // PbImage_User
            // 
            PbImage_User.BackColor = Color.Transparent;
            PbImage_User.BorderStyle = BorderStyle.Fixed3D;
            PbImage_User.Location = new Point(965, 263);
            PbImage_User.Name = "PbImage_User";
            PbImage_User.Size = new Size(414, 515);
            PbImage_User.SizeMode = PictureBoxSizeMode.Zoom;
            PbImage_User.TabIndex = 0;
            PbImage_User.TabStop = false;
            PbImage_User.Click += PbImage_User_Click;
            // 
            // LbNomeComp
            // 
            LbNomeComp.AutoSize = true;
            LbNomeComp.BackColor = Color.Transparent;
            LbNomeComp.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbNomeComp.ForeColor = Color.FromArgb(255, 207, 0);
            LbNomeComp.Location = new Point(965, 210);
            LbNomeComp.Name = "LbNomeComp";
            LbNomeComp.Size = new Size(128, 50);
            LbNomeComp.TabIndex = 1;
            LbNomeComp.Text = "label1";
            // 
            // PnBntViajar
            // 
            PnBntViajar.BackColor = Color.Transparent;
            PnBntViajar.Controls.Add(BntViajar);
            PnBntViajar.Location = new Point(157, 706);
            PnBntViajar.Name = "PnBntViajar";
            PnBntViajar.Size = new Size(228, 83);
            PnBntViajar.TabIndex = 25;
            // 
            // BntViajar
            // 
            BntViajar.BackColor = Color.Transparent;
            BntViajar.FlatStyle = FlatStyle.Popup;
            BntViajar.Location = new Point(-15, -15);
            BntViajar.Name = "BntViajar";
            BntViajar.Size = new Size(256, 116);
            BntViajar.TabIndex = 6;
            BntViajar.Text = "   ";
            BntViajar.UseVisualStyleBackColor = false;
            BntViajar.Click += BntViajar_Click;
            // 
            // FrmBoasVindas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Boas_Vindas_Duplicada;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1467, 868);
            Controls.Add(PnBntViajar);
            Controls.Add(LbNomeComp);
            Controls.Add(PbImage_User);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmBoasVindas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmBoasVindas";
            FormClosed += FrmBoasVindas_FormClosed;
            Load += FrmBoasVindas_Load;
            ((System.ComponentModel.ISupportInitialize)PbImage_User).EndInit();
            PnBntViajar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbImage_User;
        private Label LbNomeComp;
        private Panel PnBntViajar;
        private Button BntViajar;
    }
}