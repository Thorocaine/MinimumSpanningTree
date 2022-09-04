using BenchmarkDotNet.Attributes;

[MemoryDiagnoser(false)]
public class SpanningTreeBenchmarks
{
    [Benchmark(Description = "Graph 1 - Prim's algorithm")]
    public void P1() => Prim.CreateSpanningTree(Graphs.Graph1);

    [Benchmark(Description = "Graph 1 - Kruskal's algorithm")]
    public void K1() => Kruskal.CreateSpanningTree(Graphs.Graph1);

    [Benchmark(Description = "Graph 2 - Prim's algorithm")]
    public void P2() => Prim.CreateSpanningTree(Graphs.Graph2);
    
    [Benchmark(Description = "Graph 2 - Kruskal's algorithm")]
    public void K2() => Kruskal.CreateSpanningTree(Graphs.Graph2);

    [Benchmark(Description = "Graph 3 - Prim's algorithm")]
    public void P3() => Prim.CreateSpanningTree(Graphs.Graph3);

    [Benchmark(Description = "Graph 3 - Kruskal's algorithm")]
    public void K3() => Kruskal.CreateSpanningTree(Graphs.Graph3);

    [Benchmark(Description = "Graph 4 - Prim's algorithm")]
    public void P4() => Prim.CreateSpanningTree(Graphs.Graph4);

    [Benchmark(Description = "Graph 4 - Kruskal's algorithm")]
    public void K4() => Kruskal.CreateSpanningTree(Graphs.Graph4);

    [Benchmark(Description = "Graph 5 - Prim's algorithm")]
    public void P5() => Prim.CreateSpanningTree(Graphs.Graph5);

    [Benchmark(Description = "Graph 5 - Kruskal's algorithm")]
    public void K5() => Kruskal.CreateSpanningTree(Graphs.Graph5);

    [Benchmark(Description = "Graph 6 - Prim's algorithm")]
    public void P6() => Prim.CreateSpanningTree(Graphs.Graph6);

    [Benchmark(Description = "Graph 6 - Kruskal's algorithm")]
    public void K6() => Kruskal.CreateSpanningTree(Graphs.Graph6);
}