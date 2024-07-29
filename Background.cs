using System.Data;
using SFML.Graphics;
using SFML.System;

class Background
{
    private RectangleShape [,] arrOfRects;

    public Background()
    {
        arrOfRects = new RectangleShape[48, 64];
        for(int row = 0; row < 48; row++)
        {
            for(int col = 0; col < 64; col++)
            {
                arrOfRects[row, col] = new RectangleShape();
                arrOfRects[row, col].Position = new Vector2f(col * 10, row * 10);
                arrOfRects[row, col].FillColor = Color.Cyan;
                arrOfRects[row, col].Size = new Vector2f(10, 10);
            }
        }
    }

    public void Render(ref RenderWindow window)
    {
        for(int row = 0; row < 48; row++)
        {
            for(int col = 0; col < 64; col++)
            {
                window.Draw(arrOfRects[row, col]);
            }
        }   
    }

    public void SetSquareToUsed(int row, int col)
    {
        arrOfRects[col/10, row/10].FillColor = Color.Red; 
    }
}