using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 20;
            dataGridView1.ColumnCount = 20;
            int[,] a = new int[20, 20];
            int i, j, max = 0;
            Random random = new Random();
            for (i = 0; i < 20; i++)
                for (j = 0; j < 20; j++)
                    a[i, j] = random.Next(0, 100);
            for (i = 0; i < 20; i++)
                for (j = 0; j < 20; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            for (i = 0; i < 20; i++)
                for (j = 0; j < 20; j++)
                    if (a[i, j] >= a[i - 1 == -1 ? i : i - 1, j] &&
                        a[i, j] >= a[i + 1 == 20 ? i : i + 1, j] &&
                        a[i, j] >= a[i, j - 1 == -1 ? j : j - 1] &&
                        a[i, j] >= a[i, j + 1 == 20 ? j : j + 1])
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.GreenYellow;
                        max++;
                    }
             textBox1.Text = Convert.ToString(max);
        }
    }
}
