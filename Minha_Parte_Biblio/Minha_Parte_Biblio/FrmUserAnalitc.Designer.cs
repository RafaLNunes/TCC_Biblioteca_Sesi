namespace Minha_Parte_Biblio
{
    partial class FrmUserAnalitc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserAnalitc));
            cbunidade = new ComboBox();
            cbcargo = new ComboBox();
            cbanoescolar = new ComboBox();
            txtidaluno = new TextBox();
            txtnomecompleto = new TextBox();
            txtusername = new TextBox();
            txtsenha = new TextBox();
            fotousuario = new PictureBox();
            BntSalvAlt = new BntCircle();
            ((System.ComponentModel.ISupportInitialize)fotousuario).BeginInit();
            SuspendLayout();
            // 
            // cbunidade
            // 
            cbunidade.FormattingEnabled = true;
            cbunidade.Location = new Point(701, 120);
            cbunidade.Name = "cbunidade";
            cbunidade.Size = new Size(446, 28);
            cbunidade.TabIndex = 18;
            // 
            // cbcargo
            // 
            cbcargo.FormattingEnabled = true;
            cbcargo.Location = new Point(701, 429);
            cbcargo.Name = "cbcargo";
            cbcargo.Size = new Size(446, 28);
            cbcargo.TabIndex = 17;
            // 
            // cbanoescolar
            // 
            cbanoescolar.FormattingEnabled = true;
            cbanoescolar.Location = new Point(701, 272);
            cbanoescolar.Name = "cbanoescolar";
            cbanoescolar.Size = new Size(446, 28);
            cbanoescolar.TabIndex = 16;
            // 
            // txtidaluno
            // 
            txtidaluno.BorderStyle = BorderStyle.None;
            txtidaluno.Location = new Point(184, 433);
            txtidaluno.Name = "txtidaluno";
            txtidaluno.Size = new Size(445, 20);
            txtidaluno.TabIndex = 15;
            // 
            // txtnomecompleto
            // 
            txtnomecompleto.BorderStyle = BorderStyle.None;
            txtnomecompleto.Location = new Point(182, 279);
            txtnomecompleto.Name = "txtnomecompleto";
            txtnomecompleto.Size = new Size(446, 20);
            txtnomecompleto.TabIndex = 14;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(183, 124);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(445, 20);
            txtusername.TabIndex = 13;
            // 
            // txtsenha
            // 
            txtsenha.BorderStyle = BorderStyle.None;
            txtsenha.Location = new Point(184, 588);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(445, 20);
            txtsenha.TabIndex = 19;
            // 
            // fotousuario
            // 
            fotousuario.BackColor = Color.Transparent;
            fotousuario.Location = new Point(1305, 90);
            fotousuario.Name = "fotousuario";
            fotousuario.Size = new Size(405, 616);
            fotousuario.SizeMode = PictureBoxSizeMode.StretchImage;
            fotousuario.TabIndex = 20;
            fotousuario.TabStop = false;
            // 
            // BntSalvAlt
            // 
            BntSalvAlt.BackColor = Color.FromArgb(9, 90, 162);
            BntSalvAlt.FlatAppearance.BorderColor = Color.Black;
            BntSalvAlt.FlatAppearance.BorderSize = 0;
            BntSalvAlt.FlatStyle = FlatStyle.Flat;
            BntSalvAlt.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            BntSalvAlt.ForeColor = Color.FromArgb(242, 203, 17);
            BntSalvAlt.Location = new Point(701, 551);
            BntSalvAlt.Name = "BntSalvAlt";
            BntSalvAlt.Size = new Size(446, 79);
            BntSalvAlt.TabIndex = 21;
            BntSalvAlt.Text = "Salvar Alterações";
            BntSalvAlt.UseVisualStyleBackColor = false;
            BntSalvAlt.Click += BntSalvAlt_Click;
            // 
            // FrmUserAnalitc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1787, 749);
            Controls.Add(BntSalvAlt);
            Controls.Add(fotousuario);
            Controls.Add(txtsenha);
            Controls.Add(cbunidade);
            Controls.Add(cbcargo);
            Controls.Add(cbanoescolar);
            Controls.Add(txtidaluno);
            Controls.Add(txtnomecompleto);
            Controls.Add(txtusername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserAnalitc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUserAnalitc";
            Load += FrmUserAnalitc_Load;
            ((System.ComponentModel.ISupportInitialize)fotousuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbunidade;
        private ComboBox cbcargo;
        private ComboBox cbanoescolar;
        private TextBox txtidaluno;
        private TextBox txtnomecompleto;
        private TextBox txtusername;
        private TextBox txtsenha;
        private PictureBox fotousuario;
        private BntCircle BntSalvAlt;
    }
}