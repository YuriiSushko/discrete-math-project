namespace topological_sorting_algorithm;

public class DfsTopologicalSortingAlgorithmLists
{
    private void DfsFunction(int vertex, List<List<int>> adjacencyList, bool[] visitedArray, Stack<int> stack)
    {
        visitedArray[vertex] = true;
        
        foreach (var neighbourVertex in adjacencyList[vertex])
        {
            if (!visitedArray[neighbourVertex])
            {
                DfsFunction(neighbourVertex, adjacencyList, visitedArray, stack);
            }
        }
        stack.Push(vertex);
    }

    public Stack<int> TopologicalSort(List<List<int>> adjacencyList, int numVertices)
    {
        var stack = new Stack<int>();
        var visitedArray = new bool[numVertices]; 

        for (var i = 0; i < numVertices; i++)
        {
            if (!visitedArray[i])
            {
                DfsFunction(i, adjacencyList, visitedArray, stack);
            }
        }
        return stack;
    }
}