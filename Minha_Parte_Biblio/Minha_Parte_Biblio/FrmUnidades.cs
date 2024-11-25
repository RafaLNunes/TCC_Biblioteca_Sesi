using Aprendendo_MVC;
using Library_Project.modelo;
using Minha_Parte_Biblio.Modelo;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FrmUnidades : Form
    {
        ClConectection conexao = new ClConectection();

        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloUnidade Model_Unit = new ModeloUnidade();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ClInnerADMsModelo Model_Inner_Adm = new ClInnerADMsModelo();
        int index = 0;
        public FrmUnidades(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            Model_Inner_Adm = admuserview;
            this.Model_User = Model_User;
            ModelADM = ModelAdm;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void PbUnit_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmUnidades_Load(object sender, EventArgs e)
        {
            DataTable dataTable_unit = new DataTable();
            dataTable_unit = conexao.obterdados("Select CD_Unidade as 'Index',Nome_Unidade as 'Nome', Local_Unidade as 'Local' from table_unidade");
            dataGridView.DataSource = dataTable_unit;
            datagridFormat();
        }
        void datagridFormat()
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(9, 90, 162);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            //dataGridView.CellBorderSt yle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 207, 0);
            dataGridView.ForeColor = Color.Black;
            //dataGridView.BackgroundColor = Color.FromArgb(122, 193, 255); 
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            //dataGridView.EnableHeadersVisualStyles = false;
            //dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            //dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 101, 155);
            //dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;

            // Verifica se o DataGridView possui dados e se a linha selecionada é válida
            if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex >= 0)
            {
                index = dvg.CurrentCell.RowIndex;
                DataGridViewRow row = dvg.Rows[index];

                DataTable dt = new DataTable();
                dt = conexao.obterdados($"Select * from table_unidade where CD_Unidade = {row.Cells[0].Value}");

                // Limpa os labels antes de atribuir novos valores
                LbLocalName.Text = string.Empty;
                LbNomeUnit.Text = string.Empty;
                label4.Text = string.Empty;

                LbLocalName.Text = dt.Rows[0]["Local_Unidade"].ToString();
                LbNomeUnit.Text = dt.Rows[0]["Nome_Unidade"].ToString();
                label4.Text = dt.Rows[0]["Descricao_Retirada"].ToString();

                // Libera a imagem anterior, se houver
                if (PbUnit.Image != null)
                {
                    PbUnit.Image.Dispose(); // Libera a imagem anterior
                    PbUnit.Image = null; // Define como null para evitar referências
                }

                //PbUnit.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Unit\\\\", dt.Rows[0]["IMG_Unidade"].ToString()));

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Unit", dt.Rows[0]["IMG_Unidade"].ToString());
                if (File.Exists(imagePath)) // Verifica se o arquivo existe
                {
                    PbUnit.Image = Image.FromFile(imagePath);
                }
                else
                {
                    // Trate o caso em que a imagem não existe, se necessário
                    PbUnit.Image = null; // Ou uma imagem padrão
                }
            }
        }
    }
}
