using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
    
{
    public  enum  Operacion
    {
        NoDefinida = 0,
        Suma =1,
        Resta = 2,
        Division =3,
        Multiplicacion = 4,
        Modulo = 5,
    }
    public partial class Calculador : Form
        
    {
        double valor1 = 0;
        double valor2 = 0;
        Operacion operador = Operacion.NoDefinida;

        public Calculador()
        {
            InitializeComponent();
        }
        private void  LeerNumero(String numero)

        {
            if (CajaResultado.Text == "0" && CajaResultado.Text != "")
            {
                CajaResultado.Text = numero;
            }
            else
            {
                CajaResultado.Text = CajaResultado.Text + numero;
            }
        }
        private double EjecutarOperacion(String operador )

        {
            double resultado = 0;
            switch (operador )
            {
                case "+":
                    resultado = valor1 + valor2;
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    break;

            }
            return resultado;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblHistorial(object sender, EventArgs e)
        {

        }

        private void CajaResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            operador = Operacion.Modulo;
            ObtenerValor("%");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operador = Operacion.Division;
            ObtenerValor("/");
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador = Operacion.Multiplicacion;
            ObtenerValor("x");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            LeerNumero("4");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LeerNumero("5");

        }

        private void button6_Click(object sender, EventArgs e)
        {

            LeerNumero("6");

        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = Operacion.Resta;
            ObtenerValor("-");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
            



        }

        private void button3_Click(object sender, EventArgs e)
        {

            LeerNumero("2");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            LeerNumero("3");

        }
        private void ObtenerValor (String operador)
        {
            valor1 = Convert.ToDouble(CajaResultado.Text);
            label1.Text = CajaResultado.Text + operador;
            CajaResultado.Text = "0";
        }
        private void button14_Click(object sender, EventArgs e)
        {
            operador = Operacion.Suma;
            ObtenerValor("+");

        }

        private void button10_Click(object sender, EventArgs e)
        {

            LeerNumero("0");

        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (valor2 ==0)
            {
                valor2 = Convert.ToDouble(CajaResultado.Text);
                double resultado = EjecutarOperacion("+");
                CajaResultado.Text = resultado.ToString();
                label1.Text = label1.Text + CajaResultado.Text + " = ";
                valor1 = 0;
                valor2 = 0;
            }
        }
    }
}
