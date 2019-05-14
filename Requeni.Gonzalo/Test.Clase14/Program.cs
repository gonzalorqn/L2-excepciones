using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase14;

namespace Test.Clase14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            try
            {
                Console.WriteLine("Ingrese un numero:");
                num = ParseadoraDeEnteros.Parse(Console.ReadLine());
                Console.WriteLine("El numero es: " + num);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            //try
            //{
                Console.WriteLine("Ingrese un numero:");
                if(ParseadoraDeEnteros.TryParse(Console.ReadLine(),out num))
                {
                    Console.WriteLine("El numero es: " + num);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El string no podrá ser convertido");
                    Console.ReadLine();
                }
                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.ReadLine();
            //}
        }
    }
}
