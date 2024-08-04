using System.Data;
using System.Numerics;
using SFML.Graphics;
using SFML.System;

class Background
{
    public RectangleShape [,] arrOfRects;

    public List<Vector2f> visited;

    public Background()
    {
        
        arrOfRects = new RectangleShape[64, 48];
        visited = new List<Vector2f>();
        for(int col = 0; col < 64; col++)
        {
            for(int row = 0; row < 48; row++)
            {
                arrOfRects[col, row] = new RectangleShape();
                arrOfRects[col, row].Position = new Vector2f(col * 10, row * 10);
                arrOfRects[col, row].FillColor = Color.Cyan;
                arrOfRects[col, row].Size = new Vector2f(10, 10);
            }
        }
    }

    public void Render(ref RenderWindow window)
    {
        for(int col = 0; col < 64; col++)
        {
            for(int row = 0; row < 48; row++)
            {
                window.Draw(arrOfRects[col, row]);
            }
        }   
    }

    public void SetSquareToUsed(int col, int row)
    {
        Console.WriteLine($"from visited: {new Vector2f(col, row)}");
        arrOfRects[col/10, row/10].FillColor = Color.Red; 
        if (!visited.Contains(new Vector2f(col, row)))
        {
            
            this.visited.Add(new Vector2f(col, row));
        }
    }
}