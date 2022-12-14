using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork9WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
            Form1().ActiveForm.BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
            Form1().ActiveForm.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
