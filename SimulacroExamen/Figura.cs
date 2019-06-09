using System;
/*3 - Ejercicio
Plantear un modelo de Figuras que permita representar rectangulos y triangulos. 
Toda figura tiene un nombre.
Implementar el cálculo del área.
Implementar el calculo del perimetro.

Hacer un programa que cree dos triángulos y un rectángulo, agruparlos en una lista.
Recorrer la lista y, por cada elemento, informar por consola area y perimetro. */
namespace SimulacroExamen{

    public abstract class Figura{

        public double baseFigura;
        public double alturaFigura;
        public string nombre;


        public Figura(double baseFigura, double alturaFigura){

        }

        public abstract double calcularArea();

        public abstract double cacularPerimetro();




    }
}