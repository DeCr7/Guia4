using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] rangoSalarios = new int[9];
        int numVendedores;
        int ventas;
        double salario;

        Console.Write("Digite la cantidad de vendedores: ");
        numVendedores = int.Parse(Console.ReadLine());

        for (int i = 0; i < numVendedores; i++)
        {
            ventas = 0;
            salario = 0;
            Console.Write("Digite las ventas del Vendedor #" + (i+1) + ": ");
            ventas = int.Parse(Console.ReadLine());

            salario = (ventas * 0.09) + 200;

            if (salario >= 200 && salario <= 299)
            {
                rangoSalarios[0]++;
            }
            else if (salario >= 300 && salario <= 399)
            {
                rangoSalarios[1]++;
            }
            else if (salario >= 400 && salario <= 499)
            {
                rangoSalarios[2]++;
            }
            else if (salario >= 500 && salario <= 599)
            {
                rangoSalarios[3]++;
            }
            else if (salario >= 600 && salario <= 699)
            {
                rangoSalarios[4]++;
            }
            else if (salario >= 700 && salario <= 799)
            {
                rangoSalarios[5]++;
            }
            else if (salario >= 800 && salario <= 899)
            {
                rangoSalarios[6]++;
            }
            else if (salario >= 900 && salario <= 999)
            {
                rangoSalarios[7]++;
            }
            else if (salario >= 1000)
            {
                rangoSalarios[8]++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Salarios por rango:");
        Console.WriteLine("$200-$299: " + rangoSalarios[0]);
        Console.WriteLine("$300-$399: " + rangoSalarios[1]);
        Console.WriteLine("$400-$499: " + rangoSalarios[2]);
        Console.WriteLine("$500-$599: " + rangoSalarios[3]);
        Console.WriteLine("$600-$699: " + rangoSalarios[4]);
        Console.WriteLine("$700-$799: " + rangoSalarios[5]);
        Console.WriteLine("$800-$899: " + rangoSalarios[6]);
        Console.WriteLine("$900-$999: " + rangoSalarios[7]);
        Console.WriteLine("$1000 o superior: " + rangoSalarios[8]);
    }
}