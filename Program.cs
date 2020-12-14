using System;
using Sobrecarga.classes;
namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("Tsuka");
            fun.Mostrar(3);
            Console.Beep();
            //Console.WriteLine();
        }
    }
}
