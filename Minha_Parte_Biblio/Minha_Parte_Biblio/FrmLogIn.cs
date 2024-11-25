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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Minha_Parte_Biblio
{
    public partial class FrmLogIn : Form
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
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            //define aparencias dos itens no design
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92); //controla a cor abaixo das textbox
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92);//controla a cor abaixo das textbox
            txtUser.ForeColor = Color.FromArgb(164, 186, 178);//controla a cor abaixo das textbox
            txtUser.Text = "Entre com o seu NameUser"; //cria um place holder para o user
            txtPassWord.ForeColor = Color.FromArgb(164, 186, 178); //controla a cor abaixo das textbox
            txtPassWord.Text = "Entre com a sua Senha"; //cria um place holder para a senha

            txtPassWord.PasswordChar = '\0'; //define como inativo a função de esconder senha
        }

        private void Image_Visivel_Click(object sender, EventArgs e)
        {
            //ativa e desativa a função de senha, assim que o user clicar no button
            if (txtPassWord.PasswordChar == '•') // checa se está ou não ativado
            {
                txtPassWord.PasswordChar = '\0'; // se estiver vira inativo
                Image_Visivel.Image = CbVisivel_Senha.Images[1]; //e a imagem do Bnt fica como a 1 do ComboBox image
            }
            else if (txtPassWord.PasswordChar == '\0') //checa de novo
            {
                txtPassWord.PasswordChar = '•'; // se n estiver ativa
                Image_Visivel.Image = CbVisivel_Senha.Images[0]; // a imagem vira a 0 do comboimage
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            //define as infos ao interagir com a textbox user
            Image_User.Image = Cbimage_User.Images[0]; // muda a image na lateral da text
            PnBarUser.BackColor = Color.FromArgb(9, 90, 162); //controla a cor abaixo das textbox
            txtUser.ForeColor = Color.Black; // redefine a cor da letra
            txtUser.Text = ""; // limpa a por via das duvidas (Pode dar erro)
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            //define as infos ao interagir com a textbox user
            Image_User.Image = Cbimage_User.Images[1]; // muda a image na lateral da text
            PnBarUser.BackColor = Color.FromArgb(43, 59, 92); //controla a cor abaixo das textbox
        }

        private void txtPassWord_Enter(object sender, EventArgs e)
        {
            //define as infos ao interagir com a textbox password
            Image_PassWord.Image = Cbimage_PassWord.Images[0]; //muda a image na lateral da text
            PnBarPass.BackColor = Color.FromArgb(9, 90, 162); //controla a cor abaixo das textbox
            txtPassWord.ForeColor = Color.Black; //define a cor da letra
            txtPassWord.Text = ""; //por via das duvidas limpa o text (pode dar erro)
            txtPassWord.PasswordChar = '•'; // reativa a função esconder texto (por via das duvidas)
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            //define as infos ao interagir com a textbox password
            Image_PassWord.Image = Cbimage_PassWord.Images[1]; //redefine a image na lateral do text
            PnBarPass.BackColor = Color.FromArgb(43, 59, 92); //controla a cor abaixo das textbox
        }

        private void LbSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //controla a interação com uma label link
            // caso seja clicada 
            FrmSignUp signUpForm = new FrmSignUp(); //gera um forms chamado de signUpForm
            this.Hide(); // esconde o atual
            signUpForm.ShowDialog(); // abre o novo forms
        }

        private void BntSignUp_C_Click(object sender, EventArgs e)
        {
            try
            {
                //controla as reações para logar
                //ao clicar no bnt
                Model_User.UserName = txtUser.Text; // o modelo vai popular a variavel UserName com o que estiver escrito em textuser
                Model_User.Password = txtPassWord.Text; // o modelo vai popular a variavel Password com o que estiver escrito em textpassword

                //cria uma table para ser populada com a conexao ao clconnection
                DataTable DT_logIn = conexao.LogIn(Model_User,"select * from Table_User where NameUser=@nameuser and Senha=@password");




                //checa se foi populado da maneira correta
                if (Convert.ToInt32(DT_logIn.Rows[0][0]) > 0)
                {

                    Model_User.ID_Aluno = DT_logIn.Rows[0]["ID_Aluno"].ToString();
                    Model_User.NomeComp = DT_logIn.Rows[0]["Nome_Completo"].ToString();
                   
                    Model_User.Caminho_FT = DT_logIn.Rows[0]["IMG_User"].ToString();
                    Model_User.Index_Cargo = (int)DT_logIn.Rows[0]["CFK_Cargo"];
                    Model_User.Index_Ano = (int)DT_logIn.Rows[0]["CFK_Ano"];
                    Model_User.Index_Unidade = (int)DT_logIn.Rows[0]["CFK_Unidade"];
                    Model_User.CD_User = (int)DT_logIn.Rows[0]["CD_User"];

                    if ((int)DT_logIn.Rows[0]["CFK_Cargo"] == 1) {
                        if ((int) DT_logIn.Rows[0]["CFK_Ano"] == 13)
                        {
                            FrmAcessoLog log = new FrmAcessoLog(Model_User);
                            this.Hide();
                            log.ShowDialog();
                        }

                    }
                    //popula a var ID_Aluno do modelo com infos vindas da tabela, estando na linha 0 e coluna "ID_Aluno"
                    Model_User.ID_Aluno = DT_logIn.Rows[0]["ID_Aluno"].ToString();

                    //gera unma menssage de confirmação de login
                    MessageBox.Show($"ID Logado: {DT_logIn.Rows[0]["ID_Aluno"].ToString()}\nUser Name: {DT_logIn.Rows[0]["NameUser"].ToString()}");


                    //se sim
                    this.Hide();//esconde o frm atual
                    FrmBoasVindas Boa_Vinda = new FrmBoasVindas(Model_User); //gera o novo
                    MessageBox.Show($"Seja bem vindo {DT_logIn.Rows[0]["Nome_Completo"].ToString()}");// gera uma menssage de bem vindo
                    Boa_Vinda.ShowDialog();// abre o novo
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário Inexistente!!\nPor favor tente novamente ou vá para SignUp");
            }
        }
    }
}
