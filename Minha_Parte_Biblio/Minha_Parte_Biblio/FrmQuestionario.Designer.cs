namespace Minha_Parte_Biblio
{
    partial class FrmQuestionario
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
            BntADM = new BntCircle();
            BntNADM = new BntCircle();
            label1 = new Label();
            SuspendLayout();
            // 
            // BntADM
            // 
            BntADM.BackColor = Color.FromArgb(9, 90, 162);
            BntADM.FlatAppearance.BorderSize = 0;
            BntADM.FlatStyle = FlatStyle.Flat;
            BntADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BntADM.ForeColor = Color.FromArgb(242, 203, 17);
            BntADM.Location = new Point(12, 172);
            BntADM.Name = "BntADM";
            BntADM.Size = new Size(215, 77);
            BntADM.TabIndex = 0;
            BntADM.Text = "Sou ADM";
            BntADM.UseVisualStyleBackColor = false;
            BntADM.Click += BntADM_Click;
            // 
            // BntNADM
            // 
            BntNADM.BackColor = Color.FromArgb(9, 90, 162);
            BntNADM.FlatAppearance.BorderSize = 0;
            BntNADM.FlatStyle = FlatStyle.Flat;
            BntNADM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BntNADM.ForeColor = Color.FromArgb(242, 203, 17);
            BntNADM.Location = new Point(241, 172);
            BntNADM.Name = "BntNADM";
            BntNADM.Size = new Size(215, 77);
            BntNADM.TabIndex = 1;
            BntNADM.Text = "Não Sou ADM";
            BntNADM.UseVisualStyleBackColor = false;
            BntNADM.Click += BntNADM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(61, 58);
            label1.Name = "label1";
            label1.Size = new Size(366, 35);
            label1.TabIndex = 2;
            label1.Text = "Você é da area administração?";
            // 
            // FrmQuestionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 49, 65);
            ClientSize = new Size(468, 257);
            Controls.Add(label1);
            Controls.Add(BntNADM);
            Controls.Add(BntADM);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmQuestionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmQuestionario";
            Load += FrmQuestionario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BntCircle BntADM;
        private BntCircle BntNADM;
        private Label label1;
    }
}