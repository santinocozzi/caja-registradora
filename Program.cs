const string NombreKiosco = "KIOSCO EL RECREO";
Console.WriteLine($"=== {NombreKiosco} ===");
Console.Write("Nombre del cajero: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Bienvenido/a, {nombre}. Caja abierta.");

Console.WriteLine();

decimal sumaPrecios = 0m;
int cantidadProductos = 0;
string opcion;

do
{
    Console.WriteLine("¿Que desea hacer?:");
    Console.WriteLine("1- Cargar un producto ");
    Console.WriteLine("2- Cerrar la venta");
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Nombre del producto: ");
            string producto = Console.ReadLine();
            Console.Write("Precio del producto: ");
            decimal precio = decimal.Parse(Console.ReadLine());
            sumaPrecios += precio;
            cantidadProductos++;
            Console.WriteLine();
            break;
        case "2":
            Console.WriteLine("Cerrando la caja...");
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Opción invalida. Intente nuevamente.");
            Console.WriteLine();
            break;
    }
} while (opcion != "2");

const decimal descuentoMayor = 0.10m;
const decimal descuentoMenor = 0.05m;

decimal descuento = 0m;

if (sumaPrecios > 50000)
{
    descuento = sumaPrecios * descuentoMayor;
}
else if (sumaPrecios > 20000)
{
    descuento = sumaPrecios * descuentoMenor;
}
else
{
    descuento = 0m;
}

decimal precioFinal = sumaPrecios - descuento;

string medioPago;
decimal descuentoEfectivo = 0m;
decimal recargoCredito = 0m;

const decimal DescuentoEfectivo = 0.10m;
const decimal RecargoCredito = 0.15m;

do
{
   Console.WriteLine("Medio de pago:"); 
   Console.WriteLine("1 - Efectivo");
   Console.WriteLine("2 - Débito");
   Console.WriteLine("3 - Credito");
   medioPago = Console.ReadLine();
   
   switch (medioPago)
   {
     case "1":
         descuentoEfectivo = precioFinal * DescuentoEfectivo;
         Console.WriteLine($"Descuento efectivo aplicado ({descuentoEfectivo}).");
         Console.WriteLine();
         break;
     case "2":
         Console.WriteLine("Pago con debito. Sin ajustes");
         Console.WriteLine();
         break;
         
     case "3":
         recargoCredito = precioFinal * RecargoCredito;
         Console.WriteLine($"Recargo de credito aplicado ({recargoCredito}).");
         Console.WriteLine();
         break;
         
     default:
         Console.WriteLine("Medio de pago invalido. Intente nuevamente");
         Console.WriteLine();
         break;
   }
} while (medioPago != "1" && medioPago != "2" && medioPago != "3");

precioFinal -= descuentoEfectivo;
precioFinal += recargoCredito;

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"{NombreKiosco}");
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"Cajero: {nombre}");
Console.WriteLine($"Productos cargados: {cantidadProductos}");
Console.WriteLine($"Subtotal: {sumaPrecios}");
Console.WriteLine($"Descuento: {descuento + descuentoEfectivo}");
Console.WriteLine($"Recargo: {recargoCredito}");

for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}
Console.WriteLine();
Console.WriteLine($"Precio total: {precioFinal}");
for (int i = 0; i < 30; i++)
{
    Console.Write("-");
}

Console.ReadLine();

