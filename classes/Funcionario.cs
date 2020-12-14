using System;
namespace Sobrecarga.classes


{
    public class Funcionario
    {
        public string[] lista = {"Paulo", "Tsuka", "Priscila", "Fernanda"};
        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine (item);
                Console.ResetColor();
            }
        }
        public void Mostrar (int indice)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine (lista[indice]);
                Console.ResetColor();
        }
        public void Mostrar (string busca)
        {   // Fazemos uma busca no array para verificar se os textos coincidem
           foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (item == busca)
                {Console.WriteLine ("Resultado da busca"+item);}
                Console.ResetColor();
            }
        }
        

    }
}
