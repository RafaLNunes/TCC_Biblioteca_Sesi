namespace Minha_Parte_Biblio
{
    partial class FrmMeanC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeanC));
            panel1 = new Panel();
            BntAcessoADM = new BntCircle();
            pictureBox2 = new PictureBox();
            LbName_User = new Label();
            PbClose = new PictureBox();
            PbUser = new Aprendendo_MVC.PictureBoxCircle();
            FpMenu = new FlowLayoutPanel();
            PnMenu = new Panel();
            BntMenu = new Button();
            panel8 = new Panel();
            PnUser = new Panel();
            BntUser = new Button();
            panel2 = new Panel();
            PnCatalogo = new Panel();
            BntCatalogo = new Button();
            panel3 = new Panel();
            PnHist = new Panel();
            BntHist = new Button();
            panel4 = new Panel();
            PnReserv = new Panel();
            BntReserv = new Button();
            panel10 = new Panel();
            PnPerguntas = new Panel();
            BntPerguntas = new Button();
            panel11 = new Panel();
            PnNos = new Panel();
            BntNos = new Button();
            FPnContenedor = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbUser).BeginInit();
            FpMenu.SuspendLayout();
            PnMenu.SuspendLayout();
            PnUser.SuspendLayout();
            PnCatalogo.SuspendLayout();
            PnHist.SuspendLayout();
            PnReserv.SuspendLayout();
            PnPerguntas.SuspendLayout();
            PnNos.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 90, 162);
            panel1.Controls.Add(BntAcessoADM);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LbName_User);
            panel1.Controls.Add(PbClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1885, 82);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // BntAcessoADM
            // 
            BntAcessoADM.BackColor = Color.FromArgb(54, 21, 38);
            BntAcessoADM.FlatAppearance.BorderSize = 0;
            BntAcessoADM.FlatStyle = FlatStyle.Flat;
            BntAcessoADM.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntAcessoADM.ForeColor = Color.White;
            BntAcessoADM.Location = new Point(1543, 14);
            BntAcessoADM.Name = "BntAcessoADM";
            BntAcessoADM.Size = new Size(248, 57);
            BntAcessoADM.TabIndex = 15;
            BntAcessoADM.Text = "Pagina do ADM";
            BntAcessoADM.UseVisualStyleBackColor = false;
            BntAcessoADM.Click += bntCircle1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // LbName_User
            // 
            LbName_User.AutoSize = true;
            LbName_User.Font = new Font("Sitka Text", 13.2000008F, FontStyle.Bold);
            LbName_User.ForeColor = Color.Black;
            LbName_User.Location = new Point(148, 26);
            LbName_User.Name = "LbName_User";
            LbName_User.Size = new Size(131, 33);
            LbName_User.TabIndex = 14;
            LbName_User.Text = "UserName";
            LbName_User.Click += LbName_User_Click;
            // 
            // PbClose
            // 
            PbClose.Image = (Image)resources.GetObject("PbClose.Image");
            PbClose.Location = new Point(1797, 3);
            PbClose.Name = "PbClose";
            PbClose.Size = new Size(85, 76);
            PbClose.SizeMode = PictureBoxSizeMode.Zoom;
            PbClose.TabIndex = 13;
            PbClose.TabStop = false;
            PbClose.Click += PbClose_Click;
            // 
            // PbUser
            // 
            PbUser.Location = new Point(207, 35);
            PbUser.Name = "PbUser";
            PbUser.Size = new Size(125, 125);
            PbUser.SizeMode = PictureBoxSizeMode.Zoom;
            PbUser.TabIndex = 12;
            PbUser.TabStop = false;
            PbUser.Click += PbUser_Click;
            // 
            // FpMenu
            // 
            FpMenu.BackColor = Color.FromArgb(35, 49, 65);
            FpMenu.Controls.Add(PnMenu);
            FpMenu.Controls.Add(panel8);
            FpMenu.Controls.Add(PnUser);
            FpMenu.Controls.Add(panel2);
            FpMenu.Controls.Add(PnCatalogo);
            FpMenu.Controls.Add(panel3);
            FpMenu.Controls.Add(PnHist);
            FpMenu.Controls.Add(panel4);
            FpMenu.Controls.Add(PnReserv);
            FpMenu.Controls.Add(panel10);
            FpMenu.Controls.Add(PnPerguntas);
            FpMenu.Controls.Add(panel11);
            FpMenu.Controls.Add(PnNos);
            FpMenu.Dock = DockStyle.Left;
            FpMenu.Location = new Point(0, 82);
            FpMenu.MaximumSize = new Size(385, 803);
            FpMenu.MinimumSize = new Size(69, 803);
            FpMenu.Name = "FpMenu";
            FpMenu.Size = new Size(385, 803);
            FpMenu.TabIndex = 1;
            FpMenu.Paint += flowLayoutPanel1_Paint;
            // 
            // PnMenu
            // 
            PnMenu.BackColor = Color.Transparent;
            PnMenu.Controls.Add(BntMenu);
            PnMenu.Controls.Add(PbUser);
            PnMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PnMenu.ForeColor = Color.FromArgb(218, 218, 218);
            PnMenu.Location = new Point(3, 3);
            PnMenu.Name = "PnMenu";
            PnMenu.Size = new Size(382, 189);
            PnMenu.TabIndex = 5;
            // 
            // BntMenu
            // 
            BntMenu.FlatAppearance.BorderSize = 0;
            BntMenu.FlatStyle = FlatStyle.Flat;
            BntMenu.Image = (Image)resources.GetObject("BntMenu.Image");
            BntMenu.ImageAlign = ContentAlignment.MiddleLeft;
            BntMenu.Location = new Point(-22, -42);
            BntMenu.Name = "BntMenu";
            BntMenu.Padding = new Padding(20, 0, 0, 0);
            BntMenu.Size = new Size(404, 273);
            BntMenu.TabIndex = 4;
            BntMenu.Text = "       MENU";
            BntMenu.TextAlign = ContentAlignment.MiddleLeft;
            BntMenu.UseVisualStyleBackColor = true;
            BntMenu.Click += BntMenu_Click;
            // 
            // panel8
            // 
            panel8.Location = new Point(3, 198);
            panel8.Name = "panel8";
            panel8.Size = new Size(382, 33);
            panel8.TabIndex = 11;
            // 
            // PnUser
            // 
            PnUser.Controls.Add(BntUser);
            PnUser.Location = new Point(3, 237);
            PnUser.Name = "PnUser";
            PnUser.Size = new Size(382, 54);
            PnUser.TabIndex = 4;
            // 
            // BntUser
            // 
            BntUser.FlatStyle = FlatStyle.Flat;
            BntUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntUser.ForeColor = Color.FromArgb(218, 218, 218);
            BntUser.Image = (Image)resources.GetObject("BntUser.Image");
            BntUser.ImageAlign = ContentAlignment.MiddleLeft;
            BntUser.Location = new Point(-22, -34);
            BntUser.Name = "BntUser";
            BntUser.Padding = new Padding(20, 0, 0, 0);
            BntUser.Size = new Size(468, 124);
            BntUser.TabIndex = 5;
            BntUser.Text = "       Página do Usuário";
            BntUser.TextAlign = ContentAlignment.MiddleLeft;
            BntUser.UseVisualStyleBackColor = true;
            BntUser.Click += BntUser_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 15);
            panel2.TabIndex = 14;
            // 
            // PnCatalogo
            // 
            PnCatalogo.Controls.Add(BntCatalogo);
            PnCatalogo.Location = new Point(3, 318);
            PnCatalogo.Name = "PnCatalogo";
            PnCatalogo.Size = new Size(382, 58);
            PnCatalogo.TabIndex = 6;
            // 
            // BntCatalogo
            // 
            BntCatalogo.FlatStyle = FlatStyle.Flat;
            BntCatalogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntCatalogo.ForeColor = Color.FromArgb(218, 218, 218);
            BntCatalogo.Image = (Image)resources.GetObject("BntCatalogo.Image");
            BntCatalogo.ImageAlign = ContentAlignment.MiddleLeft;
            BntCatalogo.Location = new Point(-22, -35);
            BntCatalogo.Name = "BntCatalogo";
            BntCatalogo.Padding = new Padding(20, 0, 0, 0);
            BntCatalogo.Size = new Size(468, 124);
            BntCatalogo.TabIndex = 5;
            BntCatalogo.Text = "       Catálogo";
            BntCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            BntCatalogo.UseVisualStyleBackColor = true;
            BntCatalogo.Click += BntCatalogo_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 382);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 15);
            panel3.TabIndex = 13;
            // 
            // PnHist
            // 
            PnHist.Controls.Add(BntHist);
            PnHist.Location = new Point(3, 403);
            PnHist.Name = "PnHist";
            PnHist.Size = new Size(382, 49);
            PnHist.TabIndex = 7;
            // 
            // BntHist
            // 
            BntHist.FlatStyle = FlatStyle.Flat;
            BntHist.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntHist.ForeColor = Color.FromArgb(218, 218, 218);
            BntHist.Image = (Image)resources.GetObject("BntHist.Image");
            BntHist.ImageAlign = ContentAlignment.MiddleLeft;
            BntHist.Location = new Point(-22, -39);
            BntHist.Name = "BntHist";
            BntHist.Padding = new Padding(20, 0, 0, 0);
            BntHist.Size = new Size(468, 124);
            BntHist.TabIndex = 5;
            BntHist.Text = "       Seu Histórico";
            BntHist.TextAlign = ContentAlignment.MiddleLeft;
            BntHist.UseVisualStyleBackColor = true;
            BntHist.Click += BntHist_Click;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 458);
            panel4.Name = "panel4";
            panel4.Size = new Size(382, 13);
            panel4.TabIndex = 13;
            // 
            // PnReserv
            // 
            PnReserv.Controls.Add(BntReserv);
            PnReserv.Location = new Point(3, 477);
            PnReserv.Name = "PnReserv";
            PnReserv.Size = new Size(382, 51);
            PnReserv.TabIndex = 8;
            // 
            // BntReserv
            // 
            BntReserv.FlatStyle = FlatStyle.Flat;
            BntReserv.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntReserv.ForeColor = Color.FromArgb(218, 218, 218);
            BntReserv.Image = (Image)resources.GetObject("BntReserv.Image");
            BntReserv.ImageAlign = ContentAlignment.MiddleLeft;
            BntReserv.Location = new Point(-22, -38);
            BntReserv.Name = "BntReserv";
            BntReserv.Padding = new Padding(20, 0, 0, 0);
            BntReserv.Size = new Size(468, 124);
            BntReserv.TabIndex = 5;
            BntReserv.Text = "       Suas Reservas";
            BntReserv.TextAlign = ContentAlignment.MiddleLeft;
            BntReserv.UseVisualStyleBackColor = true;
            BntReserv.Click += BntReserv_Click;
            // 
            // panel10
            // 
            panel10.Location = new Point(3, 534);
            panel10.Name = "panel10";
            panel10.Size = new Size(382, 13);
            panel10.TabIndex = 13;
            // 
            // PnPerguntas
            // 
            PnPerguntas.Controls.Add(BntPerguntas);
            PnPerguntas.Location = new Point(3, 553);
            PnPerguntas.Name = "PnPerguntas";
            PnPerguntas.Size = new Size(382, 54);
            PnPerguntas.TabIndex = 9;
            // 
            // BntPerguntas
            // 
            BntPerguntas.FlatStyle = FlatStyle.Flat;
            BntPerguntas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntPerguntas.ForeColor = Color.FromArgb(218, 218, 218);
            BntPerguntas.Image = (Image)resources.GetObject("BntPerguntas.Image");
            BntPerguntas.ImageAlign = ContentAlignment.MiddleLeft;
            BntPerguntas.Location = new Point(-22, -34);
            BntPerguntas.Name = "BntPerguntas";
            BntPerguntas.Padding = new Padding(20, 0, 0, 0);
            BntPerguntas.Size = new Size(468, 124);
            BntPerguntas.TabIndex = 5;
            BntPerguntas.Text = "       Perguntas Frequentes";
            BntPerguntas.TextAlign = ContentAlignment.MiddleLeft;
            BntPerguntas.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Location = new Point(3, 613);
            panel11.Name = "panel11";
            panel11.Size = new Size(382, 13);
            panel11.TabIndex = 13;
            // 
            // PnNos
            // 
            PnNos.Controls.Add(BntNos);
            PnNos.Location = new Point(3, 632);
            PnNos.Name = "PnNos";
            PnNos.Size = new Size(382, 55);
            PnNos.TabIndex = 10;
            // 
            // BntNos
            // 
            BntNos.FlatStyle = FlatStyle.Flat;
            BntNos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BntNos.ForeColor = Color.FromArgb(218, 218, 218);
            BntNos.Image = (Image)resources.GetObject("BntNos.Image");
            BntNos.ImageAlign = ContentAlignment.MiddleLeft;
            BntNos.Location = new Point(-22, -36);
            BntNos.Name = "BntNos";
            BntNos.Padding = new Padding(20, 0, 0, 0);
            BntNos.Size = new Size(468, 124);
            BntNos.TabIndex = 5;
            BntNos.Text = "       Sobre Nós";
            BntNos.TextAlign = ContentAlignment.MiddleLeft;
            BntNos.UseVisualStyleBackColor = true;
            BntNos.Click += BntNos_Click;
            // 
            // FPnContenedor
            // 
            FPnContenedor.BackColor = Color.Transparent;
            FPnContenedor.BackgroundImage = Properties.Resources.logo_Fundo_CertinhaCC;
            FPnContenedor.Dock = DockStyle.Fill;
            FPnContenedor.Location = new Point(385, 82);
            FPnContenedor.Name = "FPnContenedor";
            FPnContenedor.Size = new Size(1500, 803);
            FPnContenedor.TabIndex = 2;
            FPnContenedor.Paint += FPnContenedor_Paint;
            // 
            // FrmMeanC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1885, 885);
            Controls.Add(FPnContenedor);
            Controls.Add(FpMenu);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMeanC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMeanC";
            Load += FrmMeanC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbUser).EndInit();
            FpMenu.ResumeLayout(false);
            PnMenu.ResumeLayout(false);
            PnUser.ResumeLayout(false);
            PnCatalogo.ResumeLayout(false);
            PnHist.ResumeLayout(false);
            PnReserv.ResumeLayout(false);
            PnPerguntas.ResumeLayout(false);
            PnNos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel FpMenu;
        private Panel PnMenu;
        private Button BntMenu;
        private Panel PnUser;
        private Button BntUser;
        private Panel PnCatalogo;
        private Button BntCatalogo;
        private Panel PnHist;
        private Button BntHist;
        private Panel PnReserv;
        private Button BntReserv;
        private Panel PnPerguntas;
        private Button BntPerguntas;
        private Panel PnNos;
        private Button BntNos;
        private Panel panel8;
        private Panel panel3;
        private Panel panel4;
        private Panel panel10;
        private Panel panel11;
        private Panel panel2;
        private Label LbName_User;
        private Aprendendo_MVC.PictureBoxCircle PbUser;
        private PictureBox PbClose;
        private FlowLayoutPanel FPnContenedor;
        private PictureBox pictureBox2;
        private BntCircle BntAcessoADM;
    }
}