namespace topological_sorting_algorithm;

public class Vertex
{
    public int IndexI { get; set; }
    public int IndexJ { get; set; }
    public int Name { get; set; }
    public int Value { get; set; }

    public Vertex(int indexI, int indexJ)
    {
        IndexI = indexI;
        IndexJ = indexJ;
    }

    public Vertex(int indexI, int indexJ, int value = 0) : this(indexI, indexJ)
    {
        IndexI = indexI;
        IndexJ = indexJ;
        Value = value;
    }
}