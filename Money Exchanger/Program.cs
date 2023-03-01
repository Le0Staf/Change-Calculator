using System;

Console.WriteLine("Enter Price: ");
double price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter what you pay: ");
double payment = Convert.ToDouble(Console.ReadLine());

double moneyBack = payment - price;
Console.WriteLine("Money Back: $" + moneyBack);

Console.WriteLine("Here is your change: ");
int hundreds = 0;
int fifties = 0;
int twenties = 0;
int tens = 0;
int fives = 0;
int twos = 0;
int ones = 0;

while (moneyBack >= 100)
{
    hundreds = hundreds + 1; 
    moneyBack = moneyBack - 100;
}

while (moneyBack >= 50 && moneyBack < 100)
{
    fifties = fifties + 1;
    moneyBack = moneyBack - 50;
}

while (moneyBack >= 20 && moneyBack < 50)
{
    twenties = twenties + 1;
    moneyBack = moneyBack - 20;
}

while (moneyBack >= 10 && moneyBack < 20)
{
    tens = tens + 1;
    moneyBack = moneyBack - 10;
}

while (moneyBack >= 5 && moneyBack < 10)
{
    fives = fives + 1;
    moneyBack = moneyBack - 5;
}

while (moneyBack >= 2 && moneyBack < 5)
{
    twos = twos + 1;
    moneyBack = moneyBack - 2;
}

while (moneyBack >= 1 && moneyBack < 2)
{
    ones = ones + 1;
    moneyBack = moneyBack - 1;
}


Console.WriteLine("$100 Bills: " + hundreds);
Console.WriteLine("$50 Bills: " + fifties);
Console.WriteLine("$20 Bills: " + twenties);
Console.WriteLine("$10 Bills: " + tens);
Console.WriteLine("$5 Bills: " + fives);
Console.WriteLine("$2 Bills: " + twos);
Console.WriteLine("$1 Bills: " + ones);