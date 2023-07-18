using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App06Treaming
{
    public partial class Form2 : Form
    {
        public string titulo;
        public string descricao;
        public string caminho_Imagem;
        public string link_video;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TituloDoFilme.Text = titulo;
            DescriçãoDoFilmeAqui.Text = descricao;
            imgFundo.ImageLocation = caminho_Imagem;
            wvVideo.Source = new Uri (link_video); //faz o WebView rodar o video
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotaoDoFilmeOuSerieAssistir_Click(object sender, EventArgs e)
        {
            wvVideo.Visible = true;
        }
    }
}
