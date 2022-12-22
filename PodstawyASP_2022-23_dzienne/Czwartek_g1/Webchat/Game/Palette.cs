using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Webchat.Game
{
    public class Palette : GameObject
    {
        [JsonIgnore]
        public int Step { get; private set; }
        public Palette(int x, int y, int w, int h, int step) : base(x, y, w, h, ShapeType.RECTANGLE)
        {
            Step = 5;
        }

        public void moveUP()
        {
            this.Move(this, 0, -this.Step);
        }

        public void moveDown()
        {
            this.Move(this, 0, this.Step);
        }
    }
}
