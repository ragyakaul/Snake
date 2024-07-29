using SFML.Graphics;
using SFML.Window;

 
 class Game
    {
        private const int WIDTH = 640;
        private const int HEIGHT = 480;
        private const string TITLE = "TRON";
        private RenderWindow window;
        private VideoMode mode = new VideoMode(WIDTH, HEIGHT);
        private Player player = new Player();
        private Background background = new Background();

        
        public Game()
        {
            this.window = new RenderWindow(this.mode, TITLE);
            //this.window.SetVerticalSyncEnabled(true);
            window.Closed += (sender, args) => window.Close();
            this.window.SetFramerateLimit(1);
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
                player.Process();
                Console.WriteLine((int)player.position.X);
                Console.WriteLine((int)player.position.Y);
                background.SetSquareToUsed((int)player.position.X, (int)player.position.Y);
            }

            private void draw()
            {
                this.window.Clear(Color.Blue);
                background.Render(ref this.window);
                player.Render(ref this.window);
                this.window.Display();
            }
        }