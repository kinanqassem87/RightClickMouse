using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RightClickMouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
             
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip1.Show(this, new Point(label1.Location.X + label1.Width/2, label1.Location.Y + label1.Height/2));
                    }
                    break;
            }

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is open File");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is open Edit");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
