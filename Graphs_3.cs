public static partial class Graphs
{
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