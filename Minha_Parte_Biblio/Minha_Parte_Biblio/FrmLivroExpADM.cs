using Aprendendo_MVC;
using Library_Project.modelo;
using Minha_Parte_Biblio.Modelo;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FrmLivroExpADM : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        ClInnerADMsModelo Model_Inner_ADM = new ClInnerADMsModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ModeloUnidade Model_Unit = new ModeloUnidade();
        int cd = 0;

        public FrmLivroExpADM(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            Model_Inner_ADM = admuserview;
            this.Model_User = user;
            ModelADM = ModelAdm;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void FrmLivroExpADM_Load(object sender, EventArgs e)
        {
            DataTable DT_Livros = new DataTable();
            DT_Livros = conexao.obterdados($"select * from Table_Livro WHERE CD_Livro = '{Model_Livro.CD_Livro}'");
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Books\\\\", DT_Livros.Rows[0]["IMG_Livro"].ToString());


            if (File.Exists(imagePath))
            {
                var img = Image.FromFile(imagePath);
                bookImage.Image = (Image)img.Clone(); // Clona a imagem para evitar problemas com o disposing
                img.Dispose();
            }



            try
            {
                DataTable dados;
                dados = conexao.obterdados("Select * from Table_Livro where CD_Livro = '" + Model_Livro.CD_Livro + "'");
                Model_Livro.Order_Livro = Convert.ToInt32(dados.Rows[0]["Order_Livro"]);

                cd = Model_Livro.Order_Livro;


                string descricao = dados.Rows[0]["Descricao_Livro"].ToString();
                label1.Text = descricao;
                label2.Text = dados.Rows[0]["Nome_Livro"].ToString();

                //DataTable cadastro;
                //cadastro = cn.cadastrar ("INSERT INTO Table_reservas (CFK_Livro) VALUES ({label2.Text})");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            FrmMeanADM books = new FrmMeanADM(Model_Livro, Model_User, Model_Unit, Model_Reserv, Model_Inner_ADM, ModelADM, 3, "0");
            this.Hide();
            books.ShowDialog();

        }
    }
}
