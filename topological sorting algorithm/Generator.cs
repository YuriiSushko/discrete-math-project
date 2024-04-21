namespace topological_sorting_algorithm;

class TopologyDFS
{
   public Vertex[,] AdjacencyMatrixGenerator(int numVertices, double density)
    {
        var random = new Random();
        var graph = new Vertex[numVertices, numVertices];
        var maxEdges = numVertices * (numVertices - 1);
        var numEdges = (int)(density * maxEdges);
        var edgeCount = 0;

        for (var i = 0; i < numVertices; i++)
        {
            for (var j = 0; j < numVertices; j++)
            {
                graph[i, j] = new Vertex(i, j);
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
        
        return graph;
    }

    public Dictionary<int, List<int>>[] AdjacencyListsGenerator(Vertex[,] graph, int vertices)
    {
        var adjacencyLists = new Dictionary<int, List<int>>[vertices];

        for (var i = 0; i < vertices; i++)
        {
            adjacencyLists[i] = new Dictionary<int, List<int>>();
            for (var j = 0; j < vertices; j++)
            {
                if (graph[i, j].Value != 0)
                {
                    if (!adjacencyLists[i].ContainsKey(graph[i, j].IndexI))
                    {
                        adjacencyLists[i][graph[i, j].IndexI] = new List<int>();
                    }
                
                    adjacencyLists[i][graph[i, j].IndexI].Add(j);
                }
            }
        }
        return adjacencyLists;
    }
}