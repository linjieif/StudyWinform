using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyWinform
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            //label1.Text = "hello:" ;
            label1.Text = GlobalFunc.Instance.AcountG;
        }

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string danjia = textBox1.Text;
            string shulian = textBox2.Text;

            int price = 0;
            int count = 0;

            try{  
                price = int.Parse(textBox1.Text); 
                count = int.Parse(textBox2.Text);
            } catch
            {

                MessageBox.Show("定价和数量必须输入数字");
            }

            //int zonjia = int.Parse(danjia) * int.Parse(shulian);
            int zonjia = price * count;

            label4.Text ="总价:" + zonjia.ToString();
        }

        
    }
}
