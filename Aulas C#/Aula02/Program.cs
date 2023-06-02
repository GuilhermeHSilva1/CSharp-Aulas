using System;

class Principal{
    static void Main(string[] args){
        Console.Write("Olá Mundo...");

        if (args.GetLength(0) > 0){
            Console.WriteLine(args.GetValue(0));
        }
        Console.ReadLine();
    }
}