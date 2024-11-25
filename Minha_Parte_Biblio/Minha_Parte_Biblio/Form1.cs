/*
 * 
 * 
 * Esse forms é para caso haja erros
 * 
 * 
 */


using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Form1 : Form
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
        public Form1()

        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passou o valor selecionado fixo
            Model_Livro.CD_Livro = comboBox1.Text;
            // Model_Livro.CD_Livro = "320C111L2021";
            DataTable dt_unit = conexao.obterdados("Select * from Table_Livro where Order_Livro = '" + (comboBox1.SelectedIndex + 1).ToString() + "'");
            Model_Livro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
            Model_Unit.CD_Unidade = Model_Livro.Index_Unidade;
            INFO_Livro info = new INFO_Livro(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            info.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // isso é apenas para teste 
            DataTable dt_unit = conexao.obterdados("Select * from Table_Livro where Order_Livro = '" + (comboBox1.SelectedIndex + 1).ToString() + "'");
            //continuação
            Model_Livro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
            Model_Unit.CD_Unidade = Model_Livro.Index_Unidade;
            Model_Livro.CD_Livro = comboBox1.Text;

            //INFO_Unidade info = new INFO_Unidade(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            //info.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.DataSource = conexao.obterdados("Select CD_Livro, Nome_Livro from Table_Livro");
                //livro.Descricao_Livro = dados.Rows[0][7].ToString();
                comboBox1.DisplayMember = "CD_Livro";
                comboBox1.ValueMember = "Nome_Livro";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
