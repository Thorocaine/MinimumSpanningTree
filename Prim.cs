public static class Prim
{
    public static Adjacency CreateSpanningTree(Adjacency graph)
    {
        var tree = new Adjacency();
        var startAt = graph.Nodes.First();
        var visited = new HashSet<char> {startAt};

        while (visited.Count < graph.NodeCount)
        {
            var (minimum, from, to) = visited
                .SelectMany(h => graph[h].Select(e => (e.distance, from: h, to: e.node)))
                .Where(x => !visited.Contains(x.to))
                .MinBy(x => x.distance);
            tree.Add(from, to, minimum);
            visited.Add(to);
        }

        return tree;
    }
}