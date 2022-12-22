using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webchat.Game
{
    public class Collisions
    {

        public bool CheckCollisionWith(GameObject go1, GameObject go2)
        {
            if (go1.ShapeType == ShapeType.RECTANGLE)
            {
                if (go2.ShapeType == ShapeType.RECTANGLE)
                {
                    return checkRectanglesCollision(go1, go2);
                }
                if (go2.ShapeType == ShapeType.ELIPSE)
                {
                    return checkRectangleEllipseCollision(go1, (Ball)go2);
                }
            }

            if (go1.ShapeType == ShapeType.ELIPSE)
            {
                if (go2.ShapeType == ShapeType.RECTANGLE)
                {
                    return checkRectangleEllipseCollision(go2, (Ball)go1);
                }
                if (go2.ShapeType == ShapeType.ELIPSE)
                {
                    return checkEllipsesColision((Ball)go1, (Ball)go2);
                }
            }
            throw new Exception("Oups");
            return false;
        }

        private bool checkEllipsesColision(Ball ellipse1, Ball ellipse2)
        {
            //check bounding collision of boxes
            bool bBoxCollision = checkRectanglesCollision(ellipse1, ellipse2);
            if (bBoxCollision == false) return false;
            //middle point between centers 
            float[] v = new float[] { Math.Abs(ellipse1.Cx - ellipse2.Cx) / 2, Math.Abs(ellipse1.Cy - ellipse2.Cy) / 2 };
            //Check if middle point belong to any of these eclipses
            if (ellipse1.doPointBelongToBall(v[0], v[1]) || ellipse2.doPointBelongToBall(v[0], v[1]))
            {
                return true;
            }
            return false;
        }

        private bool checkRectangleEllipseCollision(GameObject rect, Ball ellipse)
        {
            bool bBoxCollision = checkRectanglesCollision(rect, ellipse);
            if (bBoxCollision == false) return false;
            //Check in details, we know bounding boxes intersects
            //check if one of horizontal rectangle lines passes center of the ellipse
            if (rect.X < ellipse.Cx && rect.X + rect.Width > ellipse.Cx) return true;
            //check if one of vertical rectangle lines passes center of the ellipse
            if (rect.Y < ellipse.Cy && rect.Y + rect.Height > ellipse.Cy) return true;
            //check if any of rectangle vertex is inside the ellipse
            int[] xs = new int[] { rect.X, rect.X + rect.Width, rect.X, rect.X + rect.Width };
            int[] ys = new int[] { rect.Y, rect.Y, rect.Y + rect.Height, rect.Y + rect.Height };
            for (int i = 0; i < xs.Length; i++)
            {
                if (ellipse.doPointBelongToBall(xs[i], ys[i]))
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkRectanglesCollision(GameObject rect1, GameObject rect2)
        {
            if ((rect1.X > rect2.X + rect2.Width) || (rect2.X > rect1.X + rect1.Width))
                return false;
            if ((rect1.Y > rect2.Y + rect2.Height) || (rect2.Y > rect1.Y + rect1.Height))
                return false;
            return true;
        }

    }
}
