namespace topological_sorting_algorithm;

public class Printers
{
    public void ToPrintStack(Stack<int> stack)
    {
        Console.Write("Topological sorting of the graph: ");
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
        Console.WriteLine();
    }
    
    public void ToPrintLists(Vertex[,] graph, int vertices)
    {
        var dfs = new TopologyDFS();
        var adjacencyLists = dfs.AdjacencyListsGenerator(graph, vertices);

        Console.WriteLine("Adjacency lists:");
        for (int i = 0; i < vertices; i++)
        {
            Console.Write($"Adjacency list[{graph[i, 0].IndexI}]: ");
            if (adjacencyLists[i].ContainsKey(graph[i, 0].IndexI))
            {
                foreach (var value in adjacencyLists[i][graph[i, 0].IndexI])
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(value + " ");
                    Console.ResetColor();
                }
            }
            Console.WriteLine();
        }
    }
    
    public void ToPrintMatrix(Vertex[,] graph, int numVertices)
    {
        Console.WriteLine("Adjacency matrix:");
        Console.Write("  ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        //Only for visualisation vertices will be shown as letters, because it makes the grid more even. For adjacency lists I will use numbers
        
        for (char c = 'a'; c < 'a' + numVertices; c++)
        {
            Console.Write($"{c} ");
        }
        
        Console.ResetColor();
        Console.WriteLine();
        
        for (var i = 0; i < numVertices; i++)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{(char)('a' + i)} ");
            Console.ResetColor();
            
            for (var j = 0; j < numVertices; j++)
            {
                if (graph[i, j].Value == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write(graph[i, j].Value + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}