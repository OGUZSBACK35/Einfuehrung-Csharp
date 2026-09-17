using System;

Console.WriteLine("Lütfen Adinizi Giriniz:"); 
var name = Console.ReadLine();

Console.WriteLine("Merhaba " + name + ".");
Console.WriteLine(name.GetType());
Console.ReadKey();