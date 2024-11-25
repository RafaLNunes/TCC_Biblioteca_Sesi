namespace Minha_Parte_Biblio
{
    partial class FrmUserADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserADM));
            clPainelPersonalizado1 = new ClPainelPersonalizado();
            dataGridView = new DataGridView();
            bntCircle1 = new BntCircle();
            bntCircle2 = new BntCircle();
            bntCircle3 = new BntCircle();
            bntCircle4 = new BntCircle();
            bntCircle5 = new BntCircle();
            clPainelPersonalizado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
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
            clPainelPersonalizado1.Location = new Point(100, 129);
            clPainelPersonalizado1.Name = "clPainelPersonalizado1";
            clPainelPersonalizado1.Size = new Size(1231, 591);
            clPainelPersonalizado1.TabIndex = 4;
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
            dataGridView.Size = new Size(1231, 591);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.Click += dataGridView_Click;
            // 
            // bntCircle1
            // 
            bntCircle1.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle1.FlatAppearance.BorderSize = 0;
            bntCircle1.FlatStyle = FlatStyle.Flat;
            bntCircle1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle1.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle1.Location = new Point(1401, 267);
            bntCircle1.Name = "bntCircle1";
            bntCircle1.Size = new Size(275, 104);
            bntCircle1.TabIndex = 5;
            bntCircle1.Text = "VISUALIZAR USUÁRIO";
            bntCircle1.UseVisualStyleBackColor = false;
            bntCircle1.Click += bntCircle1_Click;
            // 
            // bntCircle2
            // 
            bntCircle2.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle2.FlatAppearance.BorderSize = 0;
            bntCircle2.FlatStyle = FlatStyle.Flat;
            bntCircle2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle2.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle2.Location = new Point(1401, 377);
            bntCircle2.Name = "bntCircle2";
            bntCircle2.Size = new Size(275, 104);
            bntCircle2.TabIndex = 6;
            bntCircle2.Text = "VER RESERVAS DO USUÁRIO";
            bntCircle2.UseVisualStyleBackColor = false;
            bntCircle2.Click += bntCircle2_Click;
            // 
            // bntCircle3
            // 
            bntCircle3.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle3.FlatAppearance.BorderSize = 0;
            bntCircle3.FlatStyle = FlatStyle.Flat;
            bntCircle3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle3.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle3.Location = new Point(1401, 487);
            bntCircle3.Name = "bntCircle3";
            bntCircle3.Size = new Size(275, 104);
            bntCircle3.TabIndex = 7;
            bntCircle3.Text = "VER HISTÓRICO DO USUÁRIO";
            bntCircle3.UseVisualStyleBackColor = false;
            bntCircle3.Click += bntCircle3_Click;
            // 
            // bntCircle4
            // 
            bntCircle4.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle4.FlatAppearance.BorderSize = 0;
            bntCircle4.FlatStyle = FlatStyle.Flat;
            bntCircle4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle4.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle4.Location = new Point(1401, 597);
            bntCircle4.Name = "bntCircle4";
            bntCircle4.Size = new Size(275, 104);
            bntCircle4.TabIndex = 8;
            bntCircle4.Text = "EXCLUIR USUÁRIO";
            bntCircle4.UseVisualStyleBackColor = false;
            bntCircle4.Click += bntCircle4_Click;
            // 
            // bntCircle5
            // 
            bntCircle5.BackColor = Color.FromArgb(9, 90, 162);
            bntCircle5.FlatAppearance.BorderSize = 0;
            bntCircle5.FlatStyle = FlatStyle.Flat;
            bntCircle5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntCircle5.ForeColor = Color.FromArgb(242, 203, 17);
            bntCircle5.Location = new Point(1401, 157);
            bntCircle5.Name = "bntCircle5";
            bntCircle5.Size = new Size(275, 104);
            bntCircle5.TabIndex = 9;
            bntCircle5.Text = "VER TODOS";
            bntCircle5.UseVisualStyleBackColor = false;
            bntCircle5.Click += bntCircle5_Click;
            // 
            // FrmUserADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1787, 749);
            Controls.Add(bntCircle5);
            Controls.Add(bntCircle4);
            Controls.Add(bntCircle3);
            Controls.Add(bntCircle2);
            Controls.Add(bntCircle1);
            Controls.Add(clPainelPersonalizado1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUserADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUserADM";
            Load += FrmUserADM_Load;
            clPainelPersonalizado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ClPainelPersonalizado clPainelPersonalizado1;
        private DataGridView dataGridView;
        private BntCircle bntCircle1;
        private BntCircle bntCircle2;
        private BntCircle bntCircle3;
        private BntCircle bntCircle4;
        private BntCircle bntCircle5;
    }
}