using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCardGame
{
    public partial class Start : Form
    {
        private event EventHandler startGame;
        public event EventHandler StartGame
        {
            add { startGame += value; }
            remove { startGame -= value; }
        }
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            startGame?.Invoke(this, new EventArgs());
        }
    }
}
