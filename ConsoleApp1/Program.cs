using System.Runtime.CompilerServices;
///Nombre del estudiante
///Grupo: 213022_118
///Programa: Ingenieria en Sistemas
///Código Fuente: autoría propia



namespace Consoleapp1
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("Fruteria UNAD, Peras, Manzanas, Ciruelas, Bananas, Piñas.");
            
            ///
                Console.WriteLine("Ingrese el numero de Manzanas que desea llevar");
                int manzanas = Convert.ToInt32(Console.ReadLine());

                const int manzanas_value = 560;
                int manzanas_total = manzanas * manzanas_value;

                Console.WriteLine("Ha ordenado " + manzanas + " Manzanas");
                Console.WriteLine("Por un valor total de " + manzanas_total + " Pesos");

            // Manzanas 

            Console.WriteLine("Ingrese el numero de peras que desea llevar");
            int Peras = Convert.ToInt32(Console.ReadLine());

            const int peras_value = 460;
            int peras_total = Peras * peras_value;

            Console.WriteLine("Ha ordenado " + Peras + " peras");
            Console.WriteLine("Por un valor total de " + peras_total + " Pesos");
            // peras 

            Console.WriteLine("Ingrese el numero de ciruelas que desea llevar");
            int ciruelas = Convert.ToInt32(Console.ReadLine());

            const int ciruelas_value = 30;
            int ciruelas_total = ciruelas * ciruelas_value;

            Console.WriteLine("Ha ordenado " + ciruelas + " ciruelas");
            Console.WriteLine("Por un valor total de " + ciruelas_total + " Pesos");
            // ciruelas 

            Console.WriteLine("Ingrese el numero de Bananos que desea llevar");
            int bananas = Convert.ToInt32(Console.ReadLine());

            const int bananas_value = 80;
            int bananas_total = bananas * bananas_value;

            Console.WriteLine("Ha ordenado " + bananas + " bananas");
            Console.WriteLine("Por un valor total de " + bananas_total + " Pesos");
            //Bananas

            Console.WriteLine("Ingrese el numero de piñass que desea llevar");
            int piñas = Convert.ToInt32(Console.ReadLine());

            const int piñas_value = 1000;
            int piñas_total = piñas * piñas_value;

            Console.WriteLine("Ha ordenado " + piñas + " Piñas");
            Console.WriteLine("Por un valor total de " + piñas_total + " Pesos");
            //Piñas


            double order_value = piñas_total + manzanas_total + bananas_total + ciruelas_total + peras_total;


            Console.WriteLine("Su orden ha finalizado, el valor total a pagar es " + order_value + " pesos");
            void discount()
            {
                if (order_value >= 20000)
                {
                    order_value = order_value * 0.90;
                    Console.WriteLine("Su descuento efectuado fue del 10% por sobrepasar una compra de $20000, el valor final a pagar es de " + order_value);
                }
            }

            discount();
            
            /*
           Console.WriteLine("Ingrese el numero de Ciruelas que desea llevar");
           Console.WriteLine("Ingrese el numero de Bananas que desea llevar");
           Console.WriteLine("Ingrese el numero de Piñas que desea llevar");
           */

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
