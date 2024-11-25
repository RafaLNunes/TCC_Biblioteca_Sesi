using Aprendendo_MVC;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio
{
    public class ClControleConexao
    {

        ClConectection conxao = new ClConectection();
        public MySqlConnection Conect = null; // garantia de que eesta aberta e vazia        



        public void ExecutarScriptSQL(string ARQmysql, string NameDT)
        {
            Conect = conxao.GetConectection();

            Conect.Open();  


            string checktxt = $"use {NameDT};\nSHOW TABLES LIKE '{NameDT}';";
            MySqlCommand cmd_check = new MySqlCommand(checktxt, Conect);



            var resulut = cmd_check.ExecuteScalar();
            if (resulut == null)
            {
                try
                {
                    ARQmysql = Path.GetFullPath(ARQmysql);
                    string ScriptTXT = File.ReadAllText(ARQmysql);

                    MessageBox.Show(ScriptTXT);



                    MySqlCommand cmd = new MySqlCommand(ScriptTXT, Conect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Script SQL executado com sucesso.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na iniciação da dt:\n\n\n" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show($"Tabela {NameDT} já existente");
            }
            Conect.Close();
        }


    }
}
