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
    public partial class DisForm : Form
    {
        public DisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += "================\r\n";
            if (checkBox1.Checked) 
            {
            Form1.Price = Form1.Price*0.8;
                Form1.msg += "會員打八折";
            }
            if (checkBox2.Checked)
            {
                Form1.Price = Form1.Price - 20;
                Form1.msg += "折扣20元\n";
            }
            Form1.msg += "實收" + Form1.Price + Environment.NewLine;
            this.Dispose();
        }

        private void DisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
