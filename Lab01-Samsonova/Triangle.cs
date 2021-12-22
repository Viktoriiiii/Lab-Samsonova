using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab01_Samsonova
{
    class Triangle : Figure
    {
        public float side_tria;
        public float radius;
        protected float radius_squared;

        public override void Set(float new_side_tria)
        {
            radius = new_side_tria * (float)(Math.Sqrt(3) / 6);
            side_tria = new_side_tria;
            radius_squared = radius * radius;
        }

        public override bool test(float x, float y)
        {
            float dx = x - pos_x;
            float dy = y - pos_y;
            if (dx * dx + dy * dy <= radius_squared) return true;
            return false;
        }

        public override void draw(Graphics g)
        {
            float x0 = pos_x - radius;
            float y0 = pos_y - radius;
            Pen p = Pens.Black;
            if (selected == true) p = Pens.Red;
            int n = 3;
            Point[] ver = new Point[n];
            float ugol = (float)(2 * Math.PI) / n;
            for (int i = 0; i < n; i++)
            {
                ver[i].X = (int)(x0 + radius * Math.Cos(ugol * i + 0));
                ver[i].Y = (int)(y0 - radius * Math.Sin(ugol * i + 0));
            }
            g.DrawPolygon(p, ver);
        }

        public override string GiveGlobName(int i)
        {
            nameGlob = "triangle" + i.ToString();
            return nameGlob;
        }

        public override string GiveName(int i)
        {
            nameLoc = "triangle" + i.ToString();
            index = i;
            return nameLoc;
        }

        public override int GetIndex()
        {
            return index;
        }
    }
}
