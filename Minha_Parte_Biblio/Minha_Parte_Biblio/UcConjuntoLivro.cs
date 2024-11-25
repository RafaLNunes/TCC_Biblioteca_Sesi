using Library_Project.modelo;
using Library_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Aprendendo_MVC;
using Minha_Parte_Biblio.Modelo;
using Library_Project.controle;
using Minha_Parte_Biblio.Controle;
using Microsoft.VisualBasic.ApplicationServices;
using Mysqlx.Session;

namespace Minha_Parte_Biblio
{
    public partial class UcConjuntoLivro : UserControl
    {
        string Cam_FT;
        //margin: 20

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

        public UcConjuntoLivro(ClUserModelo Model_User)


        {
            this.Model_User = Model_User;
            InitializeComponent();
        }


        

        #region Properties
        private string _NomeLivro;
        private string _Autor;
        private Image _IMG_cam;

        private string _Cod_Livro;
        private int _Order_Livro;

        [Category("Custom Props")]
        public string NomeLivro
        {
            get { return _NomeLivro; }
            set { _NomeLivro = value; LbNomeLivro.Text = value; }
        }

        [Category("Custom Props")]
        public string Autor
        {
            get { return _Autor; }
            set { _Autor = value; LbNomeAutor.Text = value; }
        }

        [Category("Custom Props")]
        public Image IMG_cam
        {
            get { return _IMG_cam; }
            set { _IMG_cam = value; PbLivro.Image = value; }
        }

        [Category("Custom Props")]
        public string Cod_Livro
        {
            get { return _Cod_Livro; }
            set { _Cod_Livro = value; }
        }

        [Category("Custom Props")]
        public int Order_Livro
        {
            get { return _Order_Livro; }
            set { _Order_Livro = value; }
        }

        #endregion
        private void UcConjuntoLivro_Load(object sender, EventArgs e)
        {

        }

        public void Visibilidade()
        {
            BntReserva.Visible = false;
            LbIndisp.Visible = true;
            BackgroundImage = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "CadaLivro indisp.png"));
        }

        private void BntReserva_Click(object sender, EventArgs e)
        {
            // abri o form deo livor especifico com cod do livro

            // terá um var que recebera individualmente cada cod


            //INFO_Livro frmLivroEx = new INFO_Livro(Cod_Livro);
            //frmLivroEx.ShowDialog();
            try
            {

                Model_Livro.CD_Livro = Cod_Livro;
                // Model_Livro.CD_Livro = "320C111L2021";
                DataTable dt_unit = conexao.obterdados("Select * from Table_Livro where CD_Livro = '" + Model_Livro.CD_Livro + "'");
                Model_Livro.Index_Unidade = (int)dt_unit.Rows[0]["CFK_Unidade"];
                Model_Unit.CD_Unidade = Model_Livro.Index_Unidade;
                INFO_Livro info = new INFO_Livro(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                info.ShowDialog();
            }catch(Exception ex)
            {
                MessageBox.Show("Problemas na Requisição das informações");
            }


        }
    }
}