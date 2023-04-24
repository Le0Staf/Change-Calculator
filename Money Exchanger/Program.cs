using System;

namespace MoneyExchanger
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Price Of Product: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter what you pay: ");
            double payment = Convert.ToDouble(Console.ReadLine());
            double shortof;

            if (payment < price)
            {
                shortof = price - payment;
                Console.WriteLine("Here is your change: $" + shortof);
                Console.WriteLine("Add money: ");
                payment = payment + Convert.ToDouble(Console.ReadLine());
            }

            double moneyBack = payment - price;
            Console.WriteLine("Money Back: $" + moneyBack);

            Console.WriteLine("Here is your change: ");

            //Calculate
            int[] bills = { 100, 50, 20, 10, 5, 2, 1 };
            int[] counts = new int[7];

            for (int i = 0; i < bills.Length; i++)
            {
                counts[i] = (int)moneyBack / bills[i];
                moneyBack %= bills[i];
            }

            //Output Change
            for (int i = 0; i < bills.Length; i++)
            {
                Console.WriteLine("$" + bills[i] + " Bills: " + counts[i]);
            }
        }
    }
}

