using System;
    public class Program
    {
        public static void Main(string[] args)
        {
        Random rand = new Random();
        int[] Sumas = new int[11];

        int num1;
        int num2;
        int suma;

        for (int i = 0; i < 36000; i++)
        {
            num1 = 0;
            num2 = 0;
            suma = 0;

            num1 = rand.Next(1, 7);
            num2 = rand.Next(1, 7);
            suma = num1 + num2;

            Sumas[suma - 2]++;
        }

        Console.WriteLine("Sumas\tFrecuencia");
        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine((i + 2) + "\t" + Sumas[i]);
        }
    }
    }