using Aprendendo_MVC;
using Library_Project;
using Library_Project.controle;
using Library_Project.modelo;
using Minha_Parte_Biblio.Controle;
using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuario;

namespace Minha_Parte_Biblio
{
    public partial class FrmMeanC : Form
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
        DataTable DT_Livro = new DataTable(); //dados exclusivos do livro
        DataTable DT_Reserv = new DataTable(); //dados exclusivos das reservas
        DataTable DT_Unit = new DataTable(); // dados exclusivods das unidades
        public void ArredondaCantosdoForm()
        {
            // ARREDONDAMENTO DE BORDA
            //GraphicsPath PastaGrafica = new GraphicsPath();
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            ////Arredondar canto superior esquerdo        
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            //PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            ////Arredondar canto superior direito
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            //PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            ////Arredondar canto inferior esquerdo
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            //PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            ////Arredondar canto inferior direito
            //PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            //PastaGrafica.AddPie(this.Width, this.Height - 26, 24, 26, 0, 90);

            //PastaGrafica.SetMarkers();
            //this.Region = new Region(PastaGrafica);
        }


        private void AddFormsParent(Form form1)
        {
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(form1);
            form1.BringToFront();
        }

        string SendEmailTo = "";
        
        public FrmMeanC(ClUserModelo user, int pag, string UtilitarioString)
        {
            this.Model_User = user;
            SendEmailTo = UtilitarioString;
            InitializeComponent();


            LbName_User.Text = user.UserName;
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Font = new Font("Chakra Petch", 12); // adjust font size as needed
                }
            }

            PnMenu.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnMenu.Width, PnMenu.Height, 20, 20));
            PnUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnUser.Width, PnUser.Height, 20, 20));
            PnCatalogo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnCatalogo.Width, PnCatalogo.Height, 20, 20));
            PnHist.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnHist.Width, PnHist.Height, 20, 20));
            PnReserv.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnReserv.Width, PnReserv.Height, 20, 20));
            PnPerguntas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnPerguntas.Width, PnPerguntas.Height, 20, 20));
            PnNos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, PnNos.Width, PnNos.Height, 20, 20));

            this.IsMdiContainer = true;


            switch (pag)
            {
                case 0:
                    //0 - vazio
                    FPnContenedor.Controls.Clear();
                    break;
                case 1:
                    //1 - usuario
                    Frmusuario Frmuser = new Frmusuario(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    Frmuser.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(Frmuser);
                    Frmuser.Show();
                    break;
                case 2:
                    //2 - catalogo
                    FrmCatalogo cat = new FrmCatalogo(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    cat.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(cat);
                    cat.Show();
                    break;
                case 3:
                    //3 - historicolivros
                    FrmhistLivros hist = new FrmhistLivros(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    hist.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(hist);
                    hist.Show();
                    break;
                case 4:
                    //4 - sobre nos
                    Frmsobrenos sobr = new Frmsobrenos(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    sobr.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(sobr);
                    sobr.Show();
                    break;
                case 5:
                    //5 - info livro
                    INFO_Livro infl = new INFO_Livro(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    infl.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(infl);
                    infl.Show();
                    break;
                case 6:
                    ////6 - info unidade
                    //INFO_Unidade infu = new INFO_Unidade(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    //infu.TopLevel = false;
                    //FPnContenedor.Controls.Clear();
                    //FPnContenedor.Controls.Add(infu);
                    //infu.Show();
                    break;

                case 7:
                    //7 - perguntas freq
                    TELA_Perg_Frequentes perf = new TELA_Perg_Frequentes(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    perf.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(perf);
                    perf.Show();
                    break;
                case 8:
                    //8 - reserva feita
                    TELA_Reserva_Feita ReservF = new TELA_Reserva_Feita(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    ReservF.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(ReservF);
                    ReservF.Show();
                    break;
                case 9:
                    //9 - reserva negada
                    TELA_ReservaNegada reservaNegada = new TELA_ReservaNegada(Model_Livro, Model_User, Model_Unit, Model_Reserv);
                    reservaNegada.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(reservaNegada);
                    reservaNegada.Show();
                    break;
                case 101:
                    //10 - ucconjunto

                    break;
                case 11:
                    //11 - contato consco
                    FrmSendEmail sendemail = new FrmSendEmail(SendEmailTo);
                    sendemail.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(sendemail);
                    sendemail.Show();
                    break;
                case 12:
                    //12 - sobre o Dev
                    FrmSobreDevs devs = new FrmSobreDevs(Model_User);
                    devs.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(devs);
                    devs.Show();
                    break;
                case 13:
                    //13 - verreservas
                    FrmVerReserva reservas = new FrmVerReserva(Model_Livro, Model_Reserv, Model_User);
                    reservas.TopLevel = false;
                    FPnContenedor.Controls.Clear();
                    FPnContenedor.Controls.Add(reservas);
                    reservas.Show();
                    break;
                default:
                    //Vazio
                    FPnContenedor.Controls.Clear();
                    break;
            }
        }

        [DllImport("Gdi32")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private void FrmMeanC_Load(object sender, EventArgs e)
        {
            if (Model_User.Index_Cargo == 1)
            {
                if (Model_User.Index_Ano == 13)
                {
                    BntAcessoADM.Visible = true;


                }
                else
                {
                    BntAcessoADM.Visible = false;
                }
            }
            else { BntAcessoADM.Visible = false; }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntMenu_Click(object sender, EventArgs e)
        {
            FPnContenedor.Controls.Clear();
        }

        private void PbUser_Click(object sender, EventArgs e)
        {

        }

        private void LbName_User_Click(object sender, EventArgs e)
        {

        }

        private void BntUser_Click(object sender, EventArgs e)
        {
            Frmusuario user = new Frmusuario(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            user.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(user);
            user.Show();
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntCatalogo_Click(object sender, EventArgs e)
        {
            FrmCatalogo cat = new FrmCatalogo(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            cat.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(cat);
            cat.Show();
        }

        private void BntHist_Click(object sender, EventArgs e)
        {
            FrmhistLivros hist = new FrmhistLivros(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            hist.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(hist);
            hist.Show();
        }

        private void BntNos_Click(object sender, EventArgs e)
        {
            Frmsobrenos sobr = new Frmsobrenos(Model_Livro, Model_User, Model_Unit, Model_Reserv);
            sobr.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(sobr);
            sobr.Show();
        }

        private void FPnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BntReserv_Click(object sender, EventArgs e)
        {
            FrmVerReserva reservas = new FrmVerReserva(Model_Livro, Model_Reserv, Model_User);
            reservas.TopLevel = false;
            FPnContenedor.Controls.Clear();
            FPnContenedor.Controls.Add(reservas);
            reservas.Show();
        }

        private void bntCircle1_Click(object sender, EventArgs e)
        {
            FrmADMSign ADMlog = new FrmADMSign(Model_User, 0);
            this.Hide();
            ADMlog.ShowDialog();
        }
    }
}
