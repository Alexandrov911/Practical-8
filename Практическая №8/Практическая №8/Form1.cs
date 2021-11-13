using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая__8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            int s = Convert.ToInt32(textBox2.Text);
            int k = Convert.ToInt32(textBox3.Text);
            int t = Convert.ToInt32(textBox4.Text);
            Anketa p = new Anketa();
            p.FIO = fio;
            p.school = s;
            p.klass = k;
            p.test = t;
            listBox1.Items.Add(p);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран объект для удаления");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(k);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = true;
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран объект для удаления");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                Anketa p = listBox1.Items[k] as Anketa;
                textBox1.Text=p.FIO;
                textBox2.Text = p.school.ToString();
                textBox3.Text = p.klass.ToString();
                textBox4.Text = p.test.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            Anketa p = listBox1.Items[k] as Anketa;
            p.FIO = textBox1.Text;
            p.school = Convert.ToInt32(textBox2.Text);
            p.klass = Convert.ToInt32(textBox3.Text);
            p.test = Convert.ToInt32(textBox4.Text);
            listBox1.Items[k] = p;
            button4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Anketa p = listBox1.Items[i] as Anketa;
                sum += p.klass;

            }
            MessageBox.Show((sum * 1.0 / listBox1.Items.Count).ToString());
        }
    }
}
