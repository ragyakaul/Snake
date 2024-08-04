using SFML.System;
using SFML.Graphics;
using SFML.Window;
using System.Security.Cryptography.X509Certificates;
//using System.Windows.Forms;

class Player 
{
    private const float PLAYER_SPEED = 10f;
    private RectangleShape rect; 
    private int curDirection; //use enums as well

    
    
    public Player()
    {
        rect = new RectangleShape();
        curDirection = 0;
        this.rect.Position = new Vector2f(320, 240);
        this.rect.Size = new Vector2f(10, 10);
    }

    public Vector2f GetPoint()
    {
        return this.rect.Position;
    }

    public void HandleUserInput()
    {
        if(Keyboard.IsKeyPressed(Keyboard.Key.Left))
        {
            curDirection = 0;
        }
        else if(Keyboard.IsKeyPressed(Keyboard.Key.Right))
        {
            curDirection = 1;
        }
        else if(Keyboard.IsKeyPressed(Keyboard.Key.Up))
        {
            curDirection = 2;
        }
        else if(Keyboard.IsKeyPressed(Keyboard.Key.Down))
        {
            curDirection = 3;
        }
    }

    public void UpdatePosition()
    {
        Vector2f newPosition = this.rect.Position; // calls getter & assigns it to newPosition
        switch(curDirection)
        {
            case 0:
            {
                newPosition.X -= PLAYER_SPEED;
                break;
            }
            case 1:
            {
                newPosition.X  += PLAYER_SPEED;
                break;
            }
            case 2:
            {
                newPosition.Y -= PLAYER_SPEED;
                break;
            }
            case 3:
            {
                newPosition.Y  += PLAYER_SPEED;
                break;
            }
        }
        this.rect.Position = newPosition; // calling the setter
    }

    



    public void Render(ref RenderWindow window)
    {   
        window.Draw(rect);
    }
}

