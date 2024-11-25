using Aprendendo_MVC;
using Library_Project;
using Library_Project.controle;
using Library_Project.modelo;
using Minha_Parte_Biblio.Controle;
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

namespace usuario
{
    public partial class FrmhistLivros : Form
    {
        /* =====Importação das class de modelo===== */
        ClUserModelo Model_User = new ClUserModelo(); // responsavel por importar info dos users
        ModeloLivro Model_Livro = new ModeloLivro(); // responsavel por importar info dos livros
        ModeloReservas Model_Reserv = new ModeloReservas(); // resposavel por importar info das reservas
        ModeloUnidade Model_Unit = new ModeloUnidade(); // responsavel por importar info das unidades 

        ClConectection conexao = new ClConectection(); // responsavel pela conexao com a dt

        /* =====Importação das class de controle===== */
        ClUsercontrole Controle_User = new ClUsercontrole();
        ControleLivro Controle_Livro = new ControleLivro();
        ControleReservas Controle_Reserv = new ControleReservas();

        DataTable data = new DataTable();
        int index = 0;
        int codigo1 = 0;
        string codi = "";
        string Codigo_Livro = "";
        public FrmhistLivros(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;

            InitializeComponent();
        }

        private void FrmhistLivros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmhistLivros_Load(object sender, EventArgs e)
        {


            try
            {
                // Obter os dados
                var data = conexao.obterdados($"SELECT Table_Livro.CD_Livro, Table_Livro.Nome_Livro, Table_Livro.Edicao_Livro, Table_Unidade.Nome_Unidade, Table_Historico.DT_reserva, Table_Historico.DT_devolucao FROM Table_Historico INNER JOIN Table_Livro ON Table_Historico.CFK_Livro = Table_Livro.Order_Livro INNER JOIN Table_Unidade ON Table_Livro.CFK_Unidade = Table_Unidade.CD_Unidade where Table_Historico.CFK_User = {Model_User.CD_User};");
                nlivros.Text = data.Rows.Count.ToString();
                // Limpar colunas existentes (se necessário)
                dataGridView.Columns.Clear();

                // Adicionar coluna de botão
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Informação"; // Nome da coluna
                btnColumn.Text = "Ver Livro"; // Texto do botão
                btnColumn.UseColumnTextForButtonValue = true; // Faz com que todos os botões mostrem o mesmo texto
                dataGridView.Columns.Add(btnColumn);

                // Adicionando o evento CellPainting para customizar o botão
                dataGridView.CellPainting += dataGridView_CellPainting;

                // Manipulação do evento CellClick para ações quando o botão é clicado
                dataGridView.CellClick += dataGridView_CellClick;

                // Definindo a fonte de dados do DataGridView
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            StyleDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {
   
        }
        void StyleDataGridView()
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.RowHeadersVisible = false;
            //dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(9, 90, 162);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 2 && e.RowIndex == 0) // Verifica se a célula clicada está na coluna do botão
            {
                // Ação a ser realizada quando o botão é clicado
                MessageBox.Show("Botão 'Ver Livro' clicado na linha: " + e.RowIndex);
            }
            //aqui coloca a função do button que faça usando o index do livro ou index da table hist


            // CD_Livro
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                // Obtém o valor da célula clicada
                var valorClicado = dataGridView.Rows[e.RowIndex].Cells["CD_Livro"].Value;

                // Verifica se o valor não é nulo e o converte para o tipo desejado
                if (valorClicado != null)
                {
                    Codigo_Livro = valorClicado.ToString(); // Armazena o valor na variável
                    MessageBox.Show("Código do Livro: " + Codigo_Livro);
                }
            }
            // Model_Livro.CD = CD_livro;
            Model_Livro.CD_Livro = Codigo_Livro;
            INFO_Livro info = new INFO_Livro(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            info.ShowDialog();


        }

        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // 0 é o índice da coluna do botão
            {
                // Pinta o fundo da célula
                e.PaintBackground(e.ClipBounds, true);

                // Crie um retângulo para o botão
                Rectangle buttonRect = e.CellBounds;
                buttonRect.Inflate(-2, -2); // Ajusta o tamanho do retângulo para dar um espaço

                // Defina as cores usando os valores RGB fornecidos
                Color azul = Color.FromArgb(9, 90, 162); // Azul
                Color amarelo = Color.FromArgb(242, 203, 17); // Amarelo

                // Desenha o botão com as cores desejadas
                using (Brush blueBrush = new SolidBrush(azul))
                {
                    e.Graphics.FillRectangle(blueBrush, buttonRect); // Cor de fundo azul
                }

                // Desenhe o texto do botão
                TextRenderer.DrawText(e.Graphics, "Ver Livro",
                    new Font("Arial", 10, FontStyle.Bold),
                    buttonRect, amarelo, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                // Indica que a célula foi tratada
                e.Handled = true;
            }
        }

    }
}

