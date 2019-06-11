using System;

namespace SimulacroExamen
{
    class Program
    {
        static void Main(string[] args)
        {

            Solucion  sol  =  new  Solucion ();

            
            /*EJERCICIO 3 */

            sol.crearFiguras();
            sol.mostrarFiguras();

            /*EJERCICIO 1 */
            Console.WriteLine("Ingrese la cotizacion actual:");
            double cotizacion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dolares que desea comprar");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El importe final es: ${sol.ventaDolares(cotizacion, cantidad)}");

            /*EJERICIO 2 */

            sol.cargarMatriz();
            Console.WriteLine($"{sol.calcularMayor()}");



            Console.ReadLine();



        }
    }
}
