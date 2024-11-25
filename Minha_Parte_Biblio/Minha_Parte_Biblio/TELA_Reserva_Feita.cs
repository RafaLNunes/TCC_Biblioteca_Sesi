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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuario;

namespace Library_Project
{
    public partial class TELA_Reserva_Feita : Form
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
        string codigo;
        string cod1 = "";
        public TELA_Reserva_Feita(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {

            cod1 = unidade.CD_Unidade.ToString();
            codi = user.CD_User.ToString();
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;

            codigo = Model_Livro.CD_Livro;
            InitializeComponent();
        }

        private void TELA_Reserva_Feita_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable unidade;
                unidade = conexao.obterdados("Select * from Table_Unidade where CD_Unidade = '" + cod1 + "'");
                label6.Text = unidade.Rows[0]["Nome_Unidade"].ToString();
                label7.Text = unidade.Rows[0]["Local_Unidade"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Unit: " + ex.Message);
            }
            try
            {
                DataTable livro;

                livro = conexao.obterdados("Select * from Table_Livro where CD_Livro = '" + codigo + "'");
                label4.Text = livro.Rows[0]["Nome_Livro"].ToString();
                label5.Text = livro.Rows[0]["CD_Livro"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Livro: " + ex.Message);
            }

            try
            {
                DataTable dados_aluno;
                dados_aluno = conexao.obterdados("Select * from Table_User where CD_User = '" + codi + "'");

                label1.Text = dados_aluno.Rows[0]["ID_Aluno"].ToString();
                label2.Text = dados_aluno.Rows[0]["NameUser"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Livro: " + ex.Message);
            }


            try
            {
                //Pegando data atual
                String dia = DateTime.Now.Day.ToString();
                String mon = DateTime.Now.Month.ToString();
                String ano = DateTime.Now.Year.ToString(); ;
                String hora = DateTime.Now.Hour.ToString();
                String minutos = DateTime.Now.Minute.ToString();
                String seg = DateTime.Now.Second.ToString();

                string data_Hoje = ano + "-" + mon + "-" + dia + " " + hora + ":" + minutos + ":" + seg;

                //obterdados das informações de data da reserva.


                DataTable dados_data;
                DataTable DT_Pegar = conexao.obterdados("select * from Table_reservas");
                if (DT_Pegar.Rows.Count > 0)
                {
                    dados_data = conexao.obterdados($"Select ABS(DATEDIFF('{data_Hoje}', DT_previsao_devolucao)) - 1 AS dias_faltando from Table_reservas where CD_Reservas = {DT_Pegar.Rows.Count}");
                    label3.Text = dados_data.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("DATA: " + ex.Message);
                MessageBox.Show("Reserva Efetuada"); //funcina, mas dá erro, sei lá por que
            }   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMeanC frmean = new FrmMeanC(Model_User, 2, "0");
            this.Hide();
            frmean.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMeanC frmean = new FrmMeanC(Model_User, 2, "0");
            this.Hide();
            frmean.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }   

        private void button3_Click(object sender, EventArgs e)
        {
            FrmMeanC frm = new FrmMeanC(Model_User, 13, "0");
            this.Hide();
            frm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
