This is my (Jonathan Peel) code example for comparing the minimu spanning trees.

|                          Method |       Mean |     Error |     StdDev |  Allocated |
|-------------------------------- |-----------:|----------:|-----------:|-----------:|
|    'Graph 1 - Prim's algorithm' |   4.176 us | 0.0822 us |  0.1483 us |    8.01 KB |
| 'Graph 1 - Kruskal's algorithm' |   5.562 us | 0.0583 us |  0.0546 us |   12.81 KB |
|    'Graph 2 - Prim's algorithm' |   4.638 us | 0.0773 us |  0.0723 us |     9.5 KB |
| 'Graph 2 - Kruskal's algorithm' |   4.635 us | 0.0844 us |  0.0748 us |   10.36 KB |
|    'Graph 3 - Prim's algorithm' |   3.012 us | 0.0584 us |  0.0695 us |    5.84 KB |
| 'Graph 3 - Kruskal's algorithm' |   5.552 us | 0.1056 us |  0.1085 us |   12.14 KB |
|    'Graph 4 - Prim's algorithm' |  13.737 us | 0.2694 us |  0.3503 us |   17.03 KB |
| 'Graph 4 - Kruskal's algorithm' |  22.458 us | 0.4368 us |  0.4290 us |   47.27 KB |
|    'Graph 5 - Prim's algorithm' |  95.563 us | 1.5434 us |  1.2888 us |   52.33 KB |
| 'Graph 5 - Kruskal's algorithm' |  57.757 us | 1.0381 us |  0.9710 us |  121.99 KB |
|    'Graph 6 - Prim's algorithm' | 115.439 us | 1.9573 us |  1.8308 us |   48.58 KB |
| 'Graph 6 - Kruskal's algorithm' | 471.157 us | 9.2186 us | 11.9868 us | 1013.32 KB |
