using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Samsonova
{
    class Square : Figure
    {
        public float side;
        protected float half_side;

        public override void Set(float new_side)
        {
            side = new_side;
            half_side = side * 0.5f;
        }

        public override bool test(float x, float y)
        {
            float xmin = pos_x - half_side;
            float ymin = pos_y - half_side;
            float xmax = pos_x + half_side;
            float ymax = pos_y + half_side;
            if (x < xmin || y < ymin) return false;
            if (x > xmax || y > ymax) return false;
            return true;
        }

        public override void draw(Graphics g)
        {
            float x0 = pos_x - half_side;
            float y0 = pos_y - half_side;
            Pen p = Pens.Black;
            if (selected == true) p = Pens.Red;
            g.DrawRectangle(p, x0, y0, side, side);
        }

        public override string GiveGlobName(int i)
        {
            nameGlob = "square" + i.ToString();
            return nameGlob;
        }

        public override string GiveName(int i)
        {
            nameLoc = "square" + i.ToString();
            index = i;
            return nameLoc;
        }

        public override int GetIndex()
        {
            return index;
        }
    }
}
