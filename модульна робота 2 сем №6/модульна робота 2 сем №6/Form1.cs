using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace модульна_робота_2_сем__6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = (int)numericUpDown2.Value;
            dataGridView2.ColumnCount = (int)numericUpDown2.Value;
        }

        private void елемЯкіЗаСереднєАрифметичнеЗамін0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            numericUpDown1.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
            textBox1.Visible = false;
            int hg = dataGridView1.Size.Height;
            hg = 92;           
            rez_Button.Visible = true;
        }
        private void rez_Button_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            double[] array = new double[(int)numericUpDown2.Value];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToDouble(dataGridView1[i, 0].Value);
            }
            ArraySort arr = new ArraySort();
            double[] vec = arr.getArray(array);

            for (int j = 0; j < array.Length; j++)
            {
                dataGridView2[j, 0].Value = vec[j];
            }
        }

        private void знайтиMaxЕлемГоловноїДіагоналіТаДобутокТогоРядкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rez_Button.Visible = false;
            dataGridView2.Visible = false;
            double HG = dataGridView1.Size.Height;
            HG = 230;
            label2.Visible = true;
            numericUpDown1.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value == (int)numericUpDown2.Value)
            {
                label3.Visible = true;
                textBox1.Visible = true;
                double[,] arr_max = new double[(int)numericUpDown1.Value, (int)numericUpDown2.Value];
                double num = 0; int n = 0;
                for (int i = 0; i < (int)numericUpDown1.Value; i++)
                {
                    for (int j = 0; j < (int)numericUpDown2.Value; j++)
                    {
                        arr_max[i,j] = Convert.ToDouble(dataGridView1[j,i].Value);
                    }                   
                }
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (num < arr_max[i, i])
                    {
                        num = arr_max[i, i];
                        n = i;
                    }
                }
                double res = 1;
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                    res *= arr_max[n, i];
                textBox1.Text = res.ToString();
            }
            else
                MessageBox.Show("Має бути квадратна матриця");
        }
    }
}
