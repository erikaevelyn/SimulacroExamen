using System;

namespace SimulacroExamen{

/*
Plantear un modelo de Figuras que permita representar rectangulos y triangulos. 
Toda figura tiene un nombre.
Implementar el cálculo del área.
Implementar el calculo del perimetro.
Hacer un programa que cree dos triángulos y un rectángulo, agruparlos en una lista.
Recorrer la lista y, por cada elemento, informar por consola area y perimetro.
 */
public class Solucion{

    double comision = 1.05d;
    public double ventaDolares(double cotizacion, int cantidad){
       double precio = cotizacion * cantidad * comision;

       return precio;
    }


    int[,] numeros;
    int col;
    int file;
    public void cargarMatriz(){

    
    
    Console.Write($"Ingrese la cantidad de columnas que quiere que tenga la matriz: ");
                col = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Ingrese la cantidad de filas que quiere que tenga la matriz: ");
                file = Convert.ToInt32(Console.ReadLine());
    
    numeros = new int[col,file];
        
        for(int i = 0; i<col; i++){

            for(int j = 0; j<file; j++){

                Console.Write($"Ingrese un numero para la columna {i+1} y la fila {j+1}: ");
                int numero;
                numero = Convert.ToInt32(Console.ReadLine());
                numeros[i,j] = numero;

            }
        }
    }

    public string calcularMayor(){

        int mayor = 0;
        int columna = 0;
        int fila = 0;

        for(int i=0; i<col; i++){

            for(int j=0; j<file; j++){
                
                if(mayor<numeros[i,j]) {
                    mayor=numeros[i,j];
                    columna = i+1;
                    fila = j+1;
                }

            }
        }

        string solucion = ($"El numero mayor es {mayor}, esta en la columna numero {columna} y la fila numero {fila}");
        return solucion;
    }

    int elegido; 
    int cantidadTotal = 0;
    int cantidadParcial = 0;
    Figura[] figuras;

    public void crearFiguras(){

        Console.WriteLine("Ingrese la cantidad de figuras que va a crear: ");
        cantidadTotal = Convert.ToInt32(Console.ReadLine());
        
      do{
        Console.WriteLine("Ingrese 1 si quiere crear un rectangulo y 2 si quiere crear un triangulo: ");
        elegido = Convert.ToInt32(Console.ReadLine());
        figuras = new Figura[cantidadTotal];
        
        if(elegido==1){
            double baseR;
            double alturaR;

            Console.WriteLine("Ingrese la longitud de la base: ");
            baseR = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de la altura: ");
            alturaR = Convert.ToInt32(Console.ReadLine());

            Rectangulo miRectangulo = new Rectangulo(baseR, alturaR);
            figuras[cantidadParcial]=miRectangulo;
            cantidadParcial++;
            

        }else if(elegido==2){
            double baseT;
            double alturaT;
            double lado1;
            double lado2;

            Console.WriteLine("Ingrese la longitud de la base: ");
            baseT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de la altura: ");
            alturaT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de uno de los lados (que no sea la base): ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud del ultimo lado que queda: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Triangulo miTriangulo = new Triangulo(baseT, alturaT, lado1, lado2);
            figuras[cantidadParcial]=miTriangulo;
            cantidadParcial++;
            
            }
        } while(cantidadParcial<cantidadTotal);
    }


    public void mostrarFiguras(){
        for(int i=0; i<figuras.Length; i++){
            if(figuras[i].nombre == "Rectangulo"){
                Rectangulo figuraActual = (Rectangulo)figuras[i];
                Console.WriteLine($"Figura con indice {i}, es un rectangulo con un area de: {figuraActual.calcularArea()} y un perimetro de: {figuraActual.cacularPerimetro()}");   
            }else if(figuras[i].nombre == "Triangulo"){
                Triangulo figuraActual = (Triangulo)figuras[i];
                Console.WriteLine($"Figura con indice {i}, es un triangulo con un area de: {figuraActual.calcularArea()} y un perimetro de: {figuraActual.cacularPerimetro()}");   
            }
            
        }
    }

}

}