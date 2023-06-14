using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;
        public int agencia;

        public Cliente cliente;

        public bool Saca(double valorASerSacado)
        {
            if (this.saldo >= valorASerSacado && valorASerSacado >= 0)
            {
                if (this.cliente.EhMaiorDeIdade())
                {
                    this.saldo -= valorASerSacado;
                    return true;
                }
                else if (valorASerSacado <= 200)
                {
                    this.saldo -= valorASerSacado;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
