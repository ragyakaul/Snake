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
            }

            private void draw()
            {
                this.window.Clear(Color.Blue);
                player.Render(ref this.window);
                //this.window.Draw(rect);
                this.window.Display();
                
            }

        }