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

        private void button6_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;
            /* Estrutura for
            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.01;
            }
            */

            /* Estrutura While */
            int i = 1;
            while (i <= 12)
            {
                valorInvestido *= 1.01;
                i++;
            }

            MessageBox.Show("O valor investido agora é: " + valorInvestido);


        }

        private void button7_Click(object sender, EventArgs e)
        {

            String texto = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    texto = texto + ", " + i.ToString();
                }
            }

            MessageBox.Show("Os números múltiplos de 3 são: " + texto);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("fatorial(" + n + ") = " + fatorial);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";
            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numero = 15;
            
            if (numero % 3 == 0)
            {
                MessageBox.Show("O numero " + numero + " é divisivel por 3!");
            }else if (numero % 4 == 0)
            {
                MessageBox.Show("O numero " + numero + " é divisivel por 4!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String texto_3 = "";
            String texto_4 = "";

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    texto_3 = texto_3 + ", " + i.ToString();
                } else if (i % 4 == 0){
                    texto_4 = texto_4 + ", " + i.ToString();
                }
            }

            MessageBox.Show("Os números múltiplos de 3 são: " + texto_3);
            MessageBox.Show("Os números múltiplos de 4 são: " + texto_4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }

            MessageBox.Show("Total: " + soma);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*AULA 06*/
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim";
            umaConta.saldo = 2000.0;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva";
            outraConta.saldo = 1500.0;

            //MessageBox.Show("O titular da conta " + umaConta.numero + " é " + umaConta.titular);


            /*AULA 07*/
            Conta guilherme = new Conta();
            Conta mauricio = new Conta();

            guilherme.saldo = 1500.0;
            mauricio.saldo = 2000.0;

            guilherme.Transfere(200.0, mauricio);

            //MessageBox.Show("O saldo da conta guilherme é " + guilherme.saldo);
            //MessageBox.Show("O saldo da conta mauricio é " + mauricio.saldo);



            /*AULA 08*/
            Conta conta = new Conta();
            Cliente cliente = new Cliente();

            conta.cliente = cliente;

            /*Duas formas de alterar o mesmo objeto*/
            cliente.nome = "Victor"; //outra forma: conta.cliente.nome = ...
            conta.cliente.rgTitular = "12345678-9"; //outra forma: cliente.rgtitular = ...

            MessageBox.Show(conta.cliente.nome);


        }
    }
}
