namespace Minha_Parte_Biblio
{
    partial class FrmReservADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservADM));
            BntExtender = new BntCircle();
            BntCancel = new BntCircle();
            clPainelPersonalizado1 = new ClPainelPersonalizado();
            dataGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LbNome_Obra = new Label();
            PbcUser = new PictureBox();
            clPainelPersonalizado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbcUser).BeginInit();
            SuspendLayout();
            // 
            // BntExtender
            // 
            BntExtender.BackColor = Color.FromArgb(9, 90, 162);
            BntExtender.FlatAppearance.BorderSize = 0;
            BntExtender.FlatStyle = FlatStyle.Flat;
            BntExtender.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntExtender.ForeColor = Color.FromArgb(242, 203, 17);
            BntExtender.Location = new Point(1407, 493);
            BntExtender.Name = "BntExtender";
            BntExtender.Size = new Size(267, 109);
            BntExtender.TabIndex = 0;
            BntExtender.Text = "EXTENDER RESERVA";
            BntExtender.UseVisualStyleBackColor = false;
            BntExtender.Click += bntCircle1_Click;
            // 
            // BntCancel
            // 
            BntCancel.BackColor = Color.FromArgb(9, 90, 162);
            BntCancel.FlatAppearance.BorderSize = 0;
            BntCancel.FlatStyle = FlatStyle.Flat;
            BntCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BntCancel.ForeColor = Color.FromArgb(242, 203, 17);
            BntCancel.Location = new Point(1407, 608);
            BntCancel.Name = "BntCancel";
            BntCancel.Size = new Size(267, 109);
            BntCancel.TabIndex = 1;
            BntCancel.Text = "DESFAZER RESERVA";
            BntCancel.UseVisualStyleBackColor = false;
            BntCancel.Click += BntCancel_Click;
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
            clPainelPersonalizado1.Location = new Point(97, 143);
            clPainelPersonalizado1.Name = "clPainelPersonalizado1";
            clPainelPersonalizado1.Size = new Size(1231, 574);
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
            dataGridView.Size = new Size(1231, 574);
            dataGridView.TabIndex = 2;
            dataGridView.Click += dataGridView_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(LbNome_Obra);
            flowLayoutPanel1.Location = new Point(1409, 424);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 64);
            flowLayoutPanel1.TabIndex = 7;
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
            // PbcUser
            // 
            PbcUser.BackColor = Color.White;
            PbcUser.Location = new Point(1461, 221);
            PbcUser.Name = "PbcUser";
            PbcUser.Size = new Size(158, 197);
            PbcUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PbcUser.TabIndex = 8;
            PbcUser.TabStop = false;
            // 
            // FrmReservADM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1787, 749);
            Controls.Add(PbcUser);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(clPainelPersonalizado1);
            Controls.Add(BntCancel);
            Controls.Add(BntExtender);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReservADM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReservADM";
            Load += FrmReservADM_Load;
            clPainelPersonalizado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PbcUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BntCircle BntExtender;
        private BntCircle BntCancel;
        private ClPainelPersonalizado clPainelPersonalizado1;
        private DataGridView dataGridView;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbNome_Obra;
        private PictureBox PbcUser;
    }
}