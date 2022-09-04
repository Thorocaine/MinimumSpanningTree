static class Kruskal
{
    public static Adjacency CreateSpanningTree(Adjacency graph)
    {
        var tree = new Adjacency();
        var allEdges = GetOrderedEdges(graph);
        foreach (var edge in allEdges)
            if (!tree.HasPath(edge.Node1, edge.Node2)) tree.Add(edge.Node1, edge.Node2, edge.Distance);
        return tree;
    }

    static IEnumerable<Edge> GetOrderedEdges(Adjacency graph) =>
        graph.Nodes
            .SelectMany(n => graph[n].Select(e => new Edge(e.node, n, e.distance)))
            .OrderBy(e => e.Distance)
            .Distinct();

    struct Edge
    {
        public char Node1 { get; }
        public char Node2 { get; }
        public int Distance { get; }

        public Edge(char n1, char n2, int distance)
        {
            (Node1, Node2) = n1 < n2 ? (n1, n2) : (n2, n1);
            Distance = distance;
        }
    }
}