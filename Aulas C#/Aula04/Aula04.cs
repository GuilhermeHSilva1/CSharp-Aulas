using System;

class Program{

    enum EDiaSemana{Segunda, Terça, Quarta, Quinta, Sexta, Sabado, Domingo};
    enum EDinheiro{
        Nota1 = 100, 
        Nota2= 50, 
        Nota3 = 20, 
        Nota4 = 10,
        Nota5 = 5,
        Nota6 =  2};
    static void Main(){

        // FOR executa o bloco correspondente enquanto uma expressão booliana especificada é avaliada como true
        // FOREACH enumera os elementos de uma coleção e executa o bloco correspondente para cada elemento dessa coleção

        foreach (var xItem in Enum.GetNames(typeof(EDiaSemana))){
            Console.WriteLine(xItem);
        }

        Console.WriteLine("\nNOTAS\n");

        foreach(int xNota in Enum.GetValues(typeof(EDinheiro))){
            Console.WriteLine("Nota de: " + xNota);
        }
    }
}