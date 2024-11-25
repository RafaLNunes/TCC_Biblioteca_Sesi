namespace Minha_Parte_Biblio
{
    partial class FrmUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidades));
            PbUnit = new PictureBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            LbLocalName = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            LbNomeUnit = new Label();
            label2 = new Label();
            clPainelPersonalizado1 = new ClPainelPersonalizado();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PbUnit).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            clPainelPersonalizado1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // PbUnit
            // 
            PbUnit.Location = new Point(915, 371);
            PbUnit.Name = "PbUnit";
            PbUnit.Size = new Size(485, 308);
            PbUnit.SizeMode = PictureBoxSizeMode.StretchImage;
            PbUnit.TabIndex = 14;
            PbUnit.TabStop = false;
            PbUnit.Click += PbUnit_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoScroll = true;
            flowLayoutPanel3.BackColor = Color.Transparent;
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Location = new Point(1406, 371);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(345, 308);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(169, 39);
            label4.TabIndex = 10;
            label4.Text = "Descrição";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Controls.Add(LbLocalName);
            flowLayoutPanel1.Location = new Point(915, 239);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(836, 126);
            flowLayoutPanel1.TabIndex = 16;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // LbLocalName
            // 
            LbLocalName.AutoSize = true;
            LbLocalName.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLocalName.Location = new Point(3, 0);
            LbLocalName.Name = "LbLocalName";
            LbLocalName.Size = new Size(131, 52);
            LbLocalName.TabIndex = 3;
            LbLocalName.Text = "Local";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(LbNomeUnit);
            flowLayoutPanel2.Location = new Point(918, 154);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(833, 79);
            flowLayoutPanel2.TabIndex = 17;
            // 
            // LbNomeUnit
            // 
            LbNomeUnit.AutoSize = true;
            LbNomeUnit.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold);
            LbNomeUnit.ForeColor = Color.Black;
            LbNomeUnit.Location = new Point(3, 0);
            LbNomeUnit.Name = "LbNomeUnit";
            LbNomeUnit.Size = new Size(143, 52);
            LbNomeUnit.TabIndex = 10;
            LbNomeUnit.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(912, 163);
            label2.Name = "label2";
            label2.Size = new Size(0, 91);
            label2.TabIndex = 18;
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
            clPainelPersonalizado1.Location = new Point(39, 163);
            clPainelPersonalizado1.Name = "clPainelPersonalizado1";
            clPainelPersonalizado1.Size = new Size(811, 551);
            clPainelPersonalizado1.TabIndex = 19;
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
            dataGridView.Size = new Size(811, 551);
            dataGridView.TabIndex = 2;
            dataGridView.Click += dataGridView_Click;
            // 
            // FrmUnidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1787, 749);
            Controls.Add(clPainelPersonalizado1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(PbUnit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUnidades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUnidades";
            Load += FrmUnidades_Load;
            ((System.ComponentModel.ISupportInitialize)PbUnit).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            clPainelPersonalizado1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PbUnit;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label LbLocalName;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label LbNomeUnit;
        private Label label2;
        private ClPainelPersonalizado clPainelPersonalizado1;
        private DataGridView dataGridView;
    }
}