namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        const int numVertices = 15;
        const double density = 0.4;

        var adjacencyMatrix = obj.GenerationGraphs(numVertices, density);
        var adjacencyLists = obj.SpyskySumizh(adjacencyMatrix, numVertices);
    }
}