using Aprendendo_MVC;
using Minha_Parte_Biblio.Modelo;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Controle
{
    internal class ClUsercontrole
    {
        ClConectection conexao = new ClConectection();

        public bool SignUp(ClUserModelo Perfil)
        {
            bool Resultado = false;

            try
            {

                String SQL_Insert = "insert into Table_User(ID_Aluno, Nome_Completo, NameUser, Senha, IMG_User, CFK_Ano, CFK_Cargo, CFK_Unidade)values(@ID_Aluno, @Nome_Completo, @UserName, @Password, @IMG_User, @CFK_Ano, @CFK_Cargo, @CFK_Unidade)";

                string[] campos = {"@ID_Aluno", "@Nome_Completo", "@UserName", "@Password", "@IMG_User", "@CFK_Ano", "@CFK_Cargo", "@CFK_Unidade" };
                //monto o vetor com os valores do formulario
                string[] valores = { Perfil.ID_Aluno.ToString(), Perfil.NomeComp.ToString(), Perfil.UserName.ToString(), Perfil.Password.ToString(), Perfil.Caminho_FT.ToString(), Perfil.Index_Ano.ToString(), Perfil.Index_Cargo.ToString(), Perfil.Index_Unidade.ToString() };

                //testar o insert no banco de dados
                if (conexao.cadastrar(0, campos, valores, SQL_Insert, "@ID_Aluno") >= 1)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }

            }
            catch(Exception ex) 
            {
                throw new Exception(ex.ToString());
            }


            return Resultado;
        }

        public bool CreateADM(ModeloAdm Perfil)
        {
            bool Resultado = false;

            try
            {

                String SQL_Insert = "insert into Table_Adm(NameUser_Adm, Senha_Adm, CFK_User)values(@UserADM, @pass, @userclint)";

                string[] campos = { "@UserADM", "@pass", "@userclint" };
                //monto o vetor com os valores do formulario
                string[] valores = {Perfil.userADM, Perfil.passADM, Perfil.index_clint.ToString()};

                //testar o insert no banco de dados
                if (conexao.cadastrar(0, campos, valores, SQL_Insert, "@CD_Adm") >= 1)
                {
                    Resultado = true;
                }
                else
                {
                    Resultado = false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }


            return Resultado;
        }

        public bool editar(ClUserModelo usuario)
        {
            bool resultado = false;
            try
            {


                //monta o script sql de cadastrar as informações no banco
                string sql = "update Table_User set ID_Aluno=@ID_Aluno, NameUser=@NameUser, Nome_Completo=@Nome_Completo, Senha=@Senha, CFK_Cargo=@CFK_Cargo, CFK_Unidade=@CFK_Unidade, CFK_Ano=@CFK_Ano where CD_User=@CD_User LIMIT 1;";
                //monto o vetor de atributos da tabela usuario
                string[] campos = { "@ID_Aluno", "@NameUser", "@Nome_Completo", "@Senha", "@CFK_Cargo", "@CFK_Unidade", "@CFK_Ano", "@CD_User"};
                //monto o vetor com os valores do formulario
                string[] valores = { usuario.ID_Aluno, usuario.UserName, usuario.NomeComp, usuario.Password, usuario.Index_Cargo.ToString(), usuario.Index_Unidade.ToString(), usuario.Index_Ano.ToString(), usuario.CD_User.ToString()};
                //testar o insert no banco de dados
                if (conexao.editar(sql, campos, valores, 0, "@CD_User") >= 1)

                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return resultado;
        }


        public bool excluir(ClUserModelo usuario)
        {
            bool resultado = false;
            try
            {
                string sql = "delete from Table_User where ID_Aluno=" + "'" + usuario.ID_Aluno + "'";
                if (conexao.excluir(0, sql, "ID_Aluno") >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return resultado;
        }
    }
}

