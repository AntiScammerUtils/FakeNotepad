using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scammer_Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MainText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.KeyChar = (char)((int)e.KeyChar + 1);
                if(e.KeyChar == (char)((int)'Z' + 1))
                {
                    e.KeyChar = 'A';
                }
                e.Handled = false;
            }
            else if(e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.KeyChar = (char)((int)e.KeyChar + 1);
                if (e.KeyChar == (char)((int)'z' + 1))
                {
                    e.KeyChar = 'a';
                }
                e.Handled = false;
            }
            else if(e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.KeyChar = (char)((int)e.KeyChar + 1);
                if(e.KeyChar == (char)((int)'9' + 1))
                {
                    e.KeyChar = '0';
                }
                e.Handled = false;
            }
        }
    }
}
