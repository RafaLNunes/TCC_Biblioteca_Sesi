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

namespace Minha_Parte_Biblio
{
    public partial class FrmBoasVindas : Form
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

        /* =====criação de uma table para armazenar os dados===== */
        DataTable DT_User = new DataTable(); //dados exclusivos do usuario


        public FrmBoasVindas(ClUserModelo Usuario)
        {
            Model_User = Usuario;
            InitializeComponent();
        }

        private void FrmBoasVindas_Load(object sender, EventArgs e)
        {
            //puxa infos de outros forms
            String Cam_origin = Path.Combine(Directory.GetCurrentDirectory(),"DT_Image_Users\\\\", Path.GetFileName(Model_User.Caminho_FT));// pega a imagem que o user escolheu e pos na dt
            DT_User = conexao.obterdados($"select * from Table_User where ID_Aluno = '{Model_User.ID_Aluno}'"); // popula a tabela com infos do usuario
            PbImage_User.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", DT_User.Rows[0]["IMG_User"].ToString())); // popula a picturebox com a imagem
            LbNomeComp.Text = Model_User.NomeComp.ToString(); // popula a label com o nome do usuario
        }

        private void FrmBoasVindas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // fecha o aplicativo
        }

        private void PbImage_User_Click(object sender, EventArgs e)
        {

        }

        private void BntViajar_Click(object sender, EventArgs e)
        {
            FrmMeanC Principal = new FrmMeanC(Model_User, 0, "0");
            this.Hide();
            Principal.ShowDialog();
        }
    }
}
