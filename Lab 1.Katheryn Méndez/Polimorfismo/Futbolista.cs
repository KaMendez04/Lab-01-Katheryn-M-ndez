using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1.Katheryn_Méndez.Polimorfismo
{
    public class Futbolista : IProfesion
    {
        void IProfesion.Correr()
        {
            Console.WriteLine("El furbolista debe correr por el balon");
        }
    }
}
