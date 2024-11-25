using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Modelo
{
    public class ClInnerADMsModelo
    {
        public int Index;              // CD_User
        public string ID_Aluno;        // ID_Aluno
        public string NomeCompleto;    // Nome_Completo
        public string UserName;        // NameUser   
        public string Cargo;           // Cargo
        public string Ano;             // Ano_Escolar
        public string Unidade;         // Nome_Unidade
        public int NumbReservas;       // Numb Reservas
        public int NumbHistorico;      // Numb Histórico

        public ClInnerADMsModelo()
        {
            Index = 0;
            ID_Aluno = string.Empty;
            NomeCompleto = string.Empty;
            UserName = string.Empty;
            Cargo = string.Empty;
            Ano = string.Empty;
            Unidade = string.Empty;
            NumbReservas = 0;
            NumbHistorico = 0;
        }
    }
}
