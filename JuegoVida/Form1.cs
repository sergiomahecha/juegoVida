using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JuegoVida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Aquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text!="")
            {
                int celulas = int.Parse(maskedTextBox1.Text);
                Graphics grafico = panel1.CreateGraphics();
                Brush color = Brushes.Magenta;
                Random r = new Random();
                int x, y;
                for (int i = 0; i < celulas; i++)
                {
                    x = r.Next(0,100);
                    y = r.Next(0, 100);
                    grafico.FillRectangle(color, x*5, y*5, 5, 5);
                }
            }
            else
            {
                MessageBox.Show("Debe introducir el número de celulas");
                maskedTextBox1.Focus();
            }
        }
    }
}
