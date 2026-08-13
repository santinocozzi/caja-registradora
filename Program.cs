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

Console.WriteLine($"Productos cargados: {cantidadProductos}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"Precio total: {precioFinal}");

Console.ReadLine();