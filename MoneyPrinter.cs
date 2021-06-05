using System;

namespace ModTestProd
{
    public class MoneyPrinter
    {
        public void print(string operation, string course, string amount)
        {
            Console.WriteLine("# - " + operation + " - валюта: " + course + ", в количестве: " + amount);
        }
    }
}
