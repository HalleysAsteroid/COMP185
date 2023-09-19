
using System.Globalization;

Console.WriteLine("Hello, World!");

double price = 18;
const double SALES_TAX = 6.234;

double total = price * (1 + (SALES_TAX / 100));
Console.WriteLine("Your subtotal is {0}, and your total is {1}.", price.ToString("C"), total.ToString("C"));

double five = 32_______________________________73;
Console.WriteLine(five);