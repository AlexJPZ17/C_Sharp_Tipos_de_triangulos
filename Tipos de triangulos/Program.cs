using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_de_triangulos
{
    class Program
    {
        public class TiposTriangulos
        {
            private int lado1, lado2, lado3;
            //Método que muestra los mensajes y obtiene los datos ingresados
            public void Inicializar()
            {
                Console.WriteLine("Introduzca los lados del triángulo");
                Console.WriteLine("Medida del lado 1");
                lado1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Medida del lado 2");
                lado2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Medida del lado 3");
                lado3 = Convert.ToInt32(Console.ReadLine());
            }
            //Método que busca el lado mayor de los tres lados del triangulo
            public void LadoMayor()
            {
                if (lado1 > lado2 && lado1 > lado3)
                {
                    Console.WriteLine("El lado mayor es: " + lado1);
                }
                else
                {
                    if (lado2 > lado3)
                    {
                        Console.WriteLine("El lado mayor es: " + lado2);
                    }
                    else
                    {
                        Console.WriteLine("El lado mayor es: " + lado3);
                    }
                }
            }
            //Método que busca los tipos de triángulos de acuerdo a los tipos de medidas ingresados
            public void Triangulos()
            {
                //Condiciones que evalúan el tipo de triángulo de acuerdo a los lados ingresados
                if (lado1 == lado2 && lado1 == lado3)
                    Console.WriteLine("El triángulo es equilatero");
                if(lado1 ==lado2 && lado1 != lado3 ||lado2 ==lado3 && lado2 != lado1 || lado3 == lado1 && lado3 != lado2)
                    Console.WriteLine("El triángulo es isósceles");
                if(lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                    Console.WriteLine("El triángulo es escaleno");
            }
        }
        static void Main(string[] args)
        {
            int repetir = 0;
            //instrucción do while
            do
            {
                //Mandamos a llamar a la clase TiposTriangulos
                TiposTriangulos triangulo = new TiposTriangulos();
                triangulo.Inicializar();
                triangulo.LadoMayor();
                triangulo.Triangulos();
                Console.WriteLine("Desea repetir el procedimiento coloque 1 = si o 2 = no");
                repetir = Convert.ToInt32(Console.ReadLine());
            }while(repetir == 1);
        }
    }
}
