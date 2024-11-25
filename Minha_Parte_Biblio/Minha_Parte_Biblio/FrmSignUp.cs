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
using System.Xml.Schema;

namespace Minha_Parte_Biblio
{
    public partial class FrmSignUp : Form
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


        //crias as variaveis, mas em aberto
        String Cam_FT = ""; // foto para o caminho dos arquivos da imagem
        String Cam_origin = ""; // caminho de origin, normalmente download
        String Nome_Ft = ""; // nome completo do arq da ft, sem caminho

        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            //define aparencias dos itens no design
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
            PnBarId.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
            PnBarNomeComp.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox

            txtPassWord.PasswordChar = '\0'; //define como inativo a função de esconder senha

            txtID.Text = "Entre com o seu ID"; //cria um place holder para a text
            txtNomeComp.Text = "Entre com o Nome Completo"; //cria um place holder para a text
            txtPassWord.Text = "Entre com sua Senha"; //cria um place holder para a text
            txtUser.Text = "Entre com o NameUser"; //cria um place holder para a text

            txtID.ForeColor = Color.FromArgb(164, 186, 188); //controla a cor das  letras da textbox
            txtNomeComp.ForeColor = Color.FromArgb(164, 186, 188);//controla a cor das  letras da textbox
            txtPassWord.ForeColor = Color.FromArgb(164, 186, 188);//controla a cor das  letras da textbox
            txtUser.ForeColor = Color.FromArgb(164, 186, 188);//controla a cor das  letras da textbox


            //puxa as infos para as cb, vindas da table Cargo
            CbCargo.DataSource = conexao.obterdados("select * from Table_Cargo");
            CbCargo.DisplayMember = "Cargo";
            CbCargo.ValueMember = "CD_Cargo";
            CbCargo.Text = String.Empty;

            //puxa as infos para as cb, vindas da table Ano Escolar
            CbAno.DataSource = conexao.obterdados("select * from Table_Ano_Escolar");
            CbAno.DisplayMember = "Ano_Escolar";
            CbAno.ValueMember = "CD_Ano_Escolar";
            CbAno.Text = String.Empty;

