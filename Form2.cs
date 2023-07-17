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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TituloDoFilme.Text = titulo;
            DescriçãoDoFilmeAqui.Text = descricao;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
