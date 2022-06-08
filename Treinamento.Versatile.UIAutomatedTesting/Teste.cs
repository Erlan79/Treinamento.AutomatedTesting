
using NUnit.Framework;
using System;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
         // Variável do tipo CHAR
        char InicialNomeDoMeio = 'A';
        object CharObject = 'A';

        // Variável do tipo STRING (Coleção de caracteres)
        string Nome = "Boladão";
        object StringObj = "String Obj";

        // Variável do tipo INT
        int Idade = 32;
        object IntObj = 1;

        // variável do tipo Boolean
        bool EHomem = true;
        object boolObj = false;

  
        [Test]
        public void Test1()
        {
            // As variáveis do tipo 'var' e 'object' são variáveis coringa que podem receber qualquer tipo de valor
            string nomeString = "Boladão String";
            var nomeVar = "Boladão Var";
            object nomeObj = "Boladão Object";

            int numeroInt = 1;
            var numeroVar = 2;
            object numeroObj = 3;

            bool eHomem = true;
            var eMulher = false;
            object eObj = true;

            Console.WriteLine($"Olá! meu nome é {Nome} e tenho {Idade} anos! Sou homem {EHomem}");
        }

    }
}
