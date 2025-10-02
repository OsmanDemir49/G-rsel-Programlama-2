using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp2_02_10_örn_3
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

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rastgele = new Random();
            // button1.Location = new Point(rastgele.Next(0, 100), rastgele.Next(0, 100));
            // button1.SetBounds(100, 100, 100, 100);
            button1.Left = rastgele.Next(0 , 100);
            button1.Top = rastgele.Next(0 , 100);
        }
    }
}
