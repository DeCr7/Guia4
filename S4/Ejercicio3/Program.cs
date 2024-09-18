using System;
    public class Program
    {
    public static void Main(string[] args)
    {
        int op1;
        int op2;
        int[,] ventas = new int[5, 4];
        int[] totalesVendedor = new int[4];
        int[] totalesProductos = new int[5];

        do
        {
            Console.Clear();
            Console.WriteLine("(Digite 0 para cerrar el programa)");
            Console.WriteLine("(Digite 10 para mostrar las ventas totales)");
            Console.WriteLine();
            Console.Write("Digite el vendedor (1, 2, 3, 4): ");
            op1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el producto (1, 2, 3, 4, 5): ");
            op2 = int.Parse(Console.ReadLine());

            if ((op1 >= 1 && op1 <= 4) && (op2 >= 1 && op2 <= 5))
            {
                Console.Write("Digite el monto del producto: ");
                ventas[op2-1,op1-1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Monto guardado exitosamente");
                Console.ReadKey();
            }
            else if (op1 == 0 || op2 == 0)
            {
                Console.WriteLine("¡Adiós!");
            }
            else if (op1 == 10 || op2 == 10)
            {
                Console.WriteLine();
                Console.WriteLine("Productos\tVendedor #1\tVendedor #2\tVendedor #3\tVendedor #4\tTotales");
                for (int i = 0; i < 5; i++)
                {
                    int totalProducto = 0;

                    Console.Write("Producto " + (i + 1) + "\t");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(ventas[i, j] + "\t\t");
                        totalProducto += ventas[i, j];
                    }

                    totalesProductos[i] = totalProducto;
                    Console.Write(totalProducto);
                    Console.WriteLine();
                }
                Console.Write("Totales\t\t");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(totalesVendedor[j] + "\t\t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Opciones fuera de rango");
            }

            for (int j = 0; j < 4; j++)
            {
                totalesVendedor[j] = 0;
                for (int i = 0; i < 5; i++) 
                {
                    totalesVendedor[j] += ventas[i, j];
                }
            }

        }
        while (op1 != 0 && op2 != 0);
    }
    }