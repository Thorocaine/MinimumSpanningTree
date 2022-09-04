public static class Graphs
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
           
    static void FillGraph3(Adjacency graph3)
    {
        // A small "Random" graph, by "baning" on the keyboard
        graph3.Add('a', 'b', 1);
        graph3.Add('a', 'c', 1);
        graph3.Add('b', 'd', 3);
        graph3.Add('b', 'e', 1);
        graph3.Add('d', 'g', 2);
        graph3.Add('e', 'g', 3);
        graph3.Add('c', 'f', 1);
        graph3.Add('f', 'g', 2);
        graph3.Add('f', 'e', 3);
    }

    static void FillGraph4(Adjacency graph4)
    {
        // A larger "random" graph by banging on the keyboard.
        graph4.Add('a', 'b', 5);
        graph4.Add('a', 'c', 2);
        graph4.Add('a', 'e', 2);
        graph4.Add('a', 'h', 3);
        graph4.Add('b', 'd', 1);
        graph4.Add('b', 'e', 5);
        graph4.Add('b', 'j', 5);
        graph4.Add('b', 'l', 4);
        graph4.Add('b', 'm', 3);
        graph4.Add('c', 'd', 6);
        graph4.Add('c', 'j', 3);
        graph4.Add('c', 'm', 2);
        graph4.Add('d', 'e', 4);
        graph4.Add('d', 'f', 4);
        graph4.Add('d', 'g', 3);
        graph4.Add('d', 'h', 5);
        graph4.Add('d', 'i', 2);
        graph4.Add('d', 'j', 5);
        graph4.Add('d', 'k', 3);
        graph4.Add('d', 'm', 3);
        graph4.Add('e', 'f', 5);
        graph4.Add('e', 'j', 3);
        graph4.Add('e', 'k', 7);
        graph4.Add('f', 'g', 5);
        graph4.Add('f', 'h', 4);
        graph4.Add('g', 'h', 3);
        graph4.Add('h', 'i', 6);
        graph4.Add('i', 'j', 3);
        graph4.Add('i', 'k', 6);
        graph4.Add('l', 'm', 3);
    }

    static void FillGraph5(Adjacency graph5)
    {
        var random = new Random();
        var nodeCount = random.Next(5, 26);
        for (var i = 0; i < nodeCount - 1; i++)
        {
            for (var j = i + 1; j < nodeCount; j++)
            {
                var weight = random.Next(-9, 10); //50% chance of a positive weight
                if (weight > 0) graph5.Add((char)('a' + i), (char)('a' + j), weight);
            }
        }
    }

    static void FillGraph6(Adjacency graph6)
    {
        var random = new Random();
        var nodeCount = random.Next(16, 26); // This should have a higher chance of being bigger 
        for (var i = 0; i < nodeCount - 1; i++)
        {
            for (var j = i + 1; j < nodeCount; j++)
            {
                var weight = random.Next(-1, 10); // This will have a lot more connections
                if (weight > 0) graph6.Add((char)('a' + i), (char)('a' + j), weight);
            }
        }
    }
}