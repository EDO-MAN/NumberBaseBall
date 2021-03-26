using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberBaseball
{
    public partial class Form1 : Form
    {
        int tryCount = 0;
        int strike = 0;
        int ball = 0;
        static Random random = new Random();
        static int randomNumber = random.Next(1000, 10000);
     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "" + ++tryCount;

            record.Items.Add(
                (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text)
                + ":" + strike + "S" + " " + ball + "B");

            if ((textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text)
                == textBox5.Text)
            {
                textBox5.BackColor = Color.White;
                MessageBox.Show("!VICTORY!");
                Application.Restart();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Text = Convert.ToString(randomNumber);
            record.Items.Add(textBox5.Text);
            if (textBox5.Text.Contains("1111") || textBox5.Text.Contains("2222") || textBox5.Text.Contains("3333") ||
                textBox5.Text.Contains("4444") || textBox5.Text.Contains("5555") || textBox5.Text.Contains("6666") ||
                textBox5.Text.Contains("7777") || textBox5.Text.Contains("8888") || textBox5.Text.Contains("9999"))
            {
                MessageBox.Show("중복 숫자로 인한 재시작");
                Application.Restart();
            }
            else
                textBox5.BackColor = Color.Black;
                button3.Enabled = false;
        }
    }
}
