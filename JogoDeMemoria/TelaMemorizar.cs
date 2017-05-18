using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeMemoria
{
    public partial class TelaMemorizar : Form
    {
        public TelaMemorizar()
        {
            InitializeComponent();
        }

        private void timerMemorizar_Tick(object sender, EventArgs e)
        {
            timerMemorizar.Stop();
            Hide();
            Jogo jogo = new Jogo();
            jogo.ShowDialog();
        }

        private void TelaMemorizar_Load(object sender, EventArgs e)
        {
            timerMemorizar.Start();
        }
    }
}
