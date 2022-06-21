
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {

        #region classes, métodos, variáveis e operações lógicas
        /*
        public string Nome = "Boladão";
        public int Idade = 32;
        public bool eHomem = true;

        public string RetornaStringNome(string nome) // Método 1
        public string Nome = "Maria";
        public int Idade = 32;
        public bool eHomem = true;


        public string RetornaStringNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return "O nome não foi informado";
            }
            else if (!string.IsNullOrEmpty(nome) && nome.Equals("Boladão"))
            {
                return "Boladão é o seu nome";
            }
            else if (!string.IsNullOrEmpty(nome) && nome.Equals("Jão") || nome.Equals("João"))
            {
                return "João é o seu nome";
            }
            else
            {
                return "Nome informado é diferente de Boladão e João";
            }

        } // FIM DO MÉTODO 1

        public string RetornaStringGenero(bool genero) // Método 2
        {
            if (genero == true)
            {
                return "O genero é Masculino";
            }
            else
            {
                return "O genero é Feminino";
            }

        } // FIM DO MÉTODO 2


        [Test] // MÉTODO DE TESTE

        } // FIM DO MÉTODO

        public string RetornaStringGenero(bool genero)
        {
            if (genero == true)
            {
                return "O genero é Masculino";
            }
            else
            {
                return "O genero é Feminino";
            }

        } // FIM DO MÉTODO


        [Test]
        public void Test1()
        {
            string recebeNome = RetornaStringNome(Nome);
            string recebeGenero = RetornaStringGenero(eHomem);

            Console.WriteLine(recebeNome);
            Console.WriteLine(recebeGenero);
        } // FIM DO MÉTODO DE TESTE

        */
        #endregion


        [Test] // MÉTODO DE TESTE
        public void Test1()
        {
            int index = 0;

            // 1º Exemplo é com array

            string[] nomes = { "Boladão", "João", "Maria", "Pablo" };
            while(index < nomes.Length)
            {
                Console.WriteLine("Imprimindo nomes pelo WHILE: " + nomes[index]);
                index++;
            }

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Imprimindo nomes pelo FOR: " + nomes[i]);
            }

            foreach (var nome in nomes)
            {
                Console.WriteLine("Imprimindo nomes pelo FOREACH: " + nome);
            }

            // 2º Exemplo é com List
            List<int> list = new List<int>();

            index = 1;


            while (index <=10)
            {
                list.Add(index);
                Console.WriteLine($"Adicionando o número inteiro: '{index}' na list");
                index++;
            }

            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine("Imprimindo o número da list pelo FOR: " + list[i]);
            }

            foreach (var numero in list)
            {
                Console.WriteLine("Imprimindo os números inteiros da list pelo FOREACH: " + numero);
            }

        } // FIM DO MÉTODO DE TESTE

    } // FIM DA CLASSE
} // FIM DA NAMESPACE
