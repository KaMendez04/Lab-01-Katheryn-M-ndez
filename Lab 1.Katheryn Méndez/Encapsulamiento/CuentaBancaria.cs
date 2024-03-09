using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Katheryn_Méndez.Encapsulamiento
{
    public class CuentaBancaria
    {
        private double saldo; // Saldo privado

        public void Depositar(double cantidad)
        {
            saldo += cantidad;
        }

        public void Retirar(double cantidad)
        {
            if (cantidad <= saldo)
            {
                saldo -= cantidad;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }

        public double ObtenerSaldo() 
        {
            return saldo;
        }
    }
}
