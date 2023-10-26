using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kishki
{
    
    public partial class Form1 : Form
    {
       
        static int[] ingr = { };
        public string ingrs, grams;
        static int[] gram = { };
        static int idbl;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "харчоDataSet3.Продукты". При необходимости она может быть перемещена или удалена.
            this.продуктыTableAdapter1.Fill(this.харчоDataSet3.Продукты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "харчоDataSet2.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter1.Fill(this.харчоDataSet2.Блюда);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int blud = Convert.ToInt32(comboBox2.SelectedIndex.ToString());
            switch (blud)
            {
                case 0:
                    for (int i = 0; i < 10; i++)
                    {
                        comboBox1.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                    }

                    break;
                case 1:
                    MessageBox.Show("1");
                    break;
                case 2:
                    MessageBox.Show("2");
                    break;
                case 3:
                    MessageBox.Show("3");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            //try
            //{
                string name;
                name = comboBox1.SelectedItem.ToString();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                
                if (name == Convert.ToString(dataGridView1.Rows[i].Cells[0].Value))
                    {
                        idbl = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    }
                }
                int id = idbl;
            
     //         int id = Convert.ToInt32(textBox2.Text);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == id)
                    {
                        ingrs = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);//Перенос id ингридиентов в строку
                        grams = Convert.ToString(dataGridView1.Rows[i].Cells[2].Value);// перенос грамовок
                }
                }
            
            //конвертация строки в численный массив
            double c = 0;
            if (String.IsNullOrEmpty(ingrs))
            {
                //прога не робит потому что  пишет что ingrs пустой и не может добавить его в массив
                int i = 0;
                    i = Convert.ToInt32(ingrs);
                    MessageBox.Show(">1");
                    ingr[0] = i;
                MessageBox.Show("" + i);
                gram[0] = Convert.ToInt32(grams);
                c = ingr[0] * gram[0];
            }
            else
            {
                string[] d = ingrs.Split(' ');
                ingr = d.Select(int.Parse).ToArray();
                d = grams.Split(' ');
                gram = d.Select(int.Parse).ToArray();

                c = 0;
                
                for (int i = 0; i < d.Length; i++)
                {
                    MessageBox.Show(dataGridView2.Rows[ingr[i]].Cells[2].Value + "\n" + gram[i] + "\n" + ingr[i]);
                    c += Convert.ToDouble(dataGridView2.Rows[ingr[i]].Cells[2].Value) * gram[i];//вычисление финальной калорийости
                }
            }
                kl.Text = Convert.ToString(c);
            //}
            //catch { MessageBox.Show("Данные введены не коректно или не полностью"); }

        }
    }
}
