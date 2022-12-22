using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Webchat.Game
{
    public abstract class GameObject
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        [JsonIgnore]
        private int oldX { get; set; }
        [JsonIgnore]
        private int oldY { get; set; }
        [JsonIgnore]
        public ShapeType ShapeType;

        public GameObject(int x, int y, int w, int h, ShapeType shape)
        {
            this.X = x;
            this.Y = y;
            this.Width = w;
            this.Height = h;
            this.ShapeType = shape;
        }

        public void Move(GameObject go, int dx, int dy)
        {
            oldX = X;
            oldY = Y;
            go.X += dx; 
            go.Y += dy;
        }

        public void goToPreviousPosition()
        {
            this.X = oldX;
            this.Y = oldY;
        }

    }
}
