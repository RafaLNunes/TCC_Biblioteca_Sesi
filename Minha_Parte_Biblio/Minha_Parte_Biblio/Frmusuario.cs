using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Minha_Parte_Biblio;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using System.Data;

namespace usuario
{
    public partial class Frmusuario : Form
    {

        int codigo;

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

        DataTable dt = new DataTable();


        string ID_Aluno;
        string nameuser;
        string nomecompleto;
        string senha;
        string IMG_User;
        int CFK_Ano;
        int CFK_Cargo;
        int CFK_Unidade;

        public Frmusuario(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {
            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fotousuario_Click(object sender, EventArgs e)
        {

        }

        private void Frmusuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vhrusuario1_Click(object sender, EventArgs e)
        {
            FrmMeanC mean = new FrmMeanC(Model_User, 3, "0");
            this.Hide();
            mean.ShowDialog();
        }

        private void Frmusuario_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            dt = conexao.obterdados($"select * from Table_User where ID_Aluno ='{Model_User.ID_Aluno}'");

           
            
            Model_User.CD_User = Convert.ToInt32(dt.Rows[0]["CD_User"]);

            string username;
            
            username = dt.Rows[0]["NameUser"].ToString();

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

            nameuser = dt.Rows[0]["NameUser"].ToString();
            ID_Aluno = dt.Rows[0]["ID_Aluno"].ToString();
            nomecompleto = dt.Rows[0]["Nome_Completo"].ToString();
            senha = dt.Rows[0]["Senha"].ToString();
            IMG_User = dt.Rows[0]["IMG_User"].ToString();
            CFK_Ano = Convert.ToInt32(dt.Rows[0]["CFK_Ano"]);
            CFK_Cargo = Convert.ToInt32(dt.Rows[0]["CFK_Cargo"]);
            CFK_Unidade = Convert.ToInt32(dt.Rows[0]["CFK_Unidade"]);


            txtusername.Text = nameuser;
            txtidaluno.Text = ID_Aluno;
            txtnomecompleto.Text = nomecompleto;
            txtsenha.Text = senha;
            fotousuario.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", dt.Rows[0]["IMG_User"].ToString()));

            cbanoescolar.SelectedIndex = CFK_Ano - 1;

            cbcargo.SelectedIndex = CFK_Cargo - 1;
            cbunidade.SelectedIndex = CFK_Unidade - 1;


            //MessageBox.Show("Cargo"+cbcargo.FindStringExact(cbcargo.Text).ToString()); ;
            //MessageBox.Show("ANO"+cbanoescolar.FindStringExact(cbanoescolar.Text).ToString()); ;
            //MessageBox.Show("Unit"+cbunidade.FindStringExact(cbunidade.Text).ToString());


        }

        private void btnsalvaralteracao_Click(object sender, EventArgs e)
        {

            Model_User.ID_Aluno = txtidaluno.Text;
            Model_User.NomeComp = txtnomecompleto.Text;
            Model_User.UserName = txtusername.Text;
            Model_User.Password = txtsenha.Text;



            Model_User.Index_Cargo = cbcargo.FindStringExact(cbcargo.Text)+1;
            Model_User.Index_Ano = cbanoescolar.FindStringExact(cbanoescolar.Text)+1;
            Model_User.Index_Unidade = cbunidade.FindStringExact(cbunidade.Text)+1;
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
