using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication2;


namespace TP1WFA_Calculadora_
{
    public partial class Form1 : Form
    {   
        string auxiliar1;
        string auxiliar2;
        string operador;
        double resultado;
        Numero miNumero1 = new Numero();
        Numero miNumero2 = new Numero();

        
        public Form1()
        {
            InitializeComponent();
            this.txtNumero1.Text = miNumero1.numero.ToString();
            this.txtNumero2.Text = miNumero2.numero.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            auxiliar1 = this.txtNumero1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            auxiliar2 = this.txtNumero2.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operador = Calculadora.validarOperador(this.cmbOperacion.Text);  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Numero operando1 = new Numero(auxiliar1);
            Numero operando2 = new Numero(auxiliar2);
            resultado = Calculadora.operar(operando1,operando2,operador);
            Numero resultadoFinal = new Numero(resultado);
            this.lblResultado.Text = resultadoFinal.numero.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CC();
        }
        public void CC()//OK
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = miNumero1.numero.ToString();
            this.txtNumero2.Text = miNumero2.numero.ToString();
        }
    }
}
