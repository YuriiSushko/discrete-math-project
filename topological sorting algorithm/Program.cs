using System.Diagnostics;

namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        var dfsMatrix = new DfsTopologicalSortingAlgorithmMatrix();
        var printers = new Printers();
        
        const int numVertices = 15;
        const double density = 0.4;
        const int numOfTests = 20;

        var adjacencyMatrix = new Vertex[numVertices,numVertices];
        var sortedGraphWithMatrix = new Stack<int>();
        
        var totalTimeMatrix = 0L;
        var totalTimeLists = 0L;

        for (var i = 0; i < numOfTests; i++)
        {
            adjacencyMatrix = obj.AdjacencyMatrixGenerator(numVertices, density);
            var adjacencyLists = obj.AdjacencyListsGenerator(adjacencyMatrix, numVertices);
            
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine($"Test #{i+1}: \n");
            
            sortedGraphWithMatrix = dfsMatrix.TopologicalSort(adjacencyMatrix);
            
            sw.Stop();
            totalTimeMatrix += sw.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to sort via matrices: {sw.Elapsed}");
        }

        var averagePerOneSetOfTestsMatrix = totalTimeMatrix / numOfTests;
        var averagePerOneSetOfTestsLists = totalTimeLists / numOfTests;
        
        Console.WriteLine($"Average time per {numOfTests} tests taken to compute graph with Matrix: {averagePerOneSetOfTestsMatrix}");
        Console.WriteLine($"Average time per {numOfTests} tests taken to compute graph with Lists: {averagePerOneSetOfTestsLists}");

        /*printers.ToPrintMatrix(adjacencyMatrix, numVertices);
        printers.ToPrintStack(sortedGraph);
        printers.ToPrintLists(adjacencyMatrix, numVertices);*/
    }
}