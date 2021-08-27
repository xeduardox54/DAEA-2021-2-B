using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_01_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblValor2_Click(object sender, EventArgs e)
        {

        }

        //Función para el botón de suma
        private void btnSuma_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtValor1.Text) + Convert.ToInt32(txtValor2.Text);
            rtbResultado.Text = Convert.ToString("La suma de " + txtValor1.Text + " y " + txtValor2.Text + " es igual a " + resultado);
        }
        //Función para el botón de resta
        private void btnResta_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtValor1.Text) - Convert.ToInt32(txtValor2.Text);
            rtbResultado.Text = Convert.ToString("La resta de " + txtValor1.Text + " y " + txtValor2.Text + " es igual a " + resultado);
        }
        //Función para el botón de multiplicación
        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtValor1.Text) * Convert.ToInt32(txtValor2.Text);
            rtbResultado.Text = Convert.ToString("La multiplicación de " + txtValor1.Text + " y " + txtValor2.Text + " es igual a " + resultado);
        }
        //Función para el botón de división
        private void btnDivision_Click(object sender, EventArgs e)
        {
            int resultado = Convert.ToInt32(txtValor1.Text) / Convert.ToInt32(txtValor2.Text);
            rtbResultado.Text = Convert.ToString("La división de " + txtValor1.Text + " y " + txtValor2.Text + " es igual a " + resultado);
        }
        //Función para el botón de calculo de raices
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 1; i <= 10; i++)
            {
                text += "La raíz cuadrada de " + i + " es: " + Math.Sqrt(i) + "\n";
            }
            rtbResultado.Text = text;
        }
        //Función para el botón de calculo de primos
        private void btnPrimos_Click(object sender, EventArgs e)
        {
            string texto = "";
            int contador_primos = 0;
            int cont = 2;
            while (true)
            {
                if (EsPrimo(cont))
                {
                    texto += "El número " + cont + " es primo.\n";
                    contador_primos++;
                }
                if (contador_primos == 10) break;
                cont++;
            }
            rtbResultado.Text = texto;
        }

        //Procedimiento para comprobar que un número es primo
        static bool EsPrimo(int num)
        {
            int multiplos = 0;
            for (int cont = 1; cont <= num; cont++)
            {
                if (num % cont == 0) multiplos++;
                if (multiplos >= 3) return false;
            }
            return true;
        }

    }
}
