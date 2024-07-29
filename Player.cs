using SFML.System;
using SFML.Graphics;
using SFML.Window;

class Player 
{
    private const float PLAYER_SPEED = 10f;
    public Vector2f position; // How can we directly use rect.Position in this problem? 
    private RectangleShape rect; 
    
    public Player()
    {
        rect = new RectangleShape();
        position = new Vector2f(320, 240);
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
            if(moveLeft) position.X -= PLAYER_SPEED; // Cannot modify return value of transformable position error when we try to do it directly
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

