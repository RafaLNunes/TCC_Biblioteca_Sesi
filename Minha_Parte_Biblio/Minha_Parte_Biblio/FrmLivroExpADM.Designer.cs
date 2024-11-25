namespace Minha_Parte_Biblio
{
    partial class FrmLivroExpADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivroExpADM));
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            bookImage = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            bntCircle1 = new BntCircle();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(815, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(753, 160);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 207, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 69);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // bookImage
            // 
            bookImage.BackColor = Color.Transparent;
            bookImage.Location = new Point(253, 34);
            bookImage.Name = "bookImage";
            bookImage.Size = new Size(500, 703);
            bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
            bookImage.TabIndex = 11;
            bookImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Location = new Point(818, 316);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(637, 304);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 39);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // bntCircle1
            // 
            bntCircle1.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle1.FlatAppearance.BorderSize = 0;
            bntCircle1.FlatStyle = FlatStyle.Flat;
            bntCircle1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            bntCircle1.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle1.Location = new Point(821, 626);
            bntCircle1.Name = "bntCircle1";
            bntCircle1.Size = new Size(634, 111);
            bntCircle1.TabIndex = 13;
            bntCircle1.Text = "Voltar";
            bntCircle1.UseVisualStyleBackColor = false;
            bntCircle1.Click += bntCircle1_Click;
            // 
            // FrmLivroExpADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1787, 749);
            Controls.Add(bntCircle1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(bookImage);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLivroExpADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLivroExpADM";
            Load += FrmLivroExpADM_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private PictureBox bookImage;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private BntCircle bntCircle1;
    }
}