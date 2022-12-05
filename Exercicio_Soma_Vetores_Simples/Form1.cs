using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Soma_Vetores_Simples
{
    public partial class Form1 : Form
    {
        int[] vetor1 = new int[10];//Apesar de os vetores começarem em 0 e o ideal era um vetor com 9, precisamos por 10 pra fazer a condição de paragem
        int[] vetor2 = new int[10];

        int posicao1, posicao2 = 0;
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPosicao1.Text = "0";
            lblPosicao2.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int valorVerificar2 = 0;
            if (txtValor2.Text != "" && int.TryParse(txtValor2.Text, out valorVerificar2) == true)
            {
                vetor2[posicao2] = int.Parse(txtValor2.Text);
                posicao2++;
                lblPosicao2.Text = posicao2.ToString();
                txtValor2.ResetText();
                txtValor2.Focus();

                if (posicao2 > 9)
                {                    
                    btnInserir2.Enabled = false;
                    txtValor2.Enabled = false;
                    MessageBox.Show("Atingiu limite de Valores.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Insira um valor inteiro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }   

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int valorVerificacao = 0;
            if (txtValor1.Text != ""&& int.TryParse(txtValor1.Text, out valorVerificacao) == true)
            {
                vetor1[posicao1] = int.Parse(txtValor1.Text);
                posicao1++;
                lblPosicao1.Text = posicao1.ToString();
                txtValor1.ResetText();
                txtValor1.Focus();
                //Pedido do Exercicio para que seja feita inserção de 9 numeros e para isso inserimos criterio de paragem.
                if (posicao1 > 9)
                {
                    MessageBox.Show("Atingiu limite de Valores.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnInserir1.Enabled = false;
                    txtValor1.Enabled = false;
                }
            }
            else MessageBox.Show("Insira um valor inteiro.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }       

        private void btnApresentar_Click(object sender, EventArgs e)
        {
            if (posicao1 > 9 && posicao2 > 9)
            {
                for (int ctd = 0; ctd <= 9; ctd++)
                {
                    lstVetor1.Items.Clear();
                    lstVetor2.Items.Clear();
                    lstVetor1.Items.Add(vetor1[ctd]).ToString();
                    lstVetor2.Items.Add(vetor2[ctd]).ToString();
                }
            }
            else MessageBox.Show("O vetor não possui todos os espaços preenchidos.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnSomar_Click(object sender, EventArgs e)
        {
            if (posicao1 > 9 && posicao2 > 9)
            {
                for (int cont = 0; cont <= 9; cont++)
                {
                    lstSoma.Items.Clear();
                    lstSoma.Items.Add(vetor1[cont] + vetor2[cont]).ToString();
                }
            }
            else MessageBox.Show("Vetores não estão completamente preenchidos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
