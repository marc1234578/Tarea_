
            Console.WriteLine("Ingrese el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int mayor = CalcularMayor(numero1, numero2, numero3);

            Console.WriteLine($"El mayor de los tres números es: {mayor}");
        

        static int CalcularMayor(int num1, int num2, int num3)
        {
            int mayor = num1;

            if (num2 > mayor)
            {
                mayor = num2;
            }

            if (num3 > mayor)
            {
                mayor = num3;
            }

            return mayor;
        }
    

