using System;
using System.Collections.Generic;

namespace TrabalhandoComArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> caes = new List<string>();


            Console.WriteLine("Escreva quantas raças de caes vc quer ");
            int quantdraçasdecaes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes das raças");


            for (int i = 0; i < quantdraçasdecaes; i++)
            {
                caes.Add(Console.ReadLine());
            }


            Console.WriteLine("AS raças escolhidas foram " + quantdraçasdecaes);


            for (int i = 0; i < caes.Count; i++)
            {
                Console.WriteLine(caes[i]);
            }



            List<string> nomes = new List<string>();

            Console.WriteLine("Digite quantos nomes vc quer adicionar");
            int qtdNomes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("informe os nomes");

            for (int i = 0; i < qtdNomes; i++)
            {
                nomes.Add(Console.ReadLine());
            }

            Console.ReadLine();


            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.ReadLine();

            string[] fruta = new[] { "ford", "Pera", "sao paulo" };
            int[] numerosDaSorte = new[] { 4, 8, 78 };

            //Arrays de 10 cidades e mostrar com o Console.writeLine somente a sétima cidade

            string[] cidade = new[] { "Leme", "Limeira", "Baurú", "Pirassununga", "Natal", "São Paulo", "Ribeirão", "Fortaleza", "Paulinea", "Aparecida" };

            for (int i = 0; i < cidade.Length; i++)
            {
                Console.WriteLine(cidade[i]);

            }


            Console.WriteLine("  ");
            Console.WriteLine("A sétima cidade é " + cidade[6]);


            Console.WriteLine(fruta[0]);
            Console.WriteLine(fruta[1]);
            Console.WriteLine(fruta[2]);


            Console.WriteLine(numerosDaSorte[1]);

            for (int i = 0; i < fruta.Length; i++)
            {
                Console.WriteLine(fruta[i]);
            }


            for (int i = 0; i < numerosDaSorte.Length; i++)
            {
                Console.WriteLine(numerosDaSorte[i]);

            }


            Console.ReadLine();





            List<string> usuarios = new List<string>();
            List<string> nomes2 = new List<string>();

            Console.WriteLine("Escreva quantos usuarios vc quer cadastrar ");
            int quantdeusuarios = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes dos usuarios ");


            for (int i = 0; i < quantdeusuarios; i++)
            {
                usuarios.Add(Console.ReadLine());
            }

            Console.WriteLine("Os usuarios escolhidos foram " + quantdeusuarios);

            for (int i = 0; i < usuarios.Count; i++)
            {
                Console.WriteLine(usuarios[i]);
            }


            Console.WriteLine("Digite quantos nomes que você quer adicionar ");
            int quantdenomes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe os nomes ");

            for (int i = 0; i < quantdenomes; i++)
            {
                nomes2.Add(Console.ReadLine());

            }

            Console.WriteLine("Os nomes escolhidos foram ");

            for (int i = 0; i < nomes2.Count; i++)
            {
                Console.WriteLine(nomes2[i]);
            }

            Console.WriteLine("Usuarios inseridos, bom dia! ");

            Console.ReadLine();





            List<string> frutas = new List<string>();

            Console.WriteLine("Digite o numero de frutas que vc ira levar");
            int quantdefrutas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe os nomes das frutas escolhidas");

            for (int i = 0; i < quantdefrutas; i++)
            {
                frutas.Add(Console.ReadLine());

            }

            Console.WriteLine("AS frutas foram escolhidas" + quantdefrutas);

            for (int i = 0; i < frutas.Count; i++)
            {
                Console.WriteLine(frutas[i]);
            }

            Console.WriteLine("Frutas escolhidas obrigado!");

            Console.ReadLine();
        }



    }
}
