using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minha_Parte_Biblio.Modelo
{
    public class ModeloAdm
    {
        public int index_adm;
        public String userADM;
        public String passADM;
        public int index_clint;
        public ModeloAdm() 
        {
            index_adm = 0;
            userADM = "";
            passADM = "";
            index_clint = 0;
        }
    }
}
