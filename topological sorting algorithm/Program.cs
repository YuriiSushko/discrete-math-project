namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        const int vertices = 15;
        const double density = 0.4;

        var adjacencyMatrix = obj.GenerationGraphs(vertices, density);
        var adjacencyLists = (adjacencyMatrix, vertices);
    }
}