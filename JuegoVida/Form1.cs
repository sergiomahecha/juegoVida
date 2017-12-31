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
using System.Threading;

namespace JuegoVida
{
    public partial class Form1 : Form
    {
        bool[,] actual = new bool[100, 100];

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
                    x = r.Next(0,99);
                    y = r.Next(0, 99);
                    grafico.FillRectangle(color, x*5, y*5, 5, 5);
                    actual[x, y] = true;
                }

            }
            else
            {
                MessageBox.Show("Debe introducir el número de celulas");
                maskedTextBox1.Focus();
            }
        }

        private bool[,] generacion(bool[,] actual)
        {
            bool[,] siguiente = new bool[100, 100];
            for (int x = 0; x < 100; x++)
            {
                for (int y = 0; y <100 ; y++)
                {
                    int vivas = 0;
                    int xMenor = x - 1 < 0 ? 99 : x - 1;
                    int yMenor = y - 1 <0 ? 99 : y - 1;
                    int xMayor = x + 1 >99 ? 0 : x + 1;
                    int yMayor = y + 1 >99 ? 0 : y + 1;

                    if (actual[xMenor, yMenor] == true) vivas++;
                    if (actual[xMenor, y ] == true) vivas++;
                    if (actual[xMenor,yMayor] == true) vivas++;
                    if (actual[x , yMenor] == true) vivas++;
                    if (actual[x , yMayor] == true) vivas++;
                    if (actual[xMayor, yMenor] == true) vivas++;
                    if (actual[xMayor, y ] == true) vivas++;
                    if (actual[xMayor, yMayor] == true) vivas++;

                    if (actual[x, y] == false && vivas == 3) siguiente[x, y] = true;
                    if (actual[x, y] == true && (vivas == 2 || vivas == 3))
                    {
                        siguiente[x, y] = true;
                    }
                    else
                    {
                        siguiente[x, y] = false;
                    }
                }
            }
            return siguiente;
        }

        private void bSeguir_click(object sender, EventArgs e)
        {
            bool[,] siguiente = generacion(actual);
            Graphics grafico = panel1.CreateGraphics();
            Brush color = Brushes.Magenta;
            Brush azul = Brushes.Aquamarine;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (siguiente[i, j] == true)
                    {
                        grafico.FillRectangle(color, i * 5, j * 5, 5, 5);
                    }
                    else
                    {
                        grafico.FillRectangle(azul, i * 5, j * 5, 5, 5);
                    }
                }
            }
            actual = siguiente;
        }
    }
}
