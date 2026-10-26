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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.Text = GlobalFunc.Instance.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string acount = textBox1.Text;
            string pass = textBox2.Text;

            //if (acount == "admin"&& pass == "123456")
            //{
            //    MessageBox.Show("登录成功");

            //}
            //else
            //{
            //    MessageBox.Show("登录失败");
            //}

            if (acount != "admin")
            {
                MessageBox.Show("账号错误,登录失败");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            if (pass != "123123")
            {
                MessageBox.Show("密码错误，登录失败");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            //MessageBox.Show("账号和密码正确,登录成功");

            GlobalFunc.Instance.AcountG = acount;
            Index index = new Index();
            index.Show();

            // 这里的this，其实是指代 Form1 创建的窗体
            //this.Hide();
            GlobalFunc.Instance.formLogin.Hide();

        }



        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    btn.Text = "OK";

        //    // 为什么没用？因为之前在外部创建的Button现在放进了循环里面，现在要通过点击事件直接拿到xx的方式获取button
        //    //this.button2.Text / button2.Text = "我受不了了";
        //    //button1.Text = "我真的没胖";
        //}


    }
}
