


using System;
using System.Net.NetworkInformation;

namespace Miprograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura = 150;
            string estado;
            estado = temperatura < 0 ? "Solido" : temperatura > 99 ? "Gaseoso" : "Liquido";
            Console.WriteLine("El estado del agua es {0}", estado);
            Console.Read();
        }
    } 
}
