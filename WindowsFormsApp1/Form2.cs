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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string[] main = new string[] { "麥香雞", "麥香魚", "大麥克" };
        int[] mainPrice = new int[] { 50, 60, 70 };
        string[] Dessert = new string[] { "冰炫風", "蘋果派", "蛋捲冰淇淋" };
        int[] dessertPrice = new int[] { 30, 40, 50 };
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(main);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(Dessert);
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.msg += comboBox1.Text + "" + mainPrice[comboBox1.SelectedIndex] + Environment.NewLine;
            Form1.msg += comboBox2.Text + "" + dessertPrice[comboBox2.SelectedIndex] + Environment.NewLine;
            Form1.Price += mainPrice[comboBox1.SelectedIndex] + dessertPrice[comboBox2.SelectedIndex];
            Form1.msg += "＄合計"+(Form1.Price)+"元" + Environment.NewLine;
            DisForm f1 = new DisForm();
            f1.ShowDialog();
            this.Dispose();
        }
    }
}
