using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace track_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //track Pen
        Pen WhitePen = new Pen(Color.WhiteSmoke, 5);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
