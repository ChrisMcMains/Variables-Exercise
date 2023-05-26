using System;
using System.Net.Cache;

string name = "Chris";
int age = 38;
char middleInitial = 'S';
bool isMarried = true;
double currentTemp = 78.4;
decimal currentPrice = 3.79m;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Middle Initial: {middleInitial}");
Console.WriteLine($"Married?: {isMarried}");
Console.WriteLine($"Temp: {currentTemp}");
Console.WriteLine($"Price: {currentPrice}");

Console.WriteLine($"My name is {name} and I am {age} years old.  The current temperature is {currentTemp} and gas cost {currentPrice}");