using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((BtnResponse("foo1")));
        }

        public string BtnResponse(string myinput)
        {
            string string1 = null;
            string string2 = null;
            if (myinput != null)
            {
                 string1 = "Hello";
                 string2 = "World1";
            }

            return string1 + " " + string2;
        }
    }
}
