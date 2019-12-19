using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyszamjatekGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TippTxtBox_TextChanged(object sender, EventArgs e)
        {

            DarabLbl.Text = TippTxtBox.Text.Split(' ').Where(x => x.Length != 0).ToList().Count + " db";
             
        }
    }
}
