// =====================
// 1. Variables y Tipos
// =====================

// a) Declarar una variable con el nombre de una empresa y mostrarla por consola.
using System.Runtime.CompilerServices;

string nombreEmpresa = "Austral";
Console.WriteLine(nombreEmpresa);

// b) Declarar una variable con la cantidad de empleados y mostrarla por consola.
int cantEmpleados = 256;
Console.WriteLine(cantEmpleados);

// c) Declarar una variable decimal con el ingreso mensual estimado.
double ingresoEstimado = 987567.87;
Console.WriteLine(ingresoEstimado);

// d) Mostrar por consola un mensaje que diga el nombre de la empresa, cantidad e empleados e ingreso.
Console.WriteLine($"En la empresa {nombreEmpresa} hay actualmente {cantEmpleados} con un ingreso estimado de ${ingresoEstimado}.");

// ==============
// 2. Operadores
// ==============

// a) Declarar dos precios de productos y calcular el total de los dos con IVA.
double precioProd1 = 12.34;
float precioProd2 = 45.78f;
double  montoIVA = 0.21;

double totalConIva = (precioProd1 + precioProd2) * (1 + montoIVA);
Console.WriteLine($"El monto total de los dos productos incluyendo IVA es {totalConIva}");

// b) En base a la siguiente variable -> int ingresoAnual = 1500;
//    Hacer otra variable que represente el ingreso mensual y mostrarla por consola.
int ingresoAnual = 1500;
int cantMeses = 12;

double ingresoMensual = ingresoAnual / cantMeses;
Console.WriteLine($"El ingreso mensual es de ${ingresoMensual}");

// c) Crear una variable que represente si el ingreso anual es mayor a 1000 o no.
bool ingresoMayor1000 = ingresoAnual > 1000;
Console.WriteLine($"Ingreso anual mayor a 1000?: {ingresoMayor1000}");


// d) Calcular cuánto gana una empresa por mes si su ingreso anual es 1500
//    y tiene que pagar 12% de impuestos al estado.
int ingresoEmpresa = 1500;
double impuestos = 0.12;

double gananciaEmpresa = ingresoEmpresa - ingresoEmpresa* impuestos;
double gananciaMensualEmpresa = gananciaEmpresa / cantMeses;
Console.WriteLine($"Una empresa con un ingreso de $1500, luego de haber pagado los impuestos (12%) obtiene una ganancia de ${gananciaMensualEmpresa}. El monto de impuestos a pagar será");


// ==========================
// 3. Estructuras de Control
// ==========================

// a) En base a la cantidad de empleados de una empresa, mostrar por consola el tamaño de la misma:
//     - Si tiene 10 o menos empleados → "Startup"
//     - Si tiene Entre 11 y 50 → "Pyme"
//     - Si tiene más de 50 → "Big"

int numeroEmpleados = 34;
Console.WriteLine($"La empresa cuenta con {numeroEmpleados} empleados");

if(numeroEmpleados <= 10)
{
    Console.WriteLine("Startup");
}
else if (numeroEmpleados <= 50)
{
    Console.WriteLine("Pyme");
}
else
{
    Console.WriteLine("Big");
}

// b) En base al monto de inversión de una empresa, clasificar la inversión como:
//     - Si es menor a 10,000 → "Baja"
//     - Si está entre 10,000 y 100,000 → "Media"
//     - Si es mayor a 100,000 → "Alta"

double montoInversion = 50000;
Console.WriteLine($"El monto de la inversión es de ${montoInversion}");

if (montoInversion < 10000)
{
    Console.WriteLine("Se trata de una inversión baja");
}
else if (montoInversion <= 100000)
{
    Console.WriteLine("Se trata de una inversión media");
}
else
{
    Console.WriteLine("Se trata de una inversión alta");
}

// c) Según el tipo de cliente ("mayorista" o "minorista"), mostrar el precio final de un producto con descuento si corresponde:
//     - Si es mayorista → 20% de descuento
//     - Si es minorista → precio completo

string tipoCliente = "mayorista";
double precioProducto = 450.50;
double precioFinal;

if (tipoCliente == "mayorista")
{
    precioFinal = precioProducto - precioProducto * 0.2;
}
else
{
    precioFinal = precioProducto;
}

// c.2)Según el tipo de cliente ("mayorista" o "minorista"), mostrar el precio final de un producto con descuento si corresponde:
//     - Si es mayorista → 20% de descuento
//     - Si es minorista → 50% de descuento
//     - Si es cliente final → 80% de descuento

switch (tipoCliente)
{
    case "mayorista":
        Console.WriteLine("El cliente tiene 20% de descuento");
        break;
    case "minorista":
        Console.WriteLine("El cliente tiene 50% de descuento");
        break;
    case "cliente final":
        Console.WriteLine("El cliente tiene 80% de descuento");
        break;
    default:
        Console.WriteLine("Tipo de cliente no encontrado");
        break;
}

// d) Una distribuidora tiene 20 unidades de cerveza en stock. Un cliente solicita 25 unidades.
//    Verificar si hay suficiente stock para concretar la venta:
//     - Si alcanza, mostrar por consola: "Venta confirmada. Cervezas en stock suficientes."
//     - Si no alcanza, mostrar: "No hay suficientes cervezas en stock. Faltan X unidades."
//       (donde X debe calcularse dinámicamente en base a las variables)

int stockCerveza = 20;
int pedidoCerveza = 15;

if (pedidoCerveza <= stockCerveza)
{
    stockCerveza -= pedidoCerveza;
    Console.WriteLine("Venta confirmada. Cervezas en stock suficientes.");
    Console.WriteLine($"Quedan {stockCerveza} cervezas en stock");
}
else
{
    int faltanteStock = pedidoCerveza - stockCerveza;
    Console.WriteLine($"No hay suficientes cervezas en stock. Faltan {faltanteStock} unidades.");
}


// ==========
// 4. Bucles
// ==========

// a) Mostrar los primeros 10 números naturales usando un for.

// b) Dado este array que representa las ventas de una empresa:
//    int[] ventasMensuales = { 1000, 1200, 950, 1100 };
//    Sumar las ventas mensuales con un foreach y mostrar el total por consola.

// c) Hacer una cuenta regresiva del 5 al 1 con while.

// d) Simular un login: pedir usuario hasta que ingrese "admin" con do-while.


// =============
// 5. Funciones
// =============

// a) Crear una función que reciba el ingreso mensual y devuelva el anual.
//    Llamar a la función y mostrar el resultado en consola.

// b) Crear una función que reciba una edad y devuelva si es mayor o menor de edad.
//    Llamar a la función y mostrar el resultado en consola.

// c) Crear una función que reciba el precio y el tipo de cliente y devuelva el precio final con o sin descuento.
//    Llamar a la función y mostrar el resultado en consola.


// ===================
// 6. Listas y arrays
// ===================

// a) Crear un array con nombres de 3 productos y mostrarlos por consola.

// b) Crear un array con los ingresos trimestrales (double) y calcular el total anual.

// c) Mostrar el producto más vendido de un array con cantidades vendidas.

// d) Crear una lista de precios y calcular el promedio.
//    Usar List<double> para practicar con listas.
