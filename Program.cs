using System;

namespace Ejercicios_6
{
    class Program
    {
        private static int length;

        static void Main(string[] args)
        {


            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            Console.WriteLine("1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.");
            Console.WriteLine("Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.");


             int [] vector= new int [10];
             int numero, max = 0;


             for (int x = 0; x < 10; x++)
             {
                 Console.WriteLine("Ingresar un numero");
                 numero = int.Parse(Console.ReadLine());

                 vector[x] = numero;
             }

             for (int y = 0; y < 10; y++)
             {


                 if (vector[y] > max)
                 {
                     max = vector[y];
                 }
             }

             Console.WriteLine("El numero mayor es : " + max);

            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            Console.WriteLine("2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.");
            Console.WriteLine(" Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.");
     
            int[] num = new int[10];
            int n, acum = 0;
            float promedio, con = 0, promedio2 = 0;

            for (int z = 0; z < 10; z++)
            {
            
                  Console.WriteLine("Ingresar un numero");
                  n = int.Parse(Console.ReadLine());

                  num [z] = n;
;
            }

            for (int z = 0; z < 10; z++)
            {
                   acum += num[z];
                   con++;
            }

              promedio = acum / con;
            Console.WriteLine("El promedio : " + promedio);

            for (int z = 0; z < 10; z++)
            {
                if (num[z] > promedio)
                {
                    promedio = num[z];
                    Console.WriteLine("Este numero es mayor al promedio : " + promedio );
                }
            }
            

           

            // 3A. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos)
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.
            // Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"

            Console.WriteLine("3A. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos)");
            Console.WriteLine("El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo.");
            Console.WriteLine("Mostrar el resultado en pantalla. Ejemplo:");
            Console.WriteLine("CADENA FUENTE: “La mar estaba serena");
            Console.WriteLine("CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’");
            Console.WriteLine("CADENA RESULTADO: “Li mir estibi sereni");


            char[]frase = new char[30];    
            char letraActual;
            char letraNueva;
            char letra;
            int indice = 0;

            Console.WriteLine("Ingresar un letra para la frase");
            letra = char.Parse(Console.ReadLine());

            while (letra != '0' && indice < 30)
            {
                frase[indice] = letra;
                Console.WriteLine("Ingresar un letra");
                letra = char.Parse(Console.ReadLine());
                indice++;
            }

            frase [indice] = '\0';
            Console.WriteLine("La frase completa es : ");
            indice = 0;

            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }

            Console.WriteLine(" Ingresar la letra a reemplazar");
            letraActual = char.Parse(Console.ReadLine());
             
            Console.WriteLine(" Ingresar la nueva letra");
            letraNueva = char.Parse(Console.ReadLine());

            indice = 0;

            while (frase[indice] != '\0')
            {
                if (frase[indice] == letraActual)
                
                    frase[indice] = letraNueva;
                    indice++;
                
            }

            Console.Write("La frase nueva es : ");

            indice = 0; 

            while (frase[indice] != '\0')
            {
                Console.Write(frase[indice]);
                indice++;
            }


            // 3B. Resolver el mismo ejercicio con el string.

            Console.WriteLine("3B. Resolver el mismo ejercicio con el string ");

            string fraselete;
            char letraActualAca;
            char letraNuevaAca;
           


            Console.WriteLine("Ingresar la frase");
            fraselete = Console.ReadLine();

            Console.WriteLine("Ingresar la letra a reemplazar");
            letraActualAca = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la nueva letra");
            letraNuevaAca = char.Parse(Console.ReadLine());


            fraselete = fraselete.Replace(letraActualAca, letraNuevaAca);

            Console.WriteLine("La cadena nueva es : " + fraselete);


            // 4. Una empresa comercializa articulos. Cargar los numeros de articulos y la cantidad de productos vendidos.
            // a. ¿Cuál es el producto más vendido?
            // b. ¿Cuál es el producto que NO obtubvo ventas?

            Console.WriteLine("4. Una empresa comercializa articulos. Cargar los numeros de articulos y la cantidad de productos vendidos.");
            Console.WriteLine("¿Cuál es el producto más vendido?");
            Console.WriteLine("¿Cuál es el producto que NO obtubvo ventas?");


            int nroArticulo;
            int cantidad;
            int[]totalCantidadVEndida = new int[15];

            for (int x = 0; x < length; x++)
            {
                totalCantidadVEndida[x] = 0;
            }

            Console.WriteLine("Ingresar el nro de articulo");
            nroArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());


            while (nroArticulo != 0)
            {
                totalCantidadVEndida[nroArticulo - 1] += cantidad;

                Console.WriteLine("Ingresar el nro de articulo");
                nroArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingresar la cantidad vendida");
                cantidad = int.Parse(Console.ReadLine());

            }
            //punto a
           
            int maxCantidad = totalCantidadVEndida[0];
            int nroMaximo = 1;

            for (int x = 0; x < length; x++)
            {
                    if (totalCantidadVEndida[x] > maxCantidad)
                    {
                        maxCantidad = totalCantidadVEndida[x];
                        nroMaximo = x + 1;
                    }     
            }

            Console.WriteLine("¿Cuál es el producto más vendido?");

            Console.WriteLine("El producto mas vendido : " + 
            nroMaximo + "Tiene la cantidad de " + maxCantidad);

            //punto b


            Console.WriteLine(" B) ¿Cuál es el producto que NO obtubvo ventas?");

            for (int x = 0; x < length; x++)
            {

                    if (totalCantidadVEndida [x] == 0)
                    {
                        Console.WriteLine("El producto" + (x + 1) + "no tuvo ventas");
                    }

            }

           

        }
    }
}
