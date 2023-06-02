using System;

class Program{

    static void Main(string[] args){
        int xNum1   = 3;
        float xNum2 = 5.5f;
        float xSoma;
        char xLetra = 'G';
        string xString = "Guilherme";
        var xTipo = "Gabriel";
        bool xInformacao = true;

        if (xInformacao){
            Console.WriteLine(String.Format("Meu nome é {0} e essa é uma String", xString));
            Console.WriteLine(String.Format("Meu irmão se chama {0} e essa é uma Var", xTipo));
            Console.WriteLine(String.Format("Ambos os nomes começa com o Char {0}", xLetra));
            Console.WriteLine(String.Format("Escolhi um numero q é {0} e outro q é {1}", xNum1, xNum2));
            xSoma = xNum1 + xNum2;
            Console.WriteLine("E a soma desses números da {0}", xSoma);
            Console.ReadLine();
        }
        else {
            Console.WriteLine("As informações são falsas :( ");
        }
        
    }
}