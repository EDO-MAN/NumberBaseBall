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

        TextBox[] textBoxes = null;

        static Random random = new Random();
        public int randomNumber;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_check(object sender, EventArgs e)
        {

            //label7.Text = "" + ++tryCount;

            //strike = 0;
            //ball = 0;

            //textBoxes = new TextBox[4]
            // {
            //    textBox1,
            //    textBox2,
            //    textBox3,
            //    textBox4
            // };

            //for (int i = 0; i < 4; i++)
            //{
            //    string text = textBoxes[i].Text;
            //    if (text == Convert.ToString(randomNumber).Substring(i, 1))
            //        strike++;
            //}


            ////6015

            //for (int i = 0; i < 4; i++)
            //{
            //    string text = textBoxes[i].Text;
            //    if (Convert.ToString(randomNumber).Contains(text) &&
            //        text != Convert.ToString(randomNumber).Substring(0, 1))
            //    {
            //        ball++;
            //    }

            //}





            ////성공시
            //if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == Convert.ToString(randomNumber))
            //{
            //    //textBox5.BackColor = Color.White;
            //    textBox5.Text = Convert.ToString(randomNumber);
            //    MessageBox.Show("!VICTORY!");
            //    //Application.Restart();
            //}

            ////실행 저장
            //record.Items.Add(
            //    (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text)
            //    + ":" + Convert.ToString(strike) + "S" + " " + Convert.ToString(ball) + "B");

            //textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = null;
            //label4.Text = "" + strike;
            //label5.Text = "" + ball;


            //정답 못 맞출 시 값 초기화


        }

        private void button_activate(object sender, EventArgs e)
        {
            //랜덤 생성

            //해당로직 갈아엎을것


            //randomNumber = random.Next(1000, 10000);

            //string str = Convert.ToString(randomNumber);
            ////textBox5.Text = Convert.ToString(randomNumber);
            //MessageBox.Show(str);

            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < str.Length; j++)
            //    {
            //        if (str[i] == str[j])
            //        {
            //            MessageBox.Show("중복 숫자로 인한 재시작");
            //            button_activate(sender, e);
            //        }
            //    }
            //}

            //button3.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                this.ActiveControl = textBox2;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 1)
            {
                this.ActiveControl = textBox3;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1)
            {
                this.ActiveControl = textBox4;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            randomNumber = random.Next(1000, 10000);

            string str = Convert.ToString(randomNumber);
            //textBox5.Text = Convert.ToString(randomNumber);
            MessageBox.Show(str);

            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        MessageBox.Show("중복 숫자로 인한 재시작");

                        Application.Restart();
                    }
                    
                }
            }

            //button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = "" + ++tryCount;
            strike = 0;
            ball = 0;

            textBoxes = new TextBox[4]
             {
                textBox1,
                textBox2,
                textBox3,
                textBox4
             };

            for (int i = 0; i < textBoxes.Length; i++)
            {
                string text = textBoxes[i].Text;
                if (text == Convert.ToString(randomNumber).Substring(i, 1))
                    strike++;
            }
            //6015

            for (int i = 0; i < textBoxes.Length; i++)
            {
                string text = textBoxes[i].Text;
                if (Convert.ToString(randomNumber).Contains(text) &&
                    text != Convert.ToString(randomNumber).Substring(i, 1))
                {
                    ball++;
                }
            }

            //성공시
            if (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text == Convert.ToString(randomNumber))
            {
                //textBox5.BackColor = Color.White;
                textBox5.Text = Convert.ToString(randomNumber);
                MessageBox.Show("!VICTORY!");
                Application.Restart();
            }

            //실행 저장
            record.Items.Add(
                (textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text)
                + ":" + Convert.ToString(strike) + "S" + " " + Convert.ToString(ball) + "B");

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = null;
            label4.Text = "" + strike;
            label5.Text = "" + ball;
        }
    }
}
