using System.Diagnostics;

namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        var dfsMatrix = new DfsTopologicalSortingAlgorithmMatrix();
        var dfsLists = new DfsTopologicalSortingAlgorithmLists();
        var printers = new Printers();
        
        const int numVertices = 15;
        const double density = 0.4;
        const int numOfTests = 20;

        var adjacencyMatrix = new Vertex[numVertices,numVertices];
        var sortedGraphWithMatrix = new Stack<int>();

        var adjacencyLists = new List<List<int>>();
        var sortedGraphWithLists = dfsLists.TopologicalSort(adjacencyLists, numVertices);
        
        var totalTimeMatrix = 0L;
        var totalTimeLists = 0L;

        for (var i = 0; i < numOfTests; i++)
        {
            adjacencyMatrix = obj.AdjacencyMatrixGenerator(numVertices, density);
            adjacencyLists = obj.AdjacencyListsGenerator(adjacencyMatrix, numVertices);

            var sw1 = new Stopwatch();
            sw1.Start();
            Console.WriteLine($"Test #{i+1}: \n");
            
            sortedGraphWithMatrix = dfsMatrix.TopologicalSort(adjacencyMatrix);
            
            sw1.Stop();
            totalTimeMatrix += sw1.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to sort with matrices: {sw1.Elapsed}");
            
            
            var sw2 = new Stopwatch();
            sw2.Start();
            
            sortedGraphWithLists = dfsLists.TopologicalSort(adjacencyLists, numVertices);
            
            sw2.Stop();
            totalTimeLists += sw2.ElapsedMilliseconds;
            Console.WriteLine($"Time taken to sort with lists: {sw2.Elapsed}");
        }

        var averagePerOneSetOfTestsMatrix = totalTimeMatrix / numOfTests;
        var averagePerOneSetOfTestsLists = totalTimeLists / numOfTests;
        
        Console.WriteLine($"Average time per {numOfTests} tests taken to compute graph with Matrix: {averagePerOneSetOfTestsMatrix}");
        Console.WriteLine($"Average time per {numOfTests} tests taken to compute graph with Lists: {averagePerOneSetOfTestsLists}");
        /*printers.ToPrintMatrix(adjacencyMatrix, numVertices);
        printers.ToPrintStack(sorted);
        printers.ToPrintLists(adjacencyMatrix, numVertices);*/
    }
}