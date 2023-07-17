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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FotoImagemSerie01_Click(object sender, EventArgs e)
        {
            string titulo = "Suits";
            string descricao = "Mike Ross é um garoto que abandonou a faculdade de direito mas, brilhante como é, consegue uma entrevista com o respeitado Harvey Specter, um dos melhores advogados de Manhattan. Quando percebe o talento nato e a memória fotográfica do garoto, Harvey o contrata e, juntos, eles formam uma dupla imbatível.";
            
            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.Show();
        }
    }
}
