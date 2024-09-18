using System;
    public class Program
    {
        public static void Main(string[] args)
        {
        int[] Asientos = new int[10];
        int asientoSolicitado;
        int limite;
        int op;

        Console.WriteLine("Please type 1 for 'smoking'");
        Console.WriteLine("Please type 2 for 'nonsmoking'");
        asientoSolicitado = int.Parse(Console.ReadLine());

        switch (asientoSolicitado)
        {
            case 1:
                limite = 0;

                for (int i = 0; i < 5; i++)
                {
                    if (Asientos[i] == 0)
                    {
                        Asientos[i] = 1;
                        Console.WriteLine("Asiento asignado exitosamente");
                        break;
                    }
                    else
                    {
                        limite++;
                    }

                    if (limite==5)
                    {
                        op = 0;
                        Console.WriteLine("Todos los asientos están ocupados, ¿Desea pasar a la clase nonsmoking?");
                        Console.WriteLine("Marque '1' para aceptar, '2' para rechazar");
                        op = int.Parse(Console.ReadLine());

                        if (op == 1)
                        {
                            limite = 0;
                            for (int j = 5; j < 10; j++)
                            {
                                if (Asientos[j] == 0)
                                {
                                    Console.WriteLine("Asiento asignado exitosamente.");
                                    break;
                                }
                                else
                                {
                                    limite++;
                                }
                            }

                            if (limite == 5)
                            {
                                Console.WriteLine("Ambas secciones está llenas.");
                            }
                            break;

                        }
                        else if (op == 2)
                        {
                            Console.WriteLine("Next flight leaves in 3 hours");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción no Válida");
                            break;
                        }
                    }
                }
                break;

            case 2:
                limite = 0;
                for (int i = 5; i < 10; i++)
                {
                    if (Asientos[i] == 0)
                    {
                        Asientos[i] = 1;
                        Console.WriteLine("Asiento asignado exitosamente");
                        break;
                    }
                    else
                    {
                        limite++;
                    }

                    if (limite == 5)
                    {
                        op = 0;
                        Console.WriteLine("Todos los asientos están ocupados, ¿Desea pasar a la clase smoking?");
                        Console.WriteLine("Marque '1' para aceptar, '2' para rechazar");
                        op = int.Parse(Console.ReadLine());

                        if (op == 1)
                        {
                            limite = 0;
                            for (int j = 0; j < 5; j++)
                            {
                                if (Asientos[j] == 0)
                                {
                                    Console.WriteLine("Asiento asignado exitosamente.");
                                    break;
                                }
                                else
                                {
                                    limite++;
                                }
                            }

                            if (limite == 5)
                            {
                                Console.WriteLine("Ambas secciones está llenas.");
                            }
                            break;
                        }
                        else if (op == 2)
                        {
                            Console.WriteLine("Next flight leaves in 3 hours");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Opción no Válida");
                            break;
                        }
                    }
                }
                break;

            default:
                Console.WriteLine("Opción Inválida");
                break;
        }
    }
    }