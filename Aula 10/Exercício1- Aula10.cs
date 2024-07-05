using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main() {
        int qntd;
        List<string> nomes = new List<string>();

        Console.WriteLine("Digite quantos nomes você quer inserir: ");
        qntd = int.Parse(Console.ReadLine());

        for (int i = 0; i < qntd; i++) {
            Console.WriteLine("Nome " + (i + 1) + ": ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        var nomesPorTamanho = nomes.GroupBy(n => n.Length);

        var nomesOrdenados = nomesPorTamanho.OrderBy(g => g.Key);

        List<string> Agrupamentos = new List<string>();


        foreach (var nome in nomesOrdenados) {

            var nomes_agrupados = nome.OrderBy(n => n);

            string linha = string.Join(", ", nomes_agrupados);


            Agrupamentos.Add(linha);
}
        foreach (var linha in Agrupamentos) {
            Console.WriteLine(linha);
        }
    }
}
