using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
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

namespace usuario
{
    public partial class Frmsobrenos : Form
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
        /// <summary>
        ///  /// //  /  /  /  /  BOTAR UM BNT PARA IR PARA OS DEVs
        /// </summary>
        public Frmsobrenos(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            FrmMeanC menu = new FrmMeanC(Model_User, 12, "0");
            this.Hide();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
