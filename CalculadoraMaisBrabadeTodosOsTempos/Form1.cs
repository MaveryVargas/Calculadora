using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraMaisBrabadeTodosOsTempos
{

   
    enum Operacao
    {
        soma,
        subtracao,
        mult,
        div
    }

    public partial class Calculadora : Form
    {
        private Operacao OperacaoSelec {get; set;}
        public double valor {get; set;} 
        public double result {get; set;}
        public double resultquad {get; set;}
        public Calculadora()
        {
            InitializeComponent();
        }        
        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "1"; // so de chamar a textBox ela ja printa na tela
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "0";
        }

        private void btn_Virg_Click(object sender, EventArgs e)
        {
            if(!textBox_Result.Text.Contains(","))
            {
                textBox_Result.Text = textBox_Result.Text + ",";
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.soma;
            valor = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Clear();
            
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.subtracao;
            valor = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            OperacaoSelec = Operacao.mult;
            textBox_Result.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {   
            OperacaoSelec = Operacao.div;
            valor = Convert.ToDouble(textBox_Result.Text);
            textBox_Result.Clear();
        }

        private void btn_quadrado_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(textBox_Result.Text);
            result = Math.Pow(valor ,2);
            textBox_Result.Text = Convert.ToString(result);
        }
        private void btn_root_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(textBox_Result.Text);
            result = Math.Sqrt(valor);
            textBox_Result.Text = Convert.ToString(result);
        }
        private void btn_sen_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(textBox_Result.Text);
            result = Math.Sin(valor);
            textBox_Result.Text = Convert.ToString(result);
        }
        private void btn_Cos_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDouble(textBox_Result.Text);
            result = Math.Cos(valor);
            textBox_Result.Text = Convert.ToString(result);
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear(); // ou fazer textBox_Result.Text = " ";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelec)
            {
                case Operacao.soma:
                    result = valor + Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = Convert.ToString(result);
                    break;
                
                case Operacao.subtracao:
                    result = valor - Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = Convert.ToString(result);
                    break;
                
                case Operacao.mult:
                    result = valor * Convert.ToDouble(textBox_Result.Text);
                    textBox_Result.Text = Convert.ToString(result);
                    break;
                
                case Operacao.div:
                    double aux = Convert.ToDouble(textBox_Result.Text);
                    if (aux == 0)
                    {
                        //ForeColor muda a cor da fonte, BackColor muda a cor da textbox
                        //textBox_Result.ForeColor = Color.Red;
                        textBox_Result.Text = "ERRO";
                    }
                    else
                    {
                        result = valor / Convert.ToDouble(textBox_Result.Text);
                        textBox_Result.Text = Convert.ToString(result);
                    }
                    break;
            }
            

        
        }
    }
}
