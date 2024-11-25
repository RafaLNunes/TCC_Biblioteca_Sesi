using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Modelo
{
    public class ModeloHistorico
    {

        public int CD_Hist;
        public string DT_reserva;
        public string DT_devolucao;
        public int CFK_Livro;
        public int CFK_User;

        public ModeloHistorico()
        {
            CD_Hist = 0;
            DT_reserva = "";
            DT_devolucao = "";
            CFK_Livro = 0;
            CFK_User = 0;

        }
    }
}
