using Aprendendo_MVC;
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
    public partial class FrmAcessoLog : Form
    {
        ClConectection conexao = new ClConectection();
        ClUserModelo Model_User = new ClUserModelo();
        public FrmAcessoLog(ClUserModelo User)
        {
            this.Model_User = User;
            InitializeComponent();
        }

        private void BntADM_Click(object sender, EventArgs e)
        {
            FrmADMSign Sign = new FrmADMSign(Model_User, 0);
            this.Hide();
            Sign.ShowDialog();
        }

        private void BntNADM_Click(object sender, EventArgs e)
        {
            try
            {

                //cria uma table para ser populada com a conexao ao clconnection
                DataTable DT_logIn = conexao.LogIn(Model_User,"select * from Table_User where NameUser=@nameuser and Senha=@password");




                //checa se foi populado da maneira correta
                if (Convert.ToInt32(DT_logIn.Rows[0][0]) > 0)
                {

                   

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

        private void FrmAcessoLog_Load(object sender, EventArgs e)
        {

        }
    }
}
