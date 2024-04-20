namespace topological_sorting_algorithm;

public class Vertex
{
    public int IndexI { get; set; }
    public int IndexJ { get; set; }
    public char Name { get; set; }
    public int Value { get; set; }

    public Vertex(int indexI, int indexJ, char name)
    {
        IndexI = indexI;
        IndexJ = indexJ;
        Name = name;
    }

    public Vertex(int indexI, int indexJ, char name, int value = 0) : this(indexI, indexJ, name)
    {
        IndexI = indexI;
        IndexJ = indexJ;
        Name = name;
        Value = value;
    }
}