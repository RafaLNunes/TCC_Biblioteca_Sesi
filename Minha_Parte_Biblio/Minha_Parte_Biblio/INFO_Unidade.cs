using Aprendendo_MVC;
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

namespace Library_Project
{
    public partial class INFO_Unidade : Form
    {
        /* =====Importação das class de modelo===== */
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        ClInnerADMsModelo Model_Inner_ADM = new ClInnerADMsModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ModeloUnidade Model_Unit = new ModeloUnidade();


        /* =====Importação das class de controle===== */
        ClUsercontrole Controle_User = new ClUsercontrole();
        ControleLivro Controle_Livro = new ControleLivro();
        ControleReservas Controle_Reserv = new ControleReservas();

        int codi = 0;
        DataTable nom;
        String nome_livro = "";
        String codi1 = "";

        public INFO_Unidade(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            codi = unidade.CD_Unidade;
            codi1 = livro.CD_Livro;
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void INFO_Unidade_Load(object sender, EventArgs e)
        {
            ClConectection cn = new ClConectection();
            try
            {
                DataTable dados = new DataTable();
                dados = cn.obterdados("select Table_Livro.Nome_Livro, Table_Unidade.Nome_Unidade, Table_Livro.Descricao_Livro from Table_Livro Inner Join Table_Unidade on Table_Unidade.CD_Unidade = Table_Livro.CFK_Unidade where Table_Livro.CD_Livro = '" + codi1 + "'");

                nom = dados;

                label1.Text = nom.Rows[0]["Nome_Livro"].ToString();
                label3.Text = nom.Rows[0]["Nome_Unidade"].ToString();
                label4.Text = nom.Rows[0]["Descricao_Livro"].ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

