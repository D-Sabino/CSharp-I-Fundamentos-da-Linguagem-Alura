﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta;
            numeroDaConta = 1;

            double saldo = 100.0;
            double valor = 10.0;
            bool podeSacar = (valor <= saldo) && (valor >= 0) ;

            if (podeSacar )
            {
                double saldoAposSaque = saldo - valor;

                MessageBox.Show("O saldo foi realizado com sucesso!");
                MessageBox.Show("O saldo atual é: " + saldoAposSaque);
            } else
            {
                MessageBox.Show("Saldo insuficiente");
            }

                

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Carlos = 64;
            int Maria = 64;
            int Daniel = 25;
            int media = (Carlos + Maria + Daniel) / 3;
            MessageBox.Show("A media das idades é: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;

            a = 2;
            b = 5;
            c = 2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("A1 = " + a1 + "\nA2 = " + a2);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idade = 25;
            bool brasileira = true;

            if (brasileira && idade >= 16)
            {
                MessageBox.Show("Você pode votar!");
            } else if (idade < 16)
            {
                MessageBox.Show("Você precisa ter mais de 16 anos para votar!");
            }
            else
            {
                MessageBox.Show("Você precisa ser um cidadão brasileiro para votar!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 100;
            double imposto;

            if (valorDaNotaFiscal < 1000)
            {
                imposto = valorDaNotaFiscal * 0.02;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal < 3000)
            {
                imposto = valorDaNotaFiscal * 0.025;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal < 7000)
            {
                imposto = valorDaNotaFiscal * 0.028;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 7000)
            {
                imposto = valorDaNotaFiscal * 0.03;
                MessageBox.Show("O imposto sera de " + imposto);
            }
        }
    }
}
