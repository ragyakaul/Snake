using System.Security.Principal;
using SFML.Graphics;
using SFML.Window;
using SFML.System;

 
 class Game
    {
        private const int WIDTH = 640;
        private const int HEIGHT = 480;
        private const string TITLE = "TRON";
        private RenderWindow window;
        //private VideoMode mode = new VideoMode(WIDTH, HEIGHT);
        private Player player;
        private Background background;
                

        // More explanation on why we split the declaration & initialization
        public Game()
        {
            this.window = new RenderWindow(new VideoMode(WIDTH, HEIGHT), TITLE);
            //this.window.SetVerticalSyncEnabled(true);
            this.player = new Player();
            this.background = new Background();
            window.Closed += (sender, args) => window.Close();
            this.window.SetFramerateLimit(1);
            //this.endgame();
            //this.background.SetSquareToUsed((int)player.position.X, (int)player.position.Y);
        }

            public void run()
            {
                while(this.window.IsOpen)
                {
                    this.handleEvents();
                    this.update();
                    this.draw();
                }
            }

            private void handleEvents()
            {
                this.window.DispatchEvents(); // look into it
                player.HandleUserInput(); 
            }
            private void update()
            {
                player.UpdatePosition();
                Vector2f newPosition = player.GetPoint();
                // check if game has ended: If the color of the rectangle of newPosition is red, game ends
                if(background.arrOfRects[((int)newPosition.X)/10, ((int)newPosition.Y)/10].FillColor == Color.Red)
                {
                    Console.WriteLine("Game Over!");
                    window.Close();
                }
                background.SetSquareToUsed((int)newPosition.X, (int)newPosition.Y);
            }

            private void draw()
            {
                this.window.Clear(Color.Blue);
                background.Render(ref this.window);
                player.Render(ref this.window);
                this.window.Display();
            } 
        }