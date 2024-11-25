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
    public partial class FrmQuestionario : Form
    {

        ClUserModelo Model_User = new ClUserModelo();
        public FrmQuestionario(ClUserModelo User)
        {
            this.Model_User = User;
            InitializeComponent();
        }

        private void BntADM_Click(object sender, EventArgs e)
        {
            FrmADMSign Sign = new FrmADMSign(Model_User, 1);
            this.Hide();
            Sign.ShowDialog();
        }

        private void BntNADM_Click(object sender, EventArgs e)
        {
            FrmSignUp log = new FrmSignUp();
            this.Hide();
            log.ShowDialog();

        }

        private void FrmQuestionario_Load(object sender, EventArgs e)
        {

        }
    }
}
