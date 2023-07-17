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
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemSerie02_Click(object sender, EventArgs e)
        {
            string titulo = "O Gambito Da Rainha";
            string descricao = "Em um orfanato nos anos 1950, uma garota-prodígio do xadrez luta contra o vício em uma jornada improvável para se tornar a número 1 do mundo.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemSerie03_Click(object sender, EventArgs e)
        {
            string titulo = "";
            string descricao = "";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemFILMES01_Click(object sender, EventArgs e)
        {
            string titulo = "Jumper";
            string descricao = "Quando o adolescente David Rice descobre ser um jumper, isto é, alguém que consegue se teletransportar para qualquer lugar e em qualquer tempo, ele passa a ser perseguido por uma organização secreta que caça jumpers. Então alia-se a outro jovem jumper e mergulha nessa guerra que já é travada há milhares de anos.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemFILMES02_Click(object sender, EventArgs e)
        {
            string titulo = "Your Name";
            string descricao = " dois jovens que numa manhã qualquer trocam de corpo repentinamente. A trama então segue os dois enquanto aprendem sobre a vida um do outro, se apaixonam e lutam para evitar um desastre.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemFILMES03_Click(object sender, EventArgs e)
        {
            string titulo = "Enrolados";
            string descricao = "o filme conta a história de uma jovem princesa perdida de 18 anos, com um longo cabelo mágico que anseia para deixar sua torre isolada. Contra a vontade da sua mãe, ela aceita a ajuda de um ladrão intruso para levá-la ao mundo que ela nunca viu.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemFILMES04_Click(object sender, EventArgs e)
        {
            string titulo = "Mulan";
            string descricao = "Na China da Dinastia Han, a jovem e destemida Mulan decide colocar em risco a sua vida para salvar seu pai e a pátria. Quando seu país é invadido, ela decide se disfarçar de homem, treinar para se tornar um bom soldado e, assim, ocupar o lugar paterno no exército chinês.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }

        private void FotoImagemFILMES05_Click(object sender, EventArgs e)
        {
            string titulo = "Aladin";
            string descricao = "história de Aladdin, um jovem humilde, que descobre uma lâmpada mágica, com um gênio que pode lhe conceder desejos. Agora, o rapaz quer conquistar a moça por quem se apaixonou, mas o que ele não sabe é que a jovem é uma princesa que está prestes a noivar, Jasmine.";

            Form2 telaInfo = new Form2();
            telaInfo.titulo = titulo;
            telaInfo.descricao = descricao;
            telaInfo.Show();
        }
    }
}
