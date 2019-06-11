using System;
/*3 - Ejercicio
Plantear un modelo de Figuras que permita representar rectangulos y triangulos. 
Toda figura tiene un nombre.
Implementar el cálculo del área.
Implementar el calculo del perimetro.

Hacer un programa que cree dos triángulos y un rectángulo, agruparlos en una lista.
Recorrer la lista y, por cada elemento, informar por consola area y perimetro. */
namespace SimulacroExamen{

    public class Triangulo : Figura{

        public double lado1;
        public double lado2;

        public Triangulo(double baseFigura, double alturaFigura, double lado1, double lado2):base(baseFigura, alturaFigura){
            base.nombre = "Triangulo";
            this.lado1 = lado1;
            this.lado2 = lado2;
            base.baseFigura = baseFigura;
            base.alturaFigura = alturaFigura;
        }

        public override double calcularArea(){
            base.area = (base.baseFigura*base.alturaFigura)/2;
            return base.area;

        }

        public override double cacularPerimetro(){
            base.perimetro = base.baseFigura + this.lado1 + this.lado2;
            return base.perimetro;
        }

    }
}