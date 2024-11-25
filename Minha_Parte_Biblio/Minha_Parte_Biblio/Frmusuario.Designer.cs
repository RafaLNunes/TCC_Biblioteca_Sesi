namespace usuario
{
    partial class Frmusuario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmusuario));
            txtusername = new TextBox();
            txtnomecompleto = new TextBox();
            txtidaluno = new TextBox();
            vhrusuario1 = new Button();
            btnsalvaralteracao = new Button();
            sausuario = new Panel();
            lblvhrusuario = new Panel();
            fotousuario = new PictureBox();
            cbanoescolar = new ComboBox();
            cbcargo = new ComboBox();
            cbunidade = new ComboBox();
            txtsenha = new TextBox();
            sausuario.SuspendLayout();
            lblvhrusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fotousuario).BeginInit();
            SuspendLayout();
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(38, 124);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 20);
            txtusername.TabIndex = 0;
            txtusername.TextChanged += textBox1_TextChanged;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.BorderStyle = BorderStyle.None;
            txtnomecompleto.Location = new Point(37, 279);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.Size = new Size(446, 20);
            txtnomecompleto.TabIndex = 1;
            // 
            // txtidaluno
            // 
            txtidaluno.BorderStyle = BorderStyle.None;
            txtidaluno.Location = new Point(39, 434);
            txtidaluno.Name = "txtidaluno";
            txtidaluno.Size = new Size(445, 20);
            txtidaluno.TabIndex = 3;
            // 
            // vhrusuario1
            // 
            vhrusuario1.BackColor = Color.Transparent;
            vhrusuario1.FlatStyle = FlatStyle.Popup;
            vhrusuario1.Location = new Point(-11, 0);
            vhrusuario1.Name = "vhrusuario1";
            vhrusuario1.Size = new Size(473, 73);
            vhrusuario1.TabIndex = 5;
            vhrusuario1.UseVisualStyleBackColor = false;
            vhrusuario1.Click += vhrusuario1_Click;
            // 
            // btnsalvaralteracao
            // 
            btnsalvaralteracao.BackColor = Color.Transparent;
            btnsalvaralteracao.FlatStyle = FlatStyle.Popup;
            btnsalvaralteracao.Location = new Point(-10, -20);
            btnsalvaralteracao.Name = "btnsalvaralteracao";
            btnsalvaralteracao.Size = new Size(473, 83);
            btnsalvaralteracao.TabIndex = 6;
            btnsalvaralteracao.UseVisualStyleBackColor = false;
            btnsalvaralteracao.Click += btnsalvaralteracao_Click;
            // 
            // sausuario
            // 
            sausuario.BackColor = Color.Transparent;
            sausuario.Controls.Add(btnsalvaralteracao);
            sausuario.Location = new Point(561, 632);
            sausuario.Name = "sausuario";
            sausuario.Size = new Size(446, 55);
            sausuario.TabIndex = 7;
            // 
            // lblvhrusuario
            // 
            lblvhrusuario.BackColor = Color.Transparent;
            lblvhrusuario.Controls.Add(vhrusuario1);
            lblvhrusuario.Location = new Point(562, 533);
            lblvhrusuario.Name = "lblvhrusuario";
            lblvhrusuario.Size = new Size(445, 55);
            lblvhrusuario.TabIndex = 8;
            // 
            // fotousuario
            // 
            fotousuario.BackColor = Color.Transparent;
            fotousuario.Location = new Point(1085, 91);
            fotousuario.Name = "fotousuario";
            fotousuario.Size = new Size(362, 551);
            fotousuario.SizeMode = PictureBoxSizeMode.StretchImage;
            fotousuario.TabIndex = 9;
            fotousuario.TabStop = false;
            fotousuario.Click += fotousuario_Click;
            // 
            // cbanoescolar
            // 
            cbanoescolar.FormattingEnabled = true;
            cbanoescolar.Location = new Point(556, 272);
            cbanoescolar.Name = "cbanoescolar";
            cbanoescolar.Size = new Size(446, 28);
            cbanoescolar.TabIndex = 10;
            // 
            // cbcargo
            // 
            cbcargo.FormattingEnabled = true;
            cbcargo.Location = new Point(556, 429);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(446, 28);
            cbcargo.TabIndex = 11;
            // 
            // cbunidade
            // 
            cbunidade.FormattingEnabled = true;
            cbunidade.Location = new Point(556, 120);
            cbunidade.Name = "cbunidade";
            cbunidade.Size = new Size(446, 28);
            cbunidade.TabIndex = 12;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.None;
            txtsenha.Location = new Point(37, 587);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(445, 20);
            txtsenha.TabIndex = 13;
            // 
            // Frmusuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1500, 785);
            Controls.Add(txtsenha);
            Controls.Add(cbunidade);
            Controls.Add(cbcargo);
            Controls.Add(cbanoescolar);
            Controls.Add(fotousuario);
            Controls.Add(lblvhrusuario);
            Controls.Add(sausuario);
            Controls.Add(txtidaluno);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmusuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuario";
            FormClosed += Frmusuario_FormClosed;
            Load += Frmusuario_Load;
            sausuario.ResumeLayout(false);
            lblvhrusuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fotousuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtusername;
        private TextBox txtnomecompleto;
        private TextBox txtidaluno;
        private Button vhrusuario1;
        private Button btnsalvaralteracao;
        private Panel sausuario;
        private Panel lblvhrusuario;
        private PictureBox fotousuario;
        private ComboBox cbanoescolar;
        private ComboBox cbcargo;
        private ComboBox cbunidade;
        private TextBox txtsenha;
    }
}
