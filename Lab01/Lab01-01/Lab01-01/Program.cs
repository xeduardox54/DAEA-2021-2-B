using System;

namespace Lab01_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir de Fahrenheit a Celsius");
                Console.WriteLine("[8] Convertir de Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", a, b, Multiplicar(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", a, b, Dividir(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la cantidad de grados Farenheit");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Farenheit son {1} grados Celsius", a, ConvertirCelsius(a));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la cantidad de grados Celsius");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Celsius son {1} grados Farenheit", a, ConvertirFarenheit(a));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));

        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Función para multiplicar 2 números enteros
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la división de 2 números enteros
        static int Dividir(int a, int b)
        {
            return a / b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Procedimiento que imprime 10 primeros números primos
        static void Primos()
        {
            int contador_primos = 0;
            int cont = 2;
            while (true)
            {
                if (EsPrimo(cont))
                {
                    Console.WriteLine("El número: {0} es primo.", cont);
                    contador_primos++;
                }
                if (contador_primos == 10) break;
                cont++;
            }
        }
        //Procedimiento para comprobar que un número es primo
        static bool EsPrimo(int num)
        {
            int multiplos = 0;
            for (int cont = 1; cont <= num; cont++)
            {
                if (num % cont == 0) multiplos++;
                if (multiplos >= 3) return false;
            }
            return true;
        }

        //Procedimiento para convertir grados Farenheit a Celsius
        static int ConvertirCelsius(int grados)
        {
            return (((grados - 32) * 5) / 9);
        }

        //Procedimiento para convertir grados Celsius a Farenheit
        static int ConvertirFarenheit(int grados)
        {
            return (((grados*9)/5)+32);
        }

    }
}
