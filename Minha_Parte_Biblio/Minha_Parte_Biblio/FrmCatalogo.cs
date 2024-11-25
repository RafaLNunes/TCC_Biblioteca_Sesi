using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Microsoft.VisualBasic.ApplicationServices;
using Minha_Parte_Biblio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace usuario
{
    public partial class FrmCatalogo : Form
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

        //CbCargo.DataSource = conexao.obterdados("select * from Table_Cargo");
        //CbCargo.DisplayMember = "Cargo";
        //CbCargo.ValueMember = "CD_Cargo";
        //CbCargo.Text = String.Empty;



        public FrmCatalogo(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();

            DataTable DT_Livros = new DataTable();
            DT_Livros = conexao.obterdados("select * from Table_Livro");
            UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[36];

            DataTable DT_Reserv = new DataTable();
            DT_Reserv = conexao.obterdados("select * from Table_reservas");

            for (int i = 0; i < DT_Livros.Rows.Count; i++)
            {
                Conj_Livro[i] = new UcConjuntoLivro(Model_User);

                Conj_Livro[i].NomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString();
                Conj_Livro[i].Autor = DT_Livros.Rows[i]["Autor_Livro"].ToString();
                Conj_Livro[i].Cod_Livro = DT_Livros.Rows[i]["CD_Livro"].ToString();
                Conj_Livro[i].Order_Livro = (int)DT_Livros.Rows[i]["Order_Livro"];

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books\\\\", DT_Livros.Rows[i]["IMG_Livro"].ToString());

                // Verifica se a imagem existe
                if (File.Exists(imagePath))
                {
                    var img = Image.FromFile(imagePath);
                    Conj_Livro[i].IMG_cam = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
                    img.Dispose();
                }

                // Verificação se o livro está reservado
                bool livroReservado = false;
                for (int j = 0; j < DT_Reserv.Rows.Count; j++)
                {
                    if (DT_Reserv.Rows[j]["CFK_Livro"] != DBNull.Value && (int)DT_Reserv.Rows[j]["CFK_Livro"] == Conj_Livro[i].Order_Livro)
                    {
                        livroReservado = true;
                        break; // Sai do loop se o livro for encontrado como reservado
                    }
                }

                // Se o livro estiver reservado, chama o método Visibilidade
                if (livroReservado)
                {
                    Conj_Livro[i].Visibilidade();
                }

                    FPConteinerCat.Controls.Add(Conj_Livro[i]);

            }


            /*
             * 
             * DataTable DT_Livros = conexao.obterdados("select * from Table_Livro");
UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[DT_Livros.Rows.Count];

for (int i = 0; i < DT_Livros.Rows.Count; i++)
{
    Conj_Livro[i] = new UcConjuntoLivro
    {
        Cod_Livro = (int)DT_Livros.Rows[i]["Order_Livro"],
        NomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString(),
        Autor = DT_Livros.Rows[i]["Autor_Livro"].ToString()
    };

    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books", DT_Livros.Rows[i]["IMG_Livro"].ToString());
    
    // Verifica se a imagem existe
    if (File.Exists(imagePath))
    {   
        using (var img = Image.FromFile(imagePath))
        {
            Conj_Livro[i].IMG_cam = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
        }
    }

    FPConteinerCat.Controls.Add(Conj_Livro[i]);
}
             * 
             */

        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            // Obter os dados da tabela
            DataTable livros = conexao.obterdados("SELECT Nome_Livro FROM Table_Livro");

            // tornando a TextBox para AutoComplete
            //textPesquisa.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // faz o complemento de forma automatica no textbox
            textPesquisa.AutoCompleteSource = AutoCompleteSource.CustomSource; // gera a caixa de sugestões



            // Criar a coleção para o AutoComplete
            var autoCompleteData = new AutoCompleteStringCollection();

            // Adicionar os nomes dos livros ao AutoCompleteCustomSource
            for (int i = 0; i < livros.Rows.Count; i++)
            {
                autoCompleteData.Add(livros.Rows[i]["Nome_Livro"].ToString());
            }

            textPesquisa.AutoCompleteCustomSource = autoCompleteData;

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void BntPesquisa_Click(object sender, EventArgs e)
        {
            FPConteinerCat.Controls.Clear();

            DataTable DT_Livros = new DataTable();
            DT_Livros = conexao.obterdados("select * from Table_Livro");
            UcConjuntoLivro[] Conj_Livro = new UcConjuntoLivro[36];

            DataTable DT_Reserv = new DataTable();
            DT_Reserv = conexao.obterdados("select * from Table_reservas");

            for (int i = 0; i < DT_Livros.Rows.Count; i++)
            {
                Conj_Livro[i] = new UcConjuntoLivro(Model_User);

                Conj_Livro[i].NomeLivro = DT_Livros.Rows[i]["Nome_Livro"].ToString();
                Conj_Livro[i].Autor = DT_Livros.Rows[i]["Autor_Livro"].ToString();
                Conj_Livro[i].Cod_Livro = DT_Livros.Rows[i]["CD_Livro"].ToString();
                Conj_Livro[i].Order_Livro = (int)DT_Livros.Rows[i]["Order_Livro"];

                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books\\\\", DT_Livros.Rows[i]["IMG_Livro"].ToString());

                // Verifica se a imagem existe
                if (File.Exists(imagePath))
                {
                    var img = Image.FromFile(imagePath);
                    Conj_Livro[i].IMG_cam = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
                    img.Dispose();
                }

                // Verificação se o livro está reservado
                bool livroReservado = false;
                for (int j = 0; j < DT_Reserv.Rows.Count; j++)
                {
                    if (DT_Reserv.Rows[j]["CFK_Livro"] != DBNull.Value && (int)DT_Reserv.Rows[j]["CFK_Livro"] == Conj_Livro[i].Order_Livro)
                    {
                        livroReservado = true;
                        break; // Sai do loop se o livro for encontrado como reservado
                    }
                }

                // Se o livro estiver reservado, chama o método Visibilidade
                if (livroReservado)
                {
                    Conj_Livro[i].Visibilidade();
                }

                if (textPesquisa.Text != null && Conj_Livro[i].NomeLivro.ToLower().Contains(textPesquisa.Text.ToLower().ToString()))
                {
                    FPConteinerCat.Controls.Add(Conj_Livro[i]);
                }
                if (textPesquisa.Text == null)
                {
                    FPConteinerCat.Controls.Add(Conj_Livro[i]);
                }
            }
        }
    }
}

