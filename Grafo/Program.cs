using System;
using System.Collections.Generic;
using static Grafo;
public class Grafo
{
    private Dictionary<int, List<Aresta>> ListaAdjacente;
    //private Dictionary<Vertice, List<Aresta>> ListaAdjacente;
    //private HashSet<int> VerticesExistentes = new HashSet<int>();

    public Grafo()
    {
        ListaAdjacente = new Dictionary<int, List<Aresta>>();
        //ListaAdjacente = new Dictionary<Vertice, List<Aresta>>();
    }

    //public class Vertice
    //{
    //    public int Elemento { get; set; }

    //    public Vertice(int elemento)
    //    {
    //        Elemento = elemento;
    //    }
    //}

    public class Aresta
    {
        //public Vertice Vertice1 { get; set; }
        //public Vertice Vertice2 { get; set; }
        //public int Elemento { get; set; }

        //public Aresta(Vertice vertice1, Vertice vertice2, int elemento)
        //{
        //    Vertice1 = vertice1;
        //    Vertice2 = vertice2;
        //    Elemento = elemento;
        //}

        public int Vertice1 { get; set; }
        public int Vertice2 { get; set; }
        public int Elemento { get; set; }

        public Aresta(int vertice1, int vertice2, int elemento)
        {
            Vertice1 = vertice1;
            Vertice2 = vertice2;
            Elemento = elemento;
        }
    }

    //public void AdicionarVertice(int valor)
    //{
    //    if (!VerticesExistentes.Contains(valor))
    //    {
    //        Vertice vertice = new Vertice(valor);
    //        ListaAdjacente[vertice] = new List<Aresta>();
    //        VerticesExistentes.Add(valor);
    //    }
    //    //Vertice vertice = new Vertice(valor);

    //    //if (!ListaAdjacente.ContainsKey(vertice))
    //    //{
    //    //    ListaAdjacente[vertice] = new List<Aresta>();
    //    //}
    //    else
    //    {
    //        Console.WriteLine($"O vertice {valor} já existe no grafo");
    //    }
    //}

    public void CriarVertices(int vertices)
    {
        for (int i = 1; i <= vertices; i++)
        {
            ListaAdjacente[i] = new List<Aresta>();
        }
    }
    public void AdicionarAresta(int vertice1, int vertice2)
    {
        //if (!VerticesExistentes.Contains(vertice1))
        //{
        //    Console.WriteLine($"O Vertice com valor {vertice1} não existe no grafo");
        //}
        //else if (!VerticesExistentes.Contains(vertice2))
        //{
        //    Console.WriteLine($"O Vertice com valor {vertice2} não existe no grafo");
        //}
        if (!ListaAdjacente.ContainsKey(vertice1))
        {
            Console.WriteLine($"O Vertice com valor {vertice1} não existe no grafo");
        }
        else if (!ListaAdjacente.ContainsKey(vertice2))
        {
            Console.WriteLine($"O Vertice com valor {vertice2} não existe no grafo");
        }
        else
        {

            var aresta1 = new Aresta( vertice1, vertice2, 0);
            var aresta2 = new Aresta(vertice2, vertice1, 0);
            ListaAdjacente[vertice1].Add(aresta1);
            ListaAdjacente[vertice2].Add(aresta2);
        }
        //if (!ListaAdjacente.ContainsKey(vertice1))
        //{
        //    ListaAdjacente[vertice1] = new List<int>();
        //}

        //if (!ListaAdjacente.ContainsKey(vertice2))
        //{
        //    ListaAdjacente[vertice2] = new List<int>();
        //}

        //ListaAdjacente[vertice1].Add(vertice2);
        //ListaAdjacente[vertice2].Add(vertice1);

    }

    //public bool VerificarAresta(int vertice1, int vertice2)
    //{
    //    return ListaAdjacente.ContainsKey(vertice1) && ListaAdjacente[vertice1].Contains(vertice2);
    //}

    public void ExibirGrafo()
    {
        foreach (var vertice in ListaAdjacente)
        {
            var conexoes = new List<string>();
            foreach (var aresta in vertice.Value)
            {
                conexoes.Add(aresta.Vertice2.ToString()); // Pegando o destino
            }
            Console.WriteLine($"Vértice {vertice.Key}: [{string.Join(", ", conexoes)}]");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Grafo grafo = new Grafo();

        Console.WriteLine("Informe a quantidade de vertices que deseja no grafo: ");
        int vertices = int.Parse(Console.ReadLine());
        grafo.CriarVertices(vertices);

        grafo.AdicionarAresta(1, 2);
        grafo.AdicionarAresta(2, 5);
        grafo.AdicionarAresta(5, 3);
        grafo.AdicionarAresta(4, 5);
        grafo.AdicionarAresta(1, 5);
        grafo.ExibirGrafo();
    }
}