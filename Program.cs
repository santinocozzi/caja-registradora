const string NombreKiosco = "KIOSCO EL RECREO";
Console.WriteLine($"=== {NombreKiosco} ===");
Console.Write("Nombre del cajero: ");
string nombre = Console.ReadLine();
Console.WriteLine($"Bienvenido/a, {nombre}. Caja abierta.");

Console.WriteLine();

Console.Write("Escribrí el producto: ");
string producto = Console.ReadLine();
Console.Write("Precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Se cargó el producto {producto} al precio {precio}.");

Console.ReadLine();