internal class Map
{
    public int Width { get; }
    public int Height { get; }
    public Cell[,] cells;

    public Map(int width, int height)
    {   //validate
        Width = width;
        Height = height;

        cells = new Cell[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                cells[i,j] = new Cell();
            }
        }
    }
}