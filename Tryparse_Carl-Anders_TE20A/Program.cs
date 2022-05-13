using System;
using System.Collections.Generic;
using Raylib_cs;


Console.WriteLine(int.MaxValue);

 Console.WriteLine("Hej spelare skriv in ett tal");
Console.WriteLine("Så att talet multipliceras med 5");

string tal = Console.ReadLine();
int resultat;

bool success = int.TryParse(tal, out resultat);

if (success == true)
{
  Console.WriteLine(resultat * 5);
}
else
{
  Console.WriteLine("bara SIFFROR");
}




Console.ReadLine();