using Aprendendo_MVC;
using Library_Project.modelo;
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

namespace Minha_Parte_Biblio
{
    public partial class FrmUserAnalitc : Form
    {
        ModeloAdm ModelADM = new ModeloAdm();
        ClUserModelo Model_User = new ClUserModelo();
        ClConectection conexao = new ClConectection();
        ClInnerADMsModelo Model_Inner_ADM = new ClInnerADMsModelo();
        ModeloLivro Model_Livro = new ModeloLivro();
        ModeloReservas Model_Reserv = new ModeloReservas();
        ModeloUnidade Model_Unit = new ModeloUnidade();

        string ID_Aluno;
        string nameuser;
        string nomecompleto;
        string senha;
        string IMG_User;
        int CFK_Ano;
        int CFK_Cargo;
        int CFK_Unidade;

        public FrmUserAnalitc(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv, ClInnerADMsModelo admuserview, ModeloAdm ModelAdm)
        {
            Model_Inner_ADM = admuserview;
            this.Model_User = user;
            ModelADM = ModelAdm;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;
            InitializeComponent();
        }

        private void FrmUserAnalitc_Load(object sender, EventArgs e)
        {




            DataTable dt_User_View = new DataTable();

            dt_User_View = conexao.obterdados($"select * from Table_User where CD_User ={Model_Inner_ADM.Index};");



            Model_User.CD_User = Convert.ToInt32(dt_User_View.Rows[0]["CD_User"]);

            string username;

            username = dt_User_View.Rows[0]["NameUser"].ToString();

            cbcargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            cbcargo.DisplayMember = "Cargo";
            cbcargo.ValueMember = "CD_Cargo";

            cbanoescolar.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            cbanoescolar.DisplayMember = "Ano_Escolar";
            cbanoescolar.ValueMember = "CD_Ano_Escolar";

            cbunidade.DataSource = conexao.obterdados("select * from Table_Unidade");
            cbunidade.DisplayMember = "Nome_Unidade";
            cbunidade.ValueMember = "CD_Unidade";

            txtusername.Text = username;

            nameuser = dt_User_View.Rows[0]["NameUser"].ToString();
            ID_Aluno = dt_User_View.Rows[0]["ID_Aluno"].ToString();
            nomecompleto = dt_User_View.Rows[0]["Nome_Completo"].ToString();
            senha = dt_User_View.Rows[0]["Senha"].ToString();
            IMG_User = dt_User_View.Rows[0]["IMG_User"].ToString();
            CFK_Ano = Convert.ToInt32(dt_User_View.Rows[0]["CFK_Ano"]);
            CFK_Cargo = Convert.ToInt32(dt_User_View.Rows[0]["CFK_Cargo"]);
            CFK_Unidade = Convert.ToInt32(dt_User_View.Rows[0]["CFK_Unidade"]);


            txtusername.Text = nameuser;
            txtidaluno.Text = ID_Aluno;
            txtnomecompleto.Text = nomecompleto;
            txtsenha.Text = senha;
            fotousuario.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", dt_User_View.Rows[0]["IMG_User"].ToString()));

            cbanoescolar.SelectedIndex = CFK_Ano - 1;

            cbcargo.SelectedIndex = CFK_Cargo - 1;
            cbunidade.SelectedIndex = CFK_Unidade - 1;


            //MessageBox.Show("Cargo"+cbcargo.FindStringExact(cbcargo.Text).ToString()); ;
            //MessageBox.Show("ANO"+cbanoescolar.FindStringExact(cbanoescolar.Text).ToString()); ;
            //MessageBox.Show("Unit"+cbunidade.FindStringExact(cbunidade.Text).ToString());

        }

        private void BntSalvAlt_Click(object sender, EventArgs e)
        {
            Model_User.ID_Aluno = txtidaluno.Text;
            Model_User.NomeComp = txtnomecompleto.Text;
            Model_User.UserName = txtusername.Text;
            Model_User.Password = txtsenha.Text;



            Model_User.Index_Cargo = cbcargo.FindStringExact(cbcargo.Text) + 1;
            Model_User.Index_Ano = cbanoescolar.FindStringExact(cbanoescolar.Text) + 1;
            Model_User.Index_Unidade = cbunidade.FindStringExact(cbunidade.Text) + 1;
            ClUsercontrole clUsercontrole = new ClUsercontrole();
            if (clUsercontrole.editar(Model_User) == true)
            {
                MessageBox.Show("Atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os dados");
            }
        }
    }
}
