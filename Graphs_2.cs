public static partial class Graphs
{
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
}