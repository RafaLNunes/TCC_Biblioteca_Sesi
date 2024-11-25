using Microsoft.Win32;
using Minha_Parte_Biblio.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace Aprendendo_MVC
{
    public class ClConectection
    {
        //Server: sql10.freemysqlhosting.net
        //Name: sql10731271
        //Username: sql10731271
        //Password: HdPjE6jscM
        //Port number: 3306



        static private String server = "localhost"; //localhost
        static private String DataBase = "Biblio_Sesi"; // Nome do Data Base
        static private String User = "root"; //root senha vazia
        static private String PassWord = ""; //senha do root é sempre vazia
        public MySqlConnection Conect = null; // garantia de que eesta aberta e vazia
        static private String strConect = $"server={server};database={DataBase};user id={User};password={PassWord};";

        public MySqlConnection GetConectection()
        {
            Conect = new MySqlConnection(strConect);

            return Conect;
        }



        public int cadastrar(int codigo, string[] campos, object[] valores, string SQL, String PK_Table)
        {

            //VALIDACAO DO SCRIPT
            int registro = 0;


            try
            {
                //atribuir a conexao obtida

                Conect = GetConectection();
                //Abre a conexao
                Conect.Open();
                //Prepara a execução do SQL
                MySqlCommand cmd = new MySqlCommand(SQL, Conect);
                //monto o script sql
                //pegar os campos do vetor
                for (int i = 0; i < valores.Length; i++)
                {
                    //monta a lista de parametros juntando os campos e valores
                    //pega os valores do formulario com os campos do bd
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (codigo > 0)
                {
                    //se o codigo existir no registro, sera substituido aqui para execução
                    cmd.Parameters.AddWithValue(PK_Table, codigo);
                }

                //executa o script sql
                registro = cmd.ExecuteNonQuery();
                Conect.Close();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return registro;

        }

        public DataTable obterdados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            Conect = GetConectection();//obtenho a conexao
            Conect.Open();//abro o banco
            MySqlCommand cmd = new MySqlCommand(sql, Conect);
            //monto a estrutura das informações obtidas
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            //adiciona a datatable os valores 
            adapter.Fill(dt);

            return dt;
        }


        public DataTable LogIn(ClUserModelo Model_User, String sql)
        {
            DataTable reg = new DataTable();

            try
            {
                //User Name
                String nameuser = Model_User.UserName;
                //password
                String password = Model_User.Password;

                

                MySqlConnection com = GetConectection();

                MySqlCommand cmd = new MySqlCommand(sql, Conect);

                cmd.Parameters.AddWithValue("@nameuser", nameuser);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(reg);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


            return reg;
        }

        public int LogInADM(TextBox textuser, TextBox txtsenha, String sql)
        {
            int reg = 0;

            try
            {
                //User Name
                String nameuser = textuser.Text;
                //password
                String password = txtsenha.Text;



                MySqlConnection com = GetConectection();
                com.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Conect);

                cmd.Parameters.AddWithValue("@nameuser", nameuser);
                cmd.Parameters.AddWithValue("@password", password);

                reg = cmd.ExecuteNonQuery();
                Conect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }


            return reg;
        }

        public int editar(string sql, string[] campos, object[] valores, int codigo, String PK_Table)
        {
            int resultado = 0;
            try
            {
                Conect = GetConectection();
                Conect.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conect);

                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                if (codigo != 0)
                {
                    cmd.Parameters.AddWithValue(PK_Table, codigo.ToString());
                }

                resultado = Convert.ToInt32(cmd.ExecuteNonQuery());
                Conect.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }
        public int excluir(int codigo, string sql, string PK_Table)
        {
            int registro = 0;
            try
            {
                Conect = GetConectection();
                Conect.Open();
                MySqlCommand cmd = new MySqlCommand(sql, Conect);
                if (codigo > 0)
                {
                    cmd.Parameters.AddWithValue(PK_Table, codigo);
                }
                    registro = cmd.ExecuteNonQuery();
                Conect.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return registro;
        }

    }

}

