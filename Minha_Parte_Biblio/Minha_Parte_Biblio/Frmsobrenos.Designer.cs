namespace usuario
{
    partial class Frmsobrenos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsobrenos));
            bntCircle1 = new Minha_Parte_Biblio.BntCircle();
            SuspendLayout();
            // 
            // bntCircle1
            // 
            bntCircle1.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle1.FlatAppearance.BorderSize = 0;
            bntCircle1.FlatStyle = FlatStyle.Flat;
            bntCircle1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            bntCircle1.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle1.Location = new Point(396, 572);
            bntCircle1.Name = "bntCircle1";
            bntCircle1.Size = new Size(411, 82);
            bntCircle1.TabIndex = 0;
            bntCircle1.Text = "Desenvolvedores";
            bntCircle1.UseVisualStyleBackColor = false;
            bntCircle1.Click += bntCircle1_Click;
            // 
            // Frmsobrenos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(bntCircle1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmsobrenos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmsobrenos";
            ResumeLayout(false);
        }

        #endregion

        private Minha_Parte_Biblio.BntCircle bntCircle1;
    }
}