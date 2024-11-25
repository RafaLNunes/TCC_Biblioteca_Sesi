namespace Minha_Parte_Biblio
{
    partial class FrmMeanADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeanADM));
            panel1 = new Panel();
            bntCircle1 = new BntCircle();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BntBooks = new BntCircle();
            UserAdm = new Label();
            UserClint = new Label();
            PbcUser = new Aprendendo_MVC.PictureBoxCircle();
            BntReserv = new BntCircle();
            BntUsers = new BntCircle();
            BntMenu = new BntCircle();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            FPnContenedor = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbcUser).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(35, 49, 65);
            panel1.Controls.Add(bntCircle1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BntBooks);
            panel1.Controls.Add(UserAdm);
            panel1.Controls.Add(UserClint);
            panel1.Controls.Add(PbcUser);
            panel1.Controls.Add(BntReserv);
            panel1.Controls.Add(BntUsers);
            panel1.Controls.Add(BntMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1885, 136);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // bntCircle1
            // 
            bntCircle1.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle1.FlatAppearance.BorderSize = 0;
            bntCircle1.FlatStyle = FlatStyle.Flat;
            bntCircle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            bntCircle1.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle1.Location = new Point(73, 12);
            bntCircle1.Name = "bntCircle1";
            bntCircle1.Size = new Size(208, 49);
            bntCircle1.TabIndex = 9;
            bntCircle1.Text = "Pagina do Usuário";
            bntCircle1.UseVisualStyleBackColor = false;
            bntCircle1.Click += bntCircle1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Location = new Point(1264, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 3);
            panel2.TabIndex = 7;
            // 
            // BntBooks
            // 
            BntBooks.BackColor = Color.FromArgb(9, 90, 162);
            BntBooks.FlatAppearance.BorderSize = 0;
            BntBooks.FlatStyle = FlatStyle.Flat;
            BntBooks.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntBooks.ForeColor = Color.FromArgb(242, 203, 17);
            BntBooks.Location = new Point(936, 69);
            BntBooks.Name = "BntBooks";
            BntBooks.Padding = new Padding(0, 10, 0, 0);
            BntBooks.Size = new Size(293, 129);
            BntBooks.TabIndex = 6;
            BntBooks.Text = "LIVROS";
            BntBooks.TextAlign = ContentAlignment.TopCenter;
            BntBooks.UseVisualStyleBackColor = false;
            BntBooks.Click += BntBooks_Click;
            // 
            // UserAdm
            // 
            UserAdm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserAdm.AutoSize = true;
            UserAdm.BackColor = Color.Transparent;
            UserAdm.Font = new Font("Shrikhand", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserAdm.ForeColor = Color.White;
            UserAdm.Location = new Point(1261, 79);
            UserAdm.Name = "UserAdm";
            UserAdm.Size = new Size(85, 30);
            UserAdm.TabIndex = 5;
            UserAdm.Text = "label3";
            UserAdm.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UserClint
            // 
            UserClint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UserClint.AutoSize = true;
            UserClint.BackColor = Color.Transparent;
            UserClint.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            UserClint.ForeColor = Color.White;
            UserClint.Location = new Point(1252, 14);
            UserClint.Name = "UserClint";
            UserClint.Size = new Size(137, 54);
            UserClint.TabIndex = 4;
            UserClint.Text = "label2";
            UserClint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PbcUser
            // 
            PbcUser.BackColor = Color.Red;
            PbcUser.Location = new Point(1753, 8);
            PbcUser.Name = "PbcUser";
            PbcUser.Size = new Size(120, 120);
            PbcUser.SizeMode = PictureBoxSizeMode.CenterImage;
            PbcUser.TabIndex = 3;
            PbcUser.TabStop = false;
            // 
            // BntReserv
            // 
            BntReserv.BackColor = Color.FromArgb(9, 90, 162);
            BntReserv.FlatAppearance.BorderSize = 0;
            BntReserv.FlatStyle = FlatStyle.Flat;
            BntReserv.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntReserv.ForeColor = Color.FromArgb(242, 203, 17);
            BntReserv.Location = new Point(637, 69);
            BntReserv.Name = "BntReserv";
            BntReserv.Padding = new Padding(0, 10, 0, 0);
            BntReserv.Size = new Size(293, 129);
            BntReserv.TabIndex = 2;
            BntReserv.Text = "RESERVAS";
            BntReserv.TextAlign = ContentAlignment.TopCenter;
            BntReserv.UseVisualStyleBackColor = false;
            BntReserv.Click += BntReserv_Click;
            // 
            // BntUsers
            // 
            BntUsers.BackColor = Color.FromArgb(9, 90, 162);
            BntUsers.FlatAppearance.BorderSize = 0;
            BntUsers.FlatStyle = FlatStyle.Flat;
            BntUsers.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntUsers.ForeColor = Color.FromArgb(242, 203, 17);
            BntUsers.Location = new Point(338, 69);
            BntUsers.Name = "BntUsers";
            BntUsers.Padding = new Padding(0, 10, 0, 0);
            BntUsers.Size = new Size(293, 129);
            BntUsers.TabIndex = 1;
            BntUsers.Text = "USUÁRIOS";
            BntUsers.TextAlign = ContentAlignment.TopCenter;
            BntUsers.UseVisualStyleBackColor = false;
            BntUsers.Click += BntUsers_Click;
            // 
            // BntMenu
            // 
            BntMenu.BackColor = Color.FromArgb(9, 90, 162);
            BntMenu.FlatAppearance.BorderSize = 0;
            BntMenu.FlatStyle = FlatStyle.Flat;
            BntMenu.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntMenu.ForeColor = Color.FromArgb(242, 203, 17);
            BntMenu.Location = new Point(39, 69);
            BntMenu.Name = "BntMenu";
            BntMenu.Padding = new Padding(0, 10, 0, 0);
            BntMenu.Size = new Size(293, 129);
            BntMenu.TabIndex = 0;
            BntMenu.Text = "MENU";
            BntMenu.TextAlign = ContentAlignment.TopCenter;
            BntMenu.UseVisualStyleBackColor = false;
            BntMenu.Click += BntMenu_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.FromArgb(35, 106, 127);
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel2.Location = new Point(1787, 136);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(98, 749);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(35, 106, 127);
            label1.Font = new Font("Sigmar One", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 738);
            label1.TabIndex = 0;
            label1.Text = "ADM Center";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FPnContenedor
            // 
            FPnContenedor.BackColor = Color.White;
            FPnContenedor.BackgroundImage = (Image)resources.GetObject("FPnContenedor.BackgroundImage");
            FPnContenedor.Dock = DockStyle.Fill;
            FPnContenedor.Location = new Point(0, 136);
            FPnContenedor.Name = "FPnContenedor";
            FPnContenedor.Size = new Size(1787, 749);
            FPnContenedor.TabIndex = 4;
            // 
            // FrmMeanADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(62, 6, 44);
            ClientSize = new Size(1885, 885);
            Controls.Add(FPnContenedor);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMeanADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMeanADM";
            Load += FrmMeanADM_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbcUser).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private BntCircle BntMenu;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private FlowLayoutPanel FPnContenedor;
        private Aprendendo_MVC.PictureBoxCircle PbcUser;
        private BntCircle BntReserv;
        private BntCircle BntUsers;
        private Label UserAdm;
        private Label UserClint;
        private BntCircle BntBooks;
        private Panel panel2;
        private BntCircle bntCircle1;
        private PictureBox pictureBox1;
    }
}