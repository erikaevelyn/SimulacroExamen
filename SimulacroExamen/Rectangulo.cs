using System;
/*3 - Ejercicio
Plantear un modelo de Figuras que permita representar rectangulos y triangulos. 
Toda figura tiene un nombre.
Implementar el cálculo del área.
Implementar el calculo del perimetro.

Hacer un programa que cree dos triángulos y un rectángulo, agruparlos en una lista.
Recorrer la lista y, por cada elemento, informar por consola area y perimetro. */
namespace SimulacroExamen{

    public class Rectangulo : Figura{

        public double area;

        public double perimetro;

        public Rectangulo(double baseFigura, double alturaFigura):base(baseFigura, alturaFigura){
            base.nombre = "Rectangulo";
            base.baseFigura = baseFigura;
            base.alturaFigura = alturaFigura;
        }

        public override double calcularArea(){
            area = base.baseFigura*base.alturaFigura;
            return area;
        }

        public override double cacularPerimetro(){
            perimetro = (base.baseFigura+base.alturaFigura)*2;
            return perimetro;
        }

    }
}