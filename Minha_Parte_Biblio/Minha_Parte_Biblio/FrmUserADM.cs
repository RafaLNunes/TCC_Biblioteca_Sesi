using Aprendendo_MVC;
using Library_Project.modelo;
using Minha_Parte_Biblio.Modelo;
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
    public partial class FrmUserADM : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        ClInnerADMsModelo Model_Inner_Adm = new ClInnerADMsModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ModeloUnidade Model_Unit = new ModeloUnidade();

        DataTable data = new DataTable();
        DataTable data_dados = new DataTable();

        int index = 0;
        int pag = 0;

        public FrmUserADM(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            Model_Inner_Adm = admuserview;
            this.Model_User = user;
            ModelADM = ModelAdm;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void FrmUserADM_Load(object sender, EventArgs e)
        {
            atualizarData();


        }

        void atualizarData()
        {
            try
            {
                //0
                // Obtendo os dados da consulta
                data = conexao.obterdados($"SELECT \r\n    u.CD_User \"Index\",\r\n    u.ID_Aluno as \"ID\",\r\n    u.Nome_Completo as \"Nome Completo\",\r\n    u.NameUser as \"NameUser\",\r\n    c.Cargo as \"Cargo\",\r\n    a.Ano_Escolar as \"Ano\",\r\n    un.Nome_Unidade as \"Unidade\",\r\n    COUNT(r.CD_Reservas) AS \"Numb Reservas\",\r\n    COUNT(h.CD_Hist) AS \"Numb Histórico\"\r\nFROM \r\n    Table_User u\r\nINNER JOIN \r\n    Table_Cargo c ON u.CFK_Cargo = c.CD_Cargo\r\nINNER JOIN \r\n    Table_Ano_Escolar a ON u.CFK_Ano = a.CD_Ano_Escolar\r\nINNER JOIN \r\n    Table_Unidade un ON u.CFK_Unidade = un.CD_Unidade\r\nLEFT JOIN \r\n    Table_Reservas r ON u.CD_User = r.CFK_User\r\nLEFT JOIN \r\n    Table_Historico h ON u.CD_User = h.CFK_User\r\nGROUP BY \r\n    u.CD_User, u.ID_Aluno, u.Nome_Completo, u.NameUser , u.IMG_User, c.Cargo, a.Ano_Escolar, un.Nome_Unidade;");

                // Limpar colunas existentes (se necessário)
                dataGridView.Columns.Clear();
                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
                StyleDataGridView();
                //formatDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        void formatDataGrid()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Acessar os valores das células
                string cargoValue = row.Cells["Cargo"].Value?.ToString();
                string anoValue = row.Cells["Ano"].Value?.ToString();
                MessageBox.Show(cargoValue + "\n" + anoValue);

                // Verificar as condições
                if (cargoValue == "Gerente" && anoValue == "Diretoria")
                {
                    MessageBox.Show("É: " + cargoValue + "\nÉ:" + anoValue);
                    // Definir a cor de fundo da linha como vermelho e a cor da fonte como preto
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        void PopularDTVGReserv()
        {
            //1
            try
            {
                data = conexao.obterdados($"SELECT Table_Reservas.CD_Reservas, Table_Livro.Nome_Livro, Table_reservas.DT_reserva, Table_reservas.DT_previsao_devolucao FROM Table_reservas INNER JOIN Table_Livro ON Table_Reservas.CFK_Livro = Table_Livro.Order_Livro where Table_Reservas.CFK_User = {Model_Inner_Adm.Index}");
                dataGridView.Columns.Clear();
                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
                StyleDataGridView();
                //formatDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        void PopularDTVGHist()
        {
            //2
            try
            {

                // Obtendo os dados da consulta
                data = conexao.obterdados($"SELECT Table_Livro.CD_Livro, Table_Livro.Nome_Livro, Table_Livro.Edicao_Livro, Table_Unidade.Nome_Unidade, Table_Historico.DT_reserva, Table_Historico.DT_devolucao FROM Table_Historico INNER JOIN Table_Livro ON Table_Historico.CFK_Livro = Table_Livro.Order_Livro INNER JOIN Table_Unidade ON Table_Livro.CFK_Unidade = Table_Unidade.CD_Unidade where Table_Historico.CFK_User = {Model_Inner_Adm.Index};");

                // Limpar colunas existentes (se necessário)
                dataGridView.Columns.Clear();
                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
                StyleDataGridView();
                //formatDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }


        }

        void StyleDataGridView()
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(9, 90, 162);
            //dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            DataGridView dvg = (DataGridView)sender;

            // Verifica se o DataGridView possui dados e se a linha selecionada é válida
            if (dvg.Rows.Count > 0 && dvg.CurrentCell.RowIndex >= 0 && pag == 0)
            {
                index = dvg.CurrentCell.RowIndex;
                DataGridViewRow row = dvg.Rows[index];

                Model_Inner_Adm.Index = Convert.ToInt32(row.Cells["Index"].Value);
                Model_Inner_Adm.ID_Aluno = row.Cells["ID"].Value.ToString();
                Model_Inner_Adm.NomeCompleto = row.Cells["Nome Completo"].Value.ToString();
                Model_Inner_Adm.UserName = row.Cells["NameUser"].Value.ToString();
                Model_Inner_Adm.Cargo = row.Cells["Cargo"].Value.ToString();
                Model_Inner_Adm.Ano = row.Cells["Ano"].Value.ToString();
                Model_Inner_Adm.Unidade = row.Cells["Unidade"].Value.ToString();
                Model_Inner_Adm.NumbReservas = Convert.ToInt32(row.Cells["Numb Reservas"].Value);
                Model_Inner_Adm.NumbHistorico = Convert.ToInt32(row.Cells["Numb Histórico"].Value);

                //MessageBox.Show(Modelo_Inner_Users.Index.ToString());
                //MessageBox.Show(Modelo_Inner_Users.NumbHistorico.ToString());



            }
        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            FrmMeanADM mean = new FrmMeanADM(Model_Livro, Model_User, Model_Unit, Model_Reserv, Model_Inner_Adm, ModelADM, 4, "0");
            this.Hide();
            mean.ShowDialog();
        }

        private void bntCircle2_Click(object sender, EventArgs e)
        {
            pag = 1;
            PopularDTVGReserv();
        }

        private void bntCircle3_Click(object sender, EventArgs e)
        {
            pag = 2;
            PopularDTVGHist();
        }

        private void bntCircle4_Click(object sender, EventArgs e)
        {
            int exclude = conexao.excluir(0, $"DELETE FROM Table_User WHERE CD_User = {Model_Inner_Adm.Index};", "@CD_User");
            if (exclude > 0)
            {
                MessageBox.Show("Reserva Excluída");

                switch (pag)
                {
                    case 0:
                        atualizarData();
                        break;
                    case 1:
                        PopularDTVGReserv();
                        break;
                    case 2:
                        PopularDTVGHist();
                        break;
                    default:
                        atualizarData();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma reserva foi encontrada para excluir.");
            }
        }

        private void bntCircle5_Click(object sender, EventArgs e)
        {
            pag = 0;
            atualizarData();
        }
    }
}
