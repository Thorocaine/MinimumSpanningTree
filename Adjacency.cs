public class Adjacency
{
    readonly Dictionary<char, List<(int distance, char node)>> _graph = new();
    public int NodeCount => _graph.Count;
    public IEnumerable<char> Nodes => _graph.Keys;

    public void Add(char na, char nb, int distance)
    {
        // This is similar to the Add method in the previous answer.
        // I do not validate anything in this example, as I am in control of what gets added.
        // I am not implementing a delete method, as I do not need it.
        Add(na, (distance, nb));
        Add(nb, (distance, na));
    }

    public IEnumerable<(int distance, char node)> this[char head] => _graph[head];

    public bool HasPath(char from, char to)
    {
        return _graph.ContainsKey(from) && _graph.ContainsKey(to) && CanFindAPath(from, to, Array.Empty<char>());
                                                                                                                 
        bool CanFindAPath(char from, char to, char[] haveChecked)
        {
            var adjacentNodes = _graph[from];
            if (adjacentNodes.Any(e => e.node == to)) return true;
            var haveNowChecked = haveChecked.Append(from).ToArray();
            return adjacentNodes
                .Where(e => !haveChecked.Contains(e.node))
                .Any( tryFrom => CanFindAPath(tryFrom.node, to, haveNowChecked));
        }
    }

    public void Print()
    {
        // Printing is not used in benchmarking.
        // This was used to print the results of each, and I confirmed it on paper.
        foreach (var kvp in _graph.OrderBy(kvp => kvp.Key))
        {
            Console.Write(kvp.Key);
            foreach (var (distance, node) in kvp.Value)
                Console.Write($"  -{distance}->  {node}");
            Console.WriteLine();
        }
    }

    void Add(char head, (int, char) distanceToNode)
    {
        if (_graph.ContainsKey(head)) _graph[head].Add(distanceToNode);
        else _graph.Add(head, new() {distanceToNode});
    }
}