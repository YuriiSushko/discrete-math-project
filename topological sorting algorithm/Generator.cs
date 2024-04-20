namespace topological_sorting_algorithm;

class TopologyDFS
{
    public Vertex[,] GenerationGraphs(int numVertices, double density)
    {
        var random = new Random();
        var graph = new Vertex[numVertices, numVertices];
        var maxEdges = numVertices * (numVertices - 1);
        var numEdges = (int)(density * maxEdges);
        var vertexName = '`';
        var edgeCount = 0;

        for (var i = 0; i < numVertices; i++)
        {
            vertexName++;
            for (var j = 0; j < numVertices; j++)
            {
                graph[i, j] = new Vertex(i, j, vertexName);
            }
        }

        while (edgeCount < numEdges)
        {
            var indexI = random.Next(numVertices);
            var indexJ = random.Next(numVertices);
            var vertex = graph[indexI, indexJ];

            if ((vertex.IndexI != vertex.IndexJ) && vertex.Value == 0)
            {
                vertex.Value = 1;
                edgeCount++;
            }
        }

        Console.WriteLine("Adjacency matrix:");
        for (var i = 0; i < numVertices; i++)
        {
            for (var j = 0; j < numVertices; j++)
            {
                if (graph[i,j].Value == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ResetColor();
                }
                
                Console.Write(graph[i, j].Value + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        Console.WriteLine();

        return graph;
    }

    public Dictionary<char, List<int>>[] SpyskySumizh(Vertex[,] graph, int vertices)
    {
        var adjacencyLists = new Dictionary<char, List<int>>[vertices];
       
        for (var i = 0; i < vertices; i++)
        {
            adjacencyLists[i] = new Dictionary<char, List<int>>();
            for (var j = 0; j < vertices; j++)
            {
                if (graph[i,j].Value != 0)
                {
                    if (!adjacencyLists[i].ContainsKey(graph[i, j].Name))
                    {
                        adjacencyLists[i][graph[i, j].Name] = new List<int>();
                    }
                
                    adjacencyLists[i][graph[i, j].Name].Add(1);
                }
            }
        }

        Console.WriteLine("Adjacency lists:");
        for (var i = 0; i < vertices; i++)
        {
            Console.Write($"Adjacency list[{graph[i, 0].Name}]: ");
            foreach (var kvp in adjacencyLists[i])
            {
                foreach (var value in kvp.Value)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        return adjacencyLists;
    }
}