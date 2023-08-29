// See https://aka.ms/new-console-template for more information

//Un restaurante ofrece un descuento del 10% para consumos de hasta $100.00 y un descuento de 20% para consumos mayores de $100.00,
//para ambos casos se aplica un impuesto del 18% 
//Determine el monto del descuento, el impuesto, el sub total y el importe a pagar. 

Console.WriteLine("Ingresar el monto de los consumos");
double Consumos = Convert.ToDouble(Console.ReadLine());

double Dsctmenor = 0.10;
double DsctMayor = 0.20;
double Impuesto = 0.18;

double descuento = 0;
double impuesto = 0;

if (Consumos <= 100.00) 
{
    descuento = Consumos * Dsctmenor;
}
else 
{
    descuento = Consumos * DsctMayor;
}

impuesto = (Consumos - descuento) * Impuesto;
double subtotal = Consumos - descuento;
double ImportePagar = subtotal + impuesto;

Console.WriteLine("Monto de descuento: " + descuento);
Console.WriteLine("Impuesto: " + impuesto);
Console.WriteLine("Subtotal " + subtotal);
Console.WriteLine("Importe a pagar: " + ImportePagar);
