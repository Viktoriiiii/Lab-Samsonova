using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Samsonova
{
    class Circle : Figure
    {
        public float radius;

        protected float radius_squared;
        protected float diameter;

        public override void Set(float new_radius) // setting the radius of a circle
        {
            radius = new_radius;
            radius_squared = radius * radius;
            diameter = radius * 2.0f;
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
            g.DrawEllipse(p, x0, y0, diameter, diameter);
        }

        public override string GiveGlobName(int i)
        {
            nameGlob = "circle" + i.ToString();
            return nameGlob;
        }

        public override string GiveName(int i)
        {
            nameLoc = "circle" + i.ToString();
            index = i;
            return nameLoc;
        }

        public override int GetIndex()
        {
            return index;
        }
    }
}
