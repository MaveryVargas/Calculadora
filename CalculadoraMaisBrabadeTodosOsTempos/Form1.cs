using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraMaisBrabadeTodosOsTempos
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        /*private void textBox_Result_TextChanged(object sender, EventArgs e)
        {
           textBox_Result.Text = igual.ToString(); //imprimindo valor na text box
        }*/
        
        double igual;
        string valorImp;
        double valorAux;

        
        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "1"; // so de chamar a textBox ela ja printa na tela
            valorAux= 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "2";
            valorAux= 2;
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
            textBox_Result.Text = textBox_Result.Text + ",";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "-";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "*";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = textBox_Result.Text + "/";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear(); // ou fazer textBox_Result.Text = " ";

        }
    
    }
}
