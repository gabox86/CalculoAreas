using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace appCalculoAreas
{
    class Program
    {
        // Método Main de programa
        static void Main(string[] args)
        {
            Menu();
        }

        // Menu principal de la app
        private static void Menu()
        {
            int opcion_menu;

            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Menu Calcular Areas");
                    Console.WriteLine("1. Área Rectágulo");
                    Console.WriteLine("2. Área Cuadrado");
                    Console.WriteLine("3. Área Círculo");
                    Console.WriteLine("4. Área Triángulo");
                    Console.WriteLine("5. Salir");

                    opcion_menu = int.Parse(Console.ReadLine());

                    switch (opcion_menu)
                    {
                        case 1:
                            AreaRectangulo();
                            break;
                        case 2:
                            AreaCuadrado();
                            break;
                        case 3:
                            AreaCirculo();
                            break;
                        case 4:
                            AreaTriangulo();
                            break;
                        default:
                            break;
                    }
                } while (opcion_menu < 5);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        // Método que calcula el area de un rectangulo
        public static void AreaRectangulo()
        {
            int area_rectagulo = 0;
            int base_rectangulo = 0;
            int altura_rectangulo = 0;

            try
            {
                Console.Clear();
                Console.WriteLine("Digite la base del rectágulo");
                base_rectangulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la altura del rectágulo");
                altura_rectangulo = int.Parse(Console.ReadLine());

                area_rectagulo = base_rectangulo * altura_rectangulo;

                Console.WriteLine("El área del rectágulo es: " + area_rectagulo);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        // Método que calcula el area de un cuadrado
        public static void AreaCuadrado()
        {
            int area_cuadrado = 0;
            int lado_cuadrado = 0;

            try
            {
                Console.Clear();
                Console.WriteLine("Digite el lado del cuadrado");
                lado_cuadrado = int.Parse(Console.ReadLine());

                area_cuadrado = lado_cuadrado * lado_cuadrado;

                Console.WriteLine("El área del cuadrado es: " + area_cuadrado);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        // Método que calcula el area de un circulo
        public static void AreaCirculo()
        {
            double radioCirculo = 0;
            double areaCirculo = 0;

            try
            {
                Console.Clear();
                Console.WriteLine("Digite el radio del círculo");
                radioCirculo = double.Parse(Console.ReadLine());

                areaCirculo = Math.PI * Math.Pow(radioCirculo,2);

                Console.WriteLine("El área del circulo es: " + areaCirculo);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }

        // Método que calcula el area de un tringulo
        public static void AreaTriangulo()
        {
            int area_triangulo = 0;
            int base_triangulo = 0;
            int altura_triangulo = 0;

            try
            {
                Console.Clear();
                Console.WriteLine("Digite la base del triángulo");
                base_triangulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite la altura del triángulo");
                altura_triangulo = int.Parse(Console.ReadLine());

                area_triangulo = (base_triangulo * altura_triangulo) / 2;

                Console.WriteLine("El área del triángulo es: " + altura_triangulo);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }

        }
    }
}