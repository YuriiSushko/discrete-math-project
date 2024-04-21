namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        var dfs = new DfsViaAdjacencyMatrix();
        var printers = new Printers();
        
        const int numVertices = 15;
        const double density = 0.4;

        var adjacencyMatrix = obj.AdjacencyMatrixGenerator(numVertices, density);
        var sortedGraph= dfs.TopologicalSort(adjacencyMatrix);
        var adjacencyLists = obj.AdjacencyListsGenerator(adjacencyMatrix, numVertices);
        
        printers.ToPrintMatrix(adjacencyMatrix, numVertices);
        printers.ToPrintStack(sortedGraph);
        printers.ToPrintLists(adjacencyMatrix, numVertices);
    }
}