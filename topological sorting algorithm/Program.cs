﻿using System.Diagnostics;

namespace topological_sorting_algorithm;

static class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        var dfsMatrix = new DfsTopologicalSortingAlgorithmMatrix();
        var dfsLists = new DfsTopologicalSortingAlgorithmLists();
        var printers = new Printers();
        
        const int numVertices = 500;
        const double density = 0.5;
        const int numOfTests = 20;

        var adjacencyMatrix = new Vertex[numVertices,numVertices];
        var sortedGraphWithMatrix = new Stack<int>();

        var adjacencyLists = new List<List<int>>();
        var sortedGraphWithLists = new Stack<int>();
        
        var totalTimeMatrix = 0L;
        var totalTimeLists = 0L;

        for (var i = 0; i < numOfTests; i++)
        {
            adjacencyMatrix = obj.AdjacencyMatrixGenerator(numVertices, density);
            adjacencyLists = obj.AdjacencyListsGenerator(adjacencyMatrix, numVertices);

            var sw1 = new Stopwatch();
            sw1.Start();
            Console.WriteLine($"\nTest #{i+1}: ");
            
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
        
        Console.WriteLine($"\nTotal time per {numOfTests} taken to sort graph with Matrix: {totalTimeMatrix}ms");
        Console.WriteLine($"Average time per {numOfTests} tests taken to sort graph with Matrix: {averagePerOneSetOfTestsMatrix}ms\n");
        Console.WriteLine($"Total time per {numOfTests} taken to sort graph with Lists: {totalTimeLists}ms");
        Console.WriteLine($"Average time per {numOfTests} tests taken to sort graph with Lists: {averagePerOneSetOfTestsLists}ms");
        /*printers.ToPrintMatrix(adjacencyMatrix, numVertices);
        printers.ToPrintStack(sortedGraphWithLists);
        printers.ToPrintLists(adjacencyMatrix, numVertices);*/
    }
}