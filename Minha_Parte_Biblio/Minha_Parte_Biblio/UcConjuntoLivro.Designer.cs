namespace Minha_Parte_Biblio
{
    partial class UcConjuntoLivro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PbLivro = new PictureBox();
            BntReserva = new BntCircle();
            LbNomeAutor = new Label();
            LbNomeLivro = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LbIndisp = new Label();
            ((System.ComponentModel.ISupportInitialize)PbLivro).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // PbLivro
            // 
            PbLivro.BackColor = Color.Transparent;
            PbLivro.BackgroundImageLayout = ImageLayout.Center;
            PbLivro.Location = new Point(6, 26);
            PbLivro.MaximumSize = new Size(210, 263);
            PbLivro.MinimumSize = new Size(210, 263);
            PbLivro.Name = "PbLivro";
            PbLivro.Size = new Size(210, 263);
            PbLivro.SizeMode = PictureBoxSizeMode.Zoom;
            PbLivro.TabIndex = 0;
            PbLivro.TabStop = false;
            // 
            // BntReserva
            // 
            BntReserva.BackColor = Color.FromArgb(118, 136, 169);
            BntReserva.FlatAppearance.BorderSize = 0;
            BntReserva.FlatStyle = FlatStyle.Flat;
            BntReserva.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BntReserva.Location = new Point(1, 406);
            BntReserva.Name = "BntReserva";
            BntReserva.Size = new Size(232, 57);
            BntReserva.TabIndex = 1;
            BntReserva.Text = "Iniciar Reserva";
            BntReserva.UseVisualStyleBackColor = false;
            BntReserva.Click += BntReserva_Click;
            // 
            // LbNomeAutor
            // 
            LbNomeAutor.AutoSize = true;
            LbNomeAutor.BackColor = Color.Transparent;
            LbNomeAutor.Location = new Point(109, 361);
            LbNomeAutor.Name = "LbNomeAutor";
            LbNomeAutor.Size = new Size(165, 20);
            LbNomeAutor.TabIndex = 2;
            LbNomeAutor.Text = "Gabriel García Márquez";
            // 
            // LbNomeLivro
            // 
            LbNomeLivro.AutoSize = true;
            LbNomeLivro.BackColor = Color.Transparent;
            LbNomeLivro.Font = new Font("Segoe UI", 12.8F);
            LbNomeLivro.Location = new Point(3, 0);
            LbNomeLivro.Name = "LbNomeLivro";
            LbNomeLivro.Size = new Size(247, 60);
            LbNomeLivro.TabIndex = 3;
            LbNomeLivro.Text = "Sapiens: Uma Breve História da Humanidade";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(LbNomeLivro);
            flowLayoutPanel1.Location = new Point(10, 299);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(264, 59);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // LbIndisp
            // 
            LbIndisp.AutoSize = true;
            LbIndisp.BackColor = Color.Transparent;
            LbIndisp.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            LbIndisp.Location = new Point(-1, 415);
            LbIndisp.Name = "LbIndisp";
            LbIndisp.Size = new Size(247, 37);
            LbIndisp.TabIndex = 5;
            LbIndisp.Text = "Livro Indisponivel";
            LbIndisp.Visible = false;
            // 
            // UcConjuntoLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.CadaLivro_disp;
            Controls.Add(LbIndisp);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(LbNomeAutor);
            Controls.Add(BntReserva);
            Controls.Add(PbLivro);
            MaximumSize = new Size(314, 465);
            MinimumSize = new Size(314, 465);
            Name = "UcConjuntoLivro";
            Size = new Size(314, 465);
            Load += UcConjuntoLivro_Load;
            ((System.ComponentModel.ISupportInitialize)PbLivro).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbLivro;
        private BntCircle BntReserva;
        private Label LbNomeAutor;
        private Label LbNomeLivro;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbIndisp;
    }
}
