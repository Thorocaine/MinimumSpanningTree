public static partial class Graphs
{
    public static Adjacency Graph1 { get; }
    public static Adjacency Graph2 { get; }
    public static Adjacency Graph3 { get; }
    public static Adjacency Graph4 { get; }
    public static Adjacency Graph5 { get; }
    public static Adjacency Graph6 { get; }

    static Graphs()
    {
        FillGraph1(Graph1 = new ());
        FillGraph2(Graph2 = new ());
        FillGraph3(Graph3 = new ());
        FillGraph4(Graph4 = new ());

        // The random ones.
        // They are generated once so that both algorithms can work on the same data.
        // In "The Real World (tm)" There would be a builder, I would not have so much repeated code
        FillGraph5(Graph5 = new ());
        FillGraph6(Graph6 = new ());
    }

    static void FillGraph1(Adjacency graph1)
    {
        // The example graph in Question 1.
        graph1.Add('a', 'b', 2);
        graph1.Add('a', 'c', 3);
        graph1.Add('b', 'd', 2);
        graph1.Add('c', 'd', 1);
        graph1.Add('d', 'e', 2);
        graph1.Add('d', 'f', 4);
        graph1.Add('e', 'f', 1);
        graph1.Add('e', 'g', 2);
        graph1.Add('f', 'h', 1);
        graph1.Add('g', 'h', 3);
        graph1.Add('g', 'f', 2);
    }

    static void FillGraph2(Adjacency graph2)
    {   
        // I wanted a graph with a "strong line in the "middle", to test the algorithm on
        graph2.Add('a', 'b', 1);
        graph2.Add('a', 'c', 1);
        graph2.Add('b', 'd', 1);
        graph2.Add('c', 'd', 1);
        graph2.Add('d', 'e', 6);
        graph2.Add('e', 'f', 6);
        graph2.Add('f', 'g', 1);
        graph2.Add('f', 'h', 1);
        graph2.Add('g', 'i', 1);
        graph2.Add('h', 'i', 1);
    }
}