
            Console.Write("Ingrese el monto del consumo: ");
            double montoConsumo = double.Parse(Console.ReadLine());

            double descuento, impuesto, subtotal, total;

            if (montoConsumo <= 100.00)
            {
                descuento = montoConsumo * 0.10;
            }
            else
            {
                descuento = montoConsumo * 0.20;
            }

            impuesto = montoConsumo * 0.18;
            subtotal = montoConsumo - descuento;
            total = subtotal + impuesto;

            Console.WriteLine($"Monto del descuento: S/ {descuento:F2}");
            Console.WriteLine($"Impuesto: S/ {impuesto:F2}");
            Console.WriteLine($"Subtotal: S/ {subtotal:F2}");
            Console.WriteLine($"Importe a pagar: S/ {total:F2}");
        
    

