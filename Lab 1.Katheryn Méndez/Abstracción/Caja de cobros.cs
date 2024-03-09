using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Katheryn_Méndez.Abstrancción
{
    internal class Caja_de_cobros: IFunciones //Usa los metodos de la interfaz
    {
        public string articulo {  get; set; }

        public double total { get; set; }

        public double subtotal { get; set; }

        void IFunciones.ActualizarFactura()
        {
            Console.WriteLine("Actualizar factura");
        }

        void IFunciones.AgregarFactura()
        {
            Console.WriteLine("Agregar factura");
        }

        void IFunciones.EliminarFactura()
        {
            Console.WriteLine("Eliminar factura");
        }

        void IFunciones.VerFactura()
        {
            Console.WriteLine("Ver factura");
        }
    }
}
