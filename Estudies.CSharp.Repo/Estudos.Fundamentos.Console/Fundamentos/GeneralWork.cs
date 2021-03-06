using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Fundamentos.Console.Fundamentos
{
    internal class GeneralWork
    {
        
        public GeneralWork()
        {

        }

        public void Geral()
        {
            string nome = "Geronimo";
            string sobrenome = "Olanda";
            string nomeCompleto = nome + sobrenome;

            char sexo = 'M';

            int idade = 24;
            int diaNascimento = 02;
            int mesNascimento = 02;
            int anoNasciment = 1998;

            string dataCompletaNascimento = diaNascimento + "/" + mesNascimento + "/" + anoNasciment;

            var verificaSexo = (sexo == 'M') ? "Masculino" : "Feminino";

            System.Console.WriteLine($"Meu nome é {nome} e meu sobrenome {sobrenome}.");
            System.Console.WriteLine($"Os dois juntos formam {nomeCompleto}.");
            System.Console.WriteLine("Meu sexo é " + verificaSexo + "E minha idade é " + idade);
            System.Console.WriteLine("E minha data de nascimento é " + dataCompletaNascimento);
        }

        public void ManuseioDeStrings()
        {
            string message = "I Love cake, but i don't know how to cook, i would like to learn someday.";
            string[] elementos = { "Bolo", "Bolacha" };
            //manipulando string
            var makeClone = message.Clone();
            var verifyContains = message.Contains("Love"); //caso contenha retorna true, caso não, false
            var endWith = message.EndsWith("someday."); // verifica se termina com o que desejamos
            var hash = message.GetType(); // pega o tipo a variavel
            var lower = message.ToLower(); // coloca em minusculo
            var upper = message.ToUpper(); // coloca em maiusculo
            var length = message.Length; // tamanho total da string
            var insert = message.Insert(0, "We"); //insere aonde desejamos
            var remove = message.Remove(0, 2).ToString(); // remove aonde desejamos
            var replace = message.Replace("I", "We");
            var splited = message.Split(' ');
            var trim = message.Trim();

            //condições 
            var conditionContains = (verifyContains) ? "Contem a palavra Amor em ingles" : "Não contem a palavra amor";

            foreach (var split in splited)
            {
                System.Console.WriteLine(split);
            }

            //saida
            System.Console.WriteLine(makeClone);
            System.Console.WriteLine(conditionContains);
            System.Console.WriteLine(endWith);
            System.Console.WriteLine(hash);
            System.Console.WriteLine(lower);
            System.Console.WriteLine(upper);
            System.Console.WriteLine(length);
            System.Console.WriteLine(insert);
            System.Console.WriteLine(remove);
            System.Console.WriteLine(replace);
            System.Console.WriteLine(splited);
            System.Console.WriteLine(trim);

        }
        public void switchMethod()
        {
            var dataAtual = DateTime.Now.ToString("dd/MM/yyyy");

            switch (dataAtual)
            {
                case "28/06/2022":
                    System.Console.WriteLine("Acertou talvez?");
                    break;

                case "29/06/2022":
                    System.Console.WriteLine("Acertou talvez?");
                    break;

                case "30/06/2022":
                    System.Console.WriteLine("Acertou talvez?");
                    break;

                default:
                    System.Console.WriteLine("Padraozao");
                    break;
            }


        }

        public void methodLoop()
        {
            string primeiroNome = "Thalia";
            string segundoNome = "Geronimo";

            int idade1 = 24;
            int idade2 = 24;

            double altura1 = 1.86;
            double altura2 = 1.67;

            char sexo = 'F';


            var tamanho = primeiroNome.Length;
            var i = 0;

            ArrayList list = new ArrayList();
            list.Add("Thalia meu amor");
            list.Add("Thalia sua mulher incrivel");
            list.Add("Eu amo minha profissão!");
            list.Add("Eu te amo Jesus Cristo!");

            while (i < tamanho)
            {
                System.Console.WriteLine("Eu te amo meu amor!");
                i++;
            }

            for (i = 0; i < 100; i++)
            {
                System.Console.WriteLine("Jesus Eu te Amo!");
            }

            do
            {
                System.Console.WriteLine("Funfou");
                i++;
            } while (i < 3);

            foreach (var lista in list)
            {
                System.Console.WriteLine(lista);
            }
        }

    }
}
