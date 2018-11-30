using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text="날짜가 선택되었다!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
