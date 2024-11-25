namespace Minha_Parte_Biblio
{
    partial class FrmLogInE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogInE));
            Image_User = new PictureBox();
            Image_PassWord = new PictureBox();
            txtUser = new TextBox();
            txtPassWord = new TextBox();
            Image_Visivel = new PictureBox();
            PnBntLogIn = new Panel();
            BntSignUp_C = new BntCircle();
            BntLogIn = new Button();
            Lbtext = new Label();
            LbSignUp = new LinkLabel();
            CbVisivel_Senha = new ImageList(components);
            Cbimage_PassWord = new ImageList(components);
            Cbimage_User = new ImageList(components);
            FpUser = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            PnBarUser = new Panel();
            FpPass = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            PnBarPass = new Panel();
            ((System.ComponentModel.ISupportInitialize)Image_User).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).BeginInit();
            PnBntLogIn.SuspendLayout();
            FpUser.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            FpPass.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.White;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Location = new Point(3, 27);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '•';
            txtPassWord.Size = new Size(358, 20);
            txtPassWord.TabIndex = 3;
            txtPassWord.TextChanged += txtPassWord_TextChanged;
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
            // PnBntLogIn
            // 
            PnBntLogIn.BackColor = Color.Transparent;
            PnBntLogIn.Controls.Add(BntSignUp_C);
            PnBntLogIn.Controls.Add(BntLogIn);
            PnBntLogIn.Location = new Point(885, 600);
            PnBntLogIn.Name = "PnBntLogIn";
            PnBntLogIn.Size = new Size(442, 90);
            PnBntLogIn.TabIndex = 5;
            // 
            // BntSignUp_C
            // 
            BntSignUp_C.BackColor = Color.FromArgb(9, 90, 162);
            BntSignUp_C.FlatAppearance.BorderSize = 0;
            BntSignUp_C.FlatStyle = FlatStyle.Flat;
            BntSignUp_C.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            BntSignUp_C.ForeColor = Color.FromArgb(242, 203, 17);
            BntSignUp_C.Location = new Point(0, 7);
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
            BntLogIn.Click += BntLogIn_Click;
            // 
            // Lbtext
            // 
            Lbtext.AutoSize = true;
            Lbtext.BackColor = Color.Transparent;
            Lbtext.Font = new Font("Arial", 16F);
            Lbtext.Location = new Point(829, 562);
            Lbtext.Name = "Lbtext";
            Lbtext.Size = new Size(199, 32);
            Lbtext.TabIndex = 6;
            Lbtext.Text = "Não tem conta ";
            // 
            // LbSignUp
            // 
            LbSignUp.AutoSize = true;
            LbSignUp.BackColor = Color.Transparent;
            LbSignUp.Font = new Font("Arial Black", 16F, FontStyle.Bold | FontStyle.Italic);
            LbSignUp.LinkColor = Color.Black;
            LbSignUp.Location = new Point(1013, 559);
            LbSignUp.Name = "LbSignUp";
            LbSignUp.Size = new Size(314, 38);
            LbSignUp.TabIndex = 7;
            LbSignUp.TabStop = true;
            LbSignUp.Text = "Clique aqui: Sign Up";
            LbSignUp.LinkClicked += LbSignUp_LinkClicked;
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
            // FpUser
            // 
            FpUser.BackColor = Color.Transparent;
            FpUser.Controls.Add(Image_User);
            FpUser.Controls.Add(flowLayoutPanel2);
            FpUser.Controls.Add(PnBarUser);
            FpUser.Location = new Point(842, 162);
            FpUser.Name = "FpUser";
            FpUser.Size = new Size(426, 70);
            FpUser.TabIndex = 8;
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
            // PnBarUser
            // 
            PnBarUser.Location = new Point(3, 59);
            PnBarUser.Name = "PnBarUser";
            PnBarUser.Size = new Size(420, 28);
            PnBarUser.TabIndex = 1;
            // 
            // FpPass
            // 
            FpPass.BackColor = Color.Transparent;
            FpPass.Controls.Add(Image_PassWord);
            FpPass.Controls.Add(flowLayoutPanel4);
            FpPass.Controls.Add(Image_Visivel);
            FpPass.Controls.Add(PnBarPass);
            FpPass.Location = new Point(839, 359);
            FpPass.Name = "FpPass";
            FpPass.Size = new Size(488, 70);
            FpPass.TabIndex = 9;
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
            // PnBarPass
            // 
            PnBarPass.Location = new Point(3, 59);
            PnBarPass.Name = "PnBarPass";
            PnBarPass.Size = new Size(480, 28);
            PnBarPass.TabIndex = 1;
            // 
            // FrmLogInE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 758);
            Controls.Add(FpPass);
            Controls.Add(FpUser);
            Controls.Add(LbSignUp);
            Controls.Add(Lbtext);
            Controls.Add(PnBntLogIn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogInE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            Load += FRMLogIn_Load;
            ((System.ComponentModel.ISupportInitialize)Image_User).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_PassWord).EndInit();
            ((System.ComponentModel.ISupportInitialize)Image_Visivel).EndInit();
            PnBntLogIn.ResumeLayout(false);
            FpUser.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            FpPass.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Image_User;
        private PictureBox Image_PassWord;
        private TextBox txtUser;
        private TextBox txtPassWord;
        private PictureBox Image_Visivel;
        private Panel PnBntLogIn;
        private Button BntLogIn;
        private Label Lbtext;
        private LinkLabel LbSignUp;
        private ImageList CbVisivel_Senha;
        private ImageList Cbimage_PassWord;
        private ImageList Cbimage_User;
        private FlowLayoutPanel FpUser;
        private Panel PnBarUser;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel FpPass;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel PnBarPass;
        private BntCircle BntSignUp_C;
    }
}