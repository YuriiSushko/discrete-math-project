namespace topological_sorting_algorithm;

public class Vertices
{
    public int Vertice_i { get; set; }
    public int Vertice_j { get; set; }

    public Vertices(int value_1, int value_2)
    {
        Vertice_i = value_1;
        Vertice_j = value_2;
    }
}