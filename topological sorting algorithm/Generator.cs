namespace topological_sorting_algorithm;

class TopologyDFS
{
    public int[,] GenerationGraphs(int vertices, double density)
    {
        var random = new Random();
        var graph = new int[vertices, vertices];
        var maxEdges = vertices * (vertices - 1);
        var numEdges = (int) (density * maxEdges);
        var edgeCount = 0;

        while (edgeCount < numEdges)
        {
            var index_i = random.Next(vertices);
            var index_j = random.Next(vertices);

            if ((index_i != index_j) && graph[index_i, index_j] == 0)
            {
                graph[index_i, index_j] = 1;
                edgeCount++;
            }
        }

        for (var i = 0; i < vertices; i++)
        {
            for (var j = 0; j < vertices; j++)
            {
                Console.Write(graph[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        return graph;
    }

    public Dictionary<Vertices, int>[] SpyskySumizh(int[,] graph, int vertices)
    {
        var matrix = new Dictionary<Vertices, int>[vertices];

        for (var i = 0; i < vertices; i++)
        {
            matrix[i] = new Dictionary<Vertices, int>();
            for (int j = 0; j < vertices; j++)
            {
                if (graph[i, j] != 0)
                {
                    matrix[i].Add(new Vertices(i, j), 1);
                }
            }
        }
        
        for (var i = 0; i < vertices; i++)
        {
            foreach (var variable in matrix[i])
            {
                Console.Write(variable.Value + " ");
            }
            Console.WriteLine();
        }

        return matrix;
    }
}