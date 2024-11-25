using Aprendendo_MVC;
using Library_Project.controle;
using Library_Project.modelo;
using Minha_Parte_Biblio;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using MySqlX.XDevAPI;
using System.Data;
using System.Drawing;
using System.Drawing.Text;

namespace Library_Project
{
    public partial class INFO_Livro : Form
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

        string descricao;
        String codi = "";
        String nom = "";
        String codigo = "";
        string dia = "";
        int cd = 0;
        string mon = "";
        string ano = "";
        string hora = "";
        string minutos = "";
        string seg = "";
        //dia, mês e ano em int a ser usado na devolução.
        int dia1 = 0;
        int mon1 = 0;
        int ano1 = 0;

        public INFO_Livro(ModeloLivro livro, ClUserModelo user, ModeloUnidade unidade, ModeloReservas reserv)
        {

            this.Model_User = user;
            this.Model_Livro = livro;
            this.Model_Unit = unidade;
            this.Model_Reserv = reserv;


            //ModeloUser.ID_Aluno = "123456789";
            DataTable dt_Inicial = new DataTable();

            dt_Inicial = conexao.obterdados($"select * from Table_User where ID_Aluno = '{Model_User.ID_Aluno}'");

            Model_User.CD_User = (int)dt_Inicial.Rows[0]["CD_User"];

            codigo = Model_User.CD_User.ToString();
            codi = livro.CD_Livro;
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
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
                dados = conexao.obterdados("Select * from Table_Livro where CD_Livro = '" + codi + "'");
                Model_Livro.Order_Livro = Convert.ToInt32(dados.Rows[0]["Order_Livro"]);

                cd = Model_Livro.Order_Livro;


                descricao = dados.Rows[0]["Descricao_Livro"].ToString();
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



        private void BNT_Reservar_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = conexao.obterdados("Select * from Table_reservas where CFK_Livro = " + cd);

            if (dt.Rows.Count <= 0)
            {
                ClConectection conexao = new ClConectection();
                ModeloReservas re = new ModeloReservas();
                ControleReservas ctr = new ControleReservas();

                DataTable dados;
                dados = conexao.obterdados("Select * from Table_Livro where CD_Livro = '" + codi + "'");

                DataTable data_aluno;
                data_aluno = conexao.obterdados("Select * from Table_User where CD_User = '" + codigo + "'");

                dia = DateTime.Now.Day.ToString();
                dia1 = DateTime.Now.Day;
                mon = DateTime.Now.Month.ToString();
                mon1 = DateTime.Now.Month;
                ano = DateTime.Now.Year.ToString();
                ano1 = DateTime.Now.Year;
                hora = DateTime.Now.Hour.ToString();
                minutos = DateTime.Now.Minute.ToString();
                seg = DateTime.Now.Second.ToString();

                int dia_devolucao = dia1 + 28;
                int mon_devolucao = 0;
                int ano_devolucao = 0;
                string data_devolucao = "";

                if (dia_devolucao > 28)
                {
                    mon_devolucao = mon1 + 1;
                    dia_devolucao = 1 + (dia_devolucao - 27);
                    if (mon_devolucao > 12)
                    {
                        ano_devolucao = ano1 + 1;
                        mon_devolucao = 1;
                    }
                    else
                    {
                        ano_devolucao = ano1;
                    }


                }
                else
                {
                    ano_devolucao = ano1;
                    mon_devolucao = mon1;
                    dia_devolucao = dia1;
                }

                data_devolucao = ano_devolucao.ToString() + "-" + mon_devolucao.ToString() + "-" + dia_devolucao.ToString() + " " + hora + ":" + minutos + ":" + seg;
                string datas = ano + "-" + mon + "-" + dia + " " + hora + ":" + minutos + ":" + seg;
                //datas2 se refere a data de previsão de devolução.
                string datas2 = ano + "-" + mon + "-" + dia + " " + hora + ":" + minutos + ":" + seg;

                re.DT_reserva = datas;
                re.DT_previsao_devolucao = data_devolucao;
                re.CFK_Livro = dados.Rows[0]["Order_Livro"].ToString();
                re.CFK_User = data_aluno.Rows[0]["CD_User"].ToString();

                if (ctr.registrar_Reserva(re) == true)
                {
                    TELA_Reserva_Feita tr = new TELA_Reserva_Feita(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    tr.ShowDialog();
                }
                else
                {
                    TELA_ReservaNegada rn = new TELA_ReservaNegada(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    rn.ShowDialog();
                }
            }
            else
            {
                TELA_ReservaNegada tn = new TELA_ReservaNegada(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                tn.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BNT_Voltar_ao_inicio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMeanC FrmM = new FrmMeanC(Model_User, 0, "0");
            this.Hide();
            FrmM.ShowDialog();
        }
    }
}
