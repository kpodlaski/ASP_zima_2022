using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Webchat.Game
{
    public class Ball : GameObject
    {
        [JsonIgnore]
        public int Vx { get; private set; }
        [JsonIgnore]
        public int Vy { get; private set; }
        //Center of the ball C = (Cx,Cy)
        [JsonIgnore]
        public float Cx { get; private set; }
        [JsonIgnore]
        public float Cy { get; private set; }
        public Ball(int x, int y, int w, int h, int vx, int vy) : base(x, y, w, h, ShapeType.ELIPSE)
        {
            this.Vx = vx;
            this.Vy = vy;
            Cx = x + w / 2;
            Cy = y + h / 2;
        }

        public void ReverseVy()
        {
            this.Vy = -this.Vy;
        }

        public void ReverseVx()
        {
            this.Vx = -this.Vx;
        }

        public void Move()
        {
            base.Move(this, this.Vx, this.Vy);
        }

        public bool doPointBelongToBall(float x, float y)
        {
            if (Math.Pow(2 * x / this.Width, 2) + Math.Pow(2 * y / this.Height, 2) > 1)
            {
                return false;
            }
            return true;
        }

    }
}
