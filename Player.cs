using SFML.System;
using SFML.Graphics;
using SFML.Window;

class Player 
{
    private const float PLAYER_SPEED = 10f;
    private Vector2f position; 
    private RectangleShape rect; 
    
    public Player()
    {
        position = new Vector2f(320, 240);
        rect = new RectangleShape();
        this.rect.Size = new Vector2f(10, 10);
    }
    public void HandleUserInput()
    {
        bool moveLeft = Keyboard.IsKeyPressed(Keyboard.Key.Left);
        bool moveRight = Keyboard.IsKeyPressed(Keyboard.Key.Right);
        bool moveUp = Keyboard.IsKeyPressed(Keyboard.Key.Up);
        bool moveDown = Keyboard.IsKeyPressed(Keyboard.Key.Down);

        bool  isMove = moveLeft || moveRight || moveUp || moveDown;

        if(isMove)
        {
            if(moveLeft) position.X -= PLAYER_SPEED;
            if(moveRight) position.X  += PLAYER_SPEED;
            if(moveUp) position.Y -= PLAYER_SPEED;
            if(moveDown) position.Y += PLAYER_SPEED;
        }    
    }

    public void Process()
    {
        this.rect.Position = position;
    }

    public void Render(ref RenderWindow window)
    {   
        window.Draw(rect);
    }
}

