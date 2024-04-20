namespace topological_sorting_algorithm;

class Program
{
    static void Main()
    {
        var obj = new TopologyDFS();
        obj.SpyskySumizh(obj.GenerationGraphs(15, 0.4), 15);
    }
}