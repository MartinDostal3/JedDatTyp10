using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JedDatTyp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            for(int i = 0; i < n; i++)
            {
                int pismeno = rnd.Next('M' - '*' + 1) + '*';
                char znak = (char)pismeno;
                listBox1.Items.Add(znak);

            }

            int soucet = 0;           
            for(int i = 0; i < listBox1.Items.Count; i++)
            {

                char znak = char.Parse(listBox1.Items[i].ToString());
                if(checkBox1.Checked)
                {
                    if(char.IsDigit(znak))
                    {
                        int cislo = int.Parse(znak.ToString());
                        soucet += cislo;
                    }
                    
                }
            }

            bool obsahuje = false;
            int pocet = 0;
            for (int i =0; i <listBox1.Items.Count && !obsahuje;i++)
            {
                char znak = char.Parse(listBox1.Items[i].ToString());
                if (checkBox2.Checked)
                {
                    if(char.IsUpper(znak))
                    {
                        ++pocet;
                        if(pocet>=3)
                        {
                            obsahuje = true;
                        }

                    }


                }

            }
            if(checkBox1.Checked)
            {
                MessageBox.Show("Soucet je: " + soucet);
            }

            if(checkBox2.Checked)
            {
                if(obsahuje)
                {
                    MessageBox.Show("Ano, posloupnost obsahuje tři velká písmena");
                }
                else
                {
                    MessageBox.Show("Ne, posloupnost neobsahuje tři velká písmena");
                }


            }

            


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
