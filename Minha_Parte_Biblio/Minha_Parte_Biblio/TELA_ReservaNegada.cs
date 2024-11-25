using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Minha_Parte_Biblio;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuario;

namespace Library_Project
{
    public partial class TELA_ReservaNegada : Form
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
        string codi = "";
        public TELA_ReservaNegada(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            codi = user.ID_Aluno;
            InitializeComponent();
            DataTable DT_User = conexao.obterdados("select * from Table_User where ID_Aluno = '" + codi + "'");
            Model_User.CD_User = (int)DT_User.Rows[0]["CD_User"];
            Model_User.ID_Aluno = DT_User.Rows[0]["ID_Aluno"].ToString();
            Model_User.UserName = DT_User.Rows[0]["NameUser"].ToString();
            Model_User.Index_Unidade = (int)DT_User.Rows[0]["CFK_Unidade"];
            Model_User.Index_Ano = (int)DT_User.Rows[0]["CFK_Ano"];
            Model_User.Index_Cargo = (int)DT_User.Rows[0]["CFK_Cargo"];

            label1.Text = DT_User.Rows[0]["ID_Aluno"].ToString();
            label2.Text = DT_User.Rows[0]["NameUser"].ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TELA_ReservaNegada_Load(object sender, EventArgs e)
        {
            DataTable dados_user = new DataTable();
            dados_user = conexao.obterdados("Select * from Table_User where ID_Aluno = '" + codi + "'");

            label1.Text = dados_user.Rows[0]["ID_Aluno"].ToString();
            label2.Text = dados_user.Rows[0]["NameUser"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMeanC info_livro = new FrmMeanC(Model_User, 2, "0");
            this.Hide();
            info_livro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMeanC info_livro = new FrmMeanC(Model_User, 2, "0");
            this.Hide();
            info_livro.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
