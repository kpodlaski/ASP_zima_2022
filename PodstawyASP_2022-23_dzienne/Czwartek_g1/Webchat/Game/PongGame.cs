using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Webchat.Game
{
    public class PongGame
    {
        private Ball Ball {get; set;}
        private List<GameObject> Walls {get; set;}

        private List<Palette> Palettes { get; set; }

        private Collisions collisions;

        private bool gameIsActive = false;
        private Thread gameThread;
        private static int canvasWidth = 600, canvasHeight = 500;

        private PongGame(Ball ball, List<GameObject> walls,  List<Palette> palettes, Collisions collisions)
        {
            this.Ball = ball;
            this.Walls = walls;
            this.Palettes = palettes;
            this.collisions = collisions;
        }

        public static PongGame BuildGame()
        {
            Ball ball = new Ball(10, 13, 30, 30, 2, 3);
            List<GameObject> walls = new List<GameObject>();
            walls.Add(new Wall(0, 0, 2, canvasHeight, WallDirection.VERTICAL));
            walls.Add(new Wall(canvasWidth, 0, 2, canvasHeight, WallDirection.VERTICAL));
            walls.Add(new Wall(0, 0, canvasWidth, 2, WallDirection.HORIZONTAL));
            walls.Add(new Wall(0, canvasHeight, canvasWidth, 2, WallDirection.HORIZONTAL));
            List<Palette> palettes = new List<Palette>();
            palettes.Add(new Palette((int) canvasWidth/2, 90, 10, 60, 5));
            //palettes.Add(new Palette(20, 90, 10, 60, 5));
            Collisions collisions = new Collisions();
            PongGame game = new PongGame(ball,walls,palettes,collisions);
            return game;
        }


        private bool CheckWinLooseCondition()
        {
            return false;
        }
        public void AnimationStep()
        {
            MoveBall();
        }

        private void MoveBall()
        {
            Ball.Move();
            bool collision = false;
            foreach (Wall w in Walls)
            {
                if (collisions.CheckCollisionWith(Ball, w))
                {
                    if (w.isVericall()) Ball.ReverseVx();
                    if (w.isHorizontal()) Ball.ReverseVy();
                    collision = true;
                    System.Diagnostics.Debug.Write("Collision ");
                    if (w.isVericall()){
                        System.Diagnostics.Debug.WriteLine("Vertical wall, at X="+w.X);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Horizontal wall, at Y="+w.Y);
                    }
                    
                    System.Diagnostics.Debug.WriteLine("Ball position: ["+Ball.X+","+Ball.Y+"]");
                }
            }

            
            if (collision)
            {
                Ball.goToPreviousPosition();
            }
        }

        public bool MovePalette(int id, int dy)
        {
            if (id >= Palettes.Count()) return false;
            if (dy > 0)
            {
                Palettes[id].moveDown();
            }
            else
            {
                Palettes[id].moveUP();
            }
            //Chceck collision
            bool collision = false;
            foreach (Wall w in Walls)
            {
                if (collisions.CheckCollisionWith(Palettes[id], w))
                {
                    collision = true;
                }
            }
            if (collision)
            {
                Palettes[id].goToPreviousPosition();
            }
            return !collision; 
        }

        private void gameLoop()
        {
            while (gameIsActive)
            {
                AnimationStep();
                if (CheckWinLooseCondition())
                {
                    StopGame();
                }
                Thread.Sleep(30);
            }
        }

        public void StartGame()
        {
            if (gameIsActive) return;
            gameIsActive = true;
            gameThread = new Thread(this.gameLoop);
            gameThread.Start();
        }

        public void StopGame()
        {
            gameIsActive = false;
        }

        public Object GameState()
        {
            var gameState = new { ball = Ball , palettes = Palettes };
            return gameState;
        }
    }
}
