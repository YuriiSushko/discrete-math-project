namespace topological_sorting_algorithm;

public class DfsTopologicalSortingAlgorithmMatrix
{
    private void DfsFunction(Vertex vertex, Vertex[,] adjacencyMatrix, bool[] visitedArray, Stack<int> stack)
    {
        var rawIndex = vertex.IndexI;
        visitedArray[rawIndex] = true;
        
        for (var j = 0; j < adjacencyMatrix.GetLength(1); j++)
        {
            if (adjacencyMatrix[rawIndex, j].Value != 0 && !visitedArray[j])
            {
                DfsFunction(adjacencyMatrix[j, 0], adjacencyMatrix, visitedArray, stack);
            }
        }
        
        stack.Push(rawIndex);
    }

    public Stack<int> TopologicalSort(Vertex[,] adjacencyMatrix)
    {
        var numVertices = adjacencyMatrix.GetLength(0);
        var stack = new Stack<int>();
        var visitedArray = new bool[numVertices]; 

        for (var j = 0; j < numVertices; j++)
        {
            if (!visitedArray[j] && adjacencyMatrix[j, 0].Value != 0)
            {
                DfsFunction(adjacencyMatrix[j, 0], adjacencyMatrix, visitedArray, stack);
            }
        }
        
        return stack;
    }
}