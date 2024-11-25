using Minha_Parte_Biblio.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minha_Parte_Biblio
{
    public partial class FrmSobreDevs : Form
    {
        ClUserModelo model_User = new ClUserModelo();
        public FrmSobreDevs(ClUserModelo cluser )
        {
            this.model_User = cluser;
            //System.Diagnostics.Process.Start("");
            InitializeComponent();
        }

        string AdStrEmail = "adamfap2021@gmail.com";
        string RaStrEmail = "rafaf.code@gmail.com";
        string GaStrEmail = "gabioliva2007@gmail.com";

        string AdStrGit = "http://github.com/Adam2005Prado";
        string RaStrGit = "http://github.com/RafaLNunes";
        string GaStrGit = "http://github.com/gabrieldeoliveira1";

        string AdStrLinkdn = "http://www.linkedin.com/in/adam-prado-5b5159244";
        string RaStrLinkdn = "http://www.linkedin.com/in/rafael-nunes-aa77b6309/";
        string GaStrLinkdn = "http://www.linkedin.com/in/gabriel-de-oliveira-9a8321268/";




        private void RaLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMeanC menu = new FrmMeanC(model_User, 11, RaStrEmail);
            this.Hide();
            menu.ShowDialog();
        }

        private void GaLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMeanC menu = new FrmMeanC(model_User, 11, GaStrEmail);
            this.Hide();
            menu.ShowDialog();
        }

        private void AdLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Opening_WebLink(AdStrGit);
        }

        private void RaLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening_WebLink(RaStrGit);
        }

        private void GaLbGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening_WebLink(GaStrGit);
        }

        private void AdLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening_WebLink(AdStrLinkdn);
        }

        private void RaLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening_WebLink(RaStrLinkdn);
        }

        private void GaLbLinkdin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Opening_WebLink(GaStrLinkdn);
        }

        private void AdLbEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMeanC menu = new FrmMeanC(model_User, 11, AdStrEmail);
            this.Hide();
            menu.ShowDialog();
        }

        public void Opening_WebLink(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = false });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar abrir o link");
            }
        }
    }
}
