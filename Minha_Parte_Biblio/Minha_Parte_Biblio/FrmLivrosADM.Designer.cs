namespace Minha_Parte_Biblio
{
    partial class FrmLivrosADM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivrosADM));
            BntNoflivro = new BntCircle();
            BntRevome = new BntCircle();
            BntUnit = new BntCircle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LbNome_Obra = new Label();
            clPainelPersonalizado1 = new ClPainelPersonalizado();
            dataGridView = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            clPainelPersonalizado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // BntNoflivro
            // 
            BntNoflivro.BackColor = Color.FromArgb(9, 90, 162);
            BntNoflivro.FlatAppearance.BorderSize = 0;
            BntNoflivro.FlatStyle = FlatStyle.Flat;
            BntNoflivro.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntNoflivro.ForeColor = Color.FromArgb(242, 203, 17);
            BntNoflivro.Location = new Point(1408, 345);
            BntNoflivro.Name = "BntNoflivro";
            BntNoflivro.Size = new Size(264, 106);
            BntNoflivro.TabIndex = 2;
            BntNoflivro.Text = "VER INFORMAÇÕES DO LIVRO";
            BntNoflivro.UseVisualStyleBackColor = false;
            BntNoflivro.Click += BntNoflivro_Click;
            // 
            // BntRevome
            // 
            BntRevome.BackColor = Color.FromArgb(9, 90, 162);
            BntRevome.FlatAppearance.BorderSize = 0;
            BntRevome.FlatStyle = FlatStyle.Flat;
            BntRevome.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntRevome.ForeColor = Color.FromArgb(242, 203, 17);
            BntRevome.Location = new Point(1408, 569);
            BntRevome.Name = "BntRevome";
            BntRevome.Size = new Size(264, 106);
            BntRevome.TabIndex = 3;
            BntRevome.Text = "REMOVER LIVRO";
            BntRevome.UseVisualStyleBackColor = false;
            BntRevome.Click += BntRevome_Click;
            // 
            // BntUnit
            // 
            BntUnit.BackColor = Color.FromArgb(9, 90, 162);
            BntUnit.FlatAppearance.BorderSize = 0;
            BntUnit.FlatStyle = FlatStyle.Flat;
            BntUnit.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntUnit.ForeColor = Color.FromArgb(242, 203, 17);
            BntUnit.Location = new Point(1408, 457);
            BntUnit.Name = "BntUnit";
            BntUnit.Size = new Size(264, 106);
            BntUnit.TabIndex = 3;
            BntUnit.Text = "VER UNIDADES PRESENTES";
            BntUnit.UseVisualStyleBackColor = false;
            BntUnit.Click += BntUnit_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(LbNome_Obra);
            flowLayoutPanel1.Location = new Point(1414, 275);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 64);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // LbNome_Obra
            // 
            LbNome_Obra.AutoSize = true;
            LbNome_Obra.BackColor = Color.White;
            LbNome_Obra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LbNome_Obra.ForeColor = Color.FromArgb(9, 90, 162);
            LbNome_Obra.Location = new Point(3, 0);
            LbNome_Obra.Name = "LbNome_Obra";
            LbNome_Obra.Size = new Size(0, 28);
            LbNome_Obra.TabIndex = 4;
            // 
            // clPainelPersonalizado1
            // 
            clPainelPersonalizado1.BackColor = Color.White;
            clPainelPersonalizado1.BorderRadius = 50;
            clPainelPersonalizado1.Controls.Add(dataGridView);
            clPainelPersonalizado1.ForeColor = Color.White;
            clPainelPersonalizado1.GradientAngle = 90;
            clPainelPersonalizado1.GradientBottomColor = Color.DodgerBlue;
            clPainelPersonalizado1.GradientTopColor = Color.DodgerBlue;
            clPainelPersonalizado1.Location = new Point(108, 131);
            clPainelPersonalizado1.Name = "clPainelPersonalizado1";
            clPainelPersonalizado1.Size = new Size(1221, 584);
            clPainelPersonalizado1.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Cursor = Cursors.Cross;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1221, 584);
            dataGridView.TabIndex = 2;
            dataGridView.CellValueChanged += dataGridView_CellValueChanged;
            dataGridView.Click += dataGridView_Click;
            // 
            // FrmLivrosADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1787, 749);
            Controls.Add(clPainelPersonalizado1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(BntUnit);
            Controls.Add(BntRevome);
            Controls.Add(BntNoflivro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLivrosADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLivrosADM";
            Load += FrmLivrosADM_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            clPainelPersonalizado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BntCircle BntNoflivro;
        private BntCircle BntRevome;
        private BntCircle BntUnit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbNome_Obra;
        private ClPainelPersonalizado clPainelPersonalizado1;
        private DataGridView dataGridView;
    }
}