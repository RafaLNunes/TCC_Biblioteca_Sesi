using Aprendendo_MVC;
using Library_Project.modelo;
using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minha_Parte_Biblio
{
    public partial class FrmLivrosADM : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        ClInnerADMsModelo Model_Inner_ADM = new ClInnerADMsModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ModeloUnidade Model_Unit = new ModeloUnidade();

        DataTable data = new DataTable();
        int index = 0;
        int codigo1 = 0;

        public FrmLivrosADM(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            Model_Inner_ADM = admuserview;
            this.Model_User = user;
            ModelADM = ModelAdm;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void FrmLivrosADM_Load(object sender, EventArgs e)
        {
            PopularDTGV();
        }

        void PopularDTGV()
        {
            try
            {
                // Obtendo os dados da consulta
                data = conexao.obterdados($"Select L.Order_Livro as 'Index', L.CD_Livro as 'Registro', L.Nome_Livro as 'Nome Livro', U.Nome_Unidade, L.QTD_estoque as 'Qtd estoque', L.Numb_Paginas as 'Numb Paginas' from Table_Livro L inner join Table_Unidade U on L.CFK_Unidade = U.CD_Unidade Order By L.Order_Livro;");

                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

            StyleDataGridView();
        }

        void StyleDataGridView()
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

        private void BntNoflivro_Click(object sender, EventArgs e)
        {
            FrmMeanADM mean = new FrmMeanADM(Model_Livro, Model_User, Model_Unit, Model_Reserv, Model_Inner_ADM, ModelADM, 5,"0");
            this.Hide();
            mean.ShowDialog();
        }

        private void BntUnit_Click(object sender, EventArgs e)
        {
            FrmMeanADM mena = new FrmMeanADM(Model_Livro, Model_User, Model_Unit, Model_Reserv, Model_Inner_ADM, ModelADM, 6, "0");
            this.Hide(); mena.ShowDialog();
        }

        private void BntRevome_Click(object sender, EventArgs e)
        {
            int exclude = conexao.excluir(0, $"DELETE FROM Table_Livro WHERE Order_Livro = '{Model_Livro.Order_Livro}'", "@CD_Resevas");
            if (exclude > 0)
            {
                MessageBox.Show("Reserva Excluída");

                data = conexao.obterdados($"SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro where Table_Reservas.CFK_User = {Model_User.CD_User}");
                dataGridView.DataSource = data;
            }
            else
            {
                MessageBox.Show("Nenhuma reserva foi encontrada para excluir.");
            }
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;

            // Verifica se o DataGridView possui dados e se a linha selecionada é válida
            if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex >= 0)
            {
                index = dvg.CurrentCell.RowIndex;
                DataGridViewRow row = dvg.Rows[index];

                // Acessando os valores das células pelo índice da coluna
                codigo1 = Convert.ToInt32(row.Cells[0].Value.ToString()); // CD_Reservas
                                                                          // Você pode acessar outros valores assim:
                string nomeLivro = row.Cells[2].Value.ToString(); // Nome_Livro

                LbNome_Obra.Text = nomeLivro;

                DataTable dt_livro = new DataTable();
                dt_livro = conexao.obterdados($"Select * from Table_Livro where Nome_Livro = '{nomeLivro}'");

                Model_Livro.Order_Livro = (int)dt_livro.Rows[0]["Order_Livro"];
                Model_Livro.Nome_Livro = dt_livro.Rows[0]["Nome_Livro"].ToString();
                Model_Livro.QTD_estoque = (int)dt_livro.Rows[0]["QTD_estoque"];
                Model_Livro.Numb_Paginas = (int)dt_livro.Rows[0]["Numb_Paginas"];
                Model_Livro.Edicao_Livro = (int)dt_livro.Rows[0]["Edicao_Livro"];
                Model_Livro.IMG_Livro = dt_livro.Rows[0]["IMG_Livro"].ToString();
                Model_Livro.Descricao_Livro = dt_livro.Rows[0]["Descricao_Livro"].ToString();
                Model_Livro.Index_Unidade = (int)dt_livro.Rows[0]["CFK_Unidade"];
                Model_Livro.CD_Livro = dt_livro.Rows[0]["CD_Livro"].ToString();

                //MessageBox.Show(Model_Livro.Order_Livro + "\n" + Model_Livro.Index_Unidade);

            }
        }
    }
}