            //puxa as infos para as cb, vindas da table Nome Unidade
            CbUnidade.DataSource = conexao.obterdados("select * from Table_Unidade");
            CbUnidade.DisplayMember = "Nome_Unidade";
            CbUnidade.ValueMember = "CD_Unidade";
            CbUnidade.Text = String.Empty;

        }

        private void Image_Visivel_Click(object sender, EventArgs e)
        {
            //ativa e desativa a função de senha, assim que o user clicar no button
            if (txtPassWord.PasswordChar == '•')// checa se está ou não ativado
            {
                txtPassWord.PasswordChar = '\0'; // se estiver vira inativo
                Image_Visivel.Image = CbVisivel_Senha.Images[0]; //e a imagem do Bnt fica como a 1 do ComboBox image
            }
            else if (txtPassWord.PasswordChar == '\0') //checa de novo
            {
                txtPassWord.PasswordChar = '•';// se n estiver ativa
                Image_Visivel.Image = CbVisivel_Senha.Images[1];// a imagem vira a 0 do comboimage
            }
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[0];
            PnBarPass.BackColor = Color.FromArgb(9, 90, 162);//controla a cor abaixo das textbox
            txtPassWord.Text = "";// limpa a por via das duvidas (Pode dar erro)
            txtPassWord.PasswordChar = '•'; // reativa a função esconder texto (por via das duvidas)
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            PbPassWord.Image = Cbimage_PassWord.Images[1];//redefine a image na lateral do text
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[0];//redefine a image na lateral do text
            PnBarUser.BackColor = Color.FromArgb(9, 90, 162);//controla a cor abaixo das textbox
            txtUser.Text = "";
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            PbUser.Image = Cbimage_User.Images[1];//redefine a image na lateral do text
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[0];//redefine a image na lateral do text
            PnBarId.BackColor = Color.FromArgb(9, 90, 162);//controla a cor abaixo das textbox
            txtID.Text = ""; //por via das duvidas limpa o text (pode dar erro)
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            PbID.Image = CbImage_ID.Images[1];//redefine a image na lateral do text
            PnBarId.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
        }

        private void txtNomeComp_Enter(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[0];//redefine a image na lateral do text
            PnBarNomeComp.BackColor = Color.FromArgb(9, 90, 162);//controla a cor abaixo das textbox
            txtNomeComp.Text = ""; //por via das duvidas limpa o text (pode dar erro)
        }

        private void txtNomeComp_Leave(object sender, EventArgs e)
        {
            PbNomeComp.Image = CbImage_NomeComp.Images[1];//redefine a image na lateral do text
            PnBarNomeComp.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
        }

        private void LbLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //controla a interação com uma label link
            // caso seja clicada 
            FrmLogIn fRMLogIn = new FrmLogIn(); //gera um forms chamado de signUpForm
            this.Hide(); // esconde o atual
            fRMLogIn.ShowDialog(); // abre o novo forms
        }

        private void pictureBoxCircle1_Click(object sender, EventArgs e)
        {

        }



        private void BntSignUp_Click(object sender, EventArgs e)
        {





        }

        private void CbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BntEscolher_Image_Click(object sender, EventArgs e)
        {

        }

        private void BntEscolher_Image_C_Click(object sender, EventArgs e)
        {
            try
            {
                //abre o dialog de image
                OpenFileDialog ft = new OpenFileDialog();
                //gera as infos necessarias para afunilar os arquivos que aparecem
                ft.Filter = "image file(*.jpg;*.png;*.gif;*.jpeg;*.webp)|*.jpg;*.png;*.gif;*.jpeg;*.webp";
                if (ft.ShowDialog() == DialogResult.OK)//abre o dialog de arq
                {
                    PbImage_Perfil.Image = Image.FromFile(ft.FileName); //define a picture box como ese arquivo selecionado
                    Cam_FT = ft.FileName.Replace("\\", "\\\\"); // pega o nome e redefine/ troca os // por //// (assim ele n dá pane no sistema)
                    Nome_Ft = ft.SafeFileName; // gera o nome
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BntSignUp_C_Click(object sender, EventArgs e)
        {
            try
            { //tenta o try para caso haja problema
                bool verificar = false;




            
                if (!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtNomeComp.Text) && !String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPassWord.Text) && !String.IsNullOrEmpty(CbAno.Text) && !String.IsNullOrEmpty(CbCargo.Text))
                {

                    //popula o modelo se não estiver vasio as text
                    Model_User.Index_Cargo = CbCargo.SelectedIndex + 1;
                    Model_User.Index_Ano = CbAno.SelectedIndex + 1;
                    Model_User.Index_Unidade = CbUnidade.SelectedIndex + 1;
                    Model_User.NomeComp = txtNomeComp.Text;
                    Model_User.ID_Aluno = txtID.Text;
                    Model_User.UserName = txtUser.Text;
                    Model_User.Password = txtPassWord.Text;
                    Model_User.Caminho_FT = Nome_Ft;
                    bool tester = false;
                    bool admduv = false;



                    DataTable dt_usert = new DataTable();
                    dt_usert = conexao.obterdados($"select * from Table_User where NameUser = '{Model_User.UserName}' OR Senha = '{Model_User.Password}'");
                    if (dt_usert.Rows.Count <= 0)
                    {


                        if (Model_User.Index_Cargo != 1)// nao sei porque, mas mesmo as variaveis sendo 1 ou 13, eles nçao funcinam
                        {
                            if (Model_User.Index_Ano != 13)
                            {
                                

                                if (Controle_User.SignUp(Model_User) == true)
                                {
                                        Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", Path.GetFileName(Cam_FT));
                                        File.Copy(Cam_FT, Cam_origin, true);
                                        //MessageBox.Show(Cam_origin);
                                        //MessageBox.Show(Cam_origin);
                                        tester = true;
                                }
                                if (tester == true && admduv == false) //se essa função der certo ele abre o novo frm
                                {
                                    FrmBoasVindas boVindam = new FrmBoasVindas(Model_User);
                                    this.Hide();
                                    boVindam.ShowDialog();

                                }
                            }
                        }
                        if (CbCargo.SelectedIndex + 1 == 1)
                        {
                            if (CbAno.SelectedIndex + 1 == 13)
                            {
                                if (Controle_User.SignUp(Model_User) == true)
                                {
                                    Cam_origin = Path.Combine(Directory.GetCurrentDirectory(), "DT_Image_Users\\\\", Path.GetFileName(Cam_FT));
                                    File.Copy(Cam_FT, Cam_origin, true);
                                    //MessageBox.Show(Cam_origin);
                                    //MessageBox.Show(Cam_origin);
                                    tester = true;
                                }

                                verificar = true;
                                FrmQuestionario quest = new FrmQuestionario(Model_User);
                                this.Hide();
                                quest.ShowDialog();

                            }
                            else
                            {
                                verificar = false;
                            }
                        }
                        else { verificar = false; }

                        if (verificar == false)
                        {
                            MessageBox.Show("Ambos, Cargo e Ano devem ser ADM para logar como um ADM");
                            MessageBox.Show("Ou ambos devem remeter a não ADM para logar como Usuário");
                            CbAno.Text = string.Empty;
                            CbCargo.Text = string.Empty;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuário já existente");
                    }

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BntEscolher_Image_C_MouseLeave(object sender, EventArgs e)
        {
            BntEscolher_Image_C.BackColor = Color.FromArgb(9, 90, 162);
        }

        private void BntEscolher_Image_C_MouseEnter(object sender, EventArgs e)
        {
            BntEscolher_Image_C.BackColor = Color.FromArgb(10, 59, 103);
        }

        private void BntSignUp_C_MouseEnter(object sender, EventArgs e)
        {
            BntSignUp_C.BackColor = Color.FromArgb(10, 59, 103);
        }

        private void BntSignUp_C_MouseLeave(object sender, EventArgs e)
        {
            BntSignUp_C.BackColor = Color.FromArgb(9, 90, 162);
        }
    }
}
