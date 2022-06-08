
using NUnit.Framework;
using System;

namespace Treinamento.Versatile.UIAutomatedTesting
{
    public class Teste
    {
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
        } // FIM DO MÉTODO

    } // FIM DA CLASSE
} // FIM DA NAMESPACE

