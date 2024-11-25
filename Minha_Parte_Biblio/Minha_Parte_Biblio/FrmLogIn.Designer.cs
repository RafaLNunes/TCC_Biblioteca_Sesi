namespace Minha_Parte_Biblio
{
    partial class FrmLogIn
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            FpPass = new FlowLayoutPanel();
            Image_PassWord = new PictureBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            txtPassWord = new TextBox();
            Image_Visivel = new PictureBox();
            PnBarPass = new Panel();
            FpUser = new FlowLayoutPanel();
            Image_User = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            txtUser = new TextBox();
            PnBarUser = new Panel();
            LbSignUp = new LinkLabel();
            Lbtext = new Label();
            PnBntLogIn = new Panel();
            BntSignUp_C = new BntCircle();
            BntLogIn = new Button();
            CbVisivel_Senha = new ImageList(components);
            Cbimage_PassWord = new ImageList(components);
            Cbimage_User = new ImageList(components);
            FpPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).BeginInit();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).BeginInit();
            FpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Image_User).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            PnBntLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // FpPass
            // 
            FpPass.BackColor = Color.Transparent;
            FpPass.Controls.Add(Image_PassWord);
            FpPass.Controls.Add(flowLayoutPanel4);
            FpPass.Controls.Add(Image_Visivel);
            FpPass.Controls.Add(PnBarPass);
            FpPass.Location = new Point(827, 363);
            FpPass.Name = "FpPass";
            FpPass.Size = new Size(488, 70);
            FpPass.TabIndex = 14;
            // 
            // Image_PassWord
            // 
            Image_PassWord.BackColor = Color.Transparent;
            Image_PassWord.Image = (Image)resources.GetObject("Image_PassWord.Image");
            Image_PassWord.Location = new Point(3, 3);
            Image_PassWord.Name = "Image_PassWord";
            Image_PassWord.Size = new Size(54, 50);
            Image_PassWord.SizeMode = PictureBoxSizeMode.Zoom;
            Image_PassWord.TabIndex = 1;
            Image_PassWord.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(txtPassWord);
            flowLayoutPanel4.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel4.Location = new Point(63, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(360, 50);
            flowLayoutPanel4.TabIndex = 2;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.White;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(3, 27);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '•';
            txtPassWord.Size = new Size(358, 20);
            txtPassWord.TabIndex = 3;
            txtPassWord.Enter += txtPassWord_Enter;
            txtPassWord.Leave += txtPassWord_Leave;
            // 
            // Image_Visivel
            // 
            Image_Visivel.BackColor = Color.Transparent;
            Image_Visivel.Image = (Image)resources.GetObject("Image_Visivel.Image");
            Image_Visivel.Location = new Point(429, 3);
            Image_Visivel.Name = "Image_Visivel";
            Image_Visivel.Size = new Size(54, 50);
            Image_Visivel.SizeMode = PictureBoxSizeMode.Zoom;
            Image_Visivel.TabIndex = 4;
            Image_Visivel.TabStop = false;
            Image_Visivel.Click += Image_Visivel_Click;
            // 
            // PnBarPass
            // 
            PnBarPass.Location = new Point(3, 59);
            PnBarPass.Name = "PnBarPass";
            PnBarPass.Size = new Size(480, 28);
            PnBarPass.TabIndex = 1;
            // 
            // FpUser
            // 
            FpUser.BackColor = Color.Transparent;
            FpUser.Controls.Add(Image_User);
            FpUser.Controls.Add(flowLayoutPanel2);
            FpUser.Controls.Add(PnBarUser);
            FpUser.Location = new Point(830, 166);
            FpUser.Name = "FpUser";
            FpUser.Size = new Size(426, 70);
            FpUser.TabIndex = 13;
            // 
            // Image_User
            // 
            Image_User.BackColor = Color.Transparent;
            Image_User.Image = (Image)resources.GetObject("Image_User.Image");
            Image_User.Location = new Point(3, 3);
            Image_User.Name = "Image_User";
            Image_User.Size = new Size(54, 50);
            Image_User.SizeMode = PictureBoxSizeMode.Zoom;
            Image_User.TabIndex = 0;
            Image_User.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(txtUser);
            flowLayoutPanel2.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel2.Location = new Point(63, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(360, 50);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.White;
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Location = new Point(3, 27);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(358, 20);
            txtUser.TabIndex = 2;
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // PnBarUser
            // 
            PnBarUser.Location = new Point(3, 59);
            PnBarUser.Name = "PnBarUser";
            PnBarUser.Size = new Size(420, 28);
            PnBarUser.TabIndex = 1;
            // 
            // LbSignUp
            // 
            LbSignUp.AutoSize = true;
            LbSignUp.BackColor = Color.Transparent;
            LbSignUp.Font = new Font("Arial Black", 16F, FontStyle.Bold | FontStyle.Italic);
            LbSignUp.LinkColor = Color.Black;
            LbSignUp.Location = new Point(1001, 563);
            LbSignUp.Name = "LbSignUp";
            LbSignUp.Size = new Size(314, 38);
            LbSignUp.TabIndex = 12;
            LbSignUp.TabStop = true;
            LbSignUp.Text = "Clique aqui: Sign Up";
            LbSignUp.LinkClicked += LbSignUp_LinkClicked;
            // 
            // Lbtext
            // 
            Lbtext.AutoSize = true;
            Lbtext.BackColor = Color.Transparent;
            Lbtext.Font = new Font("Arial", 16F);
            Lbtext.Location = new Point(817, 566);
            Lbtext.Name = "Lbtext";
            Lbtext.Size = new Size(199, 32);
            Lbtext.TabIndex = 11;
            Lbtext.Text = "Não tem conta ";
            // 
            // PnBntLogIn
            // 
            PnBntLogIn.BackColor = Color.Transparent;
            PnBntLogIn.Controls.Add(BntSignUp_C);
            PnBntLogIn.Controls.Add(BntLogIn);
            PnBntLogIn.Location = new Point(873, 604);
            PnBntLogIn.Name = "PnBntLogIn";
            PnBntLogIn.Size = new Size(442, 90);
            PnBntLogIn.TabIndex = 10;
            // 
            // BntSignUp_C
            // 
            BntSignUp_C.BackColor = Color.FromArgb(9, 90, 162);
            BntSignUp_C.FlatAppearance.BorderSize = 0;
            BntSignUp_C.FlatStyle = FlatStyle.Flat;
            BntSignUp_C.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            BntSignUp_C.ForeColor = Color.FromArgb(242, 203, 17);
            BntSignUp_C.Location = new Point(0, 2);
            BntSignUp_C.Name = "BntSignUp_C";
            BntSignUp_C.Size = new Size(411, 82);
            BntSignUp_C.TabIndex = 35;
            BntSignUp_C.Text = "Sign Up";
            BntSignUp_C.UseVisualStyleBackColor = false;
            BntSignUp_C.Click += BntSignUp_C_Click;
            // 
            // BntLogIn
            // 
            BntLogIn.BackColor = Color.Transparent;
            BntLogIn.FlatStyle = FlatStyle.Popup;
            BntLogIn.Location = new Point(-15, -15);
            BntLogIn.Name = "BntLogIn";
            BntLogIn.Size = new Size(478, 116);
            BntLogIn.TabIndex = 6;
            BntLogIn.Text = "   ";
            BntLogIn.UseVisualStyleBackColor = false;
            // 
            // CbVisivel_Senha
            // 
            CbVisivel_Senha.ColorDepth = ColorDepth.Depth32Bit;
            CbVisivel_Senha.ImageStream = (ImageListStreamer)resources.GetObject("CbVisivel_Senha.ImageStream");
            CbVisivel_Senha.TransparentColor = Color.Transparent;
            CbVisivel_Senha.Images.SetKeyName(0, "Olho_Visivel.png");
            CbVisivel_Senha.Images.SetKeyName(1, "Olhp_Invisivel.png");
            // 
            // Cbimage_PassWord
            // 
            Cbimage_PassWord.ColorDepth = ColorDepth.Depth32Bit;
            Cbimage_PassWord.ImageStream = (ImageListStreamer)resources.GetObject("Cbimage_PassWord.ImageStream");
            Cbimage_PassWord.TransparentColor = Color.Transparent;
            Cbimage_PassWord.Images.SetKeyName(0, "PassWord_Click.png");
            Cbimage_PassWord.Images.SetKeyName(1, "PassWord_UnClick.png");
            // 
            // Cbimage_User
            // 
            Cbimage_User.ColorDepth = ColorDepth.Depth32Bit;
            Cbimage_User.ImageStream = (ImageListStreamer)resources.GetObject("Cbimage_User.ImageStream");
            Cbimage_User.TransparentColor = Color.Transparent;
            Cbimage_User.Images.SetKeyName(0, "User_Click.png");
            Cbimage_User.Images.SetKeyName(1, "User_UnClick.png");
            // 
            // FrmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1482, 711);
            Controls.Add(FpPass);
            Controls.Add(FpUser);
            Controls.Add(LbSignUp);
            Controls.Add(Lbtext);
            Controls.Add(PnBntLogIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += FrmLogIn_Load;
            FpPass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).EndInit();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).EndInit();
            FpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Image_User).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            PnBntLogIn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FpPass;
        private PictureBox Image_PassWord;
        private FlowLayoutPanel flowLayoutPanel4;
        private TextBox txtPassWord;
        private PictureBox Image_Visivel;
        private Panel PnBarPass;
        private FlowLayoutPanel FpUser;
        private PictureBox Image_User;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox txtUser;
        private Panel PnBarUser;
        private LinkLabel LbSignUp;
        private Label Lbtext;
        private Panel PnBntLogIn;
        private BntCircle BntSignUp_C;
        private Button BntLogIn;
        private ImageList CbVisivel_Senha;
        private ImageList Cbimage_PassWord;
        private ImageList Cbimage_User;
    }
}