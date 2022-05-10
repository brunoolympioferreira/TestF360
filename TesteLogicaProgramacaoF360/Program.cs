using System;
using System.Collections.Generic;
using System.Linq;
using TesteLogicaProgramacaoF360.Services;

namespace TesteLogicaProgramacaoF360
{
    class Program
    {
        static void Main(string[] args)
        {
            var textoB = Texto.TextoB();
            var palavrasTextoB = textoB.Split(' ');

            
            
            //Exercício 1

            List<string> palavrasDeTresLetras = new();
            List<string> tresUltimasLetrasFoo = new();

            foreach (var item in palavrasTextoB)
            {
                if (item.Length == 3 && !item.Contains('d'))
                {
                    palavrasDeTresLetras.Add(item);
                }
            }

            foreach (var item in palavrasDeTresLetras)
            {
                var ultimaLetra = item.Substring(item.Length - 1, 1);
                if ((!ultimaLetra.Contains('s') && !ultimaLetra.Contains('l') && !ultimaLetra.Contains('f') && !ultimaLetra.Contains('w') && !ultimaLetra.Contains('k')))
                {
                    tresUltimasLetrasFoo.Add(ultimaLetra);
                }
            }

            Console.WriteLine($"No texto B existem {tresUltimasLetrasFoo.Count} preposições \n");

            //Exercício 2

            List<string> verbos = new();
            List<string> primeiraPessoa = new();

            foreach (var item in palavrasTextoB)
            {
                if (item.Length >= 8 && (item.EndsWith('s') || item.EndsWith('l') || item.EndsWith('f') || item.EndsWith('w') || item.EndsWith('k')))
                {
                    verbos.Add(item);
                }
            }

            foreach (var item in verbos)
            {
                if (!item.StartsWith('s') && !item.StartsWith('l') && !item.StartsWith('f') && !item.StartsWith('w') && !item.StartsWith('k'))
                {
                    primeiraPessoa.Add(item);
                }
            }

            Console.WriteLine($"No texto B existem {verbos.Count} verbos e {primeiraPessoa.Count} deles estão em primeira pessoa. \n");
;
            //Exercicio 3

            List<char> ordemAlfabetoKlingon = new() { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };

            List<string> vocabularioTextoB = new();

            vocabularioTextoB = palavrasTextoB.Distinct().ToList();

            vocabularioTextoB = vocabularioTextoB
                .OrderBy(x => ordemAlfabetoKlingon.IndexOf(x[0]))
                .ThenBy(x => ordemAlfabetoKlingon.IndexOf(x[1]))
                .ThenBy(x => ordemAlfabetoKlingon.IndexOf(x[2]))
                .ToList();

            Console.WriteLine("Alfabeto Klingon Texto B: \n");

            foreach (var item in vocabularioTextoB)
            {
                Console.Write(item + " ");
            }

            //Exercício 4

            var palavrasBonitasTextoB = 0;
            var numeroBonito = 440566;
            var divisivelPor = 3;

            foreach (var item in vocabularioTextoB)
            {
                double numPalavra = 0;

                for (int i = 0; i < item.Length; i++)
                {
                    numPalavra += ordemAlfabetoKlingon.IndexOf(item[i]) * Math.Pow(20, i);
                }

                if (numPalavra >= numeroBonito && numPalavra % divisivelPor == 0)
                {
                    palavrasBonitasTextoB++;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Palavras bonitas no Texto B: {palavrasBonitasTextoB}");

            Console.ReadKey();
        }
    }
}
