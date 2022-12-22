using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webchat.Game
{

    public class Wall : GameObject
    {
        private HashSet<WallDirection> wallDirections = new HashSet<WallDirection>();
        public Wall(int x, int y, int w, int h, params WallDirection[] directions) : base(x, y, w, h, ShapeType.RECTANGLE)
        {
            foreach (WallDirection wd in directions)
            {
                this.wallDirections.Add(wd);
            }
        }

        public bool isVericall()
        {
            foreach( WallDirection wd in wallDirections)
            {
                if (wd == WallDirection.VERTICAL) return true;
            }
            return false;
        }

        internal bool isHorizontal()
        {
            foreach (WallDirection wd in wallDirections)
            {
                if (wd == WallDirection.HORIZONTAL) return true;
            }
            return false;
        }

    }
}
