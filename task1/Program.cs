using System.Globalization;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Price per small room: $25 ");
            Console.WriteLine("Price per large room: $35 ");


            Console.WriteLine("Number of small carpets: ");
            int smallCarpets = Convert.ToInt32(Console.ReadLine());
            int totalSmallCarperts = smallCarpets * 25;
            Console.WriteLine("Number of large carpets: ");
            int largCarpets = Convert.ToInt32(Console.ReadLine());
            int totalLargCarperts = largCarpets * 35;

            int cost = totalLargCarperts + totalSmallCarperts;
            Console.WriteLine($"Cost : {cost}");
            Console.WriteLine("Tax: $6.6");

            //double costAferTax = cost + (cost * (6.6/100));
            double costAferTax = cost + 6.6 * 100 / 100;
            //double costAferTax = cost + 6.6%;

            double value = costAferTax;
            
            Console.WriteLine("Total estimate :  " + value.ToString("C", new CultureInfo("en-US")));

            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
