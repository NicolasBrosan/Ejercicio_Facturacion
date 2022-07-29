using EjercicioDePOO_Nico;

Cliente primerCliente = new Cliente(35674444, "Juan Torrez", 01);

Producto selectProducto = new Producto("Musculosa", 04, 1300);
Producto selectProducto2 = new Producto("Remeras", 02, 1000);
Producto selectProducto3 = new Producto("Buzo", 03, 1500);
Producto selectProducto4 = new Producto("Remeras largas", 05, 1100);
Producto selectProducto5 = new Producto("Jean", 01, 2000);

var detalleFact1 = new DetalleFactura(2, selectProducto);
var detalleFact2 = new DetalleFactura(3, selectProducto2);
var detalleFact3 = new DetalleFactura(2, selectProducto3);
var detalleFact4 = new DetalleFactura(1, selectProducto4);
var detalleFact5 = new DetalleFactura(4, selectProducto5);

var detalleFact = new List<DetalleFactura>();
detalleFact.Add(detalleFact1);
detalleFact.Add(detalleFact2);
detalleFact.Add(detalleFact3);
detalleFact.Add(detalleFact4);
detalleFact.Add(detalleFact5);

var factA = new FacturaA();
factA.Detalles= detalleFact;
factA.Cliente = primerCliente;

Console.WriteLine($"La cantidad de items es: {factA.CantidadItems()}");
Console.WriteLine($"El total a facturar es: ${factA.Total()}");

Console.ReadLine();